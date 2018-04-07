using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class tx : CRocrailElements
	{
		private int? m_addr;
		private int? m_backblue;
		private int? m_backgreen;
		private int? m_backred;
		private string m_block;
		private int? m_blue;
		private bool? m_bold;
		private int? m_bus;
		private int? m_carcount;
		private string m_cmd;
		private int? m_countedcars;
		private int? m_counter;
		private int? m_cx;
		private int? m_cy;
		private string m_desc;
		private int? m_display;
		private string m_format;
		private int? m_green;
		
		private string m_iid;
		private bool? m_italic;
		private int? m_load;
		private string m_location;
		private string m_oid;
		private string m_ori;
		private int? m_pointsize;
		private string m_prev_id;
		private int? m_red;
		private string m_refbkid;
		private string m_reflcid;
		private int? m_temp;
		private string m_text;
		private bool? m_transparent;
		private bool? m_underlined;
		private int? m_volt;
		private int? m_wheelcount;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<actionctrl> m_actionctrllist;
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
		public int backblue 
		{
			get { return this.m_backblue.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_backblue, value, "backblue"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int backgreen 
		{
			get { return this.m_backgreen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_backgreen, value, "backgreen"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int backred 
		{
			get { return this.m_backred.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_backred, value, "backred"); }
		}
		/// <summary>
		/// Block ID from update event.
		/// </summary>
		public string block 
		{
			get { return this.m_block; }
			private set { this.SetField(ref this.m_block, value, "block"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int blue 
		{
			get { return this.m_blue.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blue, value, "blue"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bold 
		{
			get { return this.m_bold.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bold, value, "bold"); }
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
		/// 
		/// </summary>
		public int carcount 
		{
			get { return this.m_carcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_carcount, value, "carcount"); }
		}
		/// <summary>
		/// update
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int countedcars 
		{
			get { return this.m_countedcars.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_countedcars, value, "countedcars"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int counter 
		{
			get { return this.m_counter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_counter, value, "counter"); }
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public int display 
		{
			get { return this.m_display.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_display, value, "display"); }
		}
		/// <summary>
		/// Format string.
		/// </summary>
		public string format 
		{
			get { return this.m_format; }
			private set { this.SetField(ref this.m_format, value, "format"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int green 
		{
			get { return this.m_green.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_green, value, "green"); }
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
		public bool italic 
		{
			get { return this.m_italic.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_italic, value, "italic"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int load 
		{
			get { return this.m_load.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_load, value, "load"); }
		}
		/// <summary>
		/// Location from update event.
		/// </summary>
		public string location 
		{
			get { return this.m_location; }
			private set { this.SetField(ref this.m_location, value, "location"); }
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
		/// 
		/// </summary>
		public int pointsize 
		{
			get { return this.m_pointsize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pointsize, value, "pointsize"); }
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
		public int red 
		{
			get { return this.m_red.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_red, value, "red"); }
		}
		/// <summary>
		/// Reference ID.
		/// </summary>
		public string refbkid 
		{
			get { return this.m_refbkid; }
			private set { this.SetField(ref this.m_refbkid, value, "refbkid"); }
		}
		/// <summary>
		/// Reference ID.
		/// </summary>
		public string reflcid 
		{
			get { return this.m_reflcid; }
			private set { this.SetField(ref this.m_reflcid, value, "reflcid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int temp 
		{
			get { return this.m_temp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_temp, value, "temp"); }
		}
		/// <summary>
		/// Text or Image (if ending on .png) to be displayed.
		/// </summary>
		public string text 
		{
			get { return this.m_text; }
			private set { this.SetField(ref this.m_text, value, "text"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool transparent 
		{
			get { return this.m_transparent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_transparent, value, "transparent"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool underlined 
		{
			get { return this.m_underlined.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_underlined, value, "underlined"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int volt 
		{
			get { return this.m_volt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_volt, value, "volt"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int wheelcount 
		{
			get { return this.m_wheelcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wheelcount, value, "wheelcount"); }
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
		public tx()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static tx Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			tx _tx = new tx();
			_tx.m_rocrailClient = rocrailClient;
			_tx.m_addr = (int?)xml.Attribute("addr");
			_tx.m_backblue = (int?)xml.Attribute("backblue");
			_tx.m_backgreen = (int?)xml.Attribute("backgreen");
			_tx.m_backred = (int?)xml.Attribute("backred");
			_tx.m_block = (string)xml.Attribute("block");
			_tx.m_blue = (int?)xml.Attribute("blue");
			_tx.m_bold = (bool?)xml.Attribute("bold");
			_tx.m_bus = (int?)xml.Attribute("bus");
			_tx.m_carcount = (int?)xml.Attribute("carcount");
			_tx.m_cmd = (string)xml.Attribute("cmd");
			_tx.m_countedcars = (int?)xml.Attribute("countedcars");
			_tx.m_counter = (int?)xml.Attribute("counter");
			_tx.m_cx = (int?)xml.Attribute("cx");
			_tx.m_cy = (int?)xml.Attribute("cy");
			_tx.m_desc = (string)xml.Attribute("desc");
			_tx.m_display = (int?)xml.Attribute("display");
			_tx.m_format = (string)xml.Attribute("format");
			_tx.m_green = (int?)xml.Attribute("green");
			_tx.m_id = (string)xml.Attribute("id");
			_tx.m_iid = (string)xml.Attribute("iid");
			_tx.m_italic = (bool?)xml.Attribute("italic");
			_tx.m_load = (int?)xml.Attribute("load");
			_tx.m_location = (string)xml.Attribute("location");
			_tx.m_oid = (string)xml.Attribute("oid");
			_tx.m_ori = (string)xml.Attribute("ori");
			_tx.m_pointsize = (int?)xml.Attribute("pointsize");
			_tx.m_prev_id = (string)xml.Attribute("prev_id");
			_tx.m_red = (int?)xml.Attribute("red");
			_tx.m_refbkid = (string)xml.Attribute("refbkid");
			_tx.m_reflcid = (string)xml.Attribute("reflcid");
			_tx.m_temp = (int?)xml.Attribute("temp");
			_tx.m_text = (string)xml.Attribute("text");
			_tx.m_transparent = (bool?)xml.Attribute("transparent");
			_tx.m_underlined = (bool?)xml.Attribute("underlined");
			_tx.m_volt = (int?)xml.Attribute("volt");
			_tx.m_wheelcount = (int?)xml.Attribute("wheelcount");
			_tx.m_x = (int?)xml.Attribute("x");
			_tx.m_y = (int?)xml.Attribute("y");
			_tx.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_tx.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			return _tx;
		}
		public void Update(tx element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_backblue.HasValue == true) this.backblue = element.backblue;
			if(element.m_backgreen.HasValue == true) this.backgreen = element.backgreen;
			if(element.m_backred.HasValue == true) this.backred = element.backred;
			if(element.m_block != null) this.block = element.block;
			if(element.m_blue.HasValue == true) this.blue = element.blue;
			if(element.m_bold.HasValue == true) this.bold = element.bold;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_carcount.HasValue == true) this.carcount = element.carcount;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_countedcars.HasValue == true) this.countedcars = element.countedcars;
			if(element.m_counter.HasValue == true) this.counter = element.counter;
			if(element.m_cx.HasValue == true) this.cx = element.cx;
			if(element.m_cy.HasValue == true) this.cy = element.cy;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_display.HasValue == true) this.display = element.display;
			if(element.m_format != null) this.format = element.format;
			if(element.m_green.HasValue == true) this.green = element.green;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_italic.HasValue == true) this.italic = element.italic;
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_location != null) this.location = element.location;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_pointsize.HasValue == true) this.pointsize = element.pointsize;
			if(element.m_prev_id != null) this.prev_id = element.prev_id;
			if(element.m_red.HasValue == true) this.red = element.red;
			if(element.m_refbkid != null) this.refbkid = element.refbkid;
			if(element.m_reflcid != null) this.reflcid = element.reflcid;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_text != null) this.text = element.text;
			if(element.m_transparent.HasValue == true) this.transparent = element.transparent;
			if(element.m_underlined.HasValue == true) this.underlined = element.underlined;
			if(element.m_volt.HasValue == true) this.volt = element.volt;
			if(element.m_wheelcount.HasValue == true) this.wheelcount = element.wheelcount;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;
		}
	}
}
