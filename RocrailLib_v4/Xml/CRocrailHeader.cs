using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RocrailLib_v4.Xml
{
    public class CRocrailHeader
    {
        private XElement _header;
        private XDeclaration _declaration;
        private int _size;

        public XElement Header { get { return this._header; } }
        public XDeclaration Declaration { get { return this._declaration; } }
        public int Size { get { return this._size; } }

        public CRocrailHeader(XElement header, XDeclaration declaration = null)
        {
            if (header == null)
                throw new ArgumentNullException("Header can't be null");

            this._header = header;
            this._declaration = declaration;
            this._size = -1;

            var _xmls = this._header.Descendants("xml");

            // Récupère l'attribut size du header xml
            // Exemple d'un header : <xmlh><xml size="90" /></xmlh>
            if(_xmls != null)
            {
                this._size = (from _xml in _xmls
                             let _xmlSize = _xml.Attribute("size")
                             where _xmlSize != null
                             select (int)_xmlSize).First();
            }
        }
    }
}
