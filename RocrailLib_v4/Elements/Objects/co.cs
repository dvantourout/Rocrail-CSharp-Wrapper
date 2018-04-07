using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class co : CRocrailElements
	{
		public const string ACTIVE = "active";
		public const string FLIP = "flip";
		public const string OFF = "off";
		public const string ON = "on";
		public const string PROT_DEF = "D";
		public const string PROT_DO = "do";
		public const string PROT_M = "M";
		public const string PROT_MDD = "mdd";
		public const string PROT_N = "N";
		public const string PROT_OM32 = "om32";
		public const string PROT_VO = "vo";
		public const string SOD = "sod";
		public const string VALUE = "value";
		private bool? m_accessory;
		private int? m_addr;
		private bool? m_asswitch;
		private bool? m_blink;
		private string m_blockid;
		private int? m_bus;
		private string m_cmd;
		private string m_desc;
		private int? m_gate;
		private string m_grpid;
		
		private string m_iid;
		private bool? m_inv;
		private string m_oid;
		private string m_ori;
		private int? m_param;
		private int? m_port;
		private int? m_porttype;
		private string m_prot;
		private bool? m_show;
		private string m_state;
		private int? m_svgtype;
		private bool? m_toggleswitch;
		private bool? m_tristate;
		private string m_type;
		private int? m_value;
		private int? m_x;
		private int? m_y;
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
		/// send a switch command
		/// </summary>
		public bool asswitch 
		{
			get { return this.m_asswitch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_asswitch, value, "asswitch"); }
		}
		/// <summary>
		/// Blink output.
		/// </summary>
		public bool blink 
		{
			get { return this.m_blink.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blink, value, "blink"); }
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
		/// description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int gate 
		{
			get { return this.m_gate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gate, value, "gate"); }
		}
		/// <summary>
		/// Group ID; All buttons of this group must be true to trigger actions.
		/// </summary>
		public string grpid 
		{
			get { return this.m_grpid; }
			private set { this.SetField(ref this.m_grpid, value, "grpid"); }
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
		/// Output as switch inverted. (Software wiring correction)
		/// </summary>
		public bool inv 
		{
			get { return this.m_inv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inv, value, "inv"); }
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
		/// output parameter
		/// </summary>
		public int param 
		{
			get { return this.m_param.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_param, value, "param"); }
		}
		/// <summary>
		/// port of decoder module: 0 = not used.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
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
		/// Visibility flag.
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
		}
		/// <summary>
		/// Current state of output.
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Defines which SVG symbol should be used in case of show.
		/// </summary>
		public int svgtype 
		{
			get { return this.m_svgtype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_svgtype, value, "svgtype"); }
		}
		/// <summary>
		/// Toggle switch or push button.
		/// </summary>
		public bool toggleswitch 
		{
			get { return this.m_toggleswitch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_toggleswitch, value, "toggleswitch"); }
		}
		/// <summary>
		/// Tri-state flag.
		/// </summary>
		public bool tristate 
		{
			get { return this.m_tristate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tristate, value, "tristate"); }
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
		/// output value
		/// </summary>
		public int @value 
		{
			get { return this.m_value.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value, value, "@value"); }
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
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		public co()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static co Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			co _co = new co();
			_co.m_rocrailClient = rocrailClient;
			_co.m_accessory = (bool?)xml.Attribute("accessory");
			_co.m_addr = (int?)xml.Attribute("addr");
			_co.m_asswitch = (bool?)xml.Attribute("asswitch");
			_co.m_blink = (bool?)xml.Attribute("blink");
			_co.m_blockid = (string)xml.Attribute("blockid");
			_co.m_bus = (int?)xml.Attribute("bus");
			_co.m_cmd = (string)xml.Attribute("cmd");
			_co.m_desc = (string)xml.Attribute("desc");
			_co.m_gate = (int?)xml.Attribute("gate");
			_co.m_grpid = (string)xml.Attribute("grpid");
			_co.m_id = (string)xml.Attribute("id");
			_co.m_iid = (string)xml.Attribute("iid");
			_co.m_inv = (bool?)xml.Attribute("inv");
			_co.m_oid = (string)xml.Attribute("oid");
			_co.m_ori = (string)xml.Attribute("ori");
			_co.m_param = (int?)xml.Attribute("param");
			_co.m_port = (int?)xml.Attribute("port");
			_co.m_porttype = (int?)xml.Attribute("porttype");
			_co.m_prot = (string)xml.Attribute("prot");
			_co.m_show = (bool?)xml.Attribute("show");
			_co.m_state = (string)xml.Attribute("state");
			_co.m_svgtype = (int?)xml.Attribute("svgtype");
			_co.m_toggleswitch = (bool?)xml.Attribute("toggleswitch");
			_co.m_tristate = (bool?)xml.Attribute("tristate");
			_co.m_type = (string)xml.Attribute("type");
			_co.m_value = (int?)xml.Attribute("value");
			_co.m_x = (int?)xml.Attribute("x");
			_co.m_y = (int?)xml.Attribute("y");
			_co.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_co.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			return _co;
		}
		public void Update(co element)
		{
			if(element.m_accessory.HasValue == true) this.accessory = element.accessory;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_asswitch.HasValue == true) this.asswitch = element.asswitch;
			if(element.m_blink.HasValue == true) this.blink = element.blink;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_gate.HasValue == true) this.gate = element.gate;
			if(element.m_grpid != null) this.grpid = element.grpid;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_param.HasValue == true) this.param = element.param;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_porttype.HasValue == true) this.porttype = element.porttype;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_state != null) this.state = element.state;
			if(element.m_svgtype.HasValue == true) this.svgtype = element.svgtype;
			if(element.m_toggleswitch.HasValue == true) this.toggleswitch = element.toggleswitch;
			if(element.m_tristate.HasValue == true) this.tristate = element.tristate;
			if(element.m_type != null) this.type = element.type;
			if(element.m_value.HasValue == true) this.@value = element.@value;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;
		}
	}
}
