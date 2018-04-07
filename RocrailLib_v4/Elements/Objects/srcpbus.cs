using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class srcpbus : CRocrailElements
	{
		private int? m_bus;
		private string m_iid;
		/// <summary>
		/// 
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		public srcpbus()
		{
		}
		public static srcpbus Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			srcpbus _srcpbus = new srcpbus();
			_srcpbus.m_rocrailClient = rocrailClient;
			_srcpbus.m_bus = (int?)xml.Attribute("bus");
			_srcpbus.m_iid = (string)xml.Attribute("iid");
			return _srcpbus;
		}
		public void Update(srcpbus element)
		{
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_iid != null) this.iid = element.iid;
		}
	}
}
