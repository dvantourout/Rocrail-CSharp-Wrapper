
using RocrailLib_v4.Definitions;
using RocrailLib_v4.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;

namespace RocrailLib_v4
{
    public partial class CRocrail
    {
        private volatile bool m_threadStop;
        private bool m_isClosing;

        private Thread m_thread;
        
        private MethodInfo m_updatePlanElementMethod;
        private MethodInfo m_returnPropertyValueMethod;

        private CRocrailClient m_rocrailClient;
        private Dictionary<string, object> m_planListsIndexer;
     
        public bool UsePlan { get; set; }
        public Dictionary<string, object> OtherElements { get; set; }
        public plan Plan { get; set; }

        public CRocrailClient Client { get { return this.m_rocrailClient; } }

        public CRocrail()
        {

        }

        public CRocrail(string hostname, int port)
        {
            this.Connect(hostname, port);
        }

        public void Connect(string hostname, int port)
        {
            this.m_rocrailClient = new CRocrailClient(hostname, port);

            if (this.Connected != null)
            {
                this.Connected(this, EventArgs.Empty);
            }

            this._init();
        }

        private void _init()
        {
            // On récupère le MethodInfo de la méthode _updatePlanElement, pour l'utiliser quand un élément du plan est recu
            this.m_updatePlanElementMethod = this.GetType().GetMethod("_updatePlanElement", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            this.m_returnPropertyValueMethod = this.GetType().GetMethod("_returnPropertyValue", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            
            this.OtherElements = new Dictionary<string, object>();

            this.m_thread = new Thread(new ThreadStart(this._run));
            this.m_threadStop = false;

            this.m_planListsIndexer = new Dictionary<string,object>();

            this.m_rocrailClient.TrameReceived += this.OnTrameReceived;
            this.m_rocrailClient.TrameSend += this.OnTrameSend;
        }

        private void OnTrameSend(object sender, TrameEventArgs e)
        {
            if(this.TrameSend != null)
            {
                this.TrameSend(this, e);
            }
        }

        private void OnTrameReceived(object sender, TrameEventArgs e)
        {
            if(this.TrameReceived != null)
            {
                this.TrameReceived(this, e);
            }
        }

        private void _run()
        {
            while (!this.m_threadStop)
            {
                try
                {
                    this._doWork();
                }
                catch(SocketException e)
                {
                    switch(e.ErrorCode)
                    {
                        case 10004:
                            if(this.m_isClosing != true)
                            {
                                throw new SocketException(e.ErrorCode);
                            }
                            break;
                        case 10054:
                            if(this.ConnectionLost != null)
                            {
                                this.ConnectionLost(this, EventArgs.Empty);
                            }

                            this.m_threadStop = true;

                            break;
                        default:
                            throw new SocketException(e.ErrorCode);
                    }
                }
            }
        }

        private void _doWork()
        {
            XElement _buffer = this.m_rocrailClient.Read();

            this._analyzeTrame(_buffer);
        }

        /// <summary>
        /// Retourne la valeur d'une propriété du plan par rapport à son nom
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private List<T> _returnPropertyValue<T>(string propertyName) where T : CRocrailElements
        {
            if (this.Plan != null)
            {
                // Si la propriété n'est pas dans l'indexer
                if (!this.m_planListsIndexer.ContainsKey(propertyName))
                {
                    // Récupère la propriété
                    var _listType = this.Plan.GetType().GetProperty(propertyName);
                    var _listValue = _listType.GetValue(this.Plan, null);

                    var _list = (List<T>)_listValue;

                    this.m_planListsIndexer.Add(propertyName, _list);

                    return _list;
                }
                else
                {
                    // Si la propriété a déja été traitée auparavant, la récupère dans l'indexer
                    return (List<T>)this.m_planListsIndexer[propertyName];
                }
                
            }

            return default(List<T>);
        }

        private void _analyzeTrame(XElement _buffer)
        {
            // Récupère le nom de l'élément, par exemple lc pour une locomotive
            string _elementName = _buffer.Name.LocalName;
            string _elementID = (string)_buffer.Attribute("id");

            // Récupère le Type de l'élément en le cherchant dans la libraie.
            // Par exemple l'élément lc retournera le Type de la classe RocrailLib_v4.Elements.lc
            var _rocrailElement = Type.GetType("RocrailLib_v4.Elements." + _elementName);

            // Récupère les méthodes Parse et Update de l'objet, tous les objets rocrail de la librairie
            // possèdent ces deux méthodes
            var _parseMethod = _rocrailElement.GetMethod("Parse");
            var _updateMethod = _rocrailElement.GetMethod("Update");

            // Objet donnée par la méthode Parse de l'élément, qui parse de l'XML en un object C#
            object _object;
            _object = _parseMethod.Invoke(null, new object[] { _buffer, this.m_rocrailClient });

            // Lève l'évênement ElementReceived pour signaler qu'un élément a été reçu,
            // l'évênement est levé avant le traitement de l'object rocrail
            if (this.ElementReceived != null)
            {
                var _elementEventArgs = new ElementEventArgs(
                    _object,
                    _elementName,
                    _elementID);

                this.ElementReceived(this, _elementEventArgs);
            }

            // Si l'élément n'est pas un plan ni un élément du plan
            if(_elementName != "plan" && !PlanElements.PlanElementLists.Contains(_elementName))
            {
                if (this.OtherElements.ContainsKey(_elementName))
                {
                    _updateMethod.Invoke(this.OtherElements[_elementName], new object[] { _object });

                    var _elementEventArgs = new ElementEventArgs(
                        this.OtherElements[_elementName],
                        _elementName,
                        _elementID);

                    if(this.ElementUpdated != null)
                    {
                        this.ElementUpdated(this, _elementEventArgs);
                    }
                }
                else
                {
                    this.OtherElements.Add(_elementName, _object);

                    if(this.ElementAdded != null)
                    {
                        this.ElementAdded(this, new ElementEventArgs(
                            _object,
                            _elementName,
                            _elementID));
                    }
                }
            }

            // Si le on utilise le plan rocrail, on stock alors toutes les données liées au plan dans
            // la propriété Plan
            // Les autres données seront émises par l'évenement ElementReceived
            // Si les données sont liées au plan, les met à jour dans la propriété Plan et
            // lève l'évènement ElementUpdated
            if (this.UsePlan == true)
            {
                // Si l'élément reçu est le plan, l'associe à la propriété Plan
                if (_elementName == "plan")
                {
                    this.Plan = (plan)_object;

                    if (this.PlanLoaded != null)
                    {
                        this.PlanLoaded(this, EventArgs.Empty);
                    }
                }

                // Si le plan à bien été reçu et que l'élément est un élément du plan
                // le traite
                // Traite que les éléments appartenant à des listes, comme fb (contenu par fblist)
                // par exemple
                if (this.Plan != null && PlanElements.PlanElementLists.Contains(_elementName))
                {
                    // Récupère la valeur de la liste
                    var _returnPropertyValueMethod = this.m_returnPropertyValueMethod.MakeGenericMethod(_object.GetType());
                    var _list = _returnPropertyValueMethod.Invoke(this, new object[] { _elementName + "list" });

                    // Utilise la méthode initialisée par le constructeur CRocrail _updatePlanElement
                    // La méthode est une méthode générique, _updatePlanElement<T>
                    // MakeGenericMethod permet de faire que T = type de l'élément reçu
                    var _updateElementMethod = this.m_updatePlanElementMethod.MakeGenericMethod(_object.GetType());

                    // Invoke la méthode
                    _updateElementMethod.Invoke(this, new object[] {
                        _object,
                        _list,
                        _elementName,
                        _elementID,
                        _updateMethod });
                }
            }
        }

        /// <summary>
        /// Met à jour un élément d'une liste du plan
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="updateMethod"></param>
        private void _updatePlanElement<T>(T element, List<T> list, string name, string id, MethodInfo updateMethod) where T : CRocrailElements
        {
            if(id == null)
            {
                return;
            }

            var _temp = list.Find(_el => _el.ID == id);

            updateMethod.Invoke(_temp, new object[] { element });

            if(this.ElementUpdated != null)
            {
                var _elementEventArgs = new ElementEventArgs(
                    _temp,
                    name,
                    id);

                this.ElementUpdated(this, _elementEventArgs);
            }
        }

        public void StartScrut()
        {
            this.m_thread.Start();
        }

        public void StopScrut()
        {
            this.m_threadStop = true;
        }

        public void Close()
        {
            this.m_isClosing = true;

            this.StopScrut();
            this.m_rocrailClient.Close();
        }
    }
}
