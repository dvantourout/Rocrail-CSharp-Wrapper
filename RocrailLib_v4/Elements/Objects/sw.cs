using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sw : CRocrailElements
	{
		public const string ACCESSORY = "accessory";
		public const string CCROSSING = "ccrossing";
		public const string CROSSING = "crossing";
		public const string DCROSSING = "dcrossing";
		public const string DECOUPLER = "decoupler";
		public const string FLIP = "flip";
		public const string LEFT = "left";
		public const string PROT_DEF = "D";
		public const string PROT_DO = "do";
		public const string PROT_M = "M";
		public const string PROT_MDD = "mdd";
		public const string PROT_N = "N";
		public const string PROT_OM32 = "om32";
		public const string PROT_VO = "vo";
		public const string RIGHT = "right";
		public const string STRAIGHT = "straight";
		public const string SUBLEFT = "subleft";
		public const string SUBRIGHT = "subright";
		public const string SWTYPE_DEFAULT = "default";
		public const string SWTYPE_RASTER = "raster";
		public const string TESTOFF = "testoff";
		public const string TESTON = "teston";
		public const string THREEWAY = "threeway";
		public const string TURNOUT = "turnout";
		public const string TWOWAY = "twoway";
		public const string UNLOCK = "unlock";
		public const string UNLOCKED = "-unlocked-";
		private bool? m_accessory;
		private int? m_accnr;
		private bool? m_actdelay;
		private bool? m_activate;
		private int? m_addr0pol1;
		private int? m_addr0pol2;
		private int? m_addr1;
		private int? m_addr1pol1;
		private int? m_addr1pol2;
		private int? m_addr2;
		private string m_blockid;
		private int? m_bus;
		private int? m_buspol;
		private string m_cmd;
		private int? m_cmd_extra;
		public const string CMD_LCID = "NULL";
		private bool? m_cmd_update;
		private int? m_ctcaddr1;
		private int? m_ctcaddr2;
		private int? m_ctcaddrled1;
		private int? m_ctcaddrled2;
		private bool? m_ctcasswitchled1;
		private bool? m_ctcasswitchled2;
		private int? m_ctcbus1;
		private int? m_ctcbus2;
		private int? m_ctcbusled1;
		private int? m_ctcbusled2;
		private bool? m_ctccmdon1;
		private bool? m_ctccmdon2;
		private bool? m_ctcflip1;
		private bool? m_ctcflip2;
		private int? m_ctcgateled1;
		private int? m_ctcgateled2;
		private string m_ctciid1;
		private string m_ctciid2;
		private string m_ctciidled1;
		private string m_ctciidled2;
		private int? m_ctcportled1;
		private int? m_ctcportled2;
		private int? m_delay;
		private long? m_delaytime;
		private string m_desc;
		private bool? m_dir;
		private string m_fb2G;
		private bool? m_fb2Ginv;
		private string m_fb2R;
		private bool? m_fb2Rinv;
		private string m_fbG;
		private bool? m_fbGinv;
		private string m_fbOcc;
		private string m_fbOcc2;
		private string m_fbR;
		private bool? m_fbRinv;
		private bool? m_fbset;
		private bool? m_fbusefield;
		private string m_fieldstate;
		private bool? m_forcecmd;
		private bool? m_frogaccessory;
		private string m_frogiid;
		private int? m_frogporttype;
		private bool? m_frogswitch;
		private int? m_frogtimer;
		private int? m_gate0pol1;
		private int? m_gate0pol2;
		private int? m_gate1;
		private int? m_gate1pol1;
		private int? m_gate1pol2;
		private int? m_gate2;
		private int? m_gatevalue;
		
		private string m_iid;
		private bool? m_inv;
		private bool? m_inv2;
		private string m_locid;
		private bool? m_manualcmd;
		private string m_oid;
		private string m_ori;
		private int? m_param1;
		private int? m_param2;
		private int? m_pause;
		private int? m_port0pol1;
		private int? m_port0pol2;
		private int? m_port1;
		private int? m_port1pol1;
		private int? m_port1pol2;
		private int? m_port2;
		private int? m_porttype;
		private string m_prot;
		private bool? m_rectcrossing;
		private string m_savepos;
		private bool? m_set;
		private bool? m_show;
		private bool? m_singlegate;
		private string m_state;
		private string m_subtype;
		private int? m_switched;
		private string m_swtype;
		private bool? m_td;
		private int? m_tdaddr;
		private string m_tdiid;
		private int? m_tdport;
		private bool? m_testing;
		private string m_type;
		private int? m_value1;
		private int? m_value2;
		private bool? m_virtual;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<accessoryctrl> m_accessoryctrllist;
		private List<actionctrl> m_actionctrllist;
		/// <summary>
		/// 
		/// </summary>
		public bool accessory 
		{
			get { return this.m_accessory.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accessory, value, "accessory"); }
		}
		/// <summary>
		/// Accessory number.
		/// </summary>
		public int accnr 
		{
			get { return this.m_accnr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accnr, value, "accnr"); }
		}
		/// <summary>
		/// if false: delay is programmed in central unit or module
		/// </summary>
		public bool actdelay 
		{
			get { return this.m_actdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actdelay, value, "actdelay"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool activate 
		{
			get { return this.m_activate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_activate, value, "activate"); }
		}
		/// <summary>
		/// decoder address of the polarisation
		/// </summary>
		public int addr0pol1 
		{
			get { return this.m_addr0pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr0pol1, value, "addr0pol1"); }
		}
		/// <summary>
		/// decoder address of the polarisation
		/// </summary>
		public int addr0pol2 
		{
			get { return this.m_addr0pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr0pol2, value, "addr0pol2"); }
		}
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr1 
		{
			get { return this.m_addr1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr1, value, "addr1"); }
		}
		/// <summary>
		/// decoder address of the polarisation
		/// </summary>
		public int addr1pol1 
		{
			get { return this.m_addr1pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr1pol1, value, "addr1pol1"); }
		}
		/// <summary>
		/// decoder address of the polarisation
		/// </summary>
		public int addr1pol2 
		{
			get { return this.m_addr1pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr1pol2, value, "addr1pol2"); }
		}
		/// <summary>
		/// decoder address in case of type 3way
		/// </summary>
		public int addr2 
		{
			get { return this.m_addr2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr2, value, "addr2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string blockid 
		{
			get { return this.m_blockid; }
			private set { this.SetField(ref this.m_blockid, value, "blockid"); }
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
		public int buspol 
		{
			get { return this.m_buspol.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_buspol, value, "buspol"); }
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
		public int cmd_extra 
		{
			get { return this.m_cmd_extra.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmd_extra, value, "cmd_extra"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool cmd_update 
		{
			get { return this.m_cmd_update.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmd_update, value, "cmd_update"); }
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
		public int ctcaddrled1 
		{
			get { return this.m_ctcaddrled1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddrled1, value, "ctcaddrled1"); }
		}
		/// <summary>
		/// address
		/// </summary>
		public int ctcaddrled2 
		{
			get { return this.m_ctcaddrled2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddrled2, value, "ctcaddrled2"); }
		}
		/// <summary>
		/// send a switch command
		/// </summary>
		public bool ctcasswitchled1 
		{
			get { return this.m_ctcasswitchled1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcasswitchled1, value, "ctcasswitchled1"); }
		}
		/// <summary>
		/// send a switch command
		/// </summary>
		public bool ctcasswitchled2 
		{
			get { return this.m_ctcasswitchled2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcasswitchled2, value, "ctcasswitchled2"); }
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
		public int ctcbusled1 
		{
			get { return this.m_ctcbusled1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbusled1, value, "ctcbusled1"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int ctcbusled2 
		{
			get { return this.m_ctcbusled2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbusled2, value, "ctcbusled2"); }
		}
		/// <summary>
		/// Straight command at ON.
		/// </summary>
		public bool ctccmdon1 
		{
			get { return this.m_ctccmdon1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctccmdon1, value, "ctccmdon1"); }
		}
		/// <summary>
		/// Straight command at ON.
		/// </summary>
		public bool ctccmdon2 
		{
			get { return this.m_ctccmdon2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctccmdon2, value, "ctccmdon2"); }
		}
		/// <summary>
		/// Straight command at ON.
		/// </summary>
		public bool ctcflip1 
		{
			get { return this.m_ctcflip1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcflip1, value, "ctcflip1"); }
		}
		/// <summary>
		/// Straight command at ON.
		/// </summary>
		public bool ctcflip2 
		{
			get { return this.m_ctcflip2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcflip2, value, "ctcflip2"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int ctcgateled1 
		{
			get { return this.m_ctcgateled1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcgateled1, value, "ctcgateled1"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int ctcgateled2 
		{
			get { return this.m_ctcgateled2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcgateled2, value, "ctcgateled2"); }
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
		public string ctciidled1 
		{
			get { return this.m_ctciidled1; }
			private set { this.SetField(ref this.m_ctciidled1, value, "ctciidled1"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string ctciidled2 
		{
			get { return this.m_ctciidled2; }
			private set { this.SetField(ref this.m_ctciidled2, value, "ctciidled2"); }
		}
		/// <summary>
		/// port of decoder module: 0 = not used.
		/// </summary>
		public int ctcportled1 
		{
			get { return this.m_ctcportled1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcportled1, value, "ctcportled1"); }
		}
		/// <summary>
		/// port of decoder module: 0 = not used.
		/// </summary>
		public int ctcportled2 
		{
			get { return this.m_ctcportled2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcportled2, value, "ctcportled2"); }
		}
		/// <summary>
		/// overwrites control.swtimeout if greater then 0
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
		}
		/// <summary>
		/// Delay timer for internal use only.
		/// </summary>
		public long delaytime 
		{
			get { return this.m_delaytime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delaytime, value, "delaytime"); }
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
		/// false=left, true=right
		/// </summary>
		public bool dir 
		{
			get { return this.m_dir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dir, value, "dir"); }
		}
		/// <summary>
		/// Optional feedback for straigh(Green) state.
		/// </summary>
		public string fb2G 
		{
			get { return this.m_fb2G; }
			private set { this.SetField(ref this.m_fb2G, value, "fb2G"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fb2Ginv 
		{
			get { return this.m_fb2Ginv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fb2Ginv, value, "fb2Ginv"); }
		}
		/// <summary>
		/// Optional feedback for turnout(Red) state.
		/// </summary>
		public string fb2R 
		{
			get { return this.m_fb2R; }
			private set { this.SetField(ref this.m_fb2R, value, "fb2R"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fb2Rinv 
		{
			get { return this.m_fb2Rinv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fb2Rinv, value, "fb2Rinv"); }
		}
		/// <summary>
		/// Optional feedback for straigh(Green) state.
		/// </summary>
		public string fbG 
		{
			get { return this.m_fbG; }
			private set { this.SetField(ref this.m_fbG, value, "fbG"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fbGinv 
		{
			get { return this.m_fbGinv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbGinv, value, "fbGinv"); }
		}
		/// <summary>
		/// Optional feedback for occupancy to block commands.
		/// </summary>
		public string fbOcc 
		{
			get { return this.m_fbOcc; }
			private set { this.SetField(ref this.m_fbOcc, value, "fbOcc"); }
		}
		/// <summary>
		/// Optional feedback for occupancy to block commands.
		/// </summary>
		public string fbOcc2 
		{
			get { return this.m_fbOcc2; }
			private set { this.SetField(ref this.m_fbOcc2, value, "fbOcc2"); }
		}
		/// <summary>
		/// Optional feedback for turnout(Red) state.
		/// </summary>
		public string fbR 
		{
			get { return this.m_fbR; }
			private set { this.SetField(ref this.m_fbR, value, "fbR"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fbRinv 
		{
			get { return this.m_fbRinv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbRinv, value, "fbRinv"); }
		}
		/// <summary>
		/// Feedback sets the switch unconditional.
		/// </summary>
		public bool fbset 
		{
			get { return this.m_fbset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbset, value, "fbset"); }
		}
		/// <summary>
		/// Use field events as feedback.
		/// </summary>
		public bool fbusefield 
		{
			get { return this.m_fbusefield.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbusefield, value, "fbusefield"); }
		}
		/// <summary>
		/// Current reported state of switch.
		/// </summary>
		public string fieldstate 
		{
			get { return this.m_fieldstate; }
			private set { this.SetField(ref this.m_fieldstate, value, "fieldstate"); }
		}
		/// <summary>
		/// Force command.
		/// </summary>
		public bool forcecmd 
		{
			get { return this.m_forcecmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_forcecmd, value, "forcecmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool frogaccessory 
		{
			get { return this.m_frogaccessory.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_frogaccessory, value, "frogaccessory"); }
		}
		/// <summary>
		/// Interface ID
		/// </summary>
		public string frogiid 
		{
			get { return this.m_frogiid; }
			private set { this.SetField(ref this.m_frogiid, value, "frogiid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int frogporttype 
		{
			get { return this.m_frogporttype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_frogporttype, value, "frogporttype"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool frogswitch 
		{
			get { return this.m_frogswitch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_frogswitch, value, "frogswitch"); }
		}
		/// <summary>
		/// If set to zero the wiring event is used.
		/// </summary>
		public int frogtimer 
		{
			get { return this.m_frogtimer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_frogtimer, value, "frogtimer"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate0pol1 
		{
			get { return this.m_gate0pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate0pol1, value, "gate0pol1"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate0pol2 
		{
			get { return this.m_gate0pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate0pol2, value, "gate0pol2"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate1 
		{
			get { return this.m_gate1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate1, value, "gate1"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate1pol1 
		{
			get { return this.m_gate1pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate1pol1, value, "gate1pol1"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate1pol2 
		{
			get { return this.m_gate1pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate1pol2, value, "gate1pol2"); }
		}
		/// <summary>
		/// Only in case of type 3way.
		/// </summary>
		public int gate2 
		{
			get { return this.m_gate2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate2, value, "gate2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int gatevalue 
		{
			get { return this.m_gatevalue.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gatevalue, value, "gatevalue"); }
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
		/// Switch inverted. (Software wiring correction)
		/// </summary>
		public bool inv 
		{
			get { return this.m_inv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv, value, "inv"); }
		}
		/// <summary>
		/// Switch inverted. (Software wiring correction)
		/// </summary>
		public bool inv2 
		{
			get { return this.m_inv2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv2, value, "inv2"); }
		}
		/// <summary>
		/// The loc who locked this switch.
		/// </summary>
		public string locid 
		{
			get { return this.m_locid; }
			private set { this.SetField(ref this.m_locid, value, "locid"); }
		}
		/// <summary>
		/// Manual command issued from a client.
		/// </summary>
		public bool manualcmd 
		{
			get { return this.m_manualcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manualcmd, value, "manualcmd"); }
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
		/// Orientation in the plan.
		/// </summary>
		public string ori 
		{
			get { return this.m_ori; }
			private set { this.SetField(ref this.m_ori, value, "ori"); }
		}
		/// <summary>
		/// parameter
		/// </summary>
		public int param1 
		{
			get { return this.m_param1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_param1, value, "param1"); }
		}
		/// <summary>
		/// parameter
		/// </summary>
		public int param2 
		{
			get { return this.m_param2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_param2, value, "param2"); }
		}
		/// <summary>
		/// Pause ms before executing command.
		/// </summary>
		public int pause 
		{
			get { return this.m_pause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pause, value, "pause"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port0pol1 
		{
			get { return this.m_port0pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port0pol1, value, "port0pol1"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port0pol2 
		{
			get { return this.m_port0pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port0pol2, value, "port0pol2"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port1 
		{
			get { return this.m_port1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port1, value, "port1"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port1pol1 
		{
			get { return this.m_port1pol1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port1pol1, value, "port1pol1"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port1pol2 
		{
			get { return this.m_port1pol2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port1pol2, value, "port1pol2"); }
		}
		/// <summary>
		/// Only in case of type 3way.
		/// </summary>
		public int port2 
		{
			get { return this.m_port2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port2, value, "port2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int porttype 
		{
			get { return this.m_porttype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_porttype, value, "porttype"); }
		}
		/// <summary>
		/// Protocol to use for this output.
		/// </summary>
		public string prot 
		{
			get { return this.m_prot; }
			private set { this.SetField(ref this.m_prot, value, "prot"); }
		}
		/// <summary>
		/// Crossing without motor as rectangular crossing.
		/// </summary>
		public bool rectcrossing 
		{
			get { return this.m_rectcrossing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rectcrossing, value, "rectcrossing"); }
		}
		/// <summary>
		/// save position of switch
		/// </summary>
		public string savepos 
		{
			get { return this.m_savepos; }
			private set { this.SetField(ref this.m_savepos, value, "savepos"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool @set 
		{
			get { return this.m_set.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_set, value, "@set"); }
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
		/// 
		/// </summary>
		public bool singlegate 
		{
			get { return this.m_singlegate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_singlegate, value, "singlegate"); }
		}
		/// <summary>
		/// Current state of switch.
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string subtype 
		{
			get { return this.m_subtype; }
			private set { this.SetField(ref this.m_subtype, value, "subtype"); }
		}
		/// <summary>
		/// Number of switch commands.
		/// </summary>
		public int switched 
		{
			get { return this.m_switched.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_switched, value, "switched"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string swtype 
		{
			get { return this.m_swtype; }
			private set { this.SetField(ref this.m_swtype, value, "swtype"); }
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
		/// TD address
		/// </summary>
		public int tdaddr 
		{
			get { return this.m_tdaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tdaddr, value, "tdaddr"); }
		}
		/// <summary>
		/// TD interface id
		/// </summary>
		public string tdiid 
		{
			get { return this.m_tdiid; }
			private set { this.SetField(ref this.m_tdiid, value, "tdiid"); }
		}
		/// <summary>
		/// TD output port
		/// </summary>
		public int tdport 
		{
			get { return this.m_tdport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tdport, value, "tdport"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool testing 
		{
			get { return this.m_testing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_testing, value, "testing"); }
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
		/// value
		/// </summary>
		public int value1 
		{
			get { return this.m_value1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value1, value, "value1"); }
		}
		/// <summary>
		/// value
		/// </summary>
		public int value2 
		{
			get { return this.m_value2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value2, value, "value2"); }
		}
		/// <summary>
		/// If this object is only used for dispatching commands.
		/// </summary>
		public bool @virtual 
		{
			get { return this.m_virtual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_virtual, value, "@virtual"); }
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
		/// <summary>
		/// 
		/// </summary>
		public List<accessoryctrl> accessoryctrllist 
		{
			get { return this.m_accessoryctrllist; }
			private set { this.SetField(ref this.m_accessoryctrllist, value, "accessoryctrllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}

        private string m_routeids;
        public string routeids
        {
            get { return this.m_routeids; }
            private set { this.SetField(ref this.m_routeids, value, "routeids"); }
        }

		public sw()
		{
			this.m_accessoryctrllist = new List<accessoryctrl>();
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static sw Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sw _sw = new sw();
			_sw.m_rocrailClient = rocrailClient;
			_sw.m_accessory = (bool?)xml.Attribute("accessory");
			_sw.m_accnr = (int?)xml.Attribute("accnr");
			_sw.m_actdelay = (bool?)xml.Attribute("actdelay");
			_sw.m_activate = (bool?)xml.Attribute("activate");
			_sw.m_addr0pol1 = (int?)xml.Attribute("addr0pol1");
			_sw.m_addr0pol2 = (int?)xml.Attribute("addr0pol2");
			_sw.m_addr1 = (int?)xml.Attribute("addr1");
			_sw.m_addr1pol1 = (int?)xml.Attribute("addr1pol1");
			_sw.m_addr1pol2 = (int?)xml.Attribute("addr1pol2");
			_sw.m_addr2 = (int?)xml.Attribute("addr2");
			_sw.m_blockid = (string)xml.Attribute("blockid");
			_sw.m_bus = (int?)xml.Attribute("bus");
			_sw.m_buspol = (int?)xml.Attribute("buspol");
			_sw.m_cmd = (string)xml.Attribute("cmd");
			_sw.m_cmd_extra = (int?)xml.Attribute("cmd_extra");
			_sw.m_cmd_update = (bool?)xml.Attribute("cmd_update");
			_sw.m_ctcaddr1 = (int?)xml.Attribute("ctcaddr1");
			_sw.m_ctcaddr2 = (int?)xml.Attribute("ctcaddr2");
			_sw.m_ctcaddrled1 = (int?)xml.Attribute("ctcaddrled1");
			_sw.m_ctcaddrled2 = (int?)xml.Attribute("ctcaddrled2");
			_sw.m_ctcasswitchled1 = (bool?)xml.Attribute("ctcasswitchled1");
			_sw.m_ctcasswitchled2 = (bool?)xml.Attribute("ctcasswitchled2");
			_sw.m_ctcbus1 = (int?)xml.Attribute("ctcbus1");
			_sw.m_ctcbus2 = (int?)xml.Attribute("ctcbus2");
			_sw.m_ctcbusled1 = (int?)xml.Attribute("ctcbusled1");
			_sw.m_ctcbusled2 = (int?)xml.Attribute("ctcbusled2");
			_sw.m_ctccmdon1 = (bool?)xml.Attribute("ctccmdon1");
			_sw.m_ctccmdon2 = (bool?)xml.Attribute("ctccmdon2");
			_sw.m_ctcflip1 = (bool?)xml.Attribute("ctcflip1");
			_sw.m_ctcflip2 = (bool?)xml.Attribute("ctcflip2");
			_sw.m_ctcgateled1 = (int?)xml.Attribute("ctcgateled1");
			_sw.m_ctcgateled2 = (int?)xml.Attribute("ctcgateled2");
			_sw.m_ctciid1 = (string)xml.Attribute("ctciid1");
			_sw.m_ctciid2 = (string)xml.Attribute("ctciid2");
			_sw.m_ctciidled1 = (string)xml.Attribute("ctciidled1");
			_sw.m_ctciidled2 = (string)xml.Attribute("ctciidled2");
			_sw.m_ctcportled1 = (int?)xml.Attribute("ctcportled1");
			_sw.m_ctcportled2 = (int?)xml.Attribute("ctcportled2");
			_sw.m_delay = (int?)xml.Attribute("delay");
			_sw.m_delaytime = (long?)xml.Attribute("delaytime");
			_sw.m_desc = (string)xml.Attribute("desc");
			_sw.m_dir = (bool?)xml.Attribute("dir");
			_sw.m_fb2G = (string)xml.Attribute("fb2G");
			_sw.m_fb2Ginv = (bool?)xml.Attribute("fb2Ginv");
			_sw.m_fb2R = (string)xml.Attribute("fb2R");
			_sw.m_fb2Rinv = (bool?)xml.Attribute("fb2Rinv");
			_sw.m_fbG = (string)xml.Attribute("fbG");
			_sw.m_fbGinv = (bool?)xml.Attribute("fbGinv");
			_sw.m_fbOcc = (string)xml.Attribute("fbOcc");
			_sw.m_fbOcc2 = (string)xml.Attribute("fbOcc2");
			_sw.m_fbR = (string)xml.Attribute("fbR");
			_sw.m_fbRinv = (bool?)xml.Attribute("fbRinv");
			_sw.m_fbset = (bool?)xml.Attribute("fbset");
			_sw.m_fbusefield = (bool?)xml.Attribute("fbusefield");
			_sw.m_fieldstate = (string)xml.Attribute("fieldstate");
			_sw.m_forcecmd = (bool?)xml.Attribute("forcecmd");
			_sw.m_frogaccessory = (bool?)xml.Attribute("frogaccessory");
			_sw.m_frogiid = (string)xml.Attribute("frogiid");
			_sw.m_frogporttype = (int?)xml.Attribute("frogporttype");
			_sw.m_frogswitch = (bool?)xml.Attribute("frogswitch");
			_sw.m_frogtimer = (int?)xml.Attribute("frogtimer");
			_sw.m_gate0pol1 = (int?)xml.Attribute("gate0pol1");
			_sw.m_gate0pol2 = (int?)xml.Attribute("gate0pol2");
			_sw.m_gate1 = (int?)xml.Attribute("gate1");
			_sw.m_gate1pol1 = (int?)xml.Attribute("gate1pol1");
			_sw.m_gate1pol2 = (int?)xml.Attribute("gate1pol2");
			_sw.m_gate2 = (int?)xml.Attribute("gate2");
			_sw.m_gatevalue = (int?)xml.Attribute("gatevalue");
			_sw.m_id = (string)xml.Attribute("id");
			_sw.m_iid = (string)xml.Attribute("iid");
			_sw.m_inv = (bool?)xml.Attribute("inv");
			_sw.m_inv2 = (bool?)xml.Attribute("inv2");
			_sw.m_locid = (string)xml.Attribute("locid");
			_sw.m_manualcmd = (bool?)xml.Attribute("manualcmd");
			_sw.m_oid = (string)xml.Attribute("oid");
			_sw.m_ori = (string)xml.Attribute("ori");
			_sw.m_param1 = (int?)xml.Attribute("param1");
			_sw.m_param2 = (int?)xml.Attribute("param2");
			_sw.m_pause = (int?)xml.Attribute("pause");
			_sw.m_port0pol1 = (int?)xml.Attribute("port0pol1");
			_sw.m_port0pol2 = (int?)xml.Attribute("port0pol2");
			_sw.m_port1 = (int?)xml.Attribute("port1");
			_sw.m_port1pol1 = (int?)xml.Attribute("port1pol1");
			_sw.m_port1pol2 = (int?)xml.Attribute("port1pol2");
			_sw.m_port2 = (int?)xml.Attribute("port2");
			_sw.m_porttype = (int?)xml.Attribute("porttype");
			_sw.m_prot = (string)xml.Attribute("prot");
			_sw.m_rectcrossing = (bool?)xml.Attribute("rectcrossing");
			_sw.m_savepos = (string)xml.Attribute("savepos");
			_sw.m_set = (bool?)xml.Attribute("set");
			_sw.m_show = (bool?)xml.Attribute("show");
			_sw.m_singlegate = (bool?)xml.Attribute("singlegate");
			_sw.m_state = (string)xml.Attribute("state");
			_sw.m_subtype = (string)xml.Attribute("subtype");
			_sw.m_switched = (int?)xml.Attribute("switched");
			_sw.m_swtype = (string)xml.Attribute("swtype");
			_sw.m_td = (bool?)xml.Attribute("td");
			_sw.m_tdaddr = (int?)xml.Attribute("tdaddr");
			_sw.m_tdiid = (string)xml.Attribute("tdiid");
			_sw.m_tdport = (int?)xml.Attribute("tdport");
			_sw.m_testing = (bool?)xml.Attribute("testing");
			_sw.m_type = (string)xml.Attribute("type");
			_sw.m_value1 = (int?)xml.Attribute("value1");
			_sw.m_value2 = (int?)xml.Attribute("value2");
			_sw.m_virtual = (bool?)xml.Attribute("virtual");
			_sw.m_x = (int?)xml.Attribute("x");
			_sw.m_y = (int?)xml.Attribute("y");
			_sw.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<accessoryctrl>(_sw.m_accessoryctrllist, xml, "accessoryctrl", accessoryctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<actionctrl>(_sw.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);

            _sw.m_routeids = (string)xml.Attribute("routeids");

			return _sw;
		}
		public void Update(sw element)
		{
			if(element.m_accessory.HasValue == true) this.accessory = element.accessory;
			if(element.m_accnr.HasValue == true) this.accnr = element.accnr;
			if(element.m_actdelay.HasValue == true) this.actdelay = element.actdelay;
			if(element.m_activate.HasValue == true) this.activate = element.activate;
			if(element.m_addr0pol1.HasValue == true) this.addr0pol1 = element.addr0pol1;
			if(element.m_addr0pol2.HasValue == true) this.addr0pol2 = element.addr0pol2;
			if(element.m_addr1.HasValue == true) this.addr1 = element.addr1;
			if(element.m_addr1pol1.HasValue == true) this.addr1pol1 = element.addr1pol1;
			if(element.m_addr1pol2.HasValue == true) this.addr1pol2 = element.addr1pol2;
			if(element.m_addr2.HasValue == true) this.addr2 = element.addr2;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_buspol.HasValue == true) this.buspol = element.buspol;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_cmd_extra.HasValue == true) this.cmd_extra = element.cmd_extra;
			if(element.m_cmd_update.HasValue == true) this.cmd_update = element.cmd_update;
			if(element.m_ctcaddr1.HasValue == true) this.ctcaddr1 = element.ctcaddr1;
			if(element.m_ctcaddr2.HasValue == true) this.ctcaddr2 = element.ctcaddr2;
			if(element.m_ctcaddrled1.HasValue == true) this.ctcaddrled1 = element.ctcaddrled1;
			if(element.m_ctcaddrled2.HasValue == true) this.ctcaddrled2 = element.ctcaddrled2;
			if(element.m_ctcasswitchled1.HasValue == true) this.ctcasswitchled1 = element.ctcasswitchled1;
			if(element.m_ctcasswitchled2.HasValue == true) this.ctcasswitchled2 = element.ctcasswitchled2;
			if(element.m_ctcbus1.HasValue == true) this.ctcbus1 = element.ctcbus1;
			if(element.m_ctcbus2.HasValue == true) this.ctcbus2 = element.ctcbus2;
			if(element.m_ctcbusled1.HasValue == true) this.ctcbusled1 = element.ctcbusled1;
			if(element.m_ctcbusled2.HasValue == true) this.ctcbusled2 = element.ctcbusled2;
			if(element.m_ctccmdon1.HasValue == true) this.ctccmdon1 = element.ctccmdon1;
			if(element.m_ctccmdon2.HasValue == true) this.ctccmdon2 = element.ctccmdon2;
			if(element.m_ctcflip1.HasValue == true) this.ctcflip1 = element.ctcflip1;
			if(element.m_ctcflip2.HasValue == true) this.ctcflip2 = element.ctcflip2;
			if(element.m_ctcgateled1.HasValue == true) this.ctcgateled1 = element.ctcgateled1;
			if(element.m_ctcgateled2.HasValue == true) this.ctcgateled2 = element.ctcgateled2;
			if(element.m_ctciid1 != null) this.ctciid1 = element.ctciid1;
			if(element.m_ctciid2 != null) this.ctciid2 = element.ctciid2;
			if(element.m_ctciidled1 != null) this.ctciidled1 = element.ctciidled1;
			if(element.m_ctciidled2 != null) this.ctciidled2 = element.ctciidled2;
			if(element.m_ctcportled1.HasValue == true) this.ctcportled1 = element.ctcportled1;
			if(element.m_ctcportled2.HasValue == true) this.ctcportled2 = element.ctcportled2;
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_delaytime.HasValue == true) this.delaytime = element.delaytime;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_dir.HasValue == true) this.dir = element.dir;
			if(element.m_fb2G != null) this.fb2G = element.fb2G;
			if(element.m_fb2Ginv.HasValue == true) this.fb2Ginv = element.fb2Ginv;
			if(element.m_fb2R != null) this.fb2R = element.fb2R;
			if(element.m_fb2Rinv.HasValue == true) this.fb2Rinv = element.fb2Rinv;
			if(element.m_fbG != null) this.fbG = element.fbG;
			if(element.m_fbGinv.HasValue == true) this.fbGinv = element.fbGinv;
			if(element.m_fbOcc != null) this.fbOcc = element.fbOcc;
			if(element.m_fbOcc2 != null) this.fbOcc2 = element.fbOcc2;
			if(element.m_fbR != null) this.fbR = element.fbR;
			if(element.m_fbRinv.HasValue == true) this.fbRinv = element.fbRinv;
			if(element.m_fbset.HasValue == true) this.fbset = element.fbset;
			if(element.m_fbusefield.HasValue == true) this.fbusefield = element.fbusefield;
			if(element.m_fieldstate != null) this.fieldstate = element.fieldstate;
			if(element.m_forcecmd.HasValue == true) this.forcecmd = element.forcecmd;
			if(element.m_frogaccessory.HasValue == true) this.frogaccessory = element.frogaccessory;
			if(element.m_frogiid != null) this.frogiid = element.frogiid;
			if(element.m_frogporttype.HasValue == true) this.frogporttype = element.frogporttype;
			if(element.m_frogswitch.HasValue == true) this.frogswitch = element.frogswitch;
			if(element.m_frogtimer.HasValue == true) this.frogtimer = element.frogtimer;
			if(element.m_gate0pol1.HasValue == true) this.gate0pol1 = element.gate0pol1;
			if(element.m_gate0pol2.HasValue == true) this.gate0pol2 = element.gate0pol2;
			if(element.m_gate1.HasValue == true) this.gate1 = element.gate1;
			if(element.m_gate1pol1.HasValue == true) this.gate1pol1 = element.gate1pol1;
			if(element.m_gate1pol2.HasValue == true) this.gate1pol2 = element.gate1pol2;
			if(element.m_gate2.HasValue == true) this.gate2 = element.gate2;
			if(element.m_gatevalue.HasValue == true) this.gatevalue = element.gatevalue;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_inv2.HasValue == true) this.inv2 = element.inv2;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_manualcmd.HasValue == true) this.manualcmd = element.manualcmd;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_param1.HasValue == true) this.param1 = element.param1;
			if(element.m_param2.HasValue == true) this.param2 = element.param2;
			if(element.m_pause.HasValue == true) this.pause = element.pause;
			if(element.m_port0pol1.HasValue == true) this.port0pol1 = element.port0pol1;
			if(element.m_port0pol2.HasValue == true) this.port0pol2 = element.port0pol2;
			if(element.m_port1.HasValue == true) this.port1 = element.port1;
			if(element.m_port1pol1.HasValue == true) this.port1pol1 = element.port1pol1;
			if(element.m_port1pol2.HasValue == true) this.port1pol2 = element.port1pol2;
			if(element.m_port2.HasValue == true) this.port2 = element.port2;
			if(element.m_porttype.HasValue == true) this.porttype = element.porttype;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_rectcrossing.HasValue == true) this.rectcrossing = element.rectcrossing;
			if(element.m_savepos != null) this.savepos = element.savepos;
			if(element.m_set.HasValue == true) this.@set = element.@set;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_singlegate.HasValue == true) this.singlegate = element.singlegate;
			if(element.m_state != null) this.state = element.state;
			if(element.m_subtype != null) this.subtype = element.subtype;
			if(element.m_switched.HasValue == true) this.switched = element.switched;
			if(element.m_swtype != null) this.swtype = element.swtype;
			if(element.m_td.HasValue == true) this.td = element.td;
			if(element.m_tdaddr.HasValue == true) this.tdaddr = element.tdaddr;
			if(element.m_tdiid != null) this.tdiid = element.tdiid;
			if(element.m_tdport.HasValue == true) this.tdport = element.tdport;
			if(element.m_testing.HasValue == true) this.testing = element.testing;
			if(element.m_type != null) this.type = element.type;
			if(element.m_value1.HasValue == true) this.value1 = element.value1;
			if(element.m_value2.HasValue == true) this.value2 = element.value2;
			if(element.m_virtual.HasValue == true) this.@virtual = element.@virtual;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.accessoryctrllist = element.accessoryctrllist;
			this.actionctrllist = element.actionctrllist;

            if (element.m_routeids != null) this.routeids = element.routeids;
		}
        public void TurnOut()
        {
            string sTrameCmd = "<sw id=\"" + this.id + "\" cmd=\"turnout\" manualcmd=\"true\"/>\"";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void Straight()
        {
            string sTrameCmd = "<sw id=\"" + this.id + "\" cmd=\"straight\" manualcmd=\"true\"/>\"";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void Flip()
        {
            string sTrameCmd = "<sw id=\"" + this.id + "\" cmd=\"flip\" manualcmd=\"true\"/>\"";
            this.m_rocrailClient.Send(sTrameCmd);
        }
	}
}
