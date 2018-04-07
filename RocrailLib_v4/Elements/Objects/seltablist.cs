using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class seltablist : CRocrailElements
	{
		private List<seltab> m_seltablist;
		/// <summary>
		/// 
		/// </summary>
		public List<seltab> seltablistP 
		{
			get { return this.m_seltablist; }
			private set { this.SetField(ref this.m_seltablist, value, "seltablistP"); }
		}
		public seltablist()
		{
			this.m_seltablist = new List<seltab>();
		}
		public static seltablist Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			seltablist _seltablist = new seltablist();
			_seltablist.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<seltab>(_seltablist.m_seltablist, xml, "seltab", seltab.Parse, rocrailClient);
			return _seltablist;
		}
		public void Update(seltablist element)
		{
			this.seltablistP = element.seltablistP;
		}
	}
}
