using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class portsetup : CRocrailElements
	{
		private int? m_delay;
		private int? m_eventid;
		private int? m_eventport;
		private int? m_port;
		private int? m_state;
		private int? m_type;
		/// <summary>
		/// 0=directly/continous
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int eventid 
		{
			get { return this.m_eventid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_eventid, value, "eventid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int eventport 
		{
			get { return this.m_eventport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_eventport, value, "eventport"); }
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
		/// Saved output state.
		/// </summary>
		public int state 
		{
			get { return this.m_state.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// 0=output, 1=input
		/// </summary>
		public int type 
		{
			get { return this.m_type.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		public portsetup()
		{
		}
		public static portsetup Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			portsetup _portsetup = new portsetup();
			_portsetup.m_rocrailClient = rocrailClient;
			_portsetup.m_delay = (int?)xml.Attribute("delay");
			_portsetup.m_eventid = (int?)xml.Attribute("eventid");
			_portsetup.m_eventport = (int?)xml.Attribute("eventport");
			_portsetup.m_port = (int?)xml.Attribute("port");
			_portsetup.m_state = (int?)xml.Attribute("state");
			_portsetup.m_type = (int?)xml.Attribute("type");
			return _portsetup;
		}
		public void Update(portsetup element)
		{
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_eventid.HasValue == true) this.eventid = element.eventid;
			if(element.m_eventport.HasValue == true) this.eventport = element.eventport;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_state.HasValue == true) this.state = element.state;
			if(element.m_type.HasValue == true) this.type = element.type;
		}
	}
}
