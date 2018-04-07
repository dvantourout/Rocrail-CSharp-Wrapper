using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class accessoryctrl : CRocrailElements
	{
		private bool? m_active;
		private int? m_delay;
		private int? m_interval;
		private string m_lockroutes;
		/// <summary>
		/// Activate accessory control.
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// Seconds to elaps to go back to the closed position.
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
		}
		/// <summary>
		/// Interval in seconds.
		/// </summary>
		public int interval 
		{
			get { return this.m_interval.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_interval, value, "interval"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lockroutes 
		{
			get { return this.m_lockroutes; }
			private set { this.SetField(ref this.m_lockroutes, value, "lockroutes"); }
		}
		public accessoryctrl()
		{
		}
		public static accessoryctrl Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			accessoryctrl _accessoryctrl = new accessoryctrl();
			_accessoryctrl.m_rocrailClient = rocrailClient;
			_accessoryctrl.m_active = (bool?)xml.Attribute("active");
			_accessoryctrl.m_delay = (int?)xml.Attribute("delay");
			_accessoryctrl.m_interval = (int?)xml.Attribute("interval");
			_accessoryctrl.m_lockroutes = (string)xml.Attribute("lockroutes");
			return _accessoryctrl;
		}
		public void Update(accessoryctrl element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_interval.HasValue == true) this.interval = element.interval;
			if(element.m_lockroutes != null) this.lockroutes = element.lockroutes;
		}
	}
}
