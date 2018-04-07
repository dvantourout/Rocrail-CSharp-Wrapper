using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class loconet : CRocrailElements
	{
		public const string CS_DB150 = "db150";
		public const string CS_DCS100 = "dcs100";
		public const string CS_DCS50 = "dcs50";
		public const string CS_IBCOM = "ibcom";
		public const string CS_INTELLIBOX = "intellibox";
		public const string CS_ROCRAIL = "rocrail";
		private string m_cmdstn;
		private bool? m_ignorepowercmds;
		private int? m_purgetime;
		private int? m_reportaddr;
		private bool? m_resetlissy;
		private bool? m_sensorquery;
		private bool? m_slotping;
		private int? m_slots;
		private bool? m_swack;
		private int? m_swretry;
		private int? m_swsleep;
		private bool? m_syncfc;
		private bool? m_usedouble;
		private bool? m_usefc;
		private bool? m_useidle;
		private bool? m_useseq;
		private List<options> m_optionslist;
		private List<slotserver> m_slotserverlist;
		/// <summary>
		/// 
		/// </summary>
		public string cmdstn 
		{
			get { return this.m_cmdstn; }
			private set { this.SetField(ref this.m_cmdstn, value, "cmdstn"); }
		}
		/// <summary>
		/// Ignore subsequetial power commands.
		/// </summary>
		public bool ignorepowercmds 
		{
			get { return this.m_ignorepowercmds.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ignorepowercmds, value, "ignorepowercmds"); }
		}
		/// <summary>
		/// set to zero if the command station does not purge
		/// </summary>
		public int purgetime 
		{
			get { return this.m_purgetime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_purgetime, value, "purgetime"); }
		}
		/// <summary>
		/// global addres on which sensors are reported
		/// </summary>
		public int reportaddr 
		{
			get { return this.m_reportaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reportaddr, value, "reportaddr"); }
		}
		/// <summary>
		/// Reset Lissy events after 1 second.
		/// </summary>
		public bool resetlissy 
		{
			get { return this.m_resetlissy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetlissy, value, "resetlissy"); }
		}
		/// <summary>
		/// do sensor query at OPC_GPON
		/// </summary>
		public bool sensorquery 
		{
			get { return this.m_sensorquery.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sensorquery, value, "sensorquery"); }
		}
		/// <summary>
		/// Enable slot ping if purge time is not zero.
		/// </summary>
		public bool slotping 
		{
			get { return this.m_slotping.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_slotping, value, "slotping"); }
		}
		/// <summary>
		/// number of slots for loco's
		/// </summary>
		public int slots 
		{
			get { return this.m_slots.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_slots, value, "slots"); }
		}
		/// <summary>
		/// Check long ack for switch commands.
		/// </summary>
		public bool swack 
		{
			get { return this.m_swack.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swack, value, "swack"); }
		}
		/// <summary>
		/// Number of switch command retries.
		/// </summary>
		public int swretry 
		{
			get { return this.m_swretry.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swretry, value, "swretry"); }
		}
		/// <summary>
		/// Number of ms sleep between switch command retries.
		/// </summary>
		public int swsleep 
		{
			get { return this.m_swsleep.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swsleep, value, "swsleep"); }
		}
		/// <summary>
		/// synchronize fast clock
		/// </summary>
		public bool syncfc 
		{
			get { return this.m_syncfc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_syncfc, value, "syncfc"); }
		}
		/// <summary>
		/// Use double packets for lnudp.
		/// </summary>
		public bool usedouble 
		{
			get { return this.m_usedouble.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usedouble, value, "usedouble"); }
		}
		/// <summary>
		/// enable fast clock
		/// </summary>
		public bool usefc 
		{
			get { return this.m_usefc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usefc, value, "usefc"); }
		}
		/// <summary>
		/// use OPC_IDLE instead of OPC_GPOFF
		/// </summary>
		public bool useidle 
		{
			get { return this.m_useidle.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_useidle, value, "useidle"); }
		}
		/// <summary>
		/// Use sequence counter for lnudp.
		/// </summary>
		public bool useseq 
		{
			get { return this.m_useseq.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_useseq, value, "useseq"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<options> optionslist 
		{
			get { return this.m_optionslist; }
			private set { this.SetField(ref this.m_optionslist, value, "optionslist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<slotserver> slotserverlist 
		{
			get { return this.m_slotserverlist; }
			private set { this.SetField(ref this.m_slotserverlist, value, "slotserverlist"); }
		}
		public loconet()
		{
			this.m_optionslist = new List<options>();
			this.m_slotserverlist = new List<slotserver>();
		}
		public static loconet Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			loconet _loconet = new loconet();
			_loconet.m_rocrailClient = rocrailClient;
			_loconet.m_cmdstn = (string)xml.Attribute("cmdstn");
			_loconet.m_ignorepowercmds = (bool?)xml.Attribute("ignorepowercmds");
			_loconet.m_purgetime = (int?)xml.Attribute("purgetime");
			_loconet.m_reportaddr = (int?)xml.Attribute("reportaddr");
			_loconet.m_resetlissy = (bool?)xml.Attribute("resetlissy");
			_loconet.m_sensorquery = (bool?)xml.Attribute("sensorquery");
			_loconet.m_slotping = (bool?)xml.Attribute("slotping");
			_loconet.m_slots = (int?)xml.Attribute("slots");
			_loconet.m_swack = (bool?)xml.Attribute("swack");
			_loconet.m_swretry = (int?)xml.Attribute("swretry");
			_loconet.m_swsleep = (int?)xml.Attribute("swsleep");
			_loconet.m_syncfc = (bool?)xml.Attribute("syncfc");
			_loconet.m_usedouble = (bool?)xml.Attribute("usedouble");
			_loconet.m_usefc = (bool?)xml.Attribute("usefc");
			_loconet.m_useidle = (bool?)xml.Attribute("useidle");
			_loconet.m_useseq = (bool?)xml.Attribute("useseq");
			Definitions.Tools.ParseList<options>(_loconet.m_optionslist, xml, "options", options.Parse, rocrailClient);
			Definitions.Tools.ParseList<slotserver>(_loconet.m_slotserverlist, xml, "slotserver", slotserver.Parse, rocrailClient);
			return _loconet;
		}
		public void Update(loconet element)
		{
			if(element.m_cmdstn != null) this.cmdstn = element.cmdstn;
			if(element.m_ignorepowercmds.HasValue == true) this.ignorepowercmds = element.ignorepowercmds;
			if(element.m_purgetime.HasValue == true) this.purgetime = element.purgetime;
			if(element.m_reportaddr.HasValue == true) this.reportaddr = element.reportaddr;
			if(element.m_resetlissy.HasValue == true) this.resetlissy = element.resetlissy;
			if(element.m_sensorquery.HasValue == true) this.sensorquery = element.sensorquery;
			if(element.m_slotping.HasValue == true) this.slotping = element.slotping;
			if(element.m_slots.HasValue == true) this.slots = element.slots;
			if(element.m_swack.HasValue == true) this.swack = element.swack;
			if(element.m_swretry.HasValue == true) this.swretry = element.swretry;
			if(element.m_swsleep.HasValue == true) this.swsleep = element.swsleep;
			if(element.m_syncfc.HasValue == true) this.syncfc = element.syncfc;
			if(element.m_usedouble.HasValue == true) this.usedouble = element.usedouble;
			if(element.m_usefc.HasValue == true) this.usefc = element.usefc;
			if(element.m_useidle.HasValue == true) this.useidle = element.useidle;
			if(element.m_useseq.HasValue == true) this.useseq = element.useseq;
			this.optionslist = element.optionslist;
			this.slotserverlist = element.slotserverlist;
		}
	}
}
