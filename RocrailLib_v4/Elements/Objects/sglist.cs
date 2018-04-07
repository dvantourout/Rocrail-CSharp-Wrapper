using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sglist : CRocrailElements
	{
		private List<sg> m_sglist;
		/// <summary>
		/// 
		/// </summary>
		public List<sg> sglistP 
		{
			get { return this.m_sglist; }
			private set { this.SetField(ref this.m_sglist, value, "sglistP"); }
		}
		public sglist()
		{
			this.m_sglist = new List<sg>();
		}
		public static sglist Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sglist _sglist = new sglist();
			_sglist.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<sg>(_sglist.m_sglist, xml, "sg", sg.Parse, rocrailClient);
			return _sglist;
		}
		public void Update(sglist element)
		{
			this.sglistP = element.sglistP;
		}
	}
}
