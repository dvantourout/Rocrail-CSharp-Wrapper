using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocrailLib_v4.Definitions
{
    public static class Tools
    {
        /// <summary>
        /// Permet de parser une liste d'objets XML en une liste d'objet C#
        /// </summary>
        /// <typeparam name="T">Type de l'objet rocrail à traiter</typeparam>
        /// <param name="list">Liste d'objets C#</param>
        /// <param name="xml">Code XML à traiter</param>
        /// <param name="element">Elément à traiter</param>
        /// <param name="action">Méthode Parse de l'élément traité</param>
        /// <param name="rocrailClient">Connexion au serveur Rocrail</param>
        public static void ParseList<T>(List<T> list, System.Xml.Linq.XElement xml, string element, Func<System.Xml.Linq.XElement, CRocrailClient, T> action, CRocrailClient rocrailClient)
        {
            // Si le code xml est null, on ne continue pas
            if (xml == null)
                return;

            // Récupère tous les éléments 
            var _elements = xml.Descendants(element);

            if (_elements.Count() == 0)
                return;

            _elements.ToList().ForEach(e => list.Add(action(e, rocrailClient)));
        }
    }
}
