using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class macroline : CRocrailElements
	{
		private bool? m_blink;
		private int? m_delay;
		private int? m_nr;
		private int? m_port;
		private int? m_porttype;
		private int? m_status;
		/// <summary>
		/// 
		/// </summary>
		public bool blink 
		{
			get { return this.m_blink.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blink, value, "blink"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int porttype 
		{
			get { return this.m_porttype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_porttype, value, "porttype"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int status 
		{
			get { return this.m_status.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_status, value, "status"); }
		}
		public macroline()
		{
		}
		public static macroline Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			macroline _macroline = new macroline();
			_macroline.m_rocrailClient = rocrailClient;
			_macroline.m_blink = (bool?)xml.Attribute("blink");
			_macroline.m_delay = (int?)xml.Attribute("delay");
			_macroline.m_nr = (int?)xml.Attribute("nr");
			_macroline.m_port = (int?)xml.Attribute("port");
			_macroline.m_porttype = (int?)xml.Attribute("porttype");
			_macroline.m_status = (int?)xml.Attribute("status");
			return _macroline;
		}
		public void Update(macroline element)
		{
			if(element.m_blink.HasValue == true) this.blink = element.blink;
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_porttype.HasValue == true) this.porttype = element.porttype;
			if(element.m_status.HasValue == true) this.status = element.status;
		}
	}
}
