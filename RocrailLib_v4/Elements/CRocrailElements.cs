
using GlobalDefinitions;

namespace RocrailLib_v4.Elements
{
    /// <summary>
    /// Classe mère de tous les éléments de la librairie rocrail
    /// </summary>
    public class CRocrailElements : PropertyChangedBase
    {
        protected string m_id;
        protected CRocrailClient m_rocrailClient;

        public string ID { get { return this.m_id; } }

        public CRocrailElements()
        {

        }

        public CRocrailElements(CRocrailClient rocrailClient)
        {
            this.m_rocrailClient = rocrailClient;
        }
    }
}
