using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sg : CRocrailElements
	{
		public const string ASPECT = "aspect";
		public const string AUTOOPERATED = "autooperated";
		public const string BLANK = "blank";
		public const string DISTANT = "distant";
		public const string FLIP = "flip";
		public const string GREEN = "green";
		public const string LIGHT = "light";
		public const string MAIN = "main";
		public const string MANUALOPERATED = "manualoperated";
		public const string PROT_DEF = "D";
		public const string PROT_M = "M";
		public const string PROT_MDD = "mdd";
		public const string PROT_N = "N";
		public const string PROT_OM32 = "om32";
		public const string RED = "red";
		public const string SEMAPHORE = "semaphore";
		public const string SHUNTING = "shunting";
		public const int USE_ASPECTNRS = 2;
		public const int USE_LINEAR = 3;
		public const int USE_PATTERNS = 1;
		public const string WHITE = "white";
		public const string YELLOW = "yellow";
		private bool? m_accessory;
		private int? m_addr;
		private int? m_addr2;
		private int? m_addr3;
		private int? m_addr4;
		private int? m_aspect;
		private int? m_aspects;
		private bool? m_asswitch;
		private int? m_blank;
		private int? m_blanknr;
		private string m_blockid;
		private int? m_bus;
		private string m_cmd;
		private int? m_cmdtime;
		private string m_desc;
		private bool? m_dwarf;
		private int? m_gate1;
		private int? m_gate2;
		private int? m_gate3;
		private int? m_gate4;
		private int? m_green;
		private int? m_greennr;
		
		private string m_iid;
		private bool? m_inv;
		private bool? m_manual;
		private string m_oid;
		private string m_ori;
		private bool? m_pair;
		private int? m_port1;
		private int? m_port2;
		private int? m_port3;
		private int? m_port4;
		private int? m_porttype;
		private string m_prot;
		private int? m_red;
		private int? m_rednr;
		private string m_signal;
		private string m_state;
		private string m_symbolprefix;
		private string m_type;
		private int? m_usepatterns;
		private bool? m_usesymbolprefix;
		private int? m_white;
		private int? m_whitenr;
		private int? m_x;
		private int? m_y;
		private int? m_yellow;
		private int? m_yellownr;
		private int? m_z;
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
		/// decoder address
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
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
		/// decoder address
		/// </summary>
		public int addr4 
		{
			get { return this.m_addr4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr4, value, "addr4"); }
		}
		/// <summary>
		/// Aspect to show: Extended DCC.
		/// </summary>
		public int aspect 
		{
			get { return this.m_aspect.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_aspect, value, "aspect"); }
		}
		/// <summary>
		/// number of aspects to show
		/// </summary>
		public int aspects 
		{
			get { return this.m_aspects.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_aspects, value, "aspects"); }
		}
		/// <summary>
		/// send a switch command incase of 2 aspects
		/// </summary>
		public bool asswitch 
		{
			get { return this.m_asswitch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_asswitch, value, "asswitch"); }
		}
		/// <summary>
		/// pattern for blank
		/// </summary>
		public int blank 
		{
			get { return this.m_blank.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blank, value, "blank"); }
		}
		/// <summary>
		/// pattern for blank
		/// </summary>
		public int blanknr 
		{
			get { return this.m_blanknr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blanknr, value, "blanknr"); }
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
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// Time in ms between commands.
		/// </summary>
		public int cmdtime 
		{
			get { return this.m_cmdtime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmdtime, value, "cmdtime"); }
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
		public bool dwarf 
		{
			get { return this.m_dwarf.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dwarf, value, "dwarf"); }
		}
		/// <summary>
		/// Output gate of port 1.
		/// </summary>
		public int gate1 
		{
			get { return this.m_gate1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate1, value, "gate1"); }
		}
		/// <summary>
		/// Output gate of port 2.
		/// </summary>
		public int gate2 
		{
			get { return this.m_gate2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate2, value, "gate2"); }
		}
		/// <summary>
		/// Output gate of port 3.
		/// </summary>
		public int gate3 
		{
			get { return this.m_gate3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate3, value, "gate3"); }
		}
		/// <summary>
		/// Output gate of port 4, white.
		/// </summary>
		public int gate4 
		{
			get { return this.m_gate4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate4, value, "gate4"); }
		}
		/// <summary>
		/// pattern for green
		/// </summary>
		public int green 
		{
			get { return this.m_green.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_green, value, "green"); }
		}
		/// <summary>
		/// pattern for green
		/// </summary>
		public int greennr 
		{
			get { return this.m_greennr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_greennr, value, "greennr"); }
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
		/// Signal inverted. (Software wiring correction)
		/// </summary>
		public bool inv 
		{
			get { return this.m_inv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv, value, "inv"); }
		}
		/// <summary>
		/// operator controlled signal to influence auto mode
		/// </summary>
		public bool manual 
		{
			get { return this.m_manual.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manual, value, "manual"); }
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
		/// both gates are used for on-off
		/// </summary>
		public bool pair 
		{
			get { return this.m_pair.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pair, value, "pair"); }
		}
		/// <summary>
		/// Output port 1.
		/// </summary>
		public int port1 
		{
			get { return this.m_port1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port1, value, "port1"); }
		}
		/// <summary>
		/// Output port 2.
		/// </summary>
		public int port2 
		{
			get { return this.m_port2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port2, value, "port2"); }
		}
		/// <summary>
		/// Output port 3.
		/// </summary>
		public int port3 
		{
			get { return this.m_port3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port3, value, "port3"); }
		}
		/// <summary>
		/// Output port 4, white.
		/// </summary>
		public int port4 
		{
			get { return this.m_port4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port4, value, "port4"); }
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
		/// pattern for red
		/// </summary>
		public int red 
		{
			get { return this.m_red.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_red, value, "red"); }
		}
		/// <summary>
		/// pattern for red
		/// </summary>
		public int rednr 
		{
			get { return this.m_rednr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rednr, value, "rednr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string signal 
		{
			get { return this.m_signal; }
			private set { this.SetField(ref this.m_signal, value, "signal"); }
		}
		/// <summary>
		/// Current state of signal.
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Optional symbol name prefix for multiaspect signals.
		/// </summary>
		public string symbolprefix 
		{
			get { return this.m_symbolprefix; }
			private set { this.SetField(ref this.m_symbolprefix, value, "symbolprefix"); }
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
		/// 0=no, 1=patterns, 2=aspectnrs, 3=linear
		/// </summary>
		public int usepatterns 
		{
			get { return this.m_usepatterns.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usepatterns, value, "usepatterns"); }
		}
		/// <summary>
		/// Use symbol prefix for aspects less then 5.
		/// </summary>
		public bool usesymbolprefix 
		{
			get { return this.m_usesymbolprefix.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usesymbolprefix, value, "usesymbolprefix"); }
		}
		/// <summary>
		/// pattern for white
		/// </summary>
		public int white 
		{
			get { return this.m_white.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_white, value, "white"); }
		}
		/// <summary>
		/// pattern for white
		/// </summary>
		public int whitenr 
		{
			get { return this.m_whitenr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_whitenr, value, "whitenr"); }
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
		/// pattern for yellow
		/// </summary>
		public int yellow 
		{
			get { return this.m_yellow.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_yellow, value, "yellow"); }
		}
		/// <summary>
		/// pattern for yellow
		/// </summary>
		public int yellownr 
		{
			get { return this.m_yellownr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_yellownr, value, "yellownr"); }
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

		public sg()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static sg Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sg _sg = new sg();
			_sg.m_rocrailClient = rocrailClient;
			_sg.m_accessory = (bool?)xml.Attribute("accessory");
			_sg.m_addr = (int?)xml.Attribute("addr");
			_sg.m_addr2 = (int?)xml.Attribute("addr2");
			_sg.m_addr3 = (int?)xml.Attribute("addr3");
			_sg.m_addr4 = (int?)xml.Attribute("addr4");
			_sg.m_aspect = (int?)xml.Attribute("aspect");
			_sg.m_aspects = (int?)xml.Attribute("aspects");
			_sg.m_asswitch = (bool?)xml.Attribute("asswitch");
			_sg.m_blank = (int?)xml.Attribute("blank");
			_sg.m_blanknr = (int?)xml.Attribute("blanknr");
			_sg.m_blockid = (string)xml.Attribute("blockid");
			_sg.m_bus = (int?)xml.Attribute("bus");
			_sg.m_cmd = (string)xml.Attribute("cmd");
			_sg.m_cmdtime = (int?)xml.Attribute("cmdtime");
			_sg.m_desc = (string)xml.Attribute("desc");
			_sg.m_dwarf = (bool?)xml.Attribute("dwarf");
			_sg.m_gate1 = (int?)xml.Attribute("gate1");
			_sg.m_gate2 = (int?)xml.Attribute("gate2");
			_sg.m_gate3 = (int?)xml.Attribute("gate3");
			_sg.m_gate4 = (int?)xml.Attribute("gate4");
			_sg.m_green = (int?)xml.Attribute("green");
			_sg.m_greennr = (int?)xml.Attribute("greennr");
			_sg.m_id = (string)xml.Attribute("id");
			_sg.m_iid = (string)xml.Attribute("iid");
			_sg.m_inv = (bool?)xml.Attribute("inv");
			_sg.m_manual = (bool?)xml.Attribute("manual");
			_sg.m_oid = (string)xml.Attribute("oid");
			_sg.m_ori = (string)xml.Attribute("ori");
			_sg.m_pair = (bool?)xml.Attribute("pair");
			_sg.m_port1 = (int?)xml.Attribute("port1");
			_sg.m_port2 = (int?)xml.Attribute("port2");
			_sg.m_port3 = (int?)xml.Attribute("port3");
			_sg.m_port4 = (int?)xml.Attribute("port4");
			_sg.m_porttype = (int?)xml.Attribute("porttype");
			_sg.m_prot = (string)xml.Attribute("prot");
			_sg.m_red = (int?)xml.Attribute("red");
			_sg.m_rednr = (int?)xml.Attribute("rednr");
			_sg.m_signal = (string)xml.Attribute("signal");
			_sg.m_state = (string)xml.Attribute("state");
			_sg.m_symbolprefix = (string)xml.Attribute("symbolprefix");
			_sg.m_type = (string)xml.Attribute("type");
			_sg.m_usepatterns = (int?)xml.Attribute("usepatterns");
			_sg.m_usesymbolprefix = (bool?)xml.Attribute("usesymbolprefix");
			_sg.m_white = (int?)xml.Attribute("white");
			_sg.m_whitenr = (int?)xml.Attribute("whitenr");
			_sg.m_x = (int?)xml.Attribute("x");
			_sg.m_y = (int?)xml.Attribute("y");
			_sg.m_yellow = (int?)xml.Attribute("yellow");
			_sg.m_yellownr = (int?)xml.Attribute("yellownr");
			_sg.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_sg.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);

            _sg.m_routeids = (string)xml.Attribute("routeids");

			return _sg;
		}
		public void Update(sg element)
		{
			if(element.m_accessory.HasValue == true) this.accessory = element.accessory;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_addr2.HasValue == true) this.addr2 = element.addr2;
			if(element.m_addr3.HasValue == true) this.addr3 = element.addr3;
			if(element.m_addr4.HasValue == true) this.addr4 = element.addr4;
			if(element.m_aspect.HasValue == true) this.aspect = element.aspect;
			if(element.m_aspects.HasValue == true) this.aspects = element.aspects;
			if(element.m_asswitch.HasValue == true) this.asswitch = element.asswitch;
			if(element.m_blank.HasValue == true) this.blank = element.blank;
			if(element.m_blanknr.HasValue == true) this.blanknr = element.blanknr;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_cmdtime.HasValue == true) this.cmdtime = element.cmdtime;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_dwarf.HasValue == true) this.dwarf = element.dwarf;
			if(element.m_gate1.HasValue == true) this.gate1 = element.gate1;
			if(element.m_gate2.HasValue == true) this.gate2 = element.gate2;
			if(element.m_gate3.HasValue == true) this.gate3 = element.gate3;
			if(element.m_gate4.HasValue == true) this.gate4 = element.gate4;
			if(element.m_green.HasValue == true) this.green = element.green;
			if(element.m_greennr.HasValue == true) this.greennr = element.greennr;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_manual.HasValue == true) this.manual = element.manual;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_pair.HasValue == true) this.pair = element.pair;
			if(element.m_port1.HasValue == true) this.port1 = element.port1;
			if(element.m_port2.HasValue == true) this.port2 = element.port2;
			if(element.m_port3.HasValue == true) this.port3 = element.port3;
			if(element.m_port4.HasValue == true) this.port4 = element.port4;
			if(element.m_porttype.HasValue == true) this.porttype = element.porttype;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_red.HasValue == true) this.red = element.red;
			if(element.m_rednr.HasValue == true) this.rednr = element.rednr;
			if(element.m_signal != null) this.signal = element.signal;
			if(element.m_state != null) this.state = element.state;
			if(element.m_symbolprefix != null) this.symbolprefix = element.symbolprefix;
			if(element.m_type != null) this.type = element.type;
			if(element.m_usepatterns.HasValue == true) this.usepatterns = element.usepatterns;
			if(element.m_usesymbolprefix.HasValue == true) this.usesymbolprefix = element.usesymbolprefix;
			if(element.m_white.HasValue == true) this.white = element.white;
			if(element.m_whitenr.HasValue == true) this.whitenr = element.whitenr;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_yellow.HasValue == true) this.yellow = element.yellow;
			if(element.m_yellownr.HasValue == true) this.yellownr = element.yellownr;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;

            if (element.m_routeids != null) this.routeids = element.routeids;
		}
        public void Flip()
        {
            string sTrameCmd = "<sg id=\"" + this.id + "\" cmd=\"flip\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void Red()
        {
            string sTrameCmd = "<sg id=\"" + this.id + "\" cmd=\"red\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void Green()
        {
            string sTrameCmd = "<sg id=\"" + this.id + "\" cmd=\"green\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }
        public void White()
        {
            string sTrameCmd = "<sg id=\"" + this.id + "\" cmd=\"white\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }

        public void Yellow()
        {
            string sTrameCmd = "<sg id=\"" + this.id + "\" cmd=\"yellow\"/>";
            this.m_rocrailClient.Send(sTrameCmd);
        }
	}
}
