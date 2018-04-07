using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class actionctrl : CRocrailElements
	{
		private bool? m_auto;
		private string m_bkid;
		private int? m_carcount;
		private int? m_countedcars;
		private int? m_counter;
		private string m_deact;
		private string m_desc;
		
		private string m_lcid;
		private int? m_load;
		private bool? m_manual;
		private string m_param;
		private bool? m_reset;
		private string m_state;
		private int? m_temp;
		private int? m_volt;
		private int? m_wheelcount;
		private List<actioncond> m_actioncondlist;
		/// <summary>
		/// Activate in auto mode.
		/// </summary>
		public bool auto 
		{
			get { return this.m_auto.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_auto, value, "auto"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string bkid 
		{
			get { return this.m_bkid; }
			private set { this.SetField(ref this.m_bkid, value, "bkid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int carcount 
		{
			get { return this.m_carcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_carcount, value, "carcount"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int countedcars 
		{
			get { return this.m_countedcars.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_countedcars, value, "countedcars"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int counter 
		{
			get { return this.m_counter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_counter, value, "counter"); }
		}
		/// <summary>
		/// Deactivation event.
		/// </summary>
		public string deact 
		{
			get { return this.m_deact; }
			private set { this.SetField(ref this.m_deact, value, "deact"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
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
		/// 
		/// </summary>
		public string lcid 
		{
			get { return this.m_lcid; }
			private set { this.SetField(ref this.m_lcid, value, "lcid"); }
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
		/// Activate in manual mode.
		/// </summary>
		public bool manual 
		{
			get { return this.m_manual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manual, value, "manual"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string param 
		{
			get { return this.m_param; }
			private set { this.SetField(ref this.m_param, value, "param"); }
		}
		/// <summary>
		/// Reset counter.
		/// </summary>
		public bool reset 
		{
			get { return this.m_reset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reset, value, "reset"); }
		}
		/// <summary>
		/// Activation state, empty is always.
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
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
		public int volt 
		{
			get { return this.m_volt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_volt, value, "volt"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int wheelcount 
		{
			get { return this.m_wheelcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wheelcount, value, "wheelcount"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actioncond> actioncondlist 
		{
			get { return this.m_actioncondlist; }
			private set { this.SetField(ref this.m_actioncondlist, value, "actioncondlist"); }
		}
		public actionctrl()
		{
			this.m_actioncondlist = new List<actioncond>();
		}
		public static actionctrl Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			actionctrl _actionctrl = new actionctrl();
			_actionctrl.m_rocrailClient = rocrailClient;
			_actionctrl.m_auto = (bool?)xml.Attribute("auto");
			_actionctrl.m_bkid = (string)xml.Attribute("bkid");
			_actionctrl.m_carcount = (int?)xml.Attribute("carcount");
			_actionctrl.m_countedcars = (int?)xml.Attribute("countedcars");
			_actionctrl.m_counter = (int?)xml.Attribute("counter");
			_actionctrl.m_deact = (string)xml.Attribute("deact");
			_actionctrl.m_desc = (string)xml.Attribute("desc");
			_actionctrl.m_id = (string)xml.Attribute("id");
			_actionctrl.m_lcid = (string)xml.Attribute("lcid");
			_actionctrl.m_load = (int?)xml.Attribute("load");
			_actionctrl.m_manual = (bool?)xml.Attribute("manual");
			_actionctrl.m_param = (string)xml.Attribute("param");
			_actionctrl.m_reset = (bool?)xml.Attribute("reset");
			_actionctrl.m_state = (string)xml.Attribute("state");
			_actionctrl.m_temp = (int?)xml.Attribute("temp");
			_actionctrl.m_volt = (int?)xml.Attribute("volt");
			_actionctrl.m_wheelcount = (int?)xml.Attribute("wheelcount");
			Definitions.Tools.ParseList<actioncond>(_actionctrl.m_actioncondlist, xml, "actioncond", actioncond.Parse, rocrailClient);
			return _actionctrl;
		}
		public void Update(actionctrl element)
		{
			if(element.m_auto.HasValue == true) this.auto = element.auto;
			if(element.m_bkid != null) this.bkid = element.bkid;
			if(element.m_carcount.HasValue == true) this.carcount = element.carcount;
			if(element.m_countedcars.HasValue == true) this.countedcars = element.countedcars;
			if(element.m_counter.HasValue == true) this.counter = element.counter;
			if(element.m_deact != null) this.deact = element.deact;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_id != null) this.id = element.id;
			if(element.m_lcid != null) this.lcid = element.lcid;
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_manual.HasValue == true) this.manual = element.manual;
			if(element.m_param != null) this.param = element.param;
			if(element.m_reset.HasValue == true) this.reset = element.reset;
			if(element.m_state != null) this.state = element.state;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_volt.HasValue == true) this.volt = element.volt;
			if(element.m_wheelcount.HasValue == true) this.wheelcount = element.wheelcount;
			this.actioncondlist = element.actioncondlist;
		}
	}
}
