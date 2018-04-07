using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class traverser : CRocrailElements
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
		private string m_b0sen;
		private string m_b1sen;
		private string m_b2sen;
		private string m_b3sen;
		private int? m_bus;
		private string m_cmd;
		private string m_desc;
		
		private string m_iid;
		private bool? m_inv;
		private bool? m_invnew;
		private string m_locid;
		private int? m_nrtracks;
		private string m_ori;
		private bool? m_pending;
		private int? m_port0;
		private int? m_port1;
		private int? m_port2;
		private int? m_port3;
		private int? m_port4;
		private int? m_pos;
		private string m_prot;
		private string m_psen;
		private int? m_x;
		private int? m_y;
		private int? m_z;
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
		/// decoder address
		/// </summary>
		public int addr4 
		{
			get { return this.m_addr4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr4, value, "addr4"); }
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
		/// 
		/// </summary>
		public int nrtracks 
		{
			get { return this.m_nrtracks.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrtracks, value, "nrtracks"); }
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
		/// port of decoder unit.
		/// </summary>
		public int port4 
		{
			get { return this.m_port4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port4, value, "port4"); }
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
		public traverser()
		{
		}
		public static traverser Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			traverser _traverser = new traverser();
			_traverser.m_rocrailClient = rocrailClient;
			_traverser.m_addr0 = (int?)xml.Attribute("addr0");
			_traverser.m_addr1 = (int?)xml.Attribute("addr1");
			_traverser.m_addr2 = (int?)xml.Attribute("addr2");
			_traverser.m_addr3 = (int?)xml.Attribute("addr3");
			_traverser.m_addr4 = (int?)xml.Attribute("addr4");
			_traverser.m_b0sen = (string)xml.Attribute("b0sen");
			_traverser.m_b1sen = (string)xml.Attribute("b1sen");
			_traverser.m_b2sen = (string)xml.Attribute("b2sen");
			_traverser.m_b3sen = (string)xml.Attribute("b3sen");
			_traverser.m_bus = (int?)xml.Attribute("bus");
			_traverser.m_cmd = (string)xml.Attribute("cmd");
			_traverser.m_desc = (string)xml.Attribute("desc");
			_traverser.m_id = (string)xml.Attribute("id");
			_traverser.m_iid = (string)xml.Attribute("iid");
			_traverser.m_inv = (bool?)xml.Attribute("inv");
			_traverser.m_invnew = (bool?)xml.Attribute("invnew");
			_traverser.m_locid = (string)xml.Attribute("locid");
			_traverser.m_nrtracks = (int?)xml.Attribute("nrtracks");
			_traverser.m_ori = (string)xml.Attribute("ori");
			_traverser.m_pending = (bool?)xml.Attribute("pending");
			_traverser.m_port0 = (int?)xml.Attribute("port0");
			_traverser.m_port1 = (int?)xml.Attribute("port1");
			_traverser.m_port2 = (int?)xml.Attribute("port2");
			_traverser.m_port3 = (int?)xml.Attribute("port3");
			_traverser.m_port4 = (int?)xml.Attribute("port4");
			_traverser.m_pos = (int?)xml.Attribute("pos");
			_traverser.m_prot = (string)xml.Attribute("prot");
			_traverser.m_psen = (string)xml.Attribute("psen");
			_traverser.m_x = (int?)xml.Attribute("x");
			_traverser.m_y = (int?)xml.Attribute("y");
			_traverser.m_z = (int?)xml.Attribute("z");
			return _traverser;
		}
		public void Update(traverser element)
		{
			if(element.m_addr0.HasValue == true) this.addr0 = element.addr0;
			if(element.m_addr1.HasValue == true) this.addr1 = element.addr1;
			if(element.m_addr2.HasValue == true) this.addr2 = element.addr2;
			if(element.m_addr3.HasValue == true) this.addr3 = element.addr3;
			if(element.m_addr4.HasValue == true) this.addr4 = element.addr4;
			if(element.m_b0sen != null) this.b0sen = element.b0sen;
			if(element.m_b1sen != null) this.b1sen = element.b1sen;
			if(element.m_b2sen != null) this.b2sen = element.b2sen;
			if(element.m_b3sen != null) this.b3sen = element.b3sen;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inv.HasValue == true) this.inv = element.inv;
			if(element.m_invnew.HasValue == true) this.invnew = element.invnew;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_nrtracks.HasValue == true) this.nrtracks = element.nrtracks;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_pending.HasValue == true) this.pending = element.pending;
			if(element.m_port0.HasValue == true) this.port0 = element.port0;
			if(element.m_port1.HasValue == true) this.port1 = element.port1;
			if(element.m_port2.HasValue == true) this.port2 = element.port2;
			if(element.m_port3.HasValue == true) this.port3 = element.port3;
			if(element.m_port4.HasValue == true) this.port4 = element.port4;
			if(element.m_pos.HasValue == true) this.pos = element.pos;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_psen != null) this.psen = element.psen;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
		}
	}
}
