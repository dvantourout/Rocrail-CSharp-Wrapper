using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class bk : CRocrailElements
	{
		public const string CLOSED = "closed";
		public const string COMMUTER_NO = "no";
		public const string COMMUTER_ONLY = "only";
		public const string COMMUTER_YES = "yes";
		public const string CRUISE = "cruise";
		public const string GHOST = "ghost";
		public const int INCLINE_DOWN = -1;
		public const int INCLINE_NONE = 0;
		public const int INCLINE_UP = 1;
		public const string LOC = "loc";
		public const string MAX = "max";
		public const string MID = "mid";
		public const string MIN = "min";
		public const string OPEN = "open";
		public const string PERCENT = "percent";
		public const string RESETFIFO = "resetfifo";
		public const string RESETWC = "resetwc";
		public const string SHORTCUT = "shortcut";
		public const string SHORTCUTCLEARED = "shortcutcleared";
		public const string TYPE_GOODS = "goods";
		public const string TYPE_ICE = "ice";
		public const string TYPE_LIGHT = "light";
		public const string TYPE_LIGHTGOODS = "lightgoods";
		public const string TYPE_LOCAL = "local";
		public const string TYPE_NONE = "none";
		public const string TYPE_POST = "post";
		public const string TYPE_REGIONAL = "regional";
		public const string TYPE_SHUNTING = "shunting";
		public const string TYPE_TURNTABLE = "turntable";
		public const string WAIT_FIXED = "fixed";
		public const string WAIT_LOC = "loc";
		public const string WAIT_NONE = "none";
		public const string WAIT_RANDOM = "random";
		private bool? m_acceptghost;
		private bool? m_acceptident;
		private int? m_addr;
		private bool? m_allowbbt;
		private bool? m_allowchgdir;
		private bool? m_blankatredsignal;
		private bool? m_blankatredsignalR;
		private string m_cmd;
		private string m_commuter;
		private int? m_departdelay;
		private string m_desc;
		private bool? m_electrified;
		private bool? m_entering;
		private int? m_evttimer;
		private int? m_evttimer2;
		private string m_exitspeed;
		private int? m_exitspeedpercent;
		private bool? m_extstop;
		private string m_fifoids;
		private int? m_fifosize;
		private bool? m_forceblocktimer;
		private bool? m_gomanual;
		
		private string m_iid;
		private int? m_incline;
		private int? m_len;
		private string m_locid;
		private string m_managerid;
		private bool? m_manual;
		private int? m_maxkmh;
		private int? m_maxwaittime;
		private int? m_minwaittime;
		private int? m_mvdistance;
		private bool? m_mvmph;
		private int? m_mvscale;
		private int? m_port;
		private bool? m_power;
		private string m_prevstate;
		private bool? m_remote;
		private bool? m_reserved;
		public const string RRID = "";
		private bool? m_show;
		private string m_signal;
		private string m_signalR;
		private bool? m_smallsymbol;
		private string m_speed;
		private int? m_speedpercent;
		private string m_state;
		private string m_stopspeed;
		private bool? m_td;
		private bool? m_terminalstation;
		private string m_ttid;
		private string m_turnoutstolock;
		private string m_type;
		private string m_typeperm;
		private bool? m_updateenterside;
		private bool? m_wait;
		private string m_waitmode;
		private int? m_waittime;
		private string m_wsignal;
		private string m_wsignalR;
		private int? m_x;
		private int? m_y;
		private int? m_z;
        private string m_ori;
		private List<actionctrl> m_actionctrllist;
		private List<excl> m_excllist;
		private List<fbevent> m_fbeventlist;
		private List<incl> m_incllist;
		/// <summary>
		/// accept a ghosttrain and signal the block occupied.
		/// </summary>
		public bool acceptghost 
		{
			get { return this.m_acceptghost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_acceptghost, value, "acceptghost"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool acceptident 
		{
			get { return this.m_acceptident.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_acceptident, value, "acceptident"); }
		}
		/// <summary>
		/// TD address
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool allowbbt 
		{
			get { return this.m_allowbbt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_allowbbt, value, "allowbbt"); }
		}
		/// <summary>
		/// Allow using a route in the opposite running direction.
		/// </summary>
		public bool allowchgdir 
		{
			get { return this.m_allowchgdir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_allowchgdir, value, "allowchgdir"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool blankatredsignal 
		{
			get { return this.m_blankatredsignal.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blankatredsignal, value, "blankatredsignal"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool blankatredsignalR 
		{
			get { return this.m_blankatredsignalR.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blankatredsignalR, value, "blankatredsignalR"); }
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
		/// Are commuter trains allowed?
		/// </summary>
		public string commuter 
		{
			get { return this.m_commuter; }
			private set { this.SetField(ref this.m_commuter, value, "commuter"); }
		}
		/// <summary>
		/// delay time to wait before loco starts when depart is raised
		/// </summary>
		public int departdelay 
		{
			get { return this.m_departdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_departdelay, value, "departdelay"); }
		}
		/// <summary>
		/// Description of block.
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Block is open for electric locs.
		/// </summary>
		public bool electrified 
		{
			get { return this.m_electrified.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_electrified, value, "electrified"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool entering 
		{
			get { return this.m_entering.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_entering, value, "entering"); }
		}
		/// <summary>
		/// event timer; loc should wait this time before processing the event
		/// </summary>
		public int evttimer 
		{
			get { return this.m_evttimer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_evttimer, value, "evttimer"); }
		}
		/// <summary>
		/// event timer reverse direction; loc should wait this time before processing the event
		/// </summary>
		public int evttimer2 
		{
			get { return this.m_evttimer2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_evttimer2, value, "evttimer2"); }
		}
		/// <summary>
		/// Block speed on departure.
		/// </summary>
		public string exitspeed 
		{
			get { return this.m_exitspeed; }
			private set { this.SetField(ref this.m_exitspeed, value, "exitspeed"); }
		}
		/// <summary>
		/// Block depart speed in percent.
		/// </summary>
		public int exitspeedpercent 
		{
			get { return this.m_exitspeedpercent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_exitspeedpercent, value, "exitspeedpercent"); }
		}
		/// <summary>
		/// An external stop module will take over the throttle. Use only with enter2in! (Lenz ABC.)
		/// </summary>
		public bool extstop 
		{
			get { return this.m_extstop.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_extstop, value, "extstop"); }
		}
		/// <summary>
		/// CSV list of all FiFo IDs.
		/// </summary>
		public string fifoids 
		{
			get { return this.m_fifoids; }
			private set { this.SetField(ref this.m_fifoids, value, "fifoids"); }
		}
		/// <summary>
		/// FiFo size; Must be greater then 0 to be active.
		/// </summary>
		public int fifosize 
		{
			get { return this.m_fifosize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fifosize, value, "fifosize"); }
		}
		/// <summary>
		/// Force the block event timer to overrule the optional loco event timer.
		/// </summary>
		public bool forceblocktimer 
		{
			get { return this.m_forceblocktimer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_forceblocktimer, value, "forceblocktimer"); }
		}
		/// <summary>
		/// allow half-automatic mode
		/// </summary>
		public bool gomanual 
		{
			get { return this.m_gomanual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gomanual, value, "gomanual"); }
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
		/// TD interface id
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int incline 
		{
			get { return this.m_incline.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_incline, value, "incline"); }
		}
		/// <summary>
		/// Distance between enter and in event to check with train length.
		/// </summary>
		public int len 
		{
			get { return this.m_len.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_len, value, "len"); }
		}
		/// <summary>
		/// The loc which is actualy in the block or is comming or going.
		/// </summary>
		public string locid 
		{
			get { return this.m_locid; }
			private set { this.SetField(ref this.m_locid, value, "locid"); }
		}
		/// <summary>
		/// ID of the manager object like FY or TT.
		/// </summary>
		public string managerid 
		{
			get { return this.m_managerid; }
			private set { this.SetField(ref this.m_managerid, value, "managerid"); }
		}
		/// <summary>
		/// Block not chooseable for locs in auto-mode if set to true.
		/// </summary>
		public bool manual 
		{
			get { return this.m_manual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manual, value, "manual"); }
		}
		/// <summary>
		/// Block max. speed in km/h or mph.
		/// </summary>
		public int maxkmh 
		{
			get { return this.m_maxkmh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxkmh, value, "maxkmh"); }
		}
		/// <summary>
		/// Max. wait time in case of wait_random.
		/// </summary>
		public int maxwaittime 
		{
			get { return this.m_maxwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxwaittime, value, "maxwaittime"); }
		}
		/// <summary>
		/// Min. wait time in case of wait_random.
		/// </summary>
		public int minwaittime 
		{
			get { return this.m_minwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minwaittime, value, "minwaittime"); }
		}
		/// <summary>
		/// Distance between the enter and in event.
		/// </summary>
		public int mvdistance 
		{
			get { return this.m_mvdistance.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mvdistance, value, "mvdistance"); }
		}
		/// <summary>
		/// convert to MPH
		/// </summary>
		public bool mvmph 
		{
			get { return this.m_mvmph.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mvmph, value, "mvmph"); }
		}
		/// <summary>
		/// Scale of locomotives.
		/// </summary>
		public int mvscale 
		{
			get { return this.m_mvscale.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mvscale, value, "mvscale"); }
		}
		/// <summary>
		/// TD output port
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// block power
		/// </summary>
		public bool power 
		{
			get { return this.m_power.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_power, value, "power"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string prevstate 
		{
			get { return this.m_prevstate; }
			private set { this.SetField(ref this.m_prevstate, value, "prevstate"); }
		}
		/// <summary>
		/// This flag is set by the R2Rnet object.
		/// </summary>
		public bool remote 
		{
			get { return this.m_remote.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_remote, value, "remote"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool reserved 
		{
			get { return this.m_reserved.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reserved, value, "reserved"); }
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
		/// Home Signal ID. (sw)
		/// </summary>
		public string signal 
		{
			get { return this.m_signal; }
			private set { this.SetField(ref this.m_signal, value, "signal"); }
		}
		/// <summary>
		/// Home Signal ID for reverse direction. (sw)
		/// </summary>
		public string signalR 
		{
			get { return this.m_signalR; }
			private set { this.SetField(ref this.m_signalR, value, "signalR"); }
		}
		/// <summary>
		/// Show this block with the small representation.
		/// </summary>
		public bool smallsymbol 
		{
			get { return this.m_smallsymbol.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_smallsymbol, value, "smallsymbol"); }
		}
		/// <summary>
		/// Block speed on arrive.
		/// </summary>
		public string speed 
		{
			get { return this.m_speed; }
			private set { this.SetField(ref this.m_speed, value, "speed"); }
		}
		/// <summary>
		/// Blockspeed in percent.
		/// </summary>
		public int speedpercent 
		{
			get { return this.m_speedpercent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_speedpercent, value, "speedpercent"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Block speed on arrive and stop.
		/// </summary>
		public string stopspeed 
		{
			get { return this.m_stopspeed; }
			private set { this.SetField(ref this.m_stopspeed, value, "stopspeed"); }
		}
		/// <summary>
		/// trackdriver connected to this block
		/// </summary>
		public bool td 
		{
			get { return this.m_td.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_td, value, "td"); }
		}
		/// <summary>
		/// swap placing of an incomming loc to get another default direction.(terminal station)
		/// </summary>
		public bool terminalstation 
		{
			get { return this.m_terminalstation.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_terminalstation, value, "terminalstation"); }
		}
		/// <summary>
		/// Turntable ID.
		/// </summary>
		public string ttid 
		{
			get { return this.m_ttid; }
			private set { this.SetField(ref this.m_ttid, value, "ttid"); }
		}
		/// <summary>
		/// comma separated list of turnouts to lock with the block
		/// </summary>
		public string turnoutstolock 
		{
			get { return this.m_turnoutstolock; }
			private set { this.SetField(ref this.m_turnoutstolock, value, "turnoutstolock"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
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
		/// For internal use only: Event for updating the loco block enter side only.
		/// </summary>
		public bool updateenterside 
		{
			get { return this.m_updateenterside.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_updateenterside, value, "updateenterside"); }
		}
		/// <summary>
		/// Should the loc wait in this block?
		/// </summary>
		public bool wait 
		{
			get { return this.m_wait.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wait, value, "wait"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string waitmode 
		{
			get { return this.m_waitmode; }
			private set { this.SetField(ref this.m_waitmode, value, "waitmode"); }
		}
		/// <summary>
		/// Wait time in case of wait_fixed.
		/// </summary>
		public int waittime 
		{
			get { return this.m_waittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_waittime, value, "waittime"); }
		}
		/// <summary>
		/// Warning Signal ID. (sw)
		/// </summary>
		public string wsignal 
		{
			get { return this.m_wsignal; }
			private set { this.SetField(ref this.m_wsignal, value, "wsignal"); }
		}
		/// <summary>
		/// Warning Signal ID for reverse direction. (sw)
		/// </summary>
		public string wsignalR 
		{
			get { return this.m_wsignalR; }
			private set { this.SetField(ref this.m_wsignalR, value, "wsignalR"); }
		}
		/// <summary>
		/// X-Position in the plan.
		/// </summary>
		public int x 
		{
			get { return this.m_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_x, value, "x"); }
		}
		/// <summary>
		/// Y-Position in the plan.
		/// </summary>
		public int y 
		{
			get { return this.m_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_y, value, "y"); }
		}
		/// <summary>
		/// Z-Position in the plan. (level)
		/// </summary>
		public int z 
		{
			get { return this.m_z.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_z, value, "z"); }
		}
        public string ori
        {
            get { return this.m_ori; }
            private set { this.SetField(ref this.m_ori, value, "ori"); }
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
		public bk()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_excllist = new List<excl>();
			this.m_fbeventlist = new List<fbevent>();
			this.m_incllist = new List<incl>();
		}
		public static bk Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			bk _bk = new bk();
			_bk.m_rocrailClient = rocrailClient;
			_bk.m_acceptghost = (bool?)xml.Attribute("acceptghost");
			_bk.m_acceptident = (bool?)xml.Attribute("acceptident");
			_bk.m_addr = (int?)xml.Attribute("addr");
			_bk.m_allowbbt = (bool?)xml.Attribute("allowbbt");
			_bk.m_allowchgdir = (bool?)xml.Attribute("allowchgdir");
			_bk.m_blankatredsignal = (bool?)xml.Attribute("blankatredsignal");
			_bk.m_blankatredsignalR = (bool?)xml.Attribute("blankatredsignalR");
			_bk.m_cmd = (string)xml.Attribute("cmd");
			_bk.m_commuter = (string)xml.Attribute("commuter");
			_bk.m_departdelay = (int?)xml.Attribute("departdelay");
			_bk.m_desc = (string)xml.Attribute("desc");
			_bk.m_electrified = (bool?)xml.Attribute("electrified");
			_bk.m_entering = (bool?)xml.Attribute("entering");
			_bk.m_evttimer = (int?)xml.Attribute("evttimer");
			_bk.m_evttimer2 = (int?)xml.Attribute("evttimer2");
			_bk.m_exitspeed = (string)xml.Attribute("exitspeed");
			_bk.m_exitspeedpercent = (int?)xml.Attribute("exitspeedpercent");
			_bk.m_extstop = (bool?)xml.Attribute("extstop");
			_bk.m_fifoids = (string)xml.Attribute("fifoids");
			_bk.m_fifosize = (int?)xml.Attribute("fifosize");
			_bk.m_forceblocktimer = (bool?)xml.Attribute("forceblocktimer");
			_bk.m_gomanual = (bool?)xml.Attribute("gomanual");
			_bk.m_id = (string)xml.Attribute("id");
			_bk.m_iid = (string)xml.Attribute("iid");
			_bk.m_incline = (int?)xml.Attribute("incline");
			_bk.m_len = (int?)xml.Attribute("len");
			_bk.m_locid = (string)xml.Attribute("locid");
			_bk.m_managerid = (string)xml.Attribute("managerid");
			_bk.m_manual = (bool?)xml.Attribute("manual");
			_bk.m_maxkmh = (int?)xml.Attribute("maxkmh");
			_bk.m_maxwaittime = (int?)xml.Attribute("maxwaittime");
			_bk.m_minwaittime = (int?)xml.Attribute("minwaittime");
			_bk.m_mvdistance = (int?)xml.Attribute("mvdistance");
			_bk.m_mvmph = (bool?)xml.Attribute("mvmph");
			_bk.m_mvscale = (int?)xml.Attribute("mvscale");
			_bk.m_port = (int?)xml.Attribute("port");
			_bk.m_power = (bool?)xml.Attribute("power");
			_bk.m_prevstate = (string)xml.Attribute("prevstate");
			_bk.m_remote = (bool?)xml.Attribute("remote");
			_bk.m_reserved = (bool?)xml.Attribute("reserved");
			_bk.m_show = (bool?)xml.Attribute("show");
			_bk.m_signal = (string)xml.Attribute("signal");
			_bk.m_signalR = (string)xml.Attribute("signalR");
			_bk.m_smallsymbol = (bool?)xml.Attribute("smallsymbol");
			_bk.m_speed = (string)xml.Attribute("speed");
			_bk.m_speedpercent = (int?)xml.Attribute("speedpercent");
			_bk.m_state = (string)xml.Attribute("state");
			_bk.m_stopspeed = (string)xml.Attribute("stopspeed");
			_bk.m_td = (bool?)xml.Attribute("td");
			_bk.m_terminalstation = (bool?)xml.Attribute("terminalstation");
			_bk.m_ttid = (string)xml.Attribute("ttid");
			_bk.m_turnoutstolock = (string)xml.Attribute("turnoutstolock");
			_bk.m_type = (string)xml.Attribute("type");
			_bk.m_typeperm = (string)xml.Attribute("typeperm");
			_bk.m_updateenterside = (bool?)xml.Attribute("updateenterside");
			_bk.m_wait = (bool?)xml.Attribute("wait");
			_bk.m_waitmode = (string)xml.Attribute("waitmode");
			_bk.m_waittime = (int?)xml.Attribute("waittime");
			_bk.m_wsignal = (string)xml.Attribute("wsignal");
			_bk.m_wsignalR = (string)xml.Attribute("wsignalR");
			_bk.m_x = (int?)xml.Attribute("x");
			_bk.m_y = (int?)xml.Attribute("y");
			_bk.m_z = (int?)xml.Attribute("z");
            _bk.m_ori = (string)xml.Attribute("ori");
			Definitions.Tools.ParseList<actionctrl>(_bk.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<excl>(_bk.m_excllist, xml, "excl", excl.Parse, rocrailClient);
			Definitions.Tools.ParseList<fbevent>(_bk.m_fbeventlist, xml, "fbevent", fbevent.Parse, rocrailClient);
			Definitions.Tools.ParseList<incl>(_bk.m_incllist, xml, "incl", incl.Parse, rocrailClient);
			return _bk;
		}
		public void Update(bk element)
		{
			if(element.m_acceptghost.HasValue == true) this.acceptghost = element.acceptghost;
			if(element.m_acceptident.HasValue == true) this.acceptident = element.acceptident;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_allowbbt.HasValue == true) this.allowbbt = element.allowbbt;
			if(element.m_allowchgdir.HasValue == true) this.allowchgdir = element.allowchgdir;
			if(element.m_blankatredsignal.HasValue == true) this.blankatredsignal = element.blankatredsignal;
			if(element.m_blankatredsignalR.HasValue == true) this.blankatredsignalR = element.blankatredsignalR;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_commuter != null) this.commuter = element.commuter;
			if(element.m_departdelay.HasValue == true) this.departdelay = element.departdelay;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_electrified.HasValue == true) this.electrified = element.electrified;
			if(element.m_entering.HasValue == true) this.entering = element.entering;
			if(element.m_evttimer.HasValue == true) this.evttimer = element.evttimer;
			if(element.m_evttimer2.HasValue == true) this.evttimer2 = element.evttimer2;
			if(element.m_exitspeed != null) this.exitspeed = element.exitspeed;
			if(element.m_exitspeedpercent.HasValue == true) this.exitspeedpercent = element.exitspeedpercent;
			if(element.m_extstop.HasValue == true) this.extstop = element.extstop;
			if(element.m_fifoids != null) this.fifoids = element.fifoids;
			if(element.m_fifosize.HasValue == true) this.fifosize = element.fifosize;
			if(element.m_forceblocktimer.HasValue == true) this.forceblocktimer = element.forceblocktimer;
			if(element.m_gomanual.HasValue == true) this.gomanual = element.gomanual;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_incline.HasValue == true) this.incline = element.incline;
			if(element.m_len.HasValue == true) this.len = element.len;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_managerid != null) this.managerid = element.managerid;
			if(element.m_manual.HasValue == true) this.manual = element.manual;
			if(element.m_maxkmh.HasValue == true) this.maxkmh = element.maxkmh;
			if(element.m_maxwaittime.HasValue == true) this.maxwaittime = element.maxwaittime;
			if(element.m_minwaittime.HasValue == true) this.minwaittime = element.minwaittime;
			if(element.m_mvdistance.HasValue == true) this.mvdistance = element.mvdistance;
			if(element.m_mvmph.HasValue == true) this.mvmph = element.mvmph;
			if(element.m_mvscale.HasValue == true) this.mvscale = element.mvscale;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_power.HasValue == true) this.power = element.power;
			if(element.m_prevstate != null) this.prevstate = element.prevstate;
			if(element.m_remote.HasValue == true) this.remote = element.remote;
			if(element.m_reserved.HasValue == true) this.reserved = element.reserved;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_signal != null) this.signal = element.signal;
			if(element.m_signalR != null) this.signalR = element.signalR;
			if(element.m_smallsymbol.HasValue == true) this.smallsymbol = element.smallsymbol;
			if(element.m_speed != null) this.speed = element.speed;
			if(element.m_speedpercent.HasValue == true) this.speedpercent = element.speedpercent;
			if(element.m_state != null) this.state = element.state;
			if(element.m_stopspeed != null) this.stopspeed = element.stopspeed;
			if(element.m_td.HasValue == true) this.td = element.td;
			if(element.m_terminalstation.HasValue == true) this.terminalstation = element.terminalstation;
			if(element.m_ttid != null) this.ttid = element.ttid;
			if(element.m_turnoutstolock != null) this.turnoutstolock = element.turnoutstolock;
			if(element.m_type != null) this.type = element.type;
			if(element.m_typeperm != null) this.typeperm = element.typeperm;
			if(element.m_updateenterside.HasValue == true) this.updateenterside = element.updateenterside;
			if(element.m_wait.HasValue == true) this.wait = element.wait;
			if(element.m_waitmode != null) this.waitmode = element.waitmode;
			if(element.m_waittime.HasValue == true) this.waittime = element.waittime;
			if(element.m_wsignal != null) this.wsignal = element.wsignal;
			if(element.m_wsignalR != null) this.wsignalR = element.wsignalR;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
            if (element.m_ori != null) this.ori = element.ori;
			this.actionctrllist = element.actionctrllist;
			this.excllist = element.excllist;
			this.fbeventlist = element.fbeventlist;
			this.incllist = element.incllist;
		}
	}
}
