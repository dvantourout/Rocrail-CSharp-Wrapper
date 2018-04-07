using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class rocrail : CRocrailElements
	{
		private bool? m_backup;
		private string m_backuppath;
		private bool? m_createmodplan;
		private string m_doneml;
		private string m_donkey;
		private string m_dpiid;
		private string m_file;
		private bool? m_fsutf8;
		private string m_imgpath;
		private string m_issuepath;
		private string m_keypath;
		private string m_lciid;
		private string m_libpath;
		private string m_locs;
		private bool? m_nodevcheck;
		private string m_occupancy;
		private string m_planfile;
		private bool? m_poweroffonexit;
		private string m_ptiid;
		private bool? m_resetspfx;
		private bool? m_runasroot;
		private string m_sciid;
		private string m_scsensor;
		private string m_soundpath;
		private string m_soundplayer;
		private bool? m_soundplayerlocation;
		private string m_sviid;
		private List<SnmpService> m_SnmpServicelist;
		private List<anaopt> m_anaoptlist;
		private List<clock> m_clocklist;
		private List<ctrl> m_ctrllist;
		private List<devices> m_deviceslist;
		private List<digint> m_digintlist;
		private List<http> m_httplist;
		private List<jsmap> m_jsmaplist;
		private List<r2rnet> m_r2rnetlist;
		private List<service> m_servicelist;
		private List<srcpcon> m_srcpconlist;
		private List<tcp> m_tcplist;
		private List<trace> m_tracelist;
		/// <summary>
		/// Activate backup for plan files.
		/// </summary>
		public bool backup 
		{
			get { return this.m_backup.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_backup, value, "backup"); }
		}
		/// <summary>
		/// Location of the plan file backups.
		/// </summary>
		public string backuppath 
		{
			get { return this.m_backuppath; }
			private set { this.SetField(ref this.m_backuppath, value, "backuppath"); }
		}
		/// <summary>
		/// Create a modplan if the planfile does not jet exist.
		/// </summary>
		public bool createmodplan 
		{
			get { return this.m_createmodplan.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_createmodplan, value, "createmodplan"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string doneml 
		{
			get { return this.m_doneml; }
			private set { this.SetField(ref this.m_doneml, value, "doneml"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string donkey 
		{
			get { return this.m_donkey; }
			private set { this.SetField(ref this.m_donkey, value, "donkey"); }
		}
		/// <summary>
		/// IID to use for dispathing a loco; using default in case not set.
		/// </summary>
		public string dpiid 
		{
			get { return this.m_dpiid; }
			private set { this.SetField(ref this.m_dpiid, value, "dpiid"); }
		}
		/// <summary>
		/// RocRail ini-file.
		/// </summary>
		public string file 
		{
			get { return this.m_file; }
			private set { this.SetField(ref this.m_file, value, "file"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fsutf8 
		{
			get { return this.m_fsutf8.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fsutf8, value, "fsutf8"); }
		}
		/// <summary>
		/// Location of (loco)images.
		/// </summary>
		public string imgpath 
		{
			get { return this.m_imgpath; }
			private set { this.SetField(ref this.m_imgpath, value, "imgpath"); }
		}
		/// <summary>
		/// Location of the reported issues.
		/// </summary>
		public string issuepath 
		{
			get { return this.m_issuepath; }
			private set { this.SetField(ref this.m_issuepath, value, "issuepath"); }
		}
		/// <summary>
		/// Location of the donation key file.
		/// </summary>
		public string keypath 
		{
			get { return this.m_keypath; }
			private set { this.SetField(ref this.m_keypath, value, "keypath"); }
		}
		/// <summary>
		/// IID to use for mobile decoders; using default in case not set.
		/// </summary>
		public string lciid 
		{
			get { return this.m_lciid; }
			private set { this.SetField(ref this.m_lciid, value, "lciid"); }
		}
		/// <summary>
		/// Location of the rocrail libraries.
		/// </summary>
		public string libpath 
		{
			get { return this.m_libpath; }
			private set { this.SetField(ref this.m_libpath, value, "libpath"); }
		}
		/// <summary>
		/// File name of locomotive definitions.
		/// </summary>
		public string locs 
		{
			get { return this.m_locs; }
			private set { this.SetField(ref this.m_locs, value, "locs"); }
		}
		/// <summary>
		/// Do not check availability of serial devices.
		/// </summary>
		public bool nodevcheck 
		{
			get { return this.m_nodevcheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nodevcheck, value, "nodevcheck"); }
		}
		/// <summary>
		/// File name of block occupancy.
		/// </summary>
		public string occupancy 
		{
			get { return this.m_occupancy; }
			private set { this.SetField(ref this.m_occupancy, value, "occupancy"); }
		}
		/// <summary>
		/// RocRail plan-file.
		/// </summary>
		public string planfile 
		{
			get { return this.m_planfile; }
			private set { this.SetField(ref this.m_planfile, value, "planfile"); }
		}
		/// <summary>
		/// Turn track power off on server exit.
		/// </summary>
		public bool poweroffonexit 
		{
			get { return this.m_poweroffonexit.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroffonexit, value, "poweroffonexit"); }
		}
		/// <summary>
		/// IID to use with programming; using default in case not set.
		/// </summary>
		public string ptiid 
		{
			get { return this.m_ptiid; }
			private set { this.SetField(ref this.m_ptiid, value, "ptiid"); }
		}
		/// <summary>
		/// Reset all loco functions and speed at startup.
		/// </summary>
		public bool resetspfx 
		{
			get { return this.m_resetspfx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetspfx, value, "resetspfx"); }
		}
		/// <summary>
		/// Force rocrail to run as root.
		/// </summary>
		public bool runasroot 
		{
			get { return this.m_runasroot.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_runasroot, value, "runasroot"); }
		}
		/// <summary>
		/// Shortcut command station IID
		/// </summary>
		public string sciid 
		{
			get { return this.m_sciid; }
			private set { this.SetField(ref this.m_sciid, value, "sciid"); }
		}
		/// <summary>
		/// Shortcut sensor ID.
		/// </summary>
		public string scsensor 
		{
			get { return this.m_scsensor; }
			private set { this.SetField(ref this.m_scsensor, value, "scsensor"); }
		}
		/// <summary>
		/// Location of (loco)sounds.
		/// </summary>
		public string soundpath 
		{
			get { return this.m_soundpath; }
			private set { this.SetField(ref this.m_soundpath, value, "soundpath"); }
		}
		/// <summary>
		/// Sound player program.
		/// </summary>
		public string soundplayer 
		{
			get { return this.m_soundplayer; }
			private set { this.SetField(ref this.m_soundplayer, value, "soundplayer"); }
		}
		/// <summary>
		/// Add loco location as second parameter.
		/// </summary>
		public bool soundplayerlocation 
		{
			get { return this.m_soundplayerlocation.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_soundplayerlocation, value, "soundplayerlocation"); }
		}
		/// <summary>
		/// IID to use with LN SV programming; using default in case not set.
		/// </summary>
		public string sviid 
		{
			get { return this.m_sviid; }
			private set { this.SetField(ref this.m_sviid, value, "sviid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<SnmpService> SnmpServicelist 
		{
			get { return this.m_SnmpServicelist; }
			private set { this.SetField(ref this.m_SnmpServicelist, value, "SnmpServicelist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<anaopt> anaoptlist 
		{
			get { return this.m_anaoptlist; }
			private set { this.SetField(ref this.m_anaoptlist, value, "anaoptlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<clock> clocklist 
		{
			get { return this.m_clocklist; }
			private set { this.SetField(ref this.m_clocklist, value, "clocklist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<ctrl> ctrllist 
		{
			get { return this.m_ctrllist; }
			private set { this.SetField(ref this.m_ctrllist, value, "ctrllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<devices> deviceslist 
		{
			get { return this.m_deviceslist; }
			private set { this.SetField(ref this.m_deviceslist, value, "deviceslist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<digint> digintlist 
		{
			get { return this.m_digintlist; }
			private set { this.SetField(ref this.m_digintlist, value, "digintlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<http> httplist 
		{
			get { return this.m_httplist; }
			private set { this.SetField(ref this.m_httplist, value, "httplist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<jsmap> jsmaplist 
		{
			get { return this.m_jsmaplist; }
			private set { this.SetField(ref this.m_jsmaplist, value, "jsmaplist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<r2rnet> r2rnetlist 
		{
			get { return this.m_r2rnetlist; }
			private set { this.SetField(ref this.m_r2rnetlist, value, "r2rnetlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<service> servicelist 
		{
			get { return this.m_servicelist; }
			private set { this.SetField(ref this.m_servicelist, value, "servicelist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<srcpcon> srcpconlist 
		{
			get { return this.m_srcpconlist; }
			private set { this.SetField(ref this.m_srcpconlist, value, "srcpconlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<tcp> tcplist 
		{
			get { return this.m_tcplist; }
			private set { this.SetField(ref this.m_tcplist, value, "tcplist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<trace> tracelist 
		{
			get { return this.m_tracelist; }
			private set { this.SetField(ref this.m_tracelist, value, "tracelist"); }
		}
		public rocrail()
		{
			this.m_SnmpServicelist = new List<SnmpService>();
			this.m_anaoptlist = new List<anaopt>();
			this.m_clocklist = new List<clock>();
			this.m_ctrllist = new List<ctrl>();
			this.m_deviceslist = new List<devices>();
			this.m_digintlist = new List<digint>();
			this.m_httplist = new List<http>();
			this.m_jsmaplist = new List<jsmap>();
			this.m_r2rnetlist = new List<r2rnet>();
			this.m_servicelist = new List<service>();
			this.m_srcpconlist = new List<srcpcon>();
			this.m_tcplist = new List<tcp>();
			this.m_tracelist = new List<trace>();
		}
		public static rocrail Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			rocrail _rocrail = new rocrail();
			_rocrail.m_rocrailClient = rocrailClient;
			_rocrail.m_backup = (bool?)xml.Attribute("backup");
			_rocrail.m_backuppath = (string)xml.Attribute("backuppath");
			_rocrail.m_createmodplan = (bool?)xml.Attribute("createmodplan");
			_rocrail.m_doneml = (string)xml.Attribute("doneml");
			_rocrail.m_donkey = (string)xml.Attribute("donkey");
			_rocrail.m_dpiid = (string)xml.Attribute("dpiid");
			_rocrail.m_file = (string)xml.Attribute("file");
			_rocrail.m_fsutf8 = (bool?)xml.Attribute("fsutf8");
			_rocrail.m_imgpath = (string)xml.Attribute("imgpath");
			_rocrail.m_issuepath = (string)xml.Attribute("issuepath");
			_rocrail.m_keypath = (string)xml.Attribute("keypath");
			_rocrail.m_lciid = (string)xml.Attribute("lciid");
			_rocrail.m_libpath = (string)xml.Attribute("libpath");
			_rocrail.m_locs = (string)xml.Attribute("locs");
			_rocrail.m_nodevcheck = (bool?)xml.Attribute("nodevcheck");
			_rocrail.m_occupancy = (string)xml.Attribute("occupancy");
			_rocrail.m_planfile = (string)xml.Attribute("planfile");
			_rocrail.m_poweroffonexit = (bool?)xml.Attribute("poweroffonexit");
			_rocrail.m_ptiid = (string)xml.Attribute("ptiid");
			_rocrail.m_resetspfx = (bool?)xml.Attribute("resetspfx");
			_rocrail.m_runasroot = (bool?)xml.Attribute("runasroot");
			_rocrail.m_sciid = (string)xml.Attribute("sciid");
			_rocrail.m_scsensor = (string)xml.Attribute("scsensor");
			_rocrail.m_soundpath = (string)xml.Attribute("soundpath");
			_rocrail.m_soundplayer = (string)xml.Attribute("soundplayer");
			_rocrail.m_soundplayerlocation = (bool?)xml.Attribute("soundplayerlocation");
			_rocrail.m_sviid = (string)xml.Attribute("sviid");
			Definitions.Tools.ParseList<SnmpService>(_rocrail.m_SnmpServicelist, xml, "SnmpService", SnmpService.Parse, rocrailClient);
			Definitions.Tools.ParseList<anaopt>(_rocrail.m_anaoptlist, xml, "anaopt", anaopt.Parse, rocrailClient);
			Definitions.Tools.ParseList<clock>(_rocrail.m_clocklist, xml, "clock", clock.Parse, rocrailClient);
			Definitions.Tools.ParseList<ctrl>(_rocrail.m_ctrllist, xml, "ctrl", ctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<devices>(_rocrail.m_deviceslist, xml, "devices", devices.Parse, rocrailClient);
			Definitions.Tools.ParseList<digint>(_rocrail.m_digintlist, xml, "digint", digint.Parse, rocrailClient);
			Definitions.Tools.ParseList<http>(_rocrail.m_httplist, xml, "http", http.Parse, rocrailClient);
			Definitions.Tools.ParseList<jsmap>(_rocrail.m_jsmaplist, xml, "jsmap", jsmap.Parse, rocrailClient);
			Definitions.Tools.ParseList<r2rnet>(_rocrail.m_r2rnetlist, xml, "r2rnet", r2rnet.Parse, rocrailClient);
			Definitions.Tools.ParseList<service>(_rocrail.m_servicelist, xml, "service", service.Parse, rocrailClient);
			Definitions.Tools.ParseList<srcpcon>(_rocrail.m_srcpconlist, xml, "srcpcon", srcpcon.Parse, rocrailClient);
			Definitions.Tools.ParseList<tcp>(_rocrail.m_tcplist, xml, "tcp", tcp.Parse, rocrailClient);
			Definitions.Tools.ParseList<trace>(_rocrail.m_tracelist, xml, "trace", trace.Parse, rocrailClient);
			return _rocrail;
		}
		public void Update(rocrail element)
		{
			if(element.m_backup.HasValue == true) this.backup = element.backup;
			if(element.m_backuppath != null) this.backuppath = element.backuppath;
			if(element.m_createmodplan.HasValue == true) this.createmodplan = element.createmodplan;
			if(element.m_doneml != null) this.doneml = element.doneml;
			if(element.m_donkey != null) this.donkey = element.donkey;
			if(element.m_dpiid != null) this.dpiid = element.dpiid;
			if(element.m_file != null) this.file = element.file;
			if(element.m_fsutf8.HasValue == true) this.fsutf8 = element.fsutf8;
			if(element.m_imgpath != null) this.imgpath = element.imgpath;
			if(element.m_issuepath != null) this.issuepath = element.issuepath;
			if(element.m_keypath != null) this.keypath = element.keypath;
			if(element.m_lciid != null) this.lciid = element.lciid;
			if(element.m_libpath != null) this.libpath = element.libpath;
			if(element.m_locs != null) this.locs = element.locs;
			if(element.m_nodevcheck.HasValue == true) this.nodevcheck = element.nodevcheck;
			if(element.m_occupancy != null) this.occupancy = element.occupancy;
			if(element.m_planfile != null) this.planfile = element.planfile;
			if(element.m_poweroffonexit.HasValue == true) this.poweroffonexit = element.poweroffonexit;
			if(element.m_ptiid != null) this.ptiid = element.ptiid;
			if(element.m_resetspfx.HasValue == true) this.resetspfx = element.resetspfx;
			if(element.m_runasroot.HasValue == true) this.runasroot = element.runasroot;
			if(element.m_sciid != null) this.sciid = element.sciid;
			if(element.m_scsensor != null) this.scsensor = element.scsensor;
			if(element.m_soundpath != null) this.soundpath = element.soundpath;
			if(element.m_soundplayer != null) this.soundplayer = element.soundplayer;
			if(element.m_soundplayerlocation.HasValue == true) this.soundplayerlocation = element.soundplayerlocation;
			if(element.m_sviid != null) this.sviid = element.sviid;
			this.SnmpServicelist = element.SnmpServicelist;
			this.anaoptlist = element.anaoptlist;
			this.clocklist = element.clocklist;
			this.ctrllist = element.ctrllist;
			this.deviceslist = element.deviceslist;
			this.digintlist = element.digintlist;
			this.httplist = element.httplist;
			this.jsmaplist = element.jsmaplist;
			this.r2rnetlist = element.r2rnetlist;
			this.servicelist = element.servicelist;
			this.srcpconlist = element.srcpconlist;
			this.tcplist = element.tcplist;
			this.tracelist = element.tracelist;
		}
	}
}
