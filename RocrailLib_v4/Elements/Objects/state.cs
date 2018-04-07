using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class state : CRocrailElements
	{
		private bool? m_accessorybus;
		private bool? m_consolemode;
		private bool? m_emergency;
		private bool? m_healthy;
		private string m_iid;
		private int? m_load;
		private int? m_loadmax;
		private bool? m_needkey4loconet;
		private bool? m_power;
		private bool? m_programming;
		private int? m_ptload;
		private bool? m_sensorbus;
		private bool? m_shortcut;
		private int? m_temp;
		private int? m_tempmax;
		private bool? m_trackbus;
		private int? m_uid;
		private int? m_volt;
		private int? m_voltmin;
		/// <summary>
		/// 
		/// </summary>
		public bool accessorybus 
		{
			get { return this.m_accessorybus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accessorybus, value, "accessorybus"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool consolemode 
		{
			get { return this.m_consolemode.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_consolemode, value, "consolemode"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool emergency 
		{
			get { return this.m_emergency.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_emergency, value, "emergency"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool healthy 
		{
			get { return this.m_healthy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_healthy, value, "healthy"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// Load of CS in mA.
		/// </summary>
		public int load 
		{
			get { return this.m_load.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_load, value, "load"); }
		}
		/// <summary>
		/// Load of CS in mA.
		/// </summary>
		public int loadmax 
		{
			get { return this.m_loadmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_loadmax, value, "loadmax"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool needkey4loconet 
		{
			get { return this.m_needkey4loconet.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_needkey4loconet, value, "needkey4loconet"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool power 
		{
			get { return this.m_power.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_power, value, "power"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool programming 
		{
			get { return this.m_programming.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_programming, value, "programming"); }
		}
		/// <summary>
		/// Load of PT in mA.
		/// </summary>
		public int ptload 
		{
			get { return this.m_ptload.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ptload, value, "ptload"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool sensorbus 
		{
			get { return this.m_sensorbus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sensorbus, value, "sensorbus"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool shortcut 
		{
			get { return this.m_shortcut.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcut, value, "shortcut"); }
		}
		/// <summary>
		/// Temp of CS in C.
		/// </summary>
		public int temp 
		{
			get { return this.m_temp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_temp, value, "temp"); }
		}
		/// <summary>
		/// Temp of CS in C.
		/// </summary>
		public int tempmax 
		{
			get { return this.m_tempmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tempmax, value, "tempmax"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool trackbus 
		{
			get { return this.m_trackbus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_trackbus, value, "trackbus"); }
		}
		/// <summary>
		/// Unique-ID of reporter.
		/// </summary>
		public int uid 
		{
			get { return this.m_uid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_uid, value, "uid"); }
		}
		/// <summary>
		/// Track voltage in mV.
		/// </summary>
		public int volt 
		{
			get { return this.m_volt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_volt, value, "volt"); }
		}
		/// <summary>
		/// Track voltage in mV.
		/// </summary>
		public int voltmin 
		{
			get { return this.m_voltmin.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_voltmin, value, "voltmin"); }
		}
		public state()
		{
		}
		public static state Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			state _state = new state();
			_state.m_rocrailClient = rocrailClient;
			_state.m_accessorybus = (bool?)xml.Attribute("accessorybus");
			_state.m_consolemode = (bool?)xml.Attribute("consolemode");
			_state.m_emergency = (bool?)xml.Attribute("emergency");
			_state.m_healthy = (bool?)xml.Attribute("healthy");
			_state.m_iid = (string)xml.Attribute("iid");
			_state.m_load = (int?)xml.Attribute("load");
			_state.m_loadmax = (int?)xml.Attribute("loadmax");
			_state.m_needkey4loconet = (bool?)xml.Attribute("needkey4loconet");
			_state.m_power = (bool?)xml.Attribute("power");
			_state.m_programming = (bool?)xml.Attribute("programming");
			_state.m_ptload = (int?)xml.Attribute("ptload");
			_state.m_sensorbus = (bool?)xml.Attribute("sensorbus");
			_state.m_shortcut = (bool?)xml.Attribute("shortcut");
			_state.m_temp = (int?)xml.Attribute("temp");
			_state.m_tempmax = (int?)xml.Attribute("tempmax");
			_state.m_trackbus = (bool?)xml.Attribute("trackbus");
			_state.m_uid = (int?)xml.Attribute("uid");
			_state.m_volt = (int?)xml.Attribute("volt");
			_state.m_voltmin = (int?)xml.Attribute("voltmin");
			return _state;
		}
		public void Update(state element)
		{
			if(element.m_accessorybus.HasValue == true) this.accessorybus = element.accessorybus;
			if(element.m_consolemode.HasValue == true) this.consolemode = element.consolemode;
			if(element.m_emergency.HasValue == true) this.emergency = element.emergency;
			if(element.m_healthy.HasValue == true) this.healthy = element.healthy;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_loadmax.HasValue == true) this.loadmax = element.loadmax;
			if(element.m_needkey4loconet.HasValue == true) this.needkey4loconet = element.needkey4loconet;
			if(element.m_power.HasValue == true) this.power = element.power;
			if(element.m_programming.HasValue == true) this.programming = element.programming;
			if(element.m_ptload.HasValue == true) this.ptload = element.ptload;
			if(element.m_sensorbus.HasValue == true) this.sensorbus = element.sensorbus;
			if(element.m_shortcut.HasValue == true) this.shortcut = element.shortcut;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_tempmax.HasValue == true) this.tempmax = element.tempmax;
			if(element.m_trackbus.HasValue == true) this.trackbus = element.trackbus;
			if(element.m_uid.HasValue == true) this.uid = element.uid;
			if(element.m_volt.HasValue == true) this.volt = element.volt;
			if(element.m_voltmin.HasValue == true) this.voltmin = element.voltmin;
		}
	}
}
