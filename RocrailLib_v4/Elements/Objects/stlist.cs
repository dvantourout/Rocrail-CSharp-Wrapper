using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class stlist : CRocrailElements
	{
		private List<st> m_stlist;
		/// <summary>
		/// 
		/// </summary>
		public List<st> stlistP 
		{
			get { return this.m_stlist; }
			private set { this.SetField(ref this.m_stlist, value, "stlistP"); }
		}
		public stlist()
		{
			this.m_stlist = new List<st>();
		}
		public static stlist Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			stlist _stlist = new stlist();
			_stlist.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<st>(_stlist.m_stlist, xml, "st", st.Parse, rocrailClient);
			return _stlist;
		}
		public void Update(stlist element)
		{
			this.stlistP = element.stlistP;
		}
	}
}
