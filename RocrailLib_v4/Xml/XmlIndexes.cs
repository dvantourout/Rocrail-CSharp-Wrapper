using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocrailLib_v4.Xml
{
    /// <summary>
    /// Objets encapsulant les informations d'un tag XML contenu par une chaine
    /// </summary>
    public class XmlIndexes
    {
        private readonly int _startTagIndex;
        private readonly int _endTagIndex;
        private readonly int _startDataIndex;
        private readonly int _endDataIndex;

        private bool _isOrphan;

        public int StartTagIndex { get { return this._startTagIndex; } }
        public int EndTagIndex { get { return this._endTagIndex; } }
        public int Length
        {
            get
            {
                if (this._startTagIndex == -1 || this._endTagIndex == -1)
                    return -1;

                return this._endTagIndex - this._startTagIndex;
            }
        }
        public int StartDataIndex { get { return this._startDataIndex; } }
        public int EndDataIndex { get { return this._endDataIndex; } }
        public int DataLength
        {
            get
            {
                if (this._startDataIndex == -1 || this._endDataIndex == -1)
                    return -1;

                return this._endDataIndex - this._startTagIndex;
            }
        }

        public bool IsOrphan { get { return this._isOrphan; } }

        public XmlIndexes(int startTagIndex, int endTagIndex, int startDataIndex, int endDataIndex, bool isOrphan)
        {
            this._startTagIndex = startTagIndex;
            this._endTagIndex = endTagIndex;
            this._startDataIndex = startDataIndex;
            this._endDataIndex = endDataIndex;

            this._isOrphan = isOrphan;
        }
    }
}
