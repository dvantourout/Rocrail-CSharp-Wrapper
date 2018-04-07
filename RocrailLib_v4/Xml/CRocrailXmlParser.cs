using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RocrailLib_v4.Xml
{
    /// <summary>
    /// Classe permettant le traitement des trames XML Rocrail
    /// </summary>
    public static class CRocrailXmlParser
    {
        /// <summary>
        /// Extrait le header de la trame XML, le header n'est plus présent dans la chaine
        /// XML après traitement
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static CRocrailHeader ExtractHeader(ref string xml)
        {
            XElement _xml;
            CRocrailHeader _header;

            // Récupère la balise xml du header
            // Header xml : <xmlh><xml size="90" /></xmlh>
            _xml = CRocrailXmlParser.ExtractXml(ref xml, "xmlh");

            if (_xml == null)
                return null;

            // Traite le header
            _header = new CRocrailHeader(_xml);

            return _header;
        }

        /// <summary>
        /// Extrait les données d'une trame XML Rocrail, les données ne sont plus présente
        /// dans la chain xml après traitement
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="indexStart"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        public static XElement ExtractDatas(ref string xml, int indexStart, int lenght)
        {
            XElement _xml;
            string _datas;

            var _size = xml.Length;

            // Extrait les données de la chaine
            _datas = xml.Substring(indexStart, lenght);
            xml = xml.Remove(indexStart, lenght);

            // Si le dernier caractère, est un caractère null (Indiquant la fin de la trame)
            // Le supprime pour garder un code XML valide
            if (_datas.Last() == 0x00)
                _datas = _datas.Remove(_datas.Length - 1);
            else
                throw new InvalidOperationException();

            _xml = XElement.Parse(_datas);

            return _xml;
        }

        /// <summary>
        /// Extrait du code xml d'une chaine de caractère, le code n'est plus présent dans la chaine
        /// après traitement
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static XElement ExtractXml(ref string xml, string tag)
        {
            XElement _xml;
            XmlIndexes _tagIndexes;

            string _xmlString;

            if (xml == null || xml == string.Empty)
                return null;

            if (tag == null || tag == string.Empty)
                return null;

            // Récupère les indexs de la trame XML
            _tagIndexes = CRocrailXmlParser.GetTagIndexes(xml, tag);
            
            if (_tagIndexes == null)
                return null;

            // Extraction du code XML de la chaine
            _xmlString = xml.Substring(_tagIndexes.StartTagIndex, _tagIndexes.Length);
            _xml = XElement.Parse(_xmlString);

            xml = xml.Substring(_tagIndexes.EndTagIndex);

            return _xml;
        }

        /// <summary>
        /// Retourne les indexs d'un tag XML contenu dans une chaine
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static XmlIndexes GetTagIndexes(string xml, string tag)
        {
            int _startTagIndex;
            int _endTagIndex;
            int _startDataIndex;
            int _endDataIndex;

            bool _isOrphan;

            string _startTag;
            string _endTag;

            if (xml == null || xml == string.Empty)
                return null;

            if (tag == null || tag == string.Empty)
                return null;

            // Définition des tags XML
            _startTag = "<" + tag + ">";
            _endTag = "</" + tag + ">";
            _isOrphan = false;

            _startTagIndex = xml.IndexOf(_startTag);

            // Si le tag <tag> n'est pas trouvé, on entre dans le cas
            // d'une balise orpheline, sous la forme <tag --elements-- />
            if(_startTagIndex == -1)
            {
                _startTag = "<" + tag;
                _endTag = ">";

                _isOrphan = true;

                _startTagIndex = xml.IndexOf(_startTag);
            }

            // Si le tag <tag n'est pas trouvé, la balise n'est alors pas contenu dans la chaine
            if (_startTagIndex == -1)
                return null;

            // Récupère le tag de fin, </tag> ou > suivant si la balise est orpheline ou non
            _endTagIndex = xml.IndexOf(_endTag, _startTagIndex + _startTag.Length);

            if (_endTagIndex == -1)
                return null;

            if (_isOrphan == false)
            {
                _startDataIndex = _startTagIndex + _startTag.Length;
                _endDataIndex = _endTagIndex;
            }
            else
            {
                _startDataIndex = -1;
                _endDataIndex = -1;
            }

            _endTagIndex += _endTag.Length;

            return new XmlIndexes(_startTagIndex, _endTagIndex, _startDataIndex, _endDataIndex, _isOrphan);
        }
    }
}
