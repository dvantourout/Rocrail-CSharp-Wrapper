using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sys : CRocrailElements
	{
		public const string ANALOG = "analog";
		public const string ANALYZE = "analyze";
		public const string CLEARSHORTIDS = "clearshortids";
		public const string CONFIG = "config";
		public const string DCC = "dcc";
		public const string EBREAK = "ebreak";
		public const string GETINI = "getini";
		public const string GETMODPLAN = "getmodplan";
		public const string GETMODULE = "getmodule";
		public const string GO = "go";
		public const string GROUPLINK = "grouplink";
		public const string HFI = "hfi";
		public const string INFO = "info";
		public const string LINK = "link";
		public const string LOCCNFG = "loccnfg";
		public const string RESET = "reset";
		public const string RESETBLOCK = "resetblock";
		public const string RESETFX = "resetfx";
		public const string RESETSTAT = "resetstat";
		public const string SAVE = "save";
		public const string SETINI = "setini";
		public const string SETMODPLAN = "setmodplan";
		public const string SETMODULE = "setmodule";
		public const string SHUTDOWN = "shutdown";
		public const string SHUTDOWNNODE = "shutdownnode";
		public const string SLOTS = "slots";
		public const string SOD = "sod";
		public const string STOP = "stop";
		public const string STOPLOCS = "stoplocs";
		public const string SWCNFG = "swcnfg";
		public const string TEST = "test";
		public const string TXSHORTIDS = "txshortids";
		public const string ULINK = "ulink";
		public const string UPDATESERVER = "updateserver";
		public const string VERSION = "version";
		private int? m_addr;
		private string m_arch;
		private int? m_bus;
		private string m_cmd;
		private string m_dist;
		
		private string m_iid;
		private bool? m_informall;
		private string m_oid;
		private int? m_port;
		private int? m_val;
		private int? m_valA;
		private int? m_valB;
		/// <summary>
		/// Interface address
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// Hardware architecture
		/// </summary>
		public string arch 
		{
			get { return this.m_arch; }
			private set { this.SetField(ref this.m_arch, value, "arch"); }
		}
		/// <summary>
		/// Interface bus
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
		/// Distribution name
		/// </summary>
		public string dist 
		{
			get { return this.m_dist; }
			private set { this.SetField(ref this.m_dist, value, "dist"); }
		}
		/// <summary>
		/// ID
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
		/// send command to all interfaces
		/// </summary>
		public bool informall 
		{
			get { return this.m_informall.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_informall, value, "informall"); }
		}
		/// <summary>
		/// Object ID
		/// </summary>
		public string oid 
		{
			get { return this.m_oid; }
			private set { this.SetField(ref this.m_oid, value, "oid"); }
		}
		/// <summary>
		/// Interface port
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// optional value
		/// </summary>
		public int val 
		{
			get { return this.m_val.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val, value, "val"); }
		}
		/// <summary>
		/// optional value
		/// </summary>
		public int valA 
		{
			get { return this.m_valA.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_valA, value, "valA"); }
		}
		/// <summary>
		/// optional value
		/// </summary>
		public int valB 
		{
			get { return this.m_valB.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_valB, value, "valB"); }
		}
		public sys()
		{
		}
		public static sys Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sys _sys = new sys();
			_sys.m_rocrailClient = rocrailClient;
			_sys.m_addr = (int?)xml.Attribute("addr");
			_sys.m_arch = (string)xml.Attribute("arch");
			_sys.m_bus = (int?)xml.Attribute("bus");
			_sys.m_cmd = (string)xml.Attribute("cmd");
			_sys.m_dist = (string)xml.Attribute("dist");
			_sys.m_id = (string)xml.Attribute("id");
			_sys.m_iid = (string)xml.Attribute("iid");
			_sys.m_informall = (bool?)xml.Attribute("informall");
			_sys.m_oid = (string)xml.Attribute("oid");
			_sys.m_port = (int?)xml.Attribute("port");
			_sys.m_val = (int?)xml.Attribute("val");
			_sys.m_valA = (int?)xml.Attribute("valA");
			_sys.m_valB = (int?)xml.Attribute("valB");
			return _sys;
		}
		public void Update(sys element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_arch != null) this.arch = element.arch;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_dist != null) this.dist = element.dist;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_informall.HasValue == true) this.informall = element.informall;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_val.HasValue == true) this.val = element.val;
			if(element.m_valA.HasValue == true) this.valA = element.valA;
			if(element.m_valB.HasValue == true) this.valB = element.valB;
		}
	}
}
