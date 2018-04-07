using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class devices : CRocrailElements
	{
		private string m_serial;
		public const string BARJUT = "barjut";
		public const string BIDIB = "bidib";
		public const string CBUS = "cbus";
		public const string CLOCK = "clock";
		public const string CTI = "cti";
		public const string CTS = "cts";
		public const string DCC232 = "dcc232";
		public const string DDX = "ddx";
		public const string DINAMO = "dinamo";
		public const string DSR = "dsr";
		public const string DTC = "dtc";
		public const string EASYDCC = "easydcc";
		public const string ECOS = "ecos";
		public const string EDITSPRO = "editspro";
		public const string EVEN = "even";
		public const string HSI88 = "hsi88";
		public const string INFRACAR = "infracar";
		public const string LENZ = "lenz";
		public const string LOCONET = "loconet";
		public const string LRC135 = "lrc135";
		public const string MASSOTH = "massoth";
		public const string MCS2 = "mcs2";
		public const string MTTMFCC = "mttmfcc";
		public const string MUET = "muet";
		public const string NCE = "nce";
		public const string NO = "no";
		public const string NONE = "none";
		public const string ODD = "odd";
		public const string OM32 = "om32";
		public const string OPENDCC = "opendcc";
		public const string P50 = "p50";
		public const string P50X = "p50x";
		public const string PERIR = "perir";
		public const string RCLINK = "rclink";
		public const string RFID12 = "rfid12";
		public const string RMX = "rmx";
		public const string ROCNET = "rocnet";
		public const string ROCO = "roco";
		public const string SLX = "slx";
		public const string SPROG = "sprog";
		public const string SRCP = "srcp";
		public const string SUBLIB_DEFAULT = "default";
		public const string SUBLIB_DIGITRAX_PR3 = "pr3";
		public const string SUBLIB_LENZ_ATLAS = "atlas";
		public const string SUBLIB_LENZ_CTTRAN = "cttran";
		public const string SUBLIB_LENZ_ELITE = "elite";
		public const string SUBLIB_LENZ_ETHERNET = "ethernet";
		public const string SUBLIB_LENZ_OPENDCC = "opendcc";
		public const string SUBLIB_LENZ_XNTCP = "xntcp";
		public const string SUBLIB_NATIVE = "native";
		public const string SUBLIB_SERIAL = "serial";
		public const string SUBLIB_SOCKET = "socket";
		public const string SUBLIB_TCP = "tcp";
		public const string SUBLIB_UDP = "udp";
		public const string SUBLIB_ULNI = "ulni";
		public const string SUBLIB_USB = "usb";
		public const string TAMSMC = "tamsmc";
		public const string VCS = "virtual";
		public const string XNMM = "xnmm";
		public const string XON = "xon";
		public const string XPRESSNET = "xpressnet";
		public const string Z21 = "z21";
		public const string ZIMO = "zimo";
		public const string ZIMOBIN = "zimobin";
		public const string ZS2 = "zs2";
		private bool? m_asciiprotocol;
		private int? m_bits;
		private int? m_bps;
		private int? m_ctsretry;
		private string m_device;
		private bool? m_dummyio;
		private bool? m_fastclock;
		private int? m_fbmod;
		private int? m_fboffset;
		private bool? m_fbpoll;
		private bool? m_fbreset;
		private string m_flow;
		private string m_host;
		private int? m_identdelay;
		private bool? m_ignorebusy;
		private string m_iid;
		private string m_iid_master;
		private string m_iid_slave;
		private string m_lib;
		private string m_libpath;
		private string m_localip;
		private bool? m_locolist;
		private bool? m_overrule;
		private string m_parity;
		private int? m_port;
		private bool? m_poweratstartup;
		private bool? m_poweroffexit;
		private int? m_protver;
		private int? m_psleep;
		private bool? m_ptsupport;
		private bool? m_pw4acc;
		private bool? m_readbidi;
		private bool? m_readfb;
		private bool? m_restricted;
		private bool? m_rtsdisabled;
		private bool? m_startpwstate;
		private int? m_stopbits;
		private bool? m_stress;
		private string m_sublib;
		private bool? m_swinvert;
		private bool? m_switchlist;
		private int? m_swtime;
		private bool? m_systeminfo;
		private int? m_timeout;
		/// <summary>
		/// CSV list of serial devices.
		/// </summary>
		public string serial 
		{
			get { return this.m_serial; }
			private set { this.SetField(ref this.m_serial, value, "serial"); }
		}
		/// <summary>
		/// Use an ASCII protocol.
		/// </summary>
		public bool asciiprotocol 
		{
			get { return this.m_asciiprotocol.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_asciiprotocol, value, "asciiprotocol"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bits 
		{
			get { return this.m_bits.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bits, value, "bits"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bps 
		{
			get { return this.m_bps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bps, value, "bps"); }
		}
		/// <summary>
		/// wait for CTS line to come up.
		/// </summary>
		public int ctsretry 
		{
			get { return this.m_ctsretry.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctsretry, value, "ctsretry"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string device 
		{
			get { return this.m_device; }
			private set { this.SetField(ref this.m_device, value, "device"); }
		}
		/// <summary>
		/// Do not use real I/O.
		/// </summary>
		public bool dummyio 
		{
			get { return this.m_dummyio.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dummyio, value, "dummyio"); }
		}
		/// <summary>
		/// send fast clock commands to the connected command station
		/// </summary>
		public bool fastclock 
		{
			get { return this.m_fastclock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fastclock, value, "fastclock"); }
		}
		/// <summary>
		/// Number of connected feedback modules of 8 inputs.
		/// </summary>
		public int fbmod 
		{
			get { return this.m_fbmod.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbmod, value, "fbmod"); }
		}
		/// <summary>
		/// Offset for the feedback units.
		/// </summary>
		public int fboffset 
		{
			get { return this.m_fboffset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fboffset, value, "fboffset"); }
		}
		/// <summary>
		/// Poll sensor events in p50x instead of xEvtSen.
		/// </summary>
		public bool fbpoll 
		{
			get { return this.m_fbpoll.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbpoll, value, "fbpoll"); }
		}
		/// <summary>
		/// Reset sensors automatically to low.
		/// </summary>
		public bool fbreset 
		{
			get { return this.m_fbreset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbreset, value, "fbreset"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string flow 
		{
			get { return this.m_flow; }
			private set { this.SetField(ref this.m_flow, value, "flow"); }
		}
		/// <summary>
		/// hostname.
		/// </summary>
		public string host 
		{
			get { return this.m_host; }
			private set { this.SetField(ref this.m_host, value, "host"); }
		}
		/// <summary>
		/// Delay before sending a low sensor state for ident codes.
		/// </summary>
		public int identdelay 
		{
			get { return this.m_identdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_identdelay, value, "identdelay"); }
		}
		/// <summary>
		/// ignore the busy message from command station
		/// </summary>
		public bool ignorebusy 
		{
			get { return this.m_ignorebusy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ignorebusy, value, "ignorebusy"); }
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
		/// Interface ID (loconet).
		/// </summary>
		public string iid_master 
		{
			get { return this.m_iid_master; }
			private set { this.SetField(ref this.m_iid_master, value, "iid_master"); }
		}
		/// <summary>
		/// Interface ID (ddl).
		/// </summary>
		public string iid_slave 
		{
			get { return this.m_iid_slave; }
			private set { this.SetField(ref this.m_iid_slave, value, "iid_slave"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lib 
		{
			get { return this.m_lib; }
			private set { this.SetField(ref this.m_lib, value, "lib"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string libpath 
		{
			get { return this.m_libpath; }
			private set { this.SetField(ref this.m_libpath, value, "libpath"); }
		}
		/// <summary>
		/// Local interface IP.
		/// </summary>
		public string localip 
		{
			get { return this.m_localip; }
			private set { this.SetField(ref this.m_localip, value, "localip"); }
		}
		/// <summary>
		/// Initial send the digint the list of locos.
		/// </summary>
		public bool locolist 
		{
			get { return this.m_locolist.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_locolist, value, "locolist"); }
		}
		/// <summary>
		/// Overrule throttle commands.
		/// </summary>
		public bool overrule 
		{
			get { return this.m_overrule.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_overrule, value, "overrule"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string parity 
		{
			get { return this.m_parity; }
			private set { this.SetField(ref this.m_parity, value, "parity"); }
		}
		/// <summary>
		/// command port.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// Power on at startup.
		/// </summary>
		public bool poweratstartup 
		{
			get { return this.m_poweratstartup.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweratstartup, value, "poweratstartup"); }
		}
		/// <summary>
		/// Power off at halt command.
		/// </summary>
		public bool poweroffexit 
		{
			get { return this.m_poweroffexit.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroffexit, value, "poweroffexit"); }
		}
		/// <summary>
		/// Protocol version. Default implementation is 0.
		/// </summary>
		public int protver 
		{
			get { return this.m_protver.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_protver, value, "protver"); }
		}
		/// <summary>
		/// Sleep between polling of the feedback units.
		/// </summary>
		public int psleep 
		{
			get { return this.m_psleep.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_psleep, value, "psleep"); }
		}
		/// <summary>
		/// Check for PT events.
		/// </summary>
		public bool ptsupport 
		{
			get { return this.m_ptsupport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ptsupport, value, "ptsupport"); }
		}
		/// <summary>
		/// Power must be on for accessory commands.
		/// </summary>
		public bool pw4acc 
		{
			get { return this.m_pw4acc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pw4acc, value, "pw4acc"); }
		}
		/// <summary>
		/// Poll the bidi units.
		/// </summary>
		public bool readbidi 
		{
			get { return this.m_readbidi.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_readbidi, value, "readbidi"); }
		}
		/// <summary>
		/// Poll the feedback units.
		/// </summary>
		public bool readfb 
		{
			get { return this.m_readfb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_readfb, value, "readfb"); }
		}
		/// <summary>
		/// Restricted functionality due to missing support key.
		/// </summary>
		public bool restricted 
		{
			get { return this.m_restricted.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_restricted, value, "restricted"); }
		}
		/// <summary>
		/// Disables RTS line for USB converters. (Depends on type if this is needed.)
		/// </summary>
		public bool rtsdisabled 
		{
			get { return this.m_rtsdisabled.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rtsdisabled, value, "rtsdisabled"); }
		}
		/// <summary>
		/// Powerstate at startup.
		/// </summary>
		public bool startpwstate 
		{
			get { return this.m_startpwstate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_startpwstate, value, "startpwstate"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int stopbits 
		{
			get { return this.m_stopbits.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stopbits, value, "stopbits"); }
		}
		/// <summary>
		/// send every 10ms a loconet packet to stress the network
		/// </summary>
		public bool stress 
		{
			get { return this.m_stress.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stress, value, "stress"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string sublib 
		{
			get { return this.m_sublib; }
			private set { this.SetField(ref this.m_sublib, value, "sublib"); }
		}
		/// <summary>
		/// Invert all turnouts/switches.
		/// </summary>
		public bool swinvert 
		{
			get { return this.m_swinvert.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swinvert, value, "swinvert"); }
		}
		/// <summary>
		/// Initial send the digint the list of switches.
		/// </summary>
		public bool switchlist 
		{
			get { return this.m_switchlist.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_switchlist, value, "switchlist"); }
		}
		/// <summary>
		/// Switch time.
		/// </summary>
		public int swtime 
		{
			get { return this.m_swtime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swtime, value, "swtime"); }
		}
		/// <summary>
		/// Activate system info if available.
		/// </summary>
		public bool systeminfo 
		{
			get { return this.m_systeminfo.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_systeminfo, value, "systeminfo"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timeout 
		{
			get { return this.m_timeout.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timeout, value, "timeout"); }
		}
		public devices()
		{
		}
		public static devices Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			devices _devices = new devices();
			_devices.m_rocrailClient = rocrailClient;
			_devices.m_serial = (string)xml.Attribute("serial");
			_devices.m_asciiprotocol = (bool?)xml.Attribute("asciiprotocol");
			_devices.m_bits = (int?)xml.Attribute("bits");
			_devices.m_bps = (int?)xml.Attribute("bps");
			_devices.m_ctsretry = (int?)xml.Attribute("ctsretry");
			_devices.m_device = (string)xml.Attribute("device");
			_devices.m_dummyio = (bool?)xml.Attribute("dummyio");
			_devices.m_fastclock = (bool?)xml.Attribute("fastclock");
			_devices.m_fbmod = (int?)xml.Attribute("fbmod");
			_devices.m_fboffset = (int?)xml.Attribute("fboffset");
			_devices.m_fbpoll = (bool?)xml.Attribute("fbpoll");
			_devices.m_fbreset = (bool?)xml.Attribute("fbreset");
			_devices.m_flow = (string)xml.Attribute("flow");
			_devices.m_host = (string)xml.Attribute("host");
			_devices.m_identdelay = (int?)xml.Attribute("identdelay");
			_devices.m_ignorebusy = (bool?)xml.Attribute("ignorebusy");
			_devices.m_iid = (string)xml.Attribute("iid");
			_devices.m_iid_master = (string)xml.Attribute("iid_master");
			_devices.m_iid_slave = (string)xml.Attribute("iid_slave");
			_devices.m_lib = (string)xml.Attribute("lib");
			_devices.m_libpath = (string)xml.Attribute("libpath");
			_devices.m_localip = (string)xml.Attribute("localip");
			_devices.m_locolist = (bool?)xml.Attribute("locolist");
			_devices.m_overrule = (bool?)xml.Attribute("overrule");
			_devices.m_parity = (string)xml.Attribute("parity");
			_devices.m_port = (int?)xml.Attribute("port");
			_devices.m_poweratstartup = (bool?)xml.Attribute("poweratstartup");
			_devices.m_poweroffexit = (bool?)xml.Attribute("poweroffexit");
			_devices.m_protver = (int?)xml.Attribute("protver");
			_devices.m_psleep = (int?)xml.Attribute("psleep");
			_devices.m_ptsupport = (bool?)xml.Attribute("ptsupport");
			_devices.m_pw4acc = (bool?)xml.Attribute("pw4acc");
			_devices.m_readbidi = (bool?)xml.Attribute("readbidi");
			_devices.m_readfb = (bool?)xml.Attribute("readfb");
			_devices.m_restricted = (bool?)xml.Attribute("restricted");
			_devices.m_rtsdisabled = (bool?)xml.Attribute("rtsdisabled");
			_devices.m_startpwstate = (bool?)xml.Attribute("startpwstate");
			_devices.m_stopbits = (int?)xml.Attribute("stopbits");
			_devices.m_stress = (bool?)xml.Attribute("stress");
			_devices.m_sublib = (string)xml.Attribute("sublib");
			_devices.m_swinvert = (bool?)xml.Attribute("swinvert");
			_devices.m_switchlist = (bool?)xml.Attribute("switchlist");
			_devices.m_swtime = (int?)xml.Attribute("swtime");
			_devices.m_systeminfo = (bool?)xml.Attribute("systeminfo");
			_devices.m_timeout = (int?)xml.Attribute("timeout");
			return _devices;
		}
		public void Update(devices element)
		{
			if(element.m_serial != null) this.serial = element.serial;
			if(element.m_asciiprotocol.HasValue == true) this.asciiprotocol = element.asciiprotocol;
			if(element.m_bits.HasValue == true) this.bits = element.bits;
			if(element.m_bps.HasValue == true) this.bps = element.bps;
			if(element.m_ctsretry.HasValue == true) this.ctsretry = element.ctsretry;
			if(element.m_device != null) this.device = element.device;
			if(element.m_dummyio.HasValue == true) this.dummyio = element.dummyio;
			if(element.m_fastclock.HasValue == true) this.fastclock = element.fastclock;
			if(element.m_fbmod.HasValue == true) this.fbmod = element.fbmod;
			if(element.m_fboffset.HasValue == true) this.fboffset = element.fboffset;
			if(element.m_fbpoll.HasValue == true) this.fbpoll = element.fbpoll;
			if(element.m_fbreset.HasValue == true) this.fbreset = element.fbreset;
			if(element.m_flow != null) this.flow = element.flow;
			if(element.m_host != null) this.host = element.host;
			if(element.m_identdelay.HasValue == true) this.identdelay = element.identdelay;
			if(element.m_ignorebusy.HasValue == true) this.ignorebusy = element.ignorebusy;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_iid_master != null) this.iid_master = element.iid_master;
			if(element.m_iid_slave != null) this.iid_slave = element.iid_slave;
			if(element.m_lib != null) this.lib = element.lib;
			if(element.m_libpath != null) this.libpath = element.libpath;
			if(element.m_localip != null) this.localip = element.localip;
			if(element.m_locolist.HasValue == true) this.locolist = element.locolist;
			if(element.m_overrule.HasValue == true) this.overrule = element.overrule;
			if(element.m_parity != null) this.parity = element.parity;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_poweratstartup.HasValue == true) this.poweratstartup = element.poweratstartup;
			if(element.m_poweroffexit.HasValue == true) this.poweroffexit = element.poweroffexit;
			if(element.m_protver.HasValue == true) this.protver = element.protver;
			if(element.m_psleep.HasValue == true) this.psleep = element.psleep;
			if(element.m_ptsupport.HasValue == true) this.ptsupport = element.ptsupport;
			if(element.m_pw4acc.HasValue == true) this.pw4acc = element.pw4acc;
			if(element.m_readbidi.HasValue == true) this.readbidi = element.readbidi;
			if(element.m_readfb.HasValue == true) this.readfb = element.readfb;
			if(element.m_restricted.HasValue == true) this.restricted = element.restricted;
			if(element.m_rtsdisabled.HasValue == true) this.rtsdisabled = element.rtsdisabled;
			if(element.m_startpwstate.HasValue == true) this.startpwstate = element.startpwstate;
			if(element.m_stopbits.HasValue == true) this.stopbits = element.stopbits;
			if(element.m_stress.HasValue == true) this.stress = element.stress;
			if(element.m_sublib != null) this.sublib = element.sublib;
			if(element.m_swinvert.HasValue == true) this.swinvert = element.swinvert;
			if(element.m_switchlist.HasValue == true) this.switchlist = element.switchlist;
			if(element.m_swtime.HasValue == true) this.swtime = element.swtime;
			if(element.m_systeminfo.HasValue == true) this.systeminfo = element.systeminfo;
			if(element.m_timeout.HasValue == true) this.timeout = element.timeout;
		}
	}
}
