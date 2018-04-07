using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class cbnodeevent : CRocrailElements
	{
		private int? m_addr;
		private int? m_evnr;
		private int? m_evval;
		private int? m_nodenr;
		/// <summary>
		/// Device address of producer.
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// Event variable index.
		/// </summary>
		public int evnr 
		{
			get { return this.m_evnr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_evnr, value, "evnr"); }
		}
		/// <summary>
		/// Event variable value.
		/// </summary>
		public int evval 
		{
			get { return this.m_evval.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_evval, value, "evval"); }
		}
		/// <summary>
		/// Node number of producer.
		/// </summary>
		public int nodenr 
		{
			get { return this.m_nodenr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nodenr, value, "nodenr"); }
		}
		public cbnodeevent()
		{
		}
		public static cbnodeevent Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			cbnodeevent _cbnodeevent = new cbnodeevent();
			_cbnodeevent.m_rocrailClient = rocrailClient;
			_cbnodeevent.m_addr = (int?)xml.Attribute("addr");
			_cbnodeevent.m_evnr = (int?)xml.Attribute("evnr");
			_cbnodeevent.m_evval = (int?)xml.Attribute("evval");
			_cbnodeevent.m_nodenr = (int?)xml.Attribute("nodenr");
			return _cbnodeevent;
		}
		public void Update(cbnodeevent element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_evnr.HasValue == true) this.evnr = element.evnr;
			if(element.m_evval.HasValue == true) this.evval = element.evval;
			if(element.m_nodenr.HasValue == true) this.nodenr = element.nodenr;
		}
	}
}
