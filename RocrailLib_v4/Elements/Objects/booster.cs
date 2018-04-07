using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class booster : CRocrailElements
	{
		private string m_blockids;
		private string m_district;
		
		private string m_iid;
		private int? m_load;
		private int? m_loadmax;
		private string m_modids;
		private bool? m_power;
		private string m_powerfb;
		private string m_powersw;
		private string m_scfb;
		private bool? m_scopt_poweroffall;
		private bool? m_scopt_repoweron;
		private bool? m_scopt_stoplocos;
		private bool? m_shortcut;
		private int? m_temp;
		private int? m_tempmax;
		private int? m_uid;
		private int? m_volt;
		private int? m_voltmin;
		private List<actionctrl> m_actionctrllist;
		private List<boosterevent> m_boostereventlist;
		/// <summary>
		/// 
		/// </summary>
		public string blockids 
		{
			get { return this.m_blockids; }
			private set { this.SetField(ref this.m_blockids, value, "blockids"); }
		}
		/// <summary>
		/// Power district description.
		/// </summary>
		public string district 
		{
			get { return this.m_district; }
			private set { this.SetField(ref this.m_district, value, "district"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int load 
		{
			get { return this.m_load.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_load, value, "load"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int loadmax 
		{
			get { return this.m_loadmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_loadmax, value, "loadmax"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string modids 
		{
			get { return this.m_modids; }
			private set { this.SetField(ref this.m_modids, value, "modids"); }
		}
		/// <summary>
		/// Track power flag.
		/// </summary>
		public bool power 
		{
			get { return this.m_power.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_power, value, "power"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string powerfb 
		{
			get { return this.m_powerfb; }
			private set { this.SetField(ref this.m_powerfb, value, "powerfb"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string powersw 
		{
			get { return this.m_powersw; }
			private set { this.SetField(ref this.m_powersw, value, "powersw"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string scfb 
		{
			get { return this.m_scfb; }
			private set { this.SetField(ref this.m_scfb, value, "scfb"); }
		}
		/// <summary>
		/// Power off all boosters at shortcut.
		/// </summary>
		public bool scopt_poweroffall 
		{
			get { return this.m_scopt_poweroffall.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_scopt_poweroffall, value, "scopt_poweroffall"); }
		}
		/// <summary>
		/// Repower on incase the shortcut is cleared.
		/// </summary>
		public bool scopt_repoweron 
		{
			get { return this.m_scopt_repoweron.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_scopt_repoweron, value, "scopt_repoweron"); }
		}
		/// <summary>
		/// Stop all locos in the district at shortcut.
		/// </summary>
		public bool scopt_stoplocos 
		{
			get { return this.m_scopt_stoplocos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_scopt_stoplocos, value, "scopt_stoplocos"); }
		}
		/// <summary>
		/// Shortcut flag.
		/// </summary>
		public bool shortcut 
		{
			get { return this.m_shortcut.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcut, value, "shortcut"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int temp 
		{
			get { return this.m_temp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_temp, value, "temp"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int tempmax 
		{
			get { return this.m_tempmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tempmax, value, "tempmax"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int uid 
		{
			get { return this.m_uid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_uid, value, "uid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int volt 
		{
			get { return this.m_volt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_volt, value, "volt"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int voltmin 
		{
			get { return this.m_voltmin.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_voltmin, value, "voltmin"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<boosterevent> boostereventlist 
		{
			get { return this.m_boostereventlist; }
			private set { this.SetField(ref this.m_boostereventlist, value, "boostereventlist"); }
		}
		public booster()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_boostereventlist = new List<boosterevent>();
		}
		public static booster Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			booster _booster = new booster();
			_booster.m_rocrailClient = rocrailClient;
			_booster.m_blockids = (string)xml.Attribute("blockids");
			_booster.m_district = (string)xml.Attribute("district");
			_booster.m_id = (string)xml.Attribute("id");
			_booster.m_iid = (string)xml.Attribute("iid");
			_booster.m_load = (int?)xml.Attribute("load");
			_booster.m_loadmax = (int?)xml.Attribute("loadmax");
			_booster.m_modids = (string)xml.Attribute("modids");
			_booster.m_power = (bool?)xml.Attribute("power");
			_booster.m_powerfb = (string)xml.Attribute("powerfb");
			_booster.m_powersw = (string)xml.Attribute("powersw");
			_booster.m_scfb = (string)xml.Attribute("scfb");
			_booster.m_scopt_poweroffall = (bool?)xml.Attribute("scopt_poweroffall");
			_booster.m_scopt_repoweron = (bool?)xml.Attribute("scopt_repoweron");
			_booster.m_scopt_stoplocos = (bool?)xml.Attribute("scopt_stoplocos");
			_booster.m_shortcut = (bool?)xml.Attribute("shortcut");
			_booster.m_temp = (int?)xml.Attribute("temp");
			_booster.m_tempmax = (int?)xml.Attribute("tempmax");
			_booster.m_uid = (int?)xml.Attribute("uid");
			_booster.m_volt = (int?)xml.Attribute("volt");
			_booster.m_voltmin = (int?)xml.Attribute("voltmin");
			Definitions.Tools.ParseList<actionctrl>(_booster.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<boosterevent>(_booster.m_boostereventlist, xml, "boosterevent", boosterevent.Parse, rocrailClient);
			return _booster;
		}
		public void Update(booster element)
		{
			if(element.m_blockids != null) this.blockids = element.blockids;
			if(element.m_district != null) this.district = element.district;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_loadmax.HasValue == true) this.loadmax = element.loadmax;
			if(element.m_modids != null) this.modids = element.modids;
			if(element.m_power.HasValue == true) this.power = element.power;
			if(element.m_powerfb != null) this.powerfb = element.powerfb;
			if(element.m_powersw != null) this.powersw = element.powersw;
			if(element.m_scfb != null) this.scfb = element.scfb;
			if(element.m_scopt_poweroffall.HasValue == true) this.scopt_poweroffall = element.scopt_poweroffall;
			if(element.m_scopt_repoweron.HasValue == true) this.scopt_repoweron = element.scopt_repoweron;
			if(element.m_scopt_stoplocos.HasValue == true) this.scopt_stoplocos = element.scopt_stoplocos;
			if(element.m_shortcut.HasValue == true) this.shortcut = element.shortcut;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_tempmax.HasValue == true) this.tempmax = element.tempmax;
			if(element.m_uid.HasValue == true) this.uid = element.uid;
			if(element.m_volt.HasValue == true) this.volt = element.volt;
			if(element.m_voltmin.HasValue == true) this.voltmin = element.voltmin;
			this.actionctrllist = element.actionctrllist;
			this.boostereventlist = element.boostereventlist;
		}
	}
}
