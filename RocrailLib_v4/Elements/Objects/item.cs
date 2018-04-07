using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class item : CRocrailElements
	{
		public const string EAST = "east";
		public const string NORTH = "north";
		public const string SOUTH = "south";
		public const string WEST = "west";
		private int? m_addr;
		private string m_blockid;
		private int? m_bus;
		private int? m_cx;
		private int? m_cy;
		private string m_desc;
		private bool? m_generated;
		
		private string m_iid;
		private int? m_len;
		private string m_name;
		private string m_oid;
		private string m_ori;
		private string m_prev_id;
		private string m_prev_ori;
		private int? m_prev_x;
		private int? m_prev_y;
		private bool? m_road;
		private string m_routeids;
		private bool? m_show;
		private string m_state;
		private string m_type;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		/// <summary>
		/// 
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
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
		/// 
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// Zero means not set; use default symbol size.
		/// </summary>
		public int cx 
		{
			get { return this.m_cx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cx, value, "cx"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cy 
		{
			get { return this.m_cy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cy, value, "cy"); }
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
		/// On the fly generated for an unknown address. Triggered by a client.
		/// </summary>
		public bool generated 
		{
			get { return this.m_generated.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_generated, value, "generated"); }
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
		/// 
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int len 
		{
			get { return this.m_len.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_len, value, "len"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string name 
		{
			get { return this.m_name; }
			private set { this.SetField(ref this.m_name, value, "name"); }
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
		/// 
		/// </summary>
		public string ori 
		{
			get { return this.m_ori; }
			private set { this.SetField(ref this.m_ori, value, "ori"); }
		}
		/// <summary>
		/// in case of an id change this should help to find the original in the table
		/// </summary>
		public string prev_id 
		{
			get { return this.m_prev_id; }
			private set { this.SetField(ref this.m_prev_id, value, "prev_id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string prev_ori 
		{
			get { return this.m_prev_ori; }
			private set { this.SetField(ref this.m_prev_ori, value, "prev_ori"); }
		}
		/// <summary>
		/// x position before rotation
		/// </summary>
		public int prev_x 
		{
			get { return this.m_prev_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_prev_x, value, "prev_x"); }
		}
		/// <summary>
		/// y position before rotation
		/// </summary>
		public int prev_y 
		{
			get { return this.m_prev_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_prev_y, value, "prev_y"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool road 
		{
			get { return this.m_road.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_road, value, "road"); }
		}
		/// <summary>
		/// comma separated list of route ids used to show a special route representation
		/// </summary>
		public string routeids 
		{
			get { return this.m_routeids; }
			private set { this.SetField(ref this.m_routeids, value, "routeids"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
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
		public item()
		{
		}
		public static item Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			item _item = new item();
			_item.m_rocrailClient = rocrailClient;
			_item.m_addr = (int?)xml.Attribute("addr");
			_item.m_blockid = (string)xml.Attribute("blockid");
			_item.m_bus = (int?)xml.Attribute("bus");
			_item.m_cx = (int?)xml.Attribute("cx");
			_item.m_cy = (int?)xml.Attribute("cy");
			_item.m_desc = (string)xml.Attribute("desc");
			_item.m_generated = (bool?)xml.Attribute("generated");
			_item.m_id = (string)xml.Attribute("id");
			_item.m_iid = (string)xml.Attribute("iid");
			_item.m_len = (int?)xml.Attribute("len");
			_item.m_name = (string)xml.Attribute("name");
			_item.m_oid = (string)xml.Attribute("oid");
			_item.m_ori = (string)xml.Attribute("ori");
			_item.m_prev_id = (string)xml.Attribute("prev_id");
			_item.m_prev_ori = (string)xml.Attribute("prev_ori");
			_item.m_prev_x = (int?)xml.Attribute("prev_x");
			_item.m_prev_y = (int?)xml.Attribute("prev_y");
			_item.m_road = (bool?)xml.Attribute("road");
			_item.m_routeids = (string)xml.Attribute("routeids");
			_item.m_show = (bool?)xml.Attribute("show");
			_item.m_state = (string)xml.Attribute("state");
			_item.m_type = (string)xml.Attribute("type");
			_item.m_x = (int?)xml.Attribute("x");
			_item.m_y = (int?)xml.Attribute("y");
			_item.m_z = (int?)xml.Attribute("z");
			return _item;
		}
		public void Update(item element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cx.HasValue == true) this.cx = element.cx;
			if(element.m_cy.HasValue == true) this.cy = element.cy;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_generated.HasValue == true) this.generated = element.generated;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_len.HasValue == true) this.len = element.len;
			if(element.m_name != null) this.name = element.name;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_prev_id != null) this.prev_id = element.prev_id;
			if(element.m_prev_ori != null) this.prev_ori = element.prev_ori;
			if(element.m_prev_x.HasValue == true) this.prev_x = element.prev_x;
			if(element.m_prev_y.HasValue == true) this.prev_y = element.prev_y;
			if(element.m_road.HasValue == true) this.road = element.road;
			if(element.m_routeids != null) this.routeids = element.routeids;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_state != null) this.state = element.state;
			if(element.m_type != null) this.type = element.type;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
		}
	}
}
