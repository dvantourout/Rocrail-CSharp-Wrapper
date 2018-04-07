using RocrailLib_v4.Xml;
using System;
using System.Text;
using System.Xml.Linq;

namespace RocrailLib_v4
{
    public class CRocrailClient
    {
        private CRocrailSocket m_rocrailSocket;
        private string m_trame;

        public event EventHandler<TrameEventArgs> TrameSend;
        public event EventHandler<TrameEventArgs> TrameReceived;

        public CRocrailClient(string hostname, int port)
        {
            this.m_rocrailSocket = new CRocrailSocket(hostname, port);
        }

        /// <summary>
        /// Lit une trame à partir du serveur ROcrail sous le format d'un objet XML
        /// </summary>
        /// <returns></returns>
        public XElement Read()
        {
            byte[] _buffer;
            CRocrailHeader _header;
            XElement _datas;

            // Lit un éventuel header sur le buffer m_trame
            _header = CRocrailXmlParser.ExtractHeader(ref this.m_trame);

            // Si aucun header dans le buffer
            if (_header == null)
            {
                // Lit toute les données sur le buffer du serveur
                _buffer = this.m_rocrailSocket.ReadAll();

                this.m_trame = Encoding.Default.GetString(_buffer);
                _header = CRocrailXmlParser.ExtractHeader(ref this.m_trame);
            }

            if (_header == null)
                throw new InvalidOperationException();

            // Vérifie si les données sont toutes disponibles dans le buffer m_trame
            // Si les données ne sont pas toutes disponibles, lit les données manquantes
            // à partir du serveur Rocrail
            if (this.m_trame.Length < _header.Size)
            {
                int _needToRead = _header.Size - this.m_trame.Length;

                _buffer = new byte[_needToRead];
                this.m_rocrailSocket.Read(_buffer, 0, _needToRead);
                this.m_trame += Encoding.Default.GetString(_buffer);
            }

            // Extrait les données de la trame
            _datas = CRocrailXmlParser.ExtractDatas(ref this.m_trame, 0, _header.Size);

            if(this.TrameReceived != null)
            {
                this.TrameReceived(this, new TrameEventArgs(_datas.ToString()));
            }

            return _datas;
        }

        /// <summary>
        /// Envoie une trame au serveur Rocrail, le header est généré par la fonction
        /// </summary>
        /// <param name="str"></param>
        public void Send(string str)
        {
            string _trame = "<xmlh><xml size=\"" + (str.Length  + 1) + "\"/></xmlh>" + str + "\0";

            this.m_rocrailSocket.Send(Encoding.UTF8.GetBytes(_trame));

            if(this.TrameSend != null)
            {
                this.TrameSend(this, new TrameEventArgs(str));
            }
        }

        public void Close()
        {
            this.m_rocrailSocket.Close();
        }
    }
}
