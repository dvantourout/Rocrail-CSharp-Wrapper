using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class lc : CRocrailElements
	{
		public const string V_MODE_KMH = "kmh";
		public const string V_MODE_PERCENT = "percent";
		public const string ACTIVATE = "activate";
		public const string ADDBLOCK2TRIP = "addblock2trip";
		public const string ASSIGNTRAIN = "assigntrain";
		public const string BIDIKMH = "bidikmh";
		public const string BLOCK = "block";
		public const string BLOCKSIDE = "blockside";
		public const string BRAKE = "brake";
		public const string CARGO_ALL = "all";
		public const string CARGO_CLEANING = "cleaning";
		public const string CARGO_GOODS = "goods";
		public const string CARGO_ICE = "ice";
		public const string CARGO_LIGHT = "light";
		public const string CARGO_LIGHTGOODS = "lightgoods";
		public const string CARGO_MIXED = "mixed";
		public const string CARGO_NONE = "none";
		public const string CARGO_PERSON = "person";
		public const string CARGO_POST = "post";
		public const string CARGO_REGIONAL = "regional";
		public const string CLIMB = "climb";
		public const string CONSIST = "consist";
		public const string CRUISE = "cruise";
		public const string DEACTIVATE = "deactivate";
		public const string DIRECTION = "direction";
		public const string DIRFUN = "dirfun";
		public const string DISCOVER = "discover";
		public const string DISPATCH = "dispatch";
		public const string ENGINE_AUTOMOBILE = "automobile";
		public const string ENGINE_DIESEL = "diesel";
		public const string ENGINE_ELECTRIC = "electric";
		public const string ENGINE_STEAM = "steam";
		public const string FIELDCMD = "fieldcmd";
		public const string FUNCTION = "function";
		public const string GO = "go";
		public const string GOMANUAL = "gomanual";
		public const string GOTOBLOCK = "gotoblock";
		public const string GOVIRTUAL = "govirtual";
		public const string INFO = "info";
		public const string MAX = "max";
		public const string MID = "mid";
		public const string MIN = "min";
		public const string MODE_AUTO = "auto";
		public const string MODE_HALFAUTO = "halfauto";
		public const string MODE_IDLE = "idle";
		public const string MODE_WAIT = "wait";
		public const string PROT_A = "A";
		public const string PROT_C = "C";
		public const string PROT_L = "L";
		public const string PROT_M = "M";
		public const string PROT_N = "N";
		public const string PROT_P = "P";
		public const string PROT_S = "S";
		public const string PROT_X = "X";
		public const string RELEASE = "release";
		public const string RELEASETRAIN = "releasetrain";
		public const string RESET = "reset";
		public const string SHORTID = "shortid";
		public const string SOFTRESET = "softreset";
		public const string STOP = "stop";
		public const string STOPGO = "stopgo";
		public const string SWAP = "swap";
		public const string USESCHEDULE = "useschedule";
		public const string USETOUR = "usetour";
		public const string VELOCITY = "velocity";
		private int? m_V;
		private int? m_V_Rcru;
		private int? m_V_Rmax;
		private int? m_V_Rmid;
		private int? m_V_Rmin;
		private int? m_V_cru;
		private string m_V_hint;
		private int? m_V_max;
		private int? m_V_maxkmh;
		private int? m_V_mid;
		private int? m_V_min;
		private string m_V_mode;
		private int? m_V_raw;
		private int? m_V_rawMax;
		private int? m_V_realkmh;
		private int? m_V_step;
		private int? m_accelmax;
		private int? m_accelmin;
		private bool? m_active;
		private int? m_addr;
		private bool? m_adjustaccel;
		private int? m_bbtcorrection;
		private bool? m_bbtevent;
		private int? m_bbtmaxdiff;
		private int? m_bbtstartinterval;
		private int? m_bbtsteps;
		private bool? m_bbtusefromblock;
		private bool? m_blockenterside;
		private string m_blockid;
		private int? m_blockwaittime;
		private int? m_bus;
		private string m_cargo;
		private string m_catnr;
		private bool? m_check2in;
		private string m_cmd;
		private bool? m_commuter;
		private string m_consist;
		private bool? m_consist_lightsoff;
		private bool? m_consist_syncfun;
		private int? m_consist_syncfunmap;
		private bool? m_consistcmd;
		private string m_decfile;
		private string m_decimage;
		private string m_dectype;
		private string m_desc;
		private string m_destblockid;
		private bool? m_dir;
		private int? m_dirpause;
		private string m_docu;
		private string m_engine;
		private int? m_ent2incorr;
		private int? m_era;
		private int? m_evttimer;
		private bool? m_fn;
		private int? m_fncnt;
		private int? m_fx;
		
		private string m_identifier;
		private bool? m_ignorefn;
		private string m_iid;
		private string m_image;
		private int? m_imagenr;
		private bool? m_inatpre2in;
		private bool? m_info4throttle;
		private string m_lclib;
		private int? m_len;
		private bool? m_manual;
		private int? m_mass;
		private int? m_maxload;
		private int? m_mint;
		private string m_mode;
		private long? m_mtime;
		private int? m_nrcars;
		private string m_number;
		private string m_oid;
		private bool? m_placing;
		private int? m_port;
		private string m_prev_id;
		private int? m_priority;
		private string m_prot;
		private int? m_protver;
		private string m_purchased;
		private bool? m_regulated;
		private string m_remark;
		private bool? m_restorefx;
		private bool? m_restorespeed;
		private bool? m_resumeauto;
		private string m_roadname;
		private bool? m_roaming;
		private long? m_runtime;
		private string m_scheduleid;
		private int? m_scidx;
		private bool? m_secondnextblock;
		private string m_shortid;
		private bool? m_shortin;
		private bool? m_show;
		private int? m_spcnt;
		private string m_startupscid;
		private string m_startuptourid;
		private bool? m_sw;
		private int? m_swaptimer;
		private string m_throttleid;
		private int? m_throttlenr;
		private string m_tourid;
		private string m_train;
		private int? m_trainlen;
		private int? m_trainweight;
		private string m_ttlib;
		private bool? m_usebbt;
		private bool? m_usedepartdelay;
		private bool? m_usemanualroutes;
		private bool? m_useownwaittime;
		private bool? m_usescheduletime;
		private bool? m_useshortid;
		private List<actionctrl> m_actionctrllist;
		private List<bbt> m_bbtlist;
		private List<cvbyte> m_cvbytelist;
		private List<fundef> m_fundeflist;
		/// <summary>
		/// Loc speed in kmh.
		/// </summary>
		public int V 
		{
			get { return this.m_V.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V, value, "V"); }
		}
		/// <summary>
		/// Cruise reverse speed.(not used when 0)
		/// </summary>
		public int V_Rcru 
		{
			get { return this.m_V_Rcru.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_Rcru, value, "V_Rcru"); }
		}
		/// <summary>
		/// Maximal reverse speed.(not used when 0)
		/// </summary>
		public int V_Rmax 
		{
			get { return this.m_V_Rmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_Rmax, value, "V_Rmax"); }
		}
		/// <summary>
		/// Middle reverse speed.(not used when 0)
		/// </summary>
		public int V_Rmid 
		{
			get { return this.m_V_Rmid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_Rmid, value, "V_Rmid"); }
		}
		/// <summary>
		/// Minimal reverse speed.(not used when 0)
		/// </summary>
		public int V_Rmin 
		{
			get { return this.m_V_Rmin.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_Rmin, value, "V_Rmin"); }
		}
		/// <summary>
		/// Cruise speed.(not used when 0)
		/// </summary>
		public int V_cru 
		{
			get { return this.m_V_cru.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_cru, value, "V_cru"); }
		}
		/// <summary>
		/// Loc speed in word hints.
		/// </summary>
		public string V_hint 
		{
			get { return this.m_V_hint; }
			private set { this.SetField(ref this.m_V_hint, value, "V_hint"); }
		}
		/// <summary>
		/// Maximal speed.
		/// </summary>
		public int V_max 
		{
			get { return this.m_V_max.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_max, value, "V_max"); }
		}
		/// <summary>
		/// Maximal block speed in kmh
		/// </summary>
		public int V_maxkmh 
		{
			get { return this.m_V_maxkmh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_maxkmh, value, "V_maxkmh"); }
		}
		/// <summary>
		/// Middle speed.
		/// </summary>
		public int V_mid 
		{
			get { return this.m_V_mid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_mid, value, "V_mid"); }
		}
		/// <summary>
		/// Minimal speed.
		/// </summary>
		public int V_min 
		{
			get { return this.m_V_min.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_min, value, "V_min"); }
		}
		/// <summary>
		/// How the V values should be interpreted by the digint: percent is used for decoders without max speed tuning.(Delta...)
		/// </summary>
		public string V_mode 
		{
			get { return this.m_V_mode; }
			private set { this.SetField(ref this.m_V_mode, value, "V_mode"); }
		}
		/// <summary>
		/// Loc speed in CS speed steps.
		/// </summary>
		public int V_raw 
		{
			get { return this.m_V_raw.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_raw, value, "V_raw"); }
		}
		/// <summary>
		/// Max loc speed in CS speed steps.
		/// </summary>
		public int V_rawMax 
		{
			get { return this.m_V_rawMax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_rawMax, value, "V_rawMax"); }
		}
		/// <summary>
		/// Reported speed in kmh.
		/// </summary>
		public int V_realkmh 
		{
			get { return this.m_V_realkmh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_realkmh, value, "V_realkmh"); }
		}
		/// <summary>
		/// Time between next decoder speed.(used only incase of V_mode_percent)
		/// </summary>
		public int V_step 
		{
			get { return this.m_V_step.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V_step, value, "V_step"); }
		}
		/// <summary>
		/// Maximal acceleration CV3 value.
		/// </summary>
		public int accelmax 
		{
			get { return this.m_accelmax.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accelmax, value, "accelmax"); }
		}
		/// <summary>
		/// Minimal acceleration CV3 value.
		/// </summary>
		public int accelmin 
		{
			get { return this.m_accelmin.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accelmin, value, "accelmin"); }
		}
		/// <summary>
		/// Active for running in auto mode.
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// Digital address. (0 == analog)
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// Adjust CV3 acceleration.
		/// </summary>
		public bool adjustaccel 
		{
			get { return this.m_adjustaccel.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_adjustaccel, value, "adjustaccel"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bbtcorrection 
		{
			get { return this.m_bbtcorrection.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtcorrection, value, "bbtcorrection"); }
		}
		/// <summary>
		/// Flag for filter out at broadcast.
		/// </summary>
		public bool bbtevent 
		{
			get { return this.m_bbtevent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtevent, value, "bbtevent"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bbtmaxdiff 
		{
			get { return this.m_bbtmaxdiff.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtmaxdiff, value, "bbtmaxdiff"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bbtstartinterval 
		{
			get { return this.m_bbtstartinterval.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtstartinterval, value, "bbtstartinterval"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bbtsteps 
		{
			get { return this.m_bbtsteps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtsteps, value, "bbtsteps"); }
		}
		/// <summary>
		/// Use the from blockID also as key.
		/// </summary>
		public bool bbtusefromblock 
		{
			get { return this.m_bbtusefromblock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bbtusefromblock, value, "bbtusefromblock"); }
		}
		/// <summary>
		/// Block enter side.
		/// </summary>
		public bool blockenterside 
		{
			get { return this.m_blockenterside.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockenterside, value, "blockenterside"); }
		}
		/// <summary>
		/// Current block ID.
		/// </summary>
		public string blockid 
		{
			get { return this.m_blockid; }
			private set { this.SetField(ref this.m_blockid, value, "blockid"); }
		}
		/// <summary>
		/// Own wait time.
		/// </summary>
		public int blockwaittime 
		{
			get { return this.m_blockwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockwaittime, value, "blockwaittime"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string cargo 
		{
			get { return this.m_cargo; }
			private set { this.SetField(ref this.m_cargo, value, "cargo"); }
		}
		/// <summary>
		/// Catalog number.
		/// </summary>
		public string catnr 
		{
			get { return this.m_catnr; }
			private set { this.SetField(ref this.m_catnr, value, "catnr"); }
		}
		/// <summary>
		/// Check for a free new destination between the enter and in event.
		/// </summary>
		public bool check2in 
		{
			get { return this.m_check2in.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_check2in, value, "check2in"); }
		}
		/// <summary>
		/// Loc command.
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// Commuter train?
		/// </summary>
		public bool commuter 
		{
			get { return this.m_commuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_commuter, value, "commuter"); }
		}
		/// <summary>
		/// Slave locomotives
		/// </summary>
		public string consist 
		{
			get { return this.m_consist; }
			private set { this.SetField(ref this.m_consist, value, "consist"); }
		}
		/// <summary>
		/// Keep lights turned off for all slave locos.
		/// </summary>
		public bool consist_lightsoff 
		{
			get { return this.m_consist_lightsoff.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_consist_lightsoff, value, "consist_lightsoff"); }
		}
		/// <summary>
		/// Synchronise functions for all slave locos.
		/// </summary>
		public bool consist_syncfun 
		{
			get { return this.m_consist_syncfun.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_consist_syncfun, value, "consist_syncfun"); }
		}
		/// <summary>
		/// Function map.
		/// </summary>
		public int consist_syncfunmap 
		{
			get { return this.m_consist_syncfunmap.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_consist_syncfunmap, value, "consist_syncfunmap"); }
		}
		/// <summary>
		/// Consist context command; Flag for preventing loops.
		/// </summary>
		public bool consistcmd 
		{
			get { return this.m_consistcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_consistcmd, value, "consistcmd"); }
		}
		/// <summary>
		/// Decoder definition file.
		/// </summary>
		public string decfile 
		{
			get { return this.m_decfile; }
			private set { this.SetField(ref this.m_decfile, value, "decfile"); }
		}
		/// <summary>
		/// decoder image file
		/// </summary>
		public string decimage 
		{
			get { return this.m_decimage; }
			private set { this.SetField(ref this.m_decimage, value, "decimage"); }
		}
		/// <summary>
		/// Decoder type. (CV8)
		/// </summary>
		public string dectype 
		{
			get { return this.m_dectype; }
			private set { this.SetField(ref this.m_dectype, value, "dectype"); }
		}
		/// <summary>
		/// Description of loc.
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Destination block ID. (info only)
		/// </summary>
		public string destblockid 
		{
			get { return this.m_destblockid; }
			private set { this.SetField(ref this.m_destblockid, value, "destblockid"); }
		}
		/// <summary>
		/// Direction; true is forwards.
		/// </summary>
		public bool dir 
		{
			get { return this.m_dir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dir, value, "dir"); }
		}
		/// <summary>
		/// pause after sending last turnout command and before sending the direction to the loc decoder
		/// </summary>
		public int dirpause 
		{
			get { return this.m_dirpause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dirpause, value, "dirpause"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string docu 
		{
			get { return this.m_docu; }
			private set { this.SetField(ref this.m_docu, value, "docu"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string engine 
		{
			get { return this.m_engine; }
			private set { this.SetField(ref this.m_engine, value, "engine"); }
		}
		/// <summary>
		/// Correction percentage for enter2in block timer
		/// </summary>
		public int ent2incorr 
		{
			get { return this.m_ent2incorr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ent2incorr, value, "ent2incorr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int era 
		{
			get { return this.m_era.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_era, value, "era"); }
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
		/// Function switch. (Lights)
		/// </summary>
		public bool fn 
		{
			get { return this.m_fn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fn, value, "fn"); }
		}
		/// <summary>
		/// number of decoder funktions
		/// </summary>
		public int fncnt 
		{
			get { return this.m_fncnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fncnt, value, "fncnt"); }
		}
		/// <summary>
		/// Function status bits for display only.
		/// </summary>
		public int fx 
		{
			get { return this.m_fx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fx, value, "fx"); }
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
		/// Loc identifier incase of RFID, Lissy, Barcode...
		/// </summary>
		public string identifier 
		{
			get { return this.m_identifier; }
			private set { this.SetField(ref this.m_identifier, value, "identifier"); }
		}
		/// <summary>
		/// Ignore lights.
		/// </summary>
		public bool ignorefn 
		{
			get { return this.m_ignorefn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ignorefn, value, "ignorefn"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// local image file to show in dialogs
		/// </summary>
		public string image 
		{
			get { return this.m_image; }
			private set { this.SetField(ref this.m_image, value, "image"); }
		}
		/// <summary>
		/// throttle image number
		/// </summary>
		public int imagenr 
		{
			get { return this.m_imagenr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_imagenr, value, "imagenr"); }
		}
		/// <summary>
		/// Use pre2in event to stop in blocks.
		/// </summary>
		public bool inatpre2in 
		{
			get { return this.m_inatpre2in.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inatpre2in, value, "inatpre2in"); }
		}
		/// <summary>
		/// Get loco info if it is stalled and not in automode.
		/// </summary>
		public bool info4throttle 
		{
			get { return this.m_info4throttle.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_info4throttle, value, "info4throttle"); }
		}
		/// <summary>
		/// LocDriver library
		/// </summary>
		public string lclib 
		{
			get { return this.m_lclib; }
			private set { this.SetField(ref this.m_lclib, value, "lclib"); }
		}
		/// <summary>
		/// Total length of loc with wagons to check with block length..
		/// </summary>
		public int len 
		{
			get { return this.m_len.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_len, value, "len"); }
		}
		/// <summary>
		/// Half auto mode flag.
		/// </summary>
		public bool manual 
		{
			get { return this.m_manual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manual, value, "manual"); }
		}
		/// <summary>
		/// Mass index for use with Dinamo.
		/// </summary>
		public int mass 
		{
			get { return this.m_mass.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mass, value, "mass"); }
		}
		/// <summary>
		/// Maximal loco load
		/// </summary>
		public int maxload 
		{
			get { return this.m_maxload.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxload, value, "maxload"); }
		}
		/// <summary>
		/// maintenance interval in hours
		/// </summary>
		public int mint 
		{
			get { return this.m_mint.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mint, value, "mint"); }
		}
		/// <summary>
		/// Loc mode.
		/// </summary>
		public string mode 
		{
			get { return this.m_mode; }
			private set { this.SetField(ref this.m_mode, value, "mode"); }
		}
		/// <summary>
		/// last maintenance in seconds
		/// </summary>
		public long mtime 
		{
			get { return this.m_mtime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mtime, value, "mtime"); }
		}
		/// <summary>
		/// Number of cars. Needed for counting in sensors.
		/// </summary>
		public int nrcars 
		{
			get { return this.m_nrcars.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrcars, value, "nrcars"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string number 
		{
			get { return this.m_number; }
			private set { this.SetField(ref this.m_number, value, "number"); }
		}
		/// <summary>
		/// object ID
		/// </summary>
		public string oid 
		{
			get { return this.m_oid; }
			private set { this.SetField(ref this.m_oid, value, "oid"); }
		}
		/// <summary>
		/// If loc is placed back to front this should be set to false.
		/// </summary>
		public bool placing 
		{
			get { return this.m_placing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_placing, value, "placing"); }
		}
		/// <summary>
		/// Block number in the Dinamo system. (Block property)
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// in case of an id change this should help to find the original in the loc table
		/// </summary>
		public string prev_id 
		{
			get { return this.m_prev_id; }
			private set { this.SetField(ref this.m_prev_id, value, "prev_id"); }
		}
		/// <summary>
		/// train priority used for multiplying the wait time if no destination is found
		/// </summary>
		public int priority 
		{
			get { return this.m_priority.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_priority, value, "priority"); }
		}
		/// <summary>
		/// P = protocol by server, M = Marklin, N = NMRA-DCC, L = NMRA-DCC long addresses, A = Analog, C= Car Decoder
		/// </summary>
		public string prot 
		{
			get { return this.m_prot; }
			private set { this.SetField(ref this.m_prot, value, "prot"); }
		}
		/// <summary>
		/// Protocol version
		/// </summary>
		public int protver 
		{
			get { return this.m_protver.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_protver, value, "protver"); }
		}
		/// <summary>
		/// Date of purchase
		/// </summary>
		public string purchased 
		{
			get { return this.m_purchased; }
			private set { this.SetField(ref this.m_purchased, value, "purchased"); }
		}
		/// <summary>
		/// Decoder regulates the motor.
		/// </summary>
		public bool regulated 
		{
			get { return this.m_regulated.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_regulated, value, "regulated"); }
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
		/// Restore functions from previouse session.
		/// </summary>
		public bool restorefx 
		{
			get { return this.m_restorefx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_restorefx, value, "restorefx"); }
		}
		/// <summary>
		/// Restore speed from previouse session.
		/// </summary>
		public bool restorespeed 
		{
			get { return this.m_restorespeed.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_restorespeed, value, "restorespeed"); }
		}
		/// <summary>
		/// Resume auto mode from previous session.
		/// </summary>
		public bool resumeauto 
		{
			get { return this.m_resumeauto.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resumeauto, value, "resumeauto"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string roadname 
		{
			get { return this.m_roadname; }
			private set { this.SetField(ref this.m_roadname, value, "roadname"); }
		}
		/// <summary>
		/// The roaming flag allows a loc traveling to other systems.
		/// </summary>
		public bool roaming 
		{
			get { return this.m_roaming.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_roaming, value, "roaming"); }
		}
		/// <summary>
		/// Auto runtime in seconds
		/// </summary>
		public long runtime 
		{
			get { return this.m_runtime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_runtime, value, "runtime"); }
		}
		/// <summary>
		/// Current schedule ID.
		/// </summary>
		public string scheduleid 
		{
			get { return this.m_scheduleid; }
			private set { this.SetField(ref this.m_scheduleid, value, "scheduleid"); }
		}
		/// <summary>
		/// Schedule index
		/// </summary>
		public int scidx 
		{
			get { return this.m_scidx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_scidx, value, "scidx"); }
		}
		/// <summary>
		/// Try to reserve a second next block.
		/// </summary>
		public bool secondnextblock 
		{
			get { return this.m_secondnextblock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_secondnextblock, value, "secondnextblock"); }
		}
		/// <summary>
		/// Short IDs are used for throttle displays.
		/// </summary>
		public string shortid 
		{
			get { return this.m_shortid; }
			private set { this.SetField(ref this.m_shortid, value, "shortid"); }
		}
		/// <summary>
		/// Use shortin event to stop in blocks.
		/// </summary>
		public bool shortin 
		{
			get { return this.m_shortin.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortin, value, "shortin"); }
		}
		/// <summary>
		/// Show in loco table.
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
		}
		/// <summary>
		/// Speed steps count
		/// </summary>
		public int spcnt 
		{
			get { return this.m_spcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_spcnt, value, "spcnt"); }
		}
		/// <summary>
		/// Startup schedule ID.
		/// </summary>
		public string startupscid 
		{
			get { return this.m_startupscid; }
			private set { this.SetField(ref this.m_startupscid, value, "startupscid"); }
		}
		/// <summary>
		/// Startup tour ID.
		/// </summary>
		public string startuptourid 
		{
			get { return this.m_startuptourid; }
			private set { this.SetField(ref this.m_startuptourid, value, "startuptourid"); }
		}
		/// <summary>
		/// Change direction in P50 protocol.(Use dir=true/false)
		/// </summary>
		public bool sw 
		{
			get { return this.m_sw.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sw, value, "sw"); }
		}
		/// <summary>
		/// Swap placing timer; Loco should wait this time before processing the swap.
		/// </summary>
		public int swaptimer 
		{
			get { return this.m_swaptimer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swaptimer, value, "swaptimer"); }
		}
		/// <summary>
		/// Throttle ID to which this loco is dispatched.
		/// </summary>
		public string throttleid 
		{
			get { return this.m_throttleid; }
			private set { this.SetField(ref this.m_throttleid, value, "throttleid"); }
		}
		/// <summary>
		/// Throttle number for receiving the short id.
		/// </summary>
		public int throttlenr 
		{
			get { return this.m_throttlenr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_throttlenr, value, "throttlenr"); }
		}
		/// <summary>
		/// Current tour ID.
		/// </summary>
		public string tourid 
		{
			get { return this.m_tourid; }
			private set { this.SetField(ref this.m_tourid, value, "tourid"); }
		}
		/// <summary>
		/// Operator consist ID
		/// </summary>
		public string train 
		{
			get { return this.m_train; }
			private set { this.SetField(ref this.m_train, value, "train"); }
		}
		/// <summary>
		/// Total train length
		/// </summary>
		public int trainlen 
		{
			get { return this.m_trainlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_trainlen, value, "trainlen"); }
		}
		/// <summary>
		/// Total train weight
		/// </summary>
		public int trainweight 
		{
			get { return this.m_trainweight.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_trainweight, value, "trainweight"); }
		}
		/// <summary>
		/// TurntableDriver library
		/// </summary>
		public string ttlib 
		{
			get { return this.m_ttlib; }
			private set { this.SetField(ref this.m_ttlib, value, "ttlib"); }
		}
		/// <summary>
		/// Use block brake time.
		/// </summary>
		public bool usebbt 
		{
			get { return this.m_usebbt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usebbt, value, "usebbt"); }
		}
		/// <summary>
		/// Use the depart delay defined in the current block.
		/// </summary>
		public bool usedepartdelay 
		{
			get { return this.m_usedepartdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usedepartdelay, value, "usedepartdelay"); }
		}
		/// <summary>
		/// Use manual set routes only.
		/// </summary>
		public bool usemanualroutes 
		{
			get { return this.m_usemanualroutes.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usemanualroutes, value, "usemanualroutes"); }
		}
		/// <summary>
		/// Overwrites block wait settings.
		/// </summary>
		public bool useownwaittime 
		{
			get { return this.m_useownwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_useownwaittime, value, "useownwaittime"); }
		}
		/// <summary>
		/// Use departure time in schedules.
		/// </summary>
		public bool usescheduletime 
		{
			get { return this.m_usescheduletime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usescheduletime, value, "usescheduletime"); }
		}
		/// <summary>
		/// Use short ID to send to throttle.
		/// </summary>
		public bool useshortid 
		{
			get { return this.m_useshortid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_useshortid, value, "useshortid"); }
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
		public List<bbt> bbtlist 
		{
			get { return this.m_bbtlist; }
			private set { this.SetField(ref this.m_bbtlist, value, "bbtlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cvbyte> cvbytelist 
		{
			get { return this.m_cvbytelist; }
			private set { this.SetField(ref this.m_cvbytelist, value, "cvbytelist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<fundef> fundeflist 
		{
			get { return this.m_fundeflist; }
			private set { this.SetField(ref this.m_fundeflist, value, "fundeflist"); }
		}
		public lc()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_bbtlist = new List<bbt>();
			this.m_cvbytelist = new List<cvbyte>();
			this.m_fundeflist = new List<fundef>();
		}
		public static lc Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			lc _lc = new lc();
			_lc.m_rocrailClient = rocrailClient;
			_lc.m_V = (int?)xml.Attribute("V");
			_lc.m_V_Rcru = (int?)xml.Attribute("V_Rcru");
			_lc.m_V_Rmax = (int?)xml.Attribute("V_Rmax");
			_lc.m_V_Rmid = (int?)xml.Attribute("V_Rmid");
			_lc.m_V_Rmin = (int?)xml.Attribute("V_Rmin");
			_lc.m_V_cru = (int?)xml.Attribute("V_cru");
			_lc.m_V_hint = (string)xml.Attribute("V_hint");
			_lc.m_V_max = (int?)xml.Attribute("V_max");
			_lc.m_V_maxkmh = (int?)xml.Attribute("V_maxkmh");
			_lc.m_V_mid = (int?)xml.Attribute("V_mid");
			_lc.m_V_min = (int?)xml.Attribute("V_min");
			_lc.m_V_mode = (string)xml.Attribute("V_mode");
			_lc.m_V_raw = (int?)xml.Attribute("V_raw");
			_lc.m_V_rawMax = (int?)xml.Attribute("V_rawMax");
			_lc.m_V_realkmh = (int?)xml.Attribute("V_realkmh");
			_lc.m_V_step = (int?)xml.Attribute("V_step");
			_lc.m_accelmax = (int?)xml.Attribute("accelmax");
			_lc.m_accelmin = (int?)xml.Attribute("accelmin");
			_lc.m_active = (bool?)xml.Attribute("active");
			_lc.m_addr = (int?)xml.Attribute("addr");
			_lc.m_adjustaccel = (bool?)xml.Attribute("adjustaccel");
			_lc.m_bbtcorrection = (int?)xml.Attribute("bbtcorrection");
			_lc.m_bbtevent = (bool?)xml.Attribute("bbtevent");
			_lc.m_bbtmaxdiff = (int?)xml.Attribute("bbtmaxdiff");
			_lc.m_bbtstartinterval = (int?)xml.Attribute("bbtstartinterval");
			_lc.m_bbtsteps = (int?)xml.Attribute("bbtsteps");
			_lc.m_bbtusefromblock = (bool?)xml.Attribute("bbtusefromblock");
			_lc.m_blockenterside = (bool?)xml.Attribute("blockenterside");
			_lc.m_blockid = (string)xml.Attribute("blockid");
			_lc.m_blockwaittime = (int?)xml.Attribute("blockwaittime");
			_lc.m_bus = (int?)xml.Attribute("bus");
			_lc.m_cargo = (string)xml.Attribute("cargo");
			_lc.m_catnr = (string)xml.Attribute("catnr");
			_lc.m_check2in = (bool?)xml.Attribute("check2in");
			_lc.m_cmd = (string)xml.Attribute("cmd");
			_lc.m_commuter = (bool?)xml.Attribute("commuter");
			_lc.m_consist = (string)xml.Attribute("consist");
			_lc.m_consist_lightsoff = (bool?)xml.Attribute("consist_lightsoff");
			_lc.m_consist_syncfun = (bool?)xml.Attribute("consist_syncfun");
			_lc.m_consist_syncfunmap = (int?)xml.Attribute("consist_syncfunmap");
			_lc.m_consistcmd = (bool?)xml.Attribute("consistcmd");
			_lc.m_decfile = (string)xml.Attribute("decfile");
			_lc.m_decimage = (string)xml.Attribute("decimage");
			_lc.m_dectype = (string)xml.Attribute("dectype");
			_lc.m_desc = (string)xml.Attribute("desc");
			_lc.m_destblockid = (string)xml.Attribute("destblockid");
			_lc.m_dir = (bool?)xml.Attribute("dir");
			_lc.m_dirpause = (int?)xml.Attribute("dirpause");
			_lc.m_docu = (string)xml.Attribute("docu");
			_lc.m_engine = (string)xml.Attribute("engine");
			_lc.m_ent2incorr = (int?)xml.Attribute("ent2incorr");
			_lc.m_era = (int?)xml.Attribute("era");
			_lc.m_evttimer = (int?)xml.Attribute("evttimer");
			_lc.m_fn = (bool?)xml.Attribute("fn");
			_lc.m_fncnt = (int?)xml.Attribute("fncnt");
			_lc.m_fx = (int?)xml.Attribute("fx");
			_lc.m_id = (string)xml.Attribute("id");
			_lc.m_identifier = (string)xml.Attribute("identifier");
			_lc.m_ignorefn = (bool?)xml.Attribute("ignorefn");
			_lc.m_iid = (string)xml.Attribute("iid");
			_lc.m_image = (string)xml.Attribute("image");
			_lc.m_imagenr = (int?)xml.Attribute("imagenr");
			_lc.m_inatpre2in = (bool?)xml.Attribute("inatpre2in");
			_lc.m_info4throttle = (bool?)xml.Attribute("info4throttle");
			_lc.m_lclib = (string)xml.Attribute("lclib");
			_lc.m_len = (int?)xml.Attribute("len");
			_lc.m_manual = (bool?)xml.Attribute("manual");
			_lc.m_mass = (int?)xml.Attribute("mass");
			_lc.m_maxload = (int?)xml.Attribute("maxload");
			_lc.m_mint = (int?)xml.Attribute("mint");
			_lc.m_mode = (string)xml.Attribute("mode");
			_lc.m_mtime = (long?)xml.Attribute("mtime");
			_lc.m_nrcars = (int?)xml.Attribute("nrcars");
			_lc.m_number = (string)xml.Attribute("number");
			_lc.m_oid = (string)xml.Attribute("oid");
			_lc.m_placing = (bool?)xml.Attribute("placing");
			_lc.m_port = (int?)xml.Attribute("port");
			_lc.m_prev_id = (string)xml.Attribute("prev_id");
			_lc.m_priority = (int?)xml.Attribute("priority");
			_lc.m_prot = (string)xml.Attribute("prot");
			_lc.m_protver = (int?)xml.Attribute("protver");
			_lc.m_purchased = (string)xml.Attribute("purchased");
			_lc.m_regulated = (bool?)xml.Attribute("regulated");
			_lc.m_remark = (string)xml.Attribute("remark");
			_lc.m_restorefx = (bool?)xml.Attribute("restorefx");
			_lc.m_restorespeed = (bool?)xml.Attribute("restorespeed");
			_lc.m_resumeauto = (bool?)xml.Attribute("resumeauto");
			_lc.m_roadname = (string)xml.Attribute("roadname");
			_lc.m_roaming = (bool?)xml.Attribute("roaming");
			_lc.m_runtime = (long?)xml.Attribute("runtime");
			_lc.m_scheduleid = (string)xml.Attribute("scheduleid");
			_lc.m_scidx = (int?)xml.Attribute("scidx");
			_lc.m_secondnextblock = (bool?)xml.Attribute("secondnextblock");
			_lc.m_shortid = (string)xml.Attribute("shortid");
			_lc.m_shortin = (bool?)xml.Attribute("shortin");
			_lc.m_show = (bool?)xml.Attribute("show");
			_lc.m_spcnt = (int?)xml.Attribute("spcnt");
			_lc.m_startupscid = (string)xml.Attribute("startupscid");
			_lc.m_startuptourid = (string)xml.Attribute("startuptourid");
			_lc.m_sw = (bool?)xml.Attribute("sw");
			_lc.m_swaptimer = (int?)xml.Attribute("swaptimer");
			_lc.m_throttleid = (string)xml.Attribute("throttleid");
			_lc.m_throttlenr = (int?)xml.Attribute("throttlenr");
			_lc.m_tourid = (string)xml.Attribute("tourid");
			_lc.m_train = (string)xml.Attribute("train");
			_lc.m_trainlen = (int?)xml.Attribute("trainlen");
			_lc.m_trainweight = (int?)xml.Attribute("trainweight");
			_lc.m_ttlib = (string)xml.Attribute("ttlib");
			_lc.m_usebbt = (bool?)xml.Attribute("usebbt");
			_lc.m_usedepartdelay = (bool?)xml.Attribute("usedepartdelay");
			_lc.m_usemanualroutes = (bool?)xml.Attribute("usemanualroutes");
			_lc.m_useownwaittime = (bool?)xml.Attribute("useownwaittime");
			_lc.m_usescheduletime = (bool?)xml.Attribute("usescheduletime");
			_lc.m_useshortid = (bool?)xml.Attribute("useshortid");
			Definitions.Tools.ParseList<actionctrl>(_lc.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<bbt>(_lc.m_bbtlist, xml, "bbt", bbt.Parse, rocrailClient);
			Definitions.Tools.ParseList<cvbyte>(_lc.m_cvbytelist, xml, "cvbyte", cvbyte.Parse, rocrailClient);
			Definitions.Tools.ParseList<fundef>(_lc.m_fundeflist, xml, "fundef", fundef.Parse, rocrailClient);
			return _lc;
		}
		public void Update(lc element)
		{
			if(element.m_V.HasValue == true) this.V = element.V;
			if(element.m_V_Rcru.HasValue == true) this.V_Rcru = element.V_Rcru;
			if(element.m_V_Rmax.HasValue == true) this.V_Rmax = element.V_Rmax;
			if(element.m_V_Rmid.HasValue == true) this.V_Rmid = element.V_Rmid;
			if(element.m_V_Rmin.HasValue == true) this.V_Rmin = element.V_Rmin;
			if(element.m_V_cru.HasValue == true) this.V_cru = element.V_cru;
			if(element.m_V_hint != null) this.V_hint = element.V_hint;
			if(element.m_V_max.HasValue == true) this.V_max = element.V_max;
			if(element.m_V_maxkmh.HasValue == true) this.V_maxkmh = element.V_maxkmh;
			if(element.m_V_mid.HasValue == true) this.V_mid = element.V_mid;
			if(element.m_V_min.HasValue == true) this.V_min = element.V_min;
			if(element.m_V_mode != null) this.V_mode = element.V_mode;
			if(element.m_V_raw.HasValue == true) this.V_raw = element.V_raw;
			if(element.m_V_rawMax.HasValue == true) this.V_rawMax = element.V_rawMax;
			if(element.m_V_realkmh.HasValue == true) this.V_realkmh = element.V_realkmh;
			if(element.m_V_step.HasValue == true) this.V_step = element.V_step;
			if(element.m_accelmax.HasValue == true) this.accelmax = element.accelmax;
			if(element.m_accelmin.HasValue == true) this.accelmin = element.accelmin;
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_adjustaccel.HasValue == true) this.adjustaccel = element.adjustaccel;
			if(element.m_bbtcorrection.HasValue == true) this.bbtcorrection = element.bbtcorrection;
			if(element.m_bbtevent.HasValue == true) this.bbtevent = element.bbtevent;
			if(element.m_bbtmaxdiff.HasValue == true) this.bbtmaxdiff = element.bbtmaxdiff;
			if(element.m_bbtstartinterval.HasValue == true) this.bbtstartinterval = element.bbtstartinterval;
			if(element.m_bbtsteps.HasValue == true) this.bbtsteps = element.bbtsteps;
			if(element.m_bbtusefromblock.HasValue == true) this.bbtusefromblock = element.bbtusefromblock;
			if(element.m_blockenterside.HasValue == true) this.blockenterside = element.blockenterside;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_blockwaittime.HasValue == true) this.blockwaittime = element.blockwaittime;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cargo != null) this.cargo = element.cargo;
			if(element.m_catnr != null) this.catnr = element.catnr;
			if(element.m_check2in.HasValue == true) this.check2in = element.check2in;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_commuter.HasValue == true) this.commuter = element.commuter;
			if(element.m_consist != null) this.consist = element.consist;
			if(element.m_consist_lightsoff.HasValue == true) this.consist_lightsoff = element.consist_lightsoff;
			if(element.m_consist_syncfun.HasValue == true) this.consist_syncfun = element.consist_syncfun;
			if(element.m_consist_syncfunmap.HasValue == true) this.consist_syncfunmap = element.consist_syncfunmap;
			if(element.m_consistcmd.HasValue == true) this.consistcmd = element.consistcmd;
			if(element.m_decfile != null) this.decfile = element.decfile;
			if(element.m_decimage != null) this.decimage = element.decimage;
			if(element.m_dectype != null) this.dectype = element.dectype;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_destblockid != null) this.destblockid = element.destblockid;
			if(element.m_dir.HasValue == true) this.dir = element.dir;
			if(element.m_dirpause.HasValue == true) this.dirpause = element.dirpause;
			if(element.m_docu != null) this.docu = element.docu;
			if(element.m_engine != null) this.engine = element.engine;
			if(element.m_ent2incorr.HasValue == true) this.ent2incorr = element.ent2incorr;
			if(element.m_era.HasValue == true) this.era = element.era;
			if(element.m_evttimer.HasValue == true) this.evttimer = element.evttimer;
			if(element.m_fn.HasValue == true) this.fn = element.fn;
			if(element.m_fncnt.HasValue == true) this.fncnt = element.fncnt;
			if(element.m_fx.HasValue == true) this.fx = element.fx;
			if(element.m_id != null) this.id = element.id;
			if(element.m_identifier != null) this.identifier = element.identifier;
			if(element.m_ignorefn.HasValue == true) this.ignorefn = element.ignorefn;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_image != null) this.image = element.image;
			if(element.m_imagenr.HasValue == true) this.imagenr = element.imagenr;
			if(element.m_inatpre2in.HasValue == true) this.inatpre2in = element.inatpre2in;
			if(element.m_info4throttle.HasValue == true) this.info4throttle = element.info4throttle;
			if(element.m_lclib != null) this.lclib = element.lclib;
			if(element.m_len.HasValue == true) this.len = element.len;
			if(element.m_manual.HasValue == true) this.manual = element.manual;
			if(element.m_mass.HasValue == true) this.mass = element.mass;
			if(element.m_maxload.HasValue == true) this.maxload = element.maxload;
			if(element.m_mint.HasValue == true) this.mint = element.mint;
			if(element.m_mode != null) this.mode = element.mode;
			if(element.m_mtime.HasValue == true) this.mtime = element.mtime;
			if(element.m_nrcars.HasValue == true) this.nrcars = element.nrcars;
			if(element.m_number != null) this.number = element.number;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_placing.HasValue == true) this.placing = element.placing;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_prev_id != null) this.prev_id = element.prev_id;
			if(element.m_priority.HasValue == true) this.priority = element.priority;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_protver.HasValue == true) this.protver = element.protver;
			if(element.m_purchased != null) this.purchased = element.purchased;
			if(element.m_regulated.HasValue == true) this.regulated = element.regulated;
			if(element.m_remark != null) this.remark = element.remark;
			if(element.m_restorefx.HasValue == true) this.restorefx = element.restorefx;
			if(element.m_restorespeed.HasValue == true) this.restorespeed = element.restorespeed;
			if(element.m_resumeauto.HasValue == true) this.resumeauto = element.resumeauto;
			if(element.m_roadname != null) this.roadname = element.roadname;
			if(element.m_roaming.HasValue == true) this.roaming = element.roaming;
			if(element.m_runtime.HasValue == true) this.runtime = element.runtime;
			if(element.m_scheduleid != null) this.scheduleid = element.scheduleid;
			if(element.m_scidx.HasValue == true) this.scidx = element.scidx;
			if(element.m_secondnextblock.HasValue == true) this.secondnextblock = element.secondnextblock;
			if(element.m_shortid != null) this.shortid = element.shortid;
			if(element.m_shortin.HasValue == true) this.shortin = element.shortin;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_spcnt.HasValue == true) this.spcnt = element.spcnt;
			if(element.m_startupscid != null) this.startupscid = element.startupscid;
			if(element.m_startuptourid != null) this.startuptourid = element.startuptourid;
			if(element.m_sw.HasValue == true) this.sw = element.sw;
			if(element.m_swaptimer.HasValue == true) this.swaptimer = element.swaptimer;
			if(element.m_throttleid != null) this.throttleid = element.throttleid;
			if(element.m_throttlenr.HasValue == true) this.throttlenr = element.throttlenr;
			if(element.m_tourid != null) this.tourid = element.tourid;
			if(element.m_train != null) this.train = element.train;
			if(element.m_trainlen.HasValue == true) this.trainlen = element.trainlen;
			if(element.m_trainweight.HasValue == true) this.trainweight = element.trainweight;
			if(element.m_ttlib != null) this.ttlib = element.ttlib;
			if(element.m_usebbt.HasValue == true) this.usebbt = element.usebbt;
			if(element.m_usedepartdelay.HasValue == true) this.usedepartdelay = element.usedepartdelay;
			if(element.m_usemanualroutes.HasValue == true) this.usemanualroutes = element.usemanualroutes;
			if(element.m_useownwaittime.HasValue == true) this.useownwaittime = element.useownwaittime;
			if(element.m_usescheduletime.HasValue == true) this.usescheduletime = element.usescheduletime;
			if(element.m_useshortid.HasValue == true) this.useshortid = element.useshortid;
			this.actionctrllist = element.actionctrllist;
			this.bbtlist = element.bbtlist;
			this.cvbytelist = element.cvbytelist;
			this.fundeflist = element.fundeflist;
		}

        public void ChangeSpeed(int speed)
        {
            string sTrameCmd = "<lc id=\"" + this.id + "\" V=\"" + speed + "\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void SetBlock(string blockID)
        {
            this.m_rocrailClient.Send("<lc id=\"" + this.id + "\" cmd=\"block\" blockid=\"" + blockID + "\"/>");
        }

        public void UnsetBlock()
        {
            this.SetBlock("");
            this.blockid = null;
        }
	}
}
