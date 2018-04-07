using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class seltab : CRocrailElements
	{
		public const string GOTOPOS = "gotopos";
		public const string NEXT = "next";
		public const string PREV = "prev";
		public const string PROT_DEF = "D";
		public const string PROT_M = "M";
		public const string PROT_MP = "MP";
		public const string PROT_N = "N";
		private int? m_addr0;
		private int? m_addr1;
		private int? m_addr2;
		private int? m_addr3;
		private int? m_addr4;
		private int? m_addr5;
		private int? m_addr6;
		private int? m_addr7;
		private string m_b0sen;
		private string m_b1sen;
		private string m_b2sen;
		private string m_b3sen;
		private string m_b4sen;
		private string m_b5sen;
		private string m_b6sen;
		private int? m_bus;
		private string m_cmd;
		private string m_desc;
		private bool? m_fifo;
		
		private string m_iid;
		private bool? m_inv;
		private bool? m_invnew;
		private string m_locid;
		private bool? m_manager;
		private int? m_minocc;
		private int? m_movedelay;
		private int? m_nrtracks;
		private int? m_offpos;
		private string m_ori;
		private bool? m_pending;
		private int? m_port0;
		private int? m_port1;
		private int? m_port2;
		private int? m_port3;
		private int? m_port4;
		private int? m_port5;
		private int? m_port6;
		private int? m_port7;
		private int? m_pos;
		private string m_prot;
		private string m_psen;
		private bool? m_sharedfb;
		private bool? m_singlegate;
		private string m_state;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<fbevent> m_fbeventlist;
		private List<seltabpos> m_seltabposlist;
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr0 
		{
			get { return this.m_addr0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr0, value, "addr0"); }
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
		/// decoder address
		/// </summary>
		public int addr2 
		{
			get { return this.m_addr2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr2, value, "addr2"); }
		}
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr3 
		{
			get { return this.m_addr3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr3, value, "addr3"); }
		}
		/// <summary>
		/// decoder address to signal new position
		/// </summary>
		public int addr4 
		{
			get { return this.m_addr4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr4, value, "addr4"); }
		}
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr5 
		{
			get { return this.m_addr5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr5, value, "addr5"); }
		}
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr6 
		{
			get { return this.m_addr6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr6, value, "addr6"); }
		}
		/// <summary>
		/// decoder address
		/// </summary>
		public int addr7 
		{
			get { return this.m_addr7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr7, value, "addr7"); }
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
		/// ID bit 4 of position
		/// </summary>
		public string b4sen 
		{
			get { return this.m_b4sen; }
			private set { this.SetField(ref this.m_b4sen, value, "b4sen"); }
		}
		/// <summary>
		/// ID bit 5 of position
		/// </summary>
		public string b5sen 
		{
			get { return this.m_b5sen; }
			private set { this.SetField(ref this.m_b5sen, value, "b5sen"); }
		}
		/// <summary>
		/// ID bit 6 of position
		/// </summary>
		public string b6sen 
		{
			get { return this.m_b6sen; }
			private set { this.SetField(ref this.m_b6sen, value, "b6sen"); }
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
		/// description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Firts in, First out
		/// </summary>
		public bool fifo 
		{
			get { return this.m_fifo.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fifo, value, "fifo"); }
		}
		/// <summary>
		/// object id
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// interfaced id
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// invert the switch commands 0 to 3
		/// </summary>
		public bool inv 
		{
			get { return this.m_inv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv, value, "inv"); }
		}
		/// <summary>
		/// invert the switch command 4
		/// </summary>
		public bool invnew 
		{
			get { return this.m_invnew.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_invnew, value, "invnew"); }
		}
		/// <summary>
		/// loc id
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
		/// minimal tracks to be occupied before leaving the fiddle yard
		/// </summary>
		public int minocc 
		{
			get { return this.m_minocc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minocc, value, "minocc"); }
		}
		/// <summary>
		/// delay in seconds after an IN event before processing a new move
		/// </summary>
		public int movedelay 
		{
			get { return this.m_movedelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_movedelay, value, "movedelay"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int nrtracks 
		{
			get { return this.m_nrtracks.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrtracks, value, "nrtracks"); }
		}
		/// <summary>
		/// Goto position at power off.
		/// </summary>
		public int offpos 
		{
			get { return this.m_offpos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_offpos, value, "offpos"); }
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
		/// 
		/// </summary>
		public bool pending 
		{
			get { return this.m_pending.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pending, value, "pending"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port0 
		{
			get { return this.m_port0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port0, value, "port0"); }
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
		public int port2 
		{
			get { return this.m_port2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port2, value, "port2"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port3 
		{
			get { return this.m_port3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port3, value, "port3"); }
		}
		/// <summary>
		/// port of decoder unit to signal new position.
		/// </summary>
		public int port4 
		{
			get { return this.m_port4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port4, value, "port4"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port5 
		{
			get { return this.m_port5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port5, value, "port5"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port6 
		{
			get { return this.m_port6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port6, value, "port6"); }
		}
		/// <summary>
		/// port of decoder unit.
		/// </summary>
		public int port7 
		{
			get { return this.m_port7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port7, value, "port7"); }
		}
		/// <summary>
		/// position of table
		/// </summary>
		public int pos 
		{
			get { return this.m_pos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pos, value, "pos"); }
		}
		/// <summary>
		/// protocol to use for this seltab
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
		/// Use one set of sensors for all blocks.
		/// </summary>
		public bool sharedfb 
		{
			get { return this.m_sharedfb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sharedfb, value, "sharedfb"); }
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
		/// 
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
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
		public List<fbevent> fbeventlist 
		{
			get { return this.m_fbeventlist; }
			private set { this.SetField(ref this.m_fbeventlist, value, "fbeventlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<seltabpos> seltabposlist 
		{
			get { return this.m_seltabposlist; }
			private set { this.SetField(ref this.m_seltabposlist, value, "seltabposlist"); }
		}
		public seltab()
		{
			this.m_fbeventlist = new List<fbevent>();
			this.m_seltabposlist = new List<seltabpos>();
		}
		public static seltab Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			seltab _seltab = new seltab();
			_seltab.m_rocrailClient = rocrailClient;
			_seltab.m_addr0 = (int?)xml.Attribute("addr0");
			_seltab.m_addr1 = (int?)xml.Attribute("addr1");
			_seltab.m_addr2 = (int?)xml.Attribute("addr2");
			_seltab.m_addr3 = (int?)xml.Attribute("addr3");
			_seltab.m_addr4 = (int?)xml.Attribute("addr4");
			_seltab.m_addr5 = (int?)xml.Attribute("addr5");
			_seltab.m_addr6 = (int?)xml.Attribute("addr6");
			_seltab.m_addr7 = (int?)xml.Attribute("addr7");
			_seltab.m_b0sen = (string)xml.Attribute("b0sen");
			_seltab.m_b1sen = (string)xml.Attribute("b1sen");
			_seltab.m_b2sen = (string)xml.Attribute("b2sen");
			_seltab.m_b3sen = (string)xml.Attribute("b3sen");
			_seltab.m_b4sen = (string)xml.Attribute("b4sen");
			_seltab.m_b5sen = (string)xml.Attribute("b5sen");
			_seltab.m_b6sen = (string)xml.Attribute("b6sen");
			_seltab.m_bus = (int?)xml.Attribute("bus");
			_seltab.m_cmd = (string)xml.Attribute("cmd");
			_seltab.m_desc = (string)xml.Attribute("desc");
			_seltab.m_fifo = (bool?)xml.Attribute("fifo");
			_seltab.m_id = (string)xml.Attribute("id");
			_seltab.m_iid = (string)xml.Attribute("iid");
			_seltab.m_inv = (bool?)xml.Attribute("inv");
			_seltab.m_invnew = (bool?)xml.Attribute("invnew");
			_seltab.m_locid = (string)xml.Attribute("locid");
			_seltab.m_manager = (bool?)xml.Attribute("manager");
			_seltab.m_minocc = (int?)xml.Attribute("minocc");
			_seltab.m_movedelay = (int?)xml.Attribute("movedelay");
			_seltab.m_nrtracks = (int?)xml.Attribute("nrtracks");
			_seltab.m_offpos = (int?)xml.Attribute("offpos");
			_seltab.m_ori = (string)xml.Attribute("ori");
			_seltab.m_pending = (bool?)xml.Attribute("pending");
			_seltab.m_port0 = (int?)xml.Attribute("port0");
			_seltab.m_port1 = (int?)xml.Attribute("port1");
			_seltab.m_port2 = (int?)xml.Attribute("port2");
			_seltab.m_port3 = (int?)xml.Attribute("port3");
			_seltab.m_port4 = (int?)xml.Attribute("port4");
			_seltab.m_port5 = (int?)xml.Attribute("port5");
			_seltab.m_port6 = (int?)xml.Attribute("port6");
			_seltab.m_port7 = (int?)xml.Attribute("port7");
			_seltab.m_pos = (int?)xml.Attribute("pos");
			_seltab.m_prot = (string)xml.Attribute("prot");
			_seltab.m_psen = (string)xml.Attribute("psen");
			_seltab.m_sharedfb = (bool?)xml.Attribute("sharedfb");
			_seltab.m_singlegate = (bool?)xml.Attribute("singlegate");
			_seltab.m_state = (string)xml.Attribute("state");
			_seltab.m_x = (int?)xml.Attribute("x");
			_seltab.m_y = (int?)xml.Attribute("y");
			_seltab.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<fbevent>(_seltab.m_fbeventlist, xml, "fbevent", fbevent.Parse, rocrailClient);
			Definitions.Tools.ParseList<seltabpos>(_seltab.m_seltabposlist, xml, "seltabpos", seltabpos.Parse, rocrailClient);
			return _seltab;
		}
		public void Update(seltab element)
		{
			if(element.m_addr0.HasValue == true) this.addr0 = element.addr0;
			if(element.m_addr1.HasValue == true) this.addr1 = element.addr1;
			if(element.m_addr2.HasValue == true) this.addr2 = element.addr2;
			if(element.m_addr3.HasValue == true) this.addr3 = element.addr3;
			if(element.m_addr4.HasValue == true) this.addr4 = element.addr4;
			if(element.m_addr5.HasValue == true) this.addr5 = element.addr5;
			if(element.m_addr6.HasValue == true) this.addr6 = element.addr6;
			if(element.m_addr7.HasValue == true) this.addr7 = element.addr7;
			if(element.m_b0sen != null) this.b0sen = element.b0sen;
			if(element.m_b1sen != null) this.b1sen = element.b1sen;
			if(element.m_b2sen != null) this.b2sen = element.b2sen;
			if(element.m_b3sen != null) this.b3sen = element.b3sen;
			if(element.m_b4sen != null) this.b4sen = element.b4sen;
			if(element.m_b5sen != null) this.b5sen = element.b5sen;
			if(element.m_b6sen != null) this.b6sen = element.b6sen;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_fifo.HasValue == true) this.fifo = element.fifo;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_invnew.HasValue == true) this.invnew = element.invnew;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_manager.HasValue == true) this.manager = element.manager;
			if(element.m_minocc.HasValue == true) this.minocc = element.minocc;
			if(element.m_movedelay.HasValue == true) this.movedelay = element.movedelay;
			if(element.m_nrtracks.HasValue == true) this.nrtracks = element.nrtracks;
			if(element.m_offpos.HasValue == true) this.offpos = element.offpos;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_pending.HasValue == true) this.pending = element.pending;
			if(element.m_port0.HasValue == true) this.port0 = element.port0;
			if(element.m_port1.HasValue == true) this.port1 = element.port1;
			if(element.m_port2.HasValue == true) this.port2 = element.port2;
			if(element.m_port3.HasValue == true) this.port3 = element.port3;
			if(element.m_port4.HasValue == true) this.port4 = element.port4;
			if(element.m_port5.HasValue == true) this.port5 = element.port5;
			if(element.m_port6.HasValue == true) this.port6 = element.port6;
			if(element.m_port7.HasValue == true) this.port7 = element.port7;
			if(element.m_pos.HasValue == true) this.pos = element.pos;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_psen != null) this.psen = element.psen;
			if(element.m_sharedfb.HasValue == true) this.sharedfb = element.sharedfb;
			if(element.m_singlegate.HasValue == true) this.singlegate = element.singlegate;
			if(element.m_state != null) this.state = element.state;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.fbeventlist = element.fbeventlist;
			this.seltabposlist = element.seltabposlist;
		}
	}
}
