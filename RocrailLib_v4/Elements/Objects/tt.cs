using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class tt : CRocrailElements
	{
		public const string ACCDEC = "accdec";
		public const string CALIBRATE = "calibrate";
		public const string D15 = "d15";
		public const string DIGITALBAHN = "digitalbahn";
		public const string DSM = "dsm";
		public const string F6915 = "f6915";
		public const string FOFF = "off";
		public const string FON = "on";
		public const string LIGHTOFF = "lightoff";
		public const string LIGHTON = "lighton";
		public const string LOCDEC = "locdec";
		public const string MUET = "muet";
		public const string MULTIPORT = "multiport";
		public const string NEXT = "next";
		public const string PREV = "prev";
		public const string PROT_DEF = "D";
		public const string PROT_M = "M";
		public const string PROT_MP = "MP";
		public const string PROT_N = "N";
		public const string SLX815 = "slx815";
		public const string TTDEC = "ttdec";
		public const string TURN180 = "180";
		public const string UNLOCKED = "-unlocked-";
		private int? m_V;
		private int? m_actfn;
		private int? m_addr;
		private int? m_addr0;
		private int? m_addr1;
		private int? m_addr2;
		private int? m_addr3;
		private int? m_addr4;
		private int? m_addr5;
		private int? m_addr6;
		private string m_b0sen;
		private string m_b1sen;
		private string m_b2sen;
		private string m_b3sen;
		private int? m_bit0cmd;
		private int? m_bit1cmd;
		private int? m_bit2cmd;
		private int? m_bit3cmd;
		private int? m_bit4cmd;
		private int? m_bit5cmd;
		private int? m_bridgepos;
		private int? m_bus;
		private string m_cmd;
		private int? m_delay;
		private string m_desc;
		private int? m_diraddr;
		private bool? m_embeddedblock;
		private bool? m_entering;
		private int? m_fun;
		
		private string m_iid;
		private bool? m_inv;
		private bool? m_invnew;
		private bool? m_invpos;
		private int? m_lightsfn;
		private string m_locid;
		private bool? m_manager;
		private int? m_motoroffdelay;
		private string m_oid;
		private int? m_pause;
		private int? m_poladdr;
		private int? m_port0;
		private int? m_port1;
		private int? m_port2;
		private int? m_port3;
		private int? m_port4;
		private int? m_port5;
		private int? m_port6;
		private string m_prot;
		private string m_psen;
		private bool? m_reserved;
		private int? m_resetaddr;
		private int? m_resetbitcmd;
		private int? m_resetport;
		private string m_s1;
		private string m_s2;
		private string m_sMid;
		private string m_sMid2;
		private bool? m_singlegatenew;
		private bool? m_singlegatepos;
		private string m_state;
		private bool? m_state1;
		private bool? m_state2;
		private bool? m_stateMid;
		private bool? m_stateMid2;
		private bool? m_swaprotation;
		private bool? m_swcmd;
		private int? m_symbolsize;
		private bool? m_traverser;
		private string m_type;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<actionctrl> m_actionctrllist;
		private List<track> m_tracklist;
		/// <summary>
		/// Rotation speed in percent.
		/// </summary>
		public int V 
		{
			get { return this.m_V.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_V, value, "V"); }
		}
		/// <summary>
		/// Activation function for locdec type turntable drives.
		/// </summary>
		public int actfn 
		{
			get { return this.m_actfn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actfn, value, "actfn"); }
		}
		/// <summary>
		/// Turntable address.
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// bit 0 of track
		/// </summary>
		public int addr0 
		{
			get { return this.m_addr0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr0, value, "addr0"); }
		}
		/// <summary>
		/// bit 1 of track
		/// </summary>
		public int addr1 
		{
			get { return this.m_addr1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr1, value, "addr1"); }
		}
		/// <summary>
		/// bit 2 of track
		/// </summary>
		public int addr2 
		{
			get { return this.m_addr2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr2, value, "addr2"); }
		}
		/// <summary>
		/// bit 3 of track
		/// </summary>
		public int addr3 
		{
			get { return this.m_addr3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr3, value, "addr3"); }
		}
		/// <summary>
		/// bit 4 of track
		/// </summary>
		public int addr4 
		{
			get { return this.m_addr4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr4, value, "addr4"); }
		}
		/// <summary>
		/// new position set flag address
		/// </summary>
		public int addr5 
		{
			get { return this.m_addr5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr5, value, "addr5"); }
		}
		/// <summary>
		/// bit 5 of track
		/// </summary>
		public int addr6 
		{
			get { return this.m_addr6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr6, value, "addr6"); }
		}
		/// <summary>
		/// ID bit 0 of position
		/// </summary>
		public string b0sen 
		{
			get { return this.m_b0sen; }
			private set { this.SetField(ref this.m_b0sen, value, "b0sen"); }
		}
		/// <summary>
		/// ID bit 1 of position
		/// </summary>
		public string b1sen 
		{
			get { return this.m_b1sen; }
			private set { this.SetField(ref this.m_b1sen, value, "b1sen"); }
		}
		/// <summary>
		/// ID bit 2 of position
		/// </summary>
		public string b2sen 
		{
			get { return this.m_b2sen; }
			private set { this.SetField(ref this.m_b2sen, value, "b2sen"); }
		}
		/// <summary>
		/// ID bit 3 of position
		/// </summary>
		public string b3sen 
		{
			get { return this.m_b3sen; }
			private set { this.SetField(ref this.m_b3sen, value, "b3sen"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit0cmd 
		{
			get { return this.m_bit0cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit0cmd, value, "bit0cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit1cmd 
		{
			get { return this.m_bit1cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit1cmd, value, "bit1cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit2cmd 
		{
			get { return this.m_bit2cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit2cmd, value, "bit2cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit3cmd 
		{
			get { return this.m_bit3cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit3cmd, value, "bit3cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit4cmd 
		{
			get { return this.m_bit4cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit4cmd, value, "bit4cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bit5cmd 
		{
			get { return this.m_bit5cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bit5cmd, value, "bit5cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bridgepos 
		{
			get { return this.m_bridgepos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bridgepos, value, "bridgepos"); }
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
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
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
		/// Direction address.
		/// </summary>
		public int diraddr 
		{
			get { return this.m_diraddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_diraddr, value, "diraddr"); }
		}
		/// <summary>
		/// TT is block.
		/// </summary>
		public bool embeddedblock 
		{
			get { return this.m_embeddedblock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_embeddedblock, value, "embeddedblock"); }
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
		/// 
		/// </summary>
		public int fun 
		{
			get { return this.m_fun.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fun, value, "fun"); }
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
		/// Interface ID.
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// invert the commands
		/// </summary>
		public bool inv 
		{
			get { return this.m_inv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv, value, "inv"); }
		}
		/// <summary>
		/// invert position set flag command
		/// </summary>
		public bool invnew 
		{
			get { return this.m_invnew.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_invnew, value, "invnew"); }
		}
		/// <summary>
		/// invert position commands
		/// </summary>
		public bool invpos 
		{
			get { return this.m_invpos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_invpos, value, "invpos"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int lightsfn 
		{
			get { return this.m_lightsfn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lightsfn, value, "lightsfn"); }
		}
		/// <summary>
		/// The loc who locked this turntable.
		/// </summary>
		public string locid 
		{
			get { return this.m_locid; }
			private set { this.SetField(ref this.m_locid, value, "locid"); }
		}
		/// <summary>
		/// Manager mode: Act like a block and manage all sub blocks.(Tracks)
		/// </summary>
		public bool manager 
		{
			get { return this.m_manager.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manager, value, "manager"); }
		}
		/// <summary>
		/// shut off delay for locdec motor
		/// </summary>
		public int motoroffdelay 
		{
			get { return this.m_motoroffdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_motoroffdelay, value, "motoroffdelay"); }
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
		/// pause between direction and position command
		/// </summary>
		public int pause 
		{
			get { return this.m_pause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pause, value, "pause"); }
		}
		/// <summary>
		/// Polarization relay address.
		/// </summary>
		public int poladdr 
		{
			get { return this.m_poladdr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poladdr, value, "poladdr"); }
		}
		/// <summary>
		/// bit 0 of track
		/// </summary>
		public int port0 
		{
			get { return this.m_port0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port0, value, "port0"); }
		}
		/// <summary>
		/// bit 1 of track
		/// </summary>
		public int port1 
		{
			get { return this.m_port1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port1, value, "port1"); }
		}
		/// <summary>
		/// bit 2 of track
		/// </summary>
		public int port2 
		{
			get { return this.m_port2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port2, value, "port2"); }
		}
		/// <summary>
		/// bit 3 of track
		/// </summary>
		public int port3 
		{
			get { return this.m_port3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port3, value, "port3"); }
		}
		/// <summary>
		/// bit 4 of track
		/// </summary>
		public int port4 
		{
			get { return this.m_port4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port4, value, "port4"); }
		}
		/// <summary>
		/// new position set flag port
		/// </summary>
		public int port5 
		{
			get { return this.m_port5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port5, value, "port5"); }
		}
		/// <summary>
		/// bit 5 of track
		/// </summary>
		public int port6 
		{
			get { return this.m_port6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port6, value, "port6"); }
		}
		/// <summary>
		/// Protocol to use.
		/// </summary>
		public string prot 
		{
			get { return this.m_prot; }
			private set { this.SetField(ref this.m_prot, value, "prot"); }
		}
		/// <summary>
		/// ID of the position ready sensor
		/// </summary>
		public string psen 
		{
			get { return this.m_psen; }
			private set { this.SetField(ref this.m_psen, value, "psen"); }
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
		/// Reset bit address
		/// </summary>
		public int resetaddr 
		{
			get { return this.m_resetaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetaddr, value, "resetaddr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int resetbitcmd 
		{
			get { return this.m_resetbitcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetbitcmd, value, "resetbitcmd"); }
		}
		/// <summary>
		/// Reset bit port
		/// </summary>
		public int resetport 
		{
			get { return this.m_resetport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetport, value, "resetport"); }
		}
		/// <summary>
		/// Feedback ID for detection occupancy on the bridge.
		/// </summary>
		public string s1 
		{
			get { return this.m_s1; }
			private set { this.SetField(ref this.m_s1, value, "s1"); }
		}
		/// <summary>
		/// Feedback ID for detection occupancy on the bridge.
		/// </summary>
		public string s2 
		{
			get { return this.m_s2; }
			private set { this.SetField(ref this.m_s2, value, "s2"); }
		}
		/// <summary>
		/// Feedback ID for detection occupancy on the bridge.
		/// </summary>
		public string sMid 
		{
			get { return this.m_sMid; }
			private set { this.SetField(ref this.m_sMid, value, "sMid"); }
		}
		/// <summary>
		/// Feedback ID for detection occupancy on the bridge.
		/// </summary>
		public string sMid2 
		{
			get { return this.m_sMid2; }
			private set { this.SetField(ref this.m_sMid2, value, "sMid2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool singlegatenew 
		{
			get { return this.m_singlegatenew.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_singlegatenew, value, "singlegatenew"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool singlegatepos 
		{
			get { return this.m_singlegatepos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_singlegatepos, value, "singlegatepos"); }
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
		/// Feedback state bridge sensor1.
		/// </summary>
		public bool state1 
		{
			get { return this.m_state1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state1, value, "state1"); }
		}
		/// <summary>
		/// Feedback state bridge sensor2.
		/// </summary>
		public bool state2 
		{
			get { return this.m_state2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state2, value, "state2"); }
		}
		/// <summary>
		/// Feedback state bridge sensor3.
		/// </summary>
		public bool stateMid 
		{
			get { return this.m_stateMid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stateMid, value, "stateMid"); }
		}
		/// <summary>
		/// Feedback state bridge sensor4.
		/// </summary>
		public bool stateMid2 
		{
			get { return this.m_stateMid2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stateMid2, value, "stateMid2"); }
		}
		/// <summary>
		/// swap bridge rotation direction
		/// </summary>
		public bool swaprotation 
		{
			get { return this.m_swaprotation.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swaprotation, value, "swaprotation"); }
		}
		/// <summary>
		/// use switch instead of output commands
		/// </summary>
		public bool swcmd 
		{
			get { return this.m_swcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swcmd, value, "swcmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int symbolsize 
		{
			get { return this.m_symbolsize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_symbolsize, value, "symbolsize"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool traverser 
		{
			get { return this.m_traverser.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_traverser, value, "traverser"); }
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
		/// 
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
		public List<track> tracklist 
		{
			get { return this.m_tracklist; }
			private set { this.SetField(ref this.m_tracklist, value, "tracklist"); }
		}
		public tt()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_tracklist = new List<track>();
		}
		public static tt Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			tt _tt = new tt();
			_tt.m_rocrailClient = rocrailClient;
			_tt.m_V = (int?)xml.Attribute("V");
			_tt.m_actfn = (int?)xml.Attribute("actfn");
			_tt.m_addr = (int?)xml.Attribute("addr");
			_tt.m_addr0 = (int?)xml.Attribute("addr0");
			_tt.m_addr1 = (int?)xml.Attribute("addr1");
			_tt.m_addr2 = (int?)xml.Attribute("addr2");
			_tt.m_addr3 = (int?)xml.Attribute("addr3");
			_tt.m_addr4 = (int?)xml.Attribute("addr4");
			_tt.m_addr5 = (int?)xml.Attribute("addr5");
			_tt.m_addr6 = (int?)xml.Attribute("addr6");
			_tt.m_b0sen = (string)xml.Attribute("b0sen");
			_tt.m_b1sen = (string)xml.Attribute("b1sen");
			_tt.m_b2sen = (string)xml.Attribute("b2sen");
			_tt.m_b3sen = (string)xml.Attribute("b3sen");
			_tt.m_bit0cmd = (int?)xml.Attribute("bit0cmd");
			_tt.m_bit1cmd = (int?)xml.Attribute("bit1cmd");
			_tt.m_bit2cmd = (int?)xml.Attribute("bit2cmd");
			_tt.m_bit3cmd = (int?)xml.Attribute("bit3cmd");
			_tt.m_bit4cmd = (int?)xml.Attribute("bit4cmd");
			_tt.m_bit5cmd = (int?)xml.Attribute("bit5cmd");
			_tt.m_bridgepos = (int?)xml.Attribute("bridgepos");
			_tt.m_bus = (int?)xml.Attribute("bus");
			_tt.m_cmd = (string)xml.Attribute("cmd");
			_tt.m_delay = (int?)xml.Attribute("delay");
			_tt.m_desc = (string)xml.Attribute("desc");
			_tt.m_diraddr = (int?)xml.Attribute("diraddr");
			_tt.m_embeddedblock = (bool?)xml.Attribute("embeddedblock");
			_tt.m_entering = (bool?)xml.Attribute("entering");
			_tt.m_fun = (int?)xml.Attribute("fun");
			_tt.m_id = (string)xml.Attribute("id");
			_tt.m_iid = (string)xml.Attribute("iid");
			_tt.m_inv = (bool?)xml.Attribute("inv");
			_tt.m_invnew = (bool?)xml.Attribute("invnew");
			_tt.m_invpos = (bool?)xml.Attribute("invpos");
			_tt.m_lightsfn = (int?)xml.Attribute("lightsfn");
			_tt.m_locid = (string)xml.Attribute("locid");
			_tt.m_manager = (bool?)xml.Attribute("manager");
			_tt.m_motoroffdelay = (int?)xml.Attribute("motoroffdelay");
			_tt.m_oid = (string)xml.Attribute("oid");
			_tt.m_pause = (int?)xml.Attribute("pause");
			_tt.m_poladdr = (int?)xml.Attribute("poladdr");
			_tt.m_port0 = (int?)xml.Attribute("port0");
			_tt.m_port1 = (int?)xml.Attribute("port1");
			_tt.m_port2 = (int?)xml.Attribute("port2");
			_tt.m_port3 = (int?)xml.Attribute("port3");
			_tt.m_port4 = (int?)xml.Attribute("port4");
			_tt.m_port5 = (int?)xml.Attribute("port5");
			_tt.m_port6 = (int?)xml.Attribute("port6");
			_tt.m_prot = (string)xml.Attribute("prot");
			_tt.m_psen = (string)xml.Attribute("psen");
			_tt.m_reserved = (bool?)xml.Attribute("reserved");
			_tt.m_resetaddr = (int?)xml.Attribute("resetaddr");
			_tt.m_resetbitcmd = (int?)xml.Attribute("resetbitcmd");
			_tt.m_resetport = (int?)xml.Attribute("resetport");
			_tt.m_s1 = (string)xml.Attribute("s1");
			_tt.m_s2 = (string)xml.Attribute("s2");
			_tt.m_sMid = (string)xml.Attribute("sMid");
			_tt.m_sMid2 = (string)xml.Attribute("sMid2");
			_tt.m_singlegatenew = (bool?)xml.Attribute("singlegatenew");
			_tt.m_singlegatepos = (bool?)xml.Attribute("singlegatepos");
			_tt.m_state = (string)xml.Attribute("state");
			_tt.m_state1 = (bool?)xml.Attribute("state1");
			_tt.m_state2 = (bool?)xml.Attribute("state2");
			_tt.m_stateMid = (bool?)xml.Attribute("stateMid");
			_tt.m_stateMid2 = (bool?)xml.Attribute("stateMid2");
			_tt.m_swaprotation = (bool?)xml.Attribute("swaprotation");
			_tt.m_swcmd = (bool?)xml.Attribute("swcmd");
			_tt.m_symbolsize = (int?)xml.Attribute("symbolsize");
			_tt.m_traverser = (bool?)xml.Attribute("traverser");
			_tt.m_type = (string)xml.Attribute("type");
			_tt.m_x = (int?)xml.Attribute("x");
			_tt.m_y = (int?)xml.Attribute("y");
			_tt.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_tt.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<track>(_tt.m_tracklist, xml, "track", track.Parse, rocrailClient);
			return _tt;
		}
		public void Update(tt element)
		{
			if(element.m_V.HasValue == true) this.V = element.V;
			if(element.m_actfn.HasValue == true) this.actfn = element.actfn;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_addr0.HasValue == true) this.addr0 = element.addr0;
			if(element.m_addr1.HasValue == true) this.addr1 = element.addr1;
			if(element.m_addr2.HasValue == true) this.addr2 = element.addr2;
			if(element.m_addr3.HasValue == true) this.addr3 = element.addr3;
			if(element.m_addr4.HasValue == true) this.addr4 = element.addr4;
			if(element.m_addr5.HasValue == true) this.addr5 = element.addr5;
			if(element.m_addr6.HasValue == true) this.addr6 = element.addr6;
			if(element.m_b0sen != null) this.b0sen = element.b0sen;
			if(element.m_b1sen != null) this.b1sen = element.b1sen;
			if(element.m_b2sen != null) this.b2sen = element.b2sen;
			if(element.m_b3sen != null) this.b3sen = element.b3sen;
			if(element.m_bit0cmd.HasValue == true) this.bit0cmd = element.bit0cmd;
			if(element.m_bit1cmd.HasValue == true) this.bit1cmd = element.bit1cmd;
			if(element.m_bit2cmd.HasValue == true) this.bit2cmd = element.bit2cmd;
			if(element.m_bit3cmd.HasValue == true) this.bit3cmd = element.bit3cmd;
			if(element.m_bit4cmd.HasValue == true) this.bit4cmd = element.bit4cmd;
			if(element.m_bit5cmd.HasValue == true) this.bit5cmd = element.bit5cmd;
			if(element.m_bridgepos.HasValue == true) this.bridgepos = element.bridgepos;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_diraddr.HasValue == true) this.diraddr = element.diraddr;
			if(element.m_embeddedblock.HasValue == true) this.embeddedblock = element.embeddedblock;
			if(element.m_entering.HasValue == true) this.entering = element.entering;
			if(element.m_fun.HasValue == true) this.fun = element.fun;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_invnew.HasValue == true) this.invnew = element.invnew;
			if(element.m_invpos.HasValue == true) this.invpos = element.invpos;
			if(element.m_lightsfn.HasValue == true) this.lightsfn = element.lightsfn;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_manager.HasValue == true) this.manager = element.manager;
			if(element.m_motoroffdelay.HasValue == true) this.motoroffdelay = element.motoroffdelay;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_pause.HasValue == true) this.pause = element.pause;
			if(element.m_poladdr.HasValue == true) this.poladdr = element.poladdr;
			if(element.m_port0.HasValue == true) this.port0 = element.port0;
			if(element.m_port1.HasValue == true) this.port1 = element.port1;
			if(element.m_port2.HasValue == true) this.port2 = element.port2;
			if(element.m_port3.HasValue == true) this.port3 = element.port3;
			if(element.m_port4.HasValue == true) this.port4 = element.port4;
			if(element.m_port5.HasValue == true) this.port5 = element.port5;
			if(element.m_port6.HasValue == true) this.port6 = element.port6;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_psen != null) this.psen = element.psen;
			if(element.m_reserved.HasValue == true) this.reserved = element.reserved;
			if(element.m_resetaddr.HasValue == true) this.resetaddr = element.resetaddr;
			if(element.m_resetbitcmd.HasValue == true) this.resetbitcmd = element.resetbitcmd;
			if(element.m_resetport.HasValue == true) this.resetport = element.resetport;
			if(element.m_s1 != null) this.s1 = element.s1;
			if(element.m_s2 != null) this.s2 = element.s2;
			if(element.m_sMid != null) this.sMid = element.sMid;
			if(element.m_sMid2 != null) this.sMid2 = element.sMid2;
			if(element.m_singlegatenew.HasValue == true) this.singlegatenew = element.singlegatenew;
			if(element.m_singlegatepos.HasValue == true) this.singlegatepos = element.singlegatepos;
			if(element.m_state != null) this.state = element.state;
			if(element.m_state1.HasValue == true) this.state1 = element.state1;
			if(element.m_state2.HasValue == true) this.state2 = element.state2;
			if(element.m_stateMid.HasValue == true) this.stateMid = element.stateMid;
			if(element.m_stateMid2.HasValue == true) this.stateMid2 = element.stateMid2;
			if(element.m_swaprotation.HasValue == true) this.swaprotation = element.swaprotation;
			if(element.m_swcmd.HasValue == true) this.swcmd = element.swcmd;
			if(element.m_symbolsize.HasValue == true) this.symbolsize = element.symbolsize;
			if(element.m_traverser.HasValue == true) this.traverser = element.traverser;
			if(element.m_type != null) this.type = element.type;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;
			this.tracklist = element.tracklist;
		}
	}
}
