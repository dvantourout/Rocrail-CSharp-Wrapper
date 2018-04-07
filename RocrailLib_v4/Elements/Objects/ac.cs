using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class ac : CRocrailElements
	{
		public const string BLOCK_ACCEPTIDENT = "acceptident";
		public const string BLOCK_EVENT = "event";
		public const string BLOCK_SCHEDULE = "schedule";
		public const string BLOCK_SETLOC = "setloco";
		public const string BLOCK_UNLOCK = "unlock";
		public const string FUN_OFF = "off";
		public const string FUN_ON = "on";
		public const string LOCO_CARCOUNT = "carcount";
		public const string LOCO_DISPATCH = "dispatch";
		public const string LOCO_GO = "go";
		public const string LOCO_PERCENT = "percent";
		public const string LOCO_STOP = "stop";
		public const string LOCO_SWAP = "swap";
		public const string LOCO_VELOCITY = "velocity";
		public const string OUTPUT_ACTIVE = "active";
		public const string OUTPUT_OFF = "off";
		public const string OUTPUT_ON = "on";
		public const string ROUTE_LOCK = "lock";
		public const string ROUTE_LOCKSET = "lockset";
		public const string ROUTE_SET = "set";
		public const string ROUTE_UNLOCK = "unlock";
		public const string SIGNAL_GREEN = "green";
		public const string SIGNAL_RED = "red";
		public const string SIGNAL_WHITE = "white";
		public const string SIGNAL_YELLOW = "yellow";
		public const string SOUND_PLAY = "play";
		public const string SWITCH_FLIP = "flip";
		public const string SWITCH_LEFT = "left";
		public const string SWITCH_RIGHT = "right";
		public const string SWITCH_STRAIGHT = "straight";
		public const string SWITCH_TURNOUT = "turnout";
		public const string SYSTEM_GO = "go";
		public const string SYSTEM_SHUTDOWN = "shutdown";
		public const string SYSTEM_STOP = "stop";
		public const string SYSTEM_STOPLOCS = "stoplocs";
		public const string TEST = "test";
		public const string TEXT_UPDATE = "update";
		public const string TT_GOTO = "goto";
		public const string TT_TURN180 = "180";
		public const string TYPE_SOUND = "sound";
		private int? m_actiontime;
		private bool? m_activate;
		private int? m_addr;
		private int? m_bus;
		private string m_cmd;
		private string m_desc;
		private bool? m_doublequote;
		private bool? m_every;
		private int? m_hour;
		
		private string m_iid;
		private int? m_min;
		private string m_oid;
		private string m_param;
		private bool? m_random;
		private string m_refid;
		private string m_remark;
		private int? m_sec;
		private string m_sndfile;
		private int? m_sndvolume;
		private bool? m_timed;
		private int? m_timer;
		private string m_type;
		/// <summary>
		/// function activation time
		/// </summary>
		public int actiontime 
		{
			get { return this.m_actiontime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actiontime, value, "actiontime"); }
		}
		/// <summary>
		/// action activation at state ON or OFF: default is ON(true)
		/// </summary>
		public bool activate 
		{
			get { return this.m_activate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_activate, value, "activate"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// on, off or an external program or script to be executed
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Double quote under Windows.
		/// </summary>
		public bool doublequote 
		{
			get { return this.m_doublequote.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_doublequote, value, "doublequote"); }
		}
		/// <summary>
		/// Activate every hour:min.
		/// </summary>
		public bool every 
		{
			get { return this.m_every.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_every, value, "every"); }
		}
		/// <summary>
		/// action hour
		/// </summary>
		public int hour 
		{
			get { return this.m_hour.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_hour, value, "hour"); }
		}
		/// <summary>
		/// action id
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
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
		/// action minute
		/// </summary>
		public int min 
		{
			get { return this.m_min.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_min, value, "min"); }
		}
		/// <summary>
		/// output id
		/// </summary>
		public string oid 
		{
			get { return this.m_oid; }
			private set { this.SetField(ref this.m_oid, value, "oid"); }
		}
		/// <summary>
		/// command parameter like schedule id for lc
		/// </summary>
		public string param 
		{
			get { return this.m_param; }
			private set { this.SetField(ref this.m_param, value, "param"); }
		}
		/// <summary>
		/// Use time for random activation.
		/// </summary>
		public bool random 
		{
			get { return this.m_random.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_random, value, "random"); }
		}
		/// <summary>
		/// Reference ID for getting more information for this action.
		/// </summary>
		public string refid 
		{
			get { return this.m_refid; }
			private set { this.SetField(ref this.m_refid, value, "refid"); }
		}
		/// <summary>
		/// optional remark
		/// </summary>
		public string remark 
		{
			get { return this.m_remark; }
			private set { this.SetField(ref this.m_remark, value, "remark"); }
		}
		/// <summary>
		/// action second
		/// </summary>
		public int sec 
		{
			get { return this.m_sec.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sec, value, "sec"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string sndfile 
		{
			get { return this.m_sndfile; }
			private set { this.SetField(ref this.m_sndfile, value, "sndfile"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int sndvolume 
		{
			get { return this.m_sndvolume.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sndvolume, value, "sndvolume"); }
		}
		/// <summary>
		/// Use time for activation.
		/// </summary>
		public bool timed 
		{
			get { return this.m_timed.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timed, value, "timed"); }
		}
		/// <summary>
		/// Timer in ms before activation this action.
		/// </summary>
		public int timer 
		{
			get { return this.m_timer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timer, value, "timer"); }
		}
		/// <summary>
		/// type [ext] is an external program or script to be executed
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		public ac()
		{
		}
		public static ac Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			ac _ac = new ac();
			_ac.m_rocrailClient = rocrailClient;
			_ac.m_actiontime = (int?)xml.Attribute("actiontime");
			_ac.m_activate = (bool?)xml.Attribute("activate");
			_ac.m_addr = (int?)xml.Attribute("addr");
			_ac.m_bus = (int?)xml.Attribute("bus");
			_ac.m_cmd = (string)xml.Attribute("cmd");
			_ac.m_desc = (string)xml.Attribute("desc");
			_ac.m_doublequote = (bool?)xml.Attribute("doublequote");
			_ac.m_every = (bool?)xml.Attribute("every");
			_ac.m_hour = (int?)xml.Attribute("hour");
			_ac.m_id = (string)xml.Attribute("id");
			_ac.m_iid = (string)xml.Attribute("iid");
			_ac.m_min = (int?)xml.Attribute("min");
			_ac.m_oid = (string)xml.Attribute("oid");
			_ac.m_param = (string)xml.Attribute("param");
			_ac.m_random = (bool?)xml.Attribute("random");
			_ac.m_refid = (string)xml.Attribute("refid");
			_ac.m_remark = (string)xml.Attribute("remark");
			_ac.m_sec = (int?)xml.Attribute("sec");
			_ac.m_sndfile = (string)xml.Attribute("sndfile");
			_ac.m_sndvolume = (int?)xml.Attribute("sndvolume");
			_ac.m_timed = (bool?)xml.Attribute("timed");
			_ac.m_timer = (int?)xml.Attribute("timer");
			_ac.m_type = (string)xml.Attribute("type");
			return _ac;
		}
		public void Update(ac element)
		{
			if(element.m_actiontime.HasValue == true) this.actiontime = element.actiontime;
			if(element.m_activate.HasValue == true) this.activate = element.activate;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_doublequote.HasValue == true) this.doublequote = element.doublequote;
			if(element.m_every.HasValue == true) this.every = element.every;
			if(element.m_hour.HasValue == true) this.hour = element.hour;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_min.HasValue == true) this.min = element.min;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_param != null) this.param = element.param;
			if(element.m_random.HasValue == true) this.random = element.random;
			if(element.m_refid != null) this.refid = element.refid;
			if(element.m_remark != null) this.remark = element.remark;
			if(element.m_sec.HasValue == true) this.sec = element.sec;
			if(element.m_sndfile != null) this.sndfile = element.sndfile;
			if(element.m_sndvolume.HasValue == true) this.sndvolume = element.sndvolume;
			if(element.m_timed.HasValue == true) this.timed = element.timed;
			if(element.m_timer.HasValue == true) this.timer = element.timer;
			if(element.m_type != null) this.type = element.type;
		}
	}
}
