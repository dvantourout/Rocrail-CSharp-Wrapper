using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class st : CRocrailElements
	{
		public const string V_NONE = "none";
		public const string FORCE = "force";
		public const string FORWARDS = "forwards";
		public const string GO = "go";
		public const string MODID_AUTO_GEN = "auto-generated";
		public const string NO = "no";
		public const string POINT_E = "point-e";
		public const string POINT_EN = "point-en";
		public const string POINT_ENN = "point-enn";
		public const string POINT_ES = "point-es";
		public const string POINT_ESS = "point-ess";
		public const string POINT_N = "point-n";
		public const string POINT_NE = "point-ne";
		public const string POINT_NEE = "point-nee";
		public const string POINT_NW = "point-nw";
		public const string POINT_NWW = "point-nww";
		public const string POINT_S = "point-s";
		public const string POINT_SE = "point-se";
		public const string POINT_SEE = "point-see";
		public const string POINT_SW = "point-sw";
		public const string POINT_SWW = "point-sww";
		public const string POINT_W = "point-w";
		public const string POINT_WN = "point-wn";
		public const string POINT_WNN = "point-wnn";
		public const string POINT_WS = "point-ws";
		public const string POINT_WSS = "point-wss";
		public const string REVERSE = "reverse";
		public const string ROUTELOCK = "--routelock--";
		public const int STATUS_CLOSED = 4;
		public const int STATUS_DESELECTED = 3;
		public const int STATUS_FREE = 0;
		public const int STATUS_LOCKED = 1;
		public const int STATUS_SELECTED = 2;
		public const string TEST = "test";
		private string m_bka;
		private bool? m_bkaside;
		private string m_bkb;
		private bool? m_bkbside;
		private string m_bkc;
		private string m_cmd;
		private bool? m_commuter;
		private string m_countcars;
		private bool? m_crossingblocksignals;
		private int? m_ctcaddr1;
		private int? m_ctcaddr2;
		private int? m_ctcaddr3;
		private int? m_ctcbus1;
		private int? m_ctcbus2;
		private int? m_ctcbus3;
		private string m_ctciid1;
		private string m_ctciid2;
		private string m_ctciid3;
		private string m_ctcoutput1;
		private string m_ctcoutput2;
		private string m_ctcoutput3;
		private string m_desc;
		
		private string m_locid;
		private bool? m_manual;
		private int? m_maxkmh;
		private int? m_maxlen;
		private int? m_minlen;
		private string m_modid;
		private bool? m_nocommuter;
		private string m_ori;
		private bool? m_reduceV;
		private int? m_sga;
		private int? m_sgb;
		private bool? m_show;
		private string m_speed;
		private int? m_speedpercent;
		private int? m_status;
		private bool? m_swappost;
		private string m_typeperm;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<actionctrl> m_actionctrllist;
		private List<excl> m_excllist;
		private List<fbevent> m_fbeventlist;
		private List<incl> m_incllist;
		private List<stcondition> m_stconditionlist;
		private List<swcmd> m_swcmdlist;
		/// <summary>
		/// From block ID: $ prefix is a NetRocrail ID.
		/// </summary>
		public string bka 
		{
			get { return this.m_bka; }
			private set { this.SetField(ref this.m_bka, value, "bka"); }
		}
		/// <summary>
		/// Block side connection; true=+, false=-
		/// </summary>
		public bool bkaside 
		{
			get { return this.m_bkaside.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bkaside, value, "bkaside"); }
		}
		/// <summary>
		/// To block ID: $ prefix is a NetRocrail ID.
		/// </summary>
		public string bkb 
		{
			get { return this.m_bkb; }
			private set { this.SetField(ref this.m_bkb, value, "bkb"); }
		}
		/// <summary>
		/// Block side connection; true=+, false=-
		/// </summary>
		public bool bkbside 
		{
			get { return this.m_bkbside.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bkbside, value, "bkbside"); }
		}
		/// <summary>
		/// Crossing block: optional incase a block overlaps turnouts used by this route. This is a csv list of blocks.
		/// </summary>
		public string bkc 
		{
			get { return this.m_bkc; }
			private set { this.SetField(ref this.m_bkc, value, "bkc"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// Only allow commuter trains.
		/// </summary>
		public bool commuter 
		{
			get { return this.m_commuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_commuter, value, "commuter"); }
		}
		/// <summary>
		/// Count number of cars before firing events.
		/// </summary>
		public string countcars 
		{
			get { return this.m_countcars; }
			private set { this.SetField(ref this.m_countcars, value, "countcars"); }
		}
		/// <summary>
		/// Set the signals in the crossing blocks according to the from block.
		/// </summary>
		public bool crossingblocksignals 
		{
			get { return this.m_crossingblocksignals.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_crossingblocksignals, value, "crossingblocksignals"); }
		}
		/// <summary>
		/// address
		/// </summary>
		public int ctcaddr1 
		{
			get { return this.m_ctcaddr1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddr1, value, "ctcaddr1"); }
		}
		/// <summary>
		/// address
		/// </summary>
		public int ctcaddr2 
		{
			get { return this.m_ctcaddr2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddr2, value, "ctcaddr2"); }
		}
		/// <summary>
		/// address
		/// </summary>
		public int ctcaddr3 
		{
			get { return this.m_ctcaddr3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddr3, value, "ctcaddr3"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int ctcbus1 
		{
			get { return this.m_ctcbus1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbus1, value, "ctcbus1"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int ctcbus2 
		{
			get { return this.m_ctcbus2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbus2, value, "ctcbus2"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int ctcbus3 
		{
			get { return this.m_ctcbus3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbus3, value, "ctcbus3"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string ctciid1 
		{
			get { return this.m_ctciid1; }
			private set { this.SetField(ref this.m_ctciid1, value, "ctciid1"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string ctciid2 
		{
			get { return this.m_ctciid2; }
			private set { this.SetField(ref this.m_ctciid2, value, "ctciid2"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string ctciid3 
		{
			get { return this.m_ctciid3; }
			private set { this.SetField(ref this.m_ctciid3, value, "ctciid3"); }
		}
		/// <summary>
		/// CTC Output1
		/// </summary>
		public string ctcoutput1 
		{
			get { return this.m_ctcoutput1; }
			private set { this.SetField(ref this.m_ctcoutput1, value, "ctcoutput1"); }
		}
		/// <summary>
		/// CTC Output2
		/// </summary>
		public string ctcoutput2 
		{
			get { return this.m_ctcoutput2; }
			private set { this.SetField(ref this.m_ctcoutput2, value, "ctcoutput2"); }
		}
		/// <summary>
		/// CTC Output3
		/// </summary>
		public string ctcoutput3 
		{
			get { return this.m_ctcoutput3; }
			private set { this.SetField(ref this.m_ctcoutput3, value, "ctcoutput3"); }
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
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// The loco which has locked this route.
		/// </summary>
		public string locid 
		{
			get { return this.m_locid; }
			private set { this.SetField(ref this.m_locid, value, "locid"); }
		}
		/// <summary>
		/// manual controlled route
		/// </summary>
		public bool manual 
		{
			get { return this.m_manual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manual, value, "manual"); }
		}
		/// <summary>
		/// Route max. speed in km/h or mph.
		/// </summary>
		public int maxkmh 
		{
			get { return this.m_maxkmh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxkmh, value, "maxkmh"); }
		}
		/// <summary>
		/// Maximal train length allowed for this route.
		/// </summary>
		public int maxlen 
		{
			get { return this.m_maxlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxlen, value, "maxlen"); }
		}
		/// <summary>
		/// Minimal train length allowed for this route.
		/// </summary>
		public int minlen 
		{
			get { return this.m_minlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minlen, value, "minlen"); }
		}
		/// <summary>
		/// module ID for internal use only
		/// </summary>
		public string modid 
		{
			get { return this.m_modid; }
			private set { this.SetField(ref this.m_modid, value, "modid"); }
		}
		/// <summary>
		/// Disallow commuter trains.
		/// </summary>
		public bool nocommuter 
		{
			get { return this.m_nocommuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nocommuter, value, "nocommuter"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string ori 
		{
			get { return this.m_ori; }
			private set { this.SetField(ref this.m_ori, value, "ori"); }
		}
		/// <summary>
		/// reduce speed by thrown switches
		/// </summary>
		public bool reduceV 
		{
			get { return this.m_reduceV.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reduceV, value, "reduceV"); }
		}
		/// <summary>
		/// signal pair block a
		/// </summary>
		public int sga 
		{
			get { return this.m_sga.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sga, value, "sga"); }
		}
		/// <summary>
		/// signal pair block b
		/// </summary>
		public int sgb 
		{
			get { return this.m_sgb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sgb, value, "sgb"); }
		}
		/// <summary>
		/// Visibility flag.
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
		}
		/// <summary>
		/// Route speed on departure; overwrites block departure speed if set.
		/// </summary>
		public string speed 
		{
			get { return this.m_speed; }
			private set { this.SetField(ref this.m_speed, value, "speed"); }
		}
		/// <summary>
		/// Route speed in percent.
		/// </summary>
		public int speedpercent 
		{
			get { return this.m_speedpercent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_speedpercent, value, "speedpercent"); }
		}
		/// <summary>
		/// route status
		/// </summary>
		public int status 
		{
			get { return this.m_status.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_status, value, "status"); }
		}
		/// <summary>
		/// swap loco placing at terminating this route
		/// </summary>
		public bool swappost 
		{
			get { return this.m_swappost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swappost, value, "swappost"); }
		}
		/// <summary>
		/// Only allow this type of trains.
		/// </summary>
		public string typeperm 
		{
			get { return this.m_typeperm; }
			private set { this.SetField(ref this.m_typeperm, value, "typeperm"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int x 
		{
			get { return this.m_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_x, value, "x"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int y 
		{
			get { return this.m_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_y, value, "y"); }
		}
		/// <summary>
		/// level for internal use only
		/// </summary>
		public int z 
		{
			get { return this.m_z.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_z, value, "z"); }
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
		public List<excl> excllist 
		{
			get { return this.m_excllist; }
			private set { this.SetField(ref this.m_excllist, value, "excllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<fbevent> fbeventlist 
		{
			get { return this.m_fbeventlist; }
			private set { this.SetField(ref this.m_fbeventlist, value, "fbeventlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<incl> incllist 
		{
			get { return this.m_incllist; }
			private set { this.SetField(ref this.m_incllist, value, "incllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<stcondition> stconditionlist 
		{
			get { return this.m_stconditionlist; }
			private set { this.SetField(ref this.m_stconditionlist, value, "stconditionlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<swcmd> swcmdlist 
		{
			get { return this.m_swcmdlist; }
			private set { this.SetField(ref this.m_swcmdlist, value, "swcmdlist"); }
		}
		public st()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_excllist = new List<excl>();
			this.m_fbeventlist = new List<fbevent>();
			this.m_incllist = new List<incl>();
			this.m_stconditionlist = new List<stcondition>();
			this.m_swcmdlist = new List<swcmd>();
		}
		public static st Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			st _st = new st();
			_st.m_rocrailClient = rocrailClient;
			_st.m_bka = (string)xml.Attribute("bka");
			_st.m_bkaside = (bool?)xml.Attribute("bkaside");
			_st.m_bkb = (string)xml.Attribute("bkb");
			_st.m_bkbside = (bool?)xml.Attribute("bkbside");
			_st.m_bkc = (string)xml.Attribute("bkc");
			_st.m_cmd = (string)xml.Attribute("cmd");
			_st.m_commuter = (bool?)xml.Attribute("commuter");
			_st.m_countcars = (string)xml.Attribute("countcars");
			_st.m_crossingblocksignals = (bool?)xml.Attribute("crossingblocksignals");
			_st.m_ctcaddr1 = (int?)xml.Attribute("ctcaddr1");
			_st.m_ctcaddr2 = (int?)xml.Attribute("ctcaddr2");
			_st.m_ctcaddr3 = (int?)xml.Attribute("ctcaddr3");
			_st.m_ctcbus1 = (int?)xml.Attribute("ctcbus1");
			_st.m_ctcbus2 = (int?)xml.Attribute("ctcbus2");
			_st.m_ctcbus3 = (int?)xml.Attribute("ctcbus3");
			_st.m_ctciid1 = (string)xml.Attribute("ctciid1");
			_st.m_ctciid2 = (string)xml.Attribute("ctciid2");
			_st.m_ctciid3 = (string)xml.Attribute("ctciid3");
			_st.m_ctcoutput1 = (string)xml.Attribute("ctcoutput1");
			_st.m_ctcoutput2 = (string)xml.Attribute("ctcoutput2");
			_st.m_ctcoutput3 = (string)xml.Attribute("ctcoutput3");
			_st.m_desc = (string)xml.Attribute("desc");
			_st.m_id = (string)xml.Attribute("id");
			_st.m_locid = (string)xml.Attribute("locid");
			_st.m_manual = (bool?)xml.Attribute("manual");
			_st.m_maxkmh = (int?)xml.Attribute("maxkmh");
			_st.m_maxlen = (int?)xml.Attribute("maxlen");
			_st.m_minlen = (int?)xml.Attribute("minlen");
			_st.m_modid = (string)xml.Attribute("modid");
			_st.m_nocommuter = (bool?)xml.Attribute("nocommuter");
			_st.m_ori = (string)xml.Attribute("ori");
			_st.m_reduceV = (bool?)xml.Attribute("reduceV");
			_st.m_sga = (int?)xml.Attribute("sga");
			_st.m_sgb = (int?)xml.Attribute("sgb");
			_st.m_show = (bool?)xml.Attribute("show");
			_st.m_speed = (string)xml.Attribute("speed");
			_st.m_speedpercent = (int?)xml.Attribute("speedpercent");
			_st.m_status = (int?)xml.Attribute("status");
			_st.m_swappost = (bool?)xml.Attribute("swappost");
			_st.m_typeperm = (string)xml.Attribute("typeperm");
			_st.m_x = (int?)xml.Attribute("x");
			_st.m_y = (int?)xml.Attribute("y");
			_st.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_st.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<excl>(_st.m_excllist, xml, "excl", excl.Parse, rocrailClient);
			Definitions.Tools.ParseList<fbevent>(_st.m_fbeventlist, xml, "fbevent", fbevent.Parse, rocrailClient);
			Definitions.Tools.ParseList<incl>(_st.m_incllist, xml, "incl", incl.Parse, rocrailClient);
			Definitions.Tools.ParseList<stcondition>(_st.m_stconditionlist, xml, "stcondition", stcondition.Parse, rocrailClient);
			Definitions.Tools.ParseList<swcmd>(_st.m_swcmdlist, xml, "swcmd", swcmd.Parse, rocrailClient);
			return _st;
		}
		public void Update(st element)
		{
			if(element.m_bka != null) this.bka = element.bka;
			if(element.m_bkaside.HasValue == true) this.bkaside = element.bkaside;
			if(element.m_bkb != null) this.bkb = element.bkb;
			if(element.m_bkbside.HasValue == true) this.bkbside = element.bkbside;
			if(element.m_bkc != null) this.bkc = element.bkc;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_commuter.HasValue == true) this.commuter = element.commuter;
			if(element.m_countcars != null) this.countcars = element.countcars;
			if(element.m_crossingblocksignals.HasValue == true) this.crossingblocksignals = element.crossingblocksignals;
			if(element.m_ctcaddr1.HasValue == true) this.ctcaddr1 = element.ctcaddr1;
			if(element.m_ctcaddr2.HasValue == true) this.ctcaddr2 = element.ctcaddr2;
			if(element.m_ctcaddr3.HasValue == true) this.ctcaddr3 = element.ctcaddr3;
			if(element.m_ctcbus1.HasValue == true) this.ctcbus1 = element.ctcbus1;
			if(element.m_ctcbus2.HasValue == true) this.ctcbus2 = element.ctcbus2;
			if(element.m_ctcbus3.HasValue == true) this.ctcbus3 = element.ctcbus3;
			if(element.m_ctciid1 != null) this.ctciid1 = element.ctciid1;
			if(element.m_ctciid2 != null) this.ctciid2 = element.ctciid2;
			if(element.m_ctciid3 != null) this.ctciid3 = element.ctciid3;
			if(element.m_ctcoutput1 != null) this.ctcoutput1 = element.ctcoutput1;
			if(element.m_ctcoutput2 != null) this.ctcoutput2 = element.ctcoutput2;
			if(element.m_ctcoutput3 != null) this.ctcoutput3 = element.ctcoutput3;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_id != null) this.id = element.id;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_manual.HasValue == true) this.manual = element.manual;
			if(element.m_maxkmh.HasValue == true) this.maxkmh = element.maxkmh;
			if(element.m_maxlen.HasValue == true) this.maxlen = element.maxlen;
			if(element.m_minlen.HasValue == true) this.minlen = element.minlen;
			if(element.m_modid != null) this.modid = element.modid;
			if(element.m_nocommuter.HasValue == true) this.nocommuter = element.nocommuter;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_reduceV.HasValue == true) this.reduceV = element.reduceV;
			if(element.m_sga.HasValue == true) this.sga = element.sga;
			if(element.m_sgb.HasValue == true) this.sgb = element.sgb;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_speed != null) this.speed = element.speed;
			if(element.m_speedpercent.HasValue == true) this.speedpercent = element.speedpercent;
			if(element.m_status.HasValue == true) this.status = element.status;
			if(element.m_swappost.HasValue == true) this.swappost = element.swappost;
			if(element.m_typeperm != null) this.typeperm = element.typeperm;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;
			this.excllist = element.excllist;
			this.fbeventlist = element.fbeventlist;
			this.incllist = element.incllist;
			this.stconditionlist = element.stconditionlist;
			this.swcmdlist = element.swcmdlist;
		}
	}
}
