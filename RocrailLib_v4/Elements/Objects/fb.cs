using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fb : CRocrailElements
	{
		public const int FBTYPE_BARCODE = 3;
		public const int FBTYPE_LISSY = 1;
		public const int FBTYPE_RAILCOM = 4;
		public const int FBTYPE_RFID = 5;
		public const int FBTYPE_SENSOR = 0;
		public const int FBTYPE_TRANSPONDER = 2;
		public const int FBTYPE_WHEELCOUNTER = 6;
		public const string RESET = "reset";
		public const string RESETSTATUS = "resetstatus";
		public const string SETCOUNTERVAL = "setcounterval";
		private int? m_accnr;
		private bool? m_activelow;
		private int? m_addr;
		private string m_blockid;
		private int? m_bus;
		private int? m_carcount;
		private int? m_category;
		private string m_cmd;
		private int? m_countedcars;
		private int? m_counter;
		private int? m_ctcaddr;
		private bool? m_ctcasswitch;
		private int? m_ctcbus;
		private int? m_ctcgate;
		private string m_ctciid;
		private int? m_ctcport;
		private bool? m_curve;
		private int? m_cutoutaddr;
		private int? m_cutoutbus;
		private string m_desc;
		private bool? m_direction;
		private int? m_fbtype;
		
		private string m_identifier;
		private string m_iid;
		private string m_info;
		private int? m_load;
		private string m_oid;
		private string m_ori;
		private bool? m_resetwc;
		private bool? m_shortcut;
		private bool? m_show;
		private bool? m_state;
		private int? m_timer;
		private int? m_val;
		private int? m_wheelcount;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private string m_zone;
		private List<actionctrl> m_actionctrllist;

		/// <summary>
		/// Accessory number.
		/// </summary>
		public int accnr 
		{
			get { return this.m_accnr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accnr, value, "accnr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool activelow 
		{
			get { return this.m_activelow.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_activelow, value, "activelow"); }
		}
		/// <summary>
		/// address
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
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// car counter (only for client info)
		/// </summary>
		public int carcount 
		{
			get { return this.m_carcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_carcount, value, "carcount"); }
		}
		/// <summary>
		/// Train category.
		/// </summary>
		public int category 
		{
			get { return this.m_category.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_category, value, "category"); }
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
		/// number of cars to count before firing the event. (only for client info)
		/// </summary>
		public int countedcars 
		{
			get { return this.m_countedcars.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_countedcars, value, "countedcars"); }
		}
		/// <summary>
		/// occupied counter
		/// </summary>
		public int counter 
		{
			get { return this.m_counter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_counter, value, "counter"); }
		}
		/// <summary>
		/// address
		/// </summary>
		public int ctcaddr 
		{
			get { return this.m_ctcaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcaddr, value, "ctcaddr"); }
		}
		/// <summary>
		/// send a switch command
		/// </summary>
		public bool ctcasswitch 
		{
			get { return this.m_ctcasswitch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcasswitch, value, "ctcasswitch"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int ctcbus 
		{
			get { return this.m_ctcbus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcbus, value, "ctcbus"); }
		}
		/// <summary>
		/// gate of port.
		/// </summary>
		public int ctcgate 
		{
			get { return this.m_ctcgate.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcgate, value, "ctcgate"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string ctciid 
		{
			get { return this.m_ctciid; }
			private set { this.SetField(ref this.m_ctciid, value, "ctciid"); }
		}
		/// <summary>
		/// port of decoder module: 0 = not used.
		/// </summary>
		public int ctcport 
		{
			get { return this.m_ctcport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ctcport, value, "ctcport"); }
		}
		/// <summary>
		/// Curved feedback track.
		/// </summary>
		public bool curve 
		{
			get { return this.m_curve.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_curve, value, "curve"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cutoutaddr 
		{
			get { return this.m_cutoutaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cutoutaddr, value, "cutoutaddr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cutoutbus 
		{
			get { return this.m_cutoutbus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cutoutbus, value, "cutoutbus"); }
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
		/// Loc identifier direction
		/// </summary>
		public bool direction 
		{
			get { return this.m_direction.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_direction, value, "direction"); }
		}
		/// <summary>
		/// feedback type reported by the device
		/// </summary>
		public int fbtype 
		{
			get { return this.m_fbtype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbtype, value, "fbtype"); }
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
		/// Loc identifier
		/// </summary>
		public string identifier 
		{
			get { return this.m_identifier; }
			private set { this.SetField(ref this.m_identifier, value, "identifier"); }
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
		/// extra information
		/// </summary>
		public string info 
		{
			get { return this.m_info; }
			private set { this.SetField(ref this.m_info, value, "info"); }
		}
		/// <summary>
		/// current
		/// </summary>
		public int load 
		{
			get { return this.m_load.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_load, value, "load"); }
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
		/// Send a reset commando in case of a wheel counter type.
		/// </summary>
		public bool resetwc 
		{
			get { return this.m_resetwc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetwc, value, "resetwc"); }
		}
		/// <summary>
		/// Shortcut reported by the cutout sensor; Red background in Rocview.
		/// </summary>
		public bool shortcut 
		{
			get { return this.m_shortcut.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcut, value, "shortcut"); }
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
		/// Current feedback state.
		/// </summary>
		public bool state 
		{
			get { return this.m_state.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Delayed off timer in 100ms units.
		/// </summary>
		public int timer 
		{
			get { return this.m_timer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timer, value, "timer"); }
		}
		/// <summary>
		/// multiple port value
		/// </summary>
		public int val 
		{
			get { return this.m_val.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val, value, "val"); }
		}
		/// <summary>
		/// counted wheels; sofar
		/// </summary>
		public int wheelcount 
		{
			get { return this.m_wheelcount.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wheelcount, value, "wheelcount"); }
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
		/// transponder zone
		/// </summary>
		public string zone 
		{
			get { return this.m_zone; }
			private set { this.SetField(ref this.m_zone, value, "zone"); }
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

		public fb()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static fb Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fb _fb = new fb();
			_fb.m_rocrailClient = rocrailClient;
			_fb.m_accnr = (int?)xml.Attribute("accnr");
			_fb.m_activelow = (bool?)xml.Attribute("activelow");
			_fb.m_addr = (int?)xml.Attribute("addr");
			_fb.m_blockid = (string)xml.Attribute("blockid");
			_fb.m_bus = (int?)xml.Attribute("bus");
			_fb.m_carcount = (int?)xml.Attribute("carcount");
			_fb.m_category = (int?)xml.Attribute("category");
			_fb.m_cmd = (string)xml.Attribute("cmd");
			_fb.m_countedcars = (int?)xml.Attribute("countedcars");
			_fb.m_counter = (int?)xml.Attribute("counter");
			_fb.m_ctcaddr = (int?)xml.Attribute("ctcaddr");
			_fb.m_ctcasswitch = (bool?)xml.Attribute("ctcasswitch");
			_fb.m_ctcbus = (int?)xml.Attribute("ctcbus");
			_fb.m_ctcgate = (int?)xml.Attribute("ctcgate");
			_fb.m_ctciid = (string)xml.Attribute("ctciid");
			_fb.m_ctcport = (int?)xml.Attribute("ctcport");
			_fb.m_curve = (bool?)xml.Attribute("curve");
			_fb.m_cutoutaddr = (int?)xml.Attribute("cutoutaddr");
			_fb.m_cutoutbus = (int?)xml.Attribute("cutoutbus");
			_fb.m_desc = (string)xml.Attribute("desc");
			_fb.m_direction = (bool?)xml.Attribute("direction");
			_fb.m_fbtype = (int?)xml.Attribute("fbtype");
			_fb.m_id = (string)xml.Attribute("id");
			_fb.m_identifier = (string)xml.Attribute("identifier");
			_fb.m_iid = (string)xml.Attribute("iid");
			_fb.m_info = (string)xml.Attribute("info");
			_fb.m_load = (int?)xml.Attribute("load");
			_fb.m_oid = (string)xml.Attribute("oid");
			_fb.m_ori = (string)xml.Attribute("ori");
			_fb.m_resetwc = (bool?)xml.Attribute("resetwc");
			_fb.m_shortcut = (bool?)xml.Attribute("shortcut");
			_fb.m_show = (bool?)xml.Attribute("show");
			_fb.m_state = (bool?)xml.Attribute("state");
			_fb.m_timer = (int?)xml.Attribute("timer");
			_fb.m_val = (int?)xml.Attribute("val");
			_fb.m_wheelcount = (int?)xml.Attribute("wheelcount");
			_fb.m_x = (int?)xml.Attribute("x");
			_fb.m_y = (int?)xml.Attribute("y");
			_fb.m_z = (int?)xml.Attribute("z");
			_fb.m_zone = (string)xml.Attribute("zone");

            if(_fb.id == "D164")
            {

            }

			Definitions.Tools.ParseList<actionctrl>(_fb.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);

            _fb.m_routeids = (string)xml.Attribute("routeids");

			return _fb;
		}
		public void Update(fb element)
		{
			if(element.m_accnr.HasValue == true) this.accnr = element.accnr;
			if(element.m_activelow.HasValue == true) this.activelow = element.activelow;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_carcount.HasValue == true) this.carcount = element.carcount;
			if(element.m_category.HasValue == true) this.category = element.category;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_countedcars.HasValue == true) this.countedcars = element.countedcars;
			if(element.m_counter.HasValue == true) this.counter = element.counter;
			if(element.m_ctcaddr.HasValue == true) this.ctcaddr = element.ctcaddr;
			if(element.m_ctcasswitch.HasValue == true) this.ctcasswitch = element.ctcasswitch;
			if(element.m_ctcbus.HasValue == true) this.ctcbus = element.ctcbus;
			if(element.m_ctcgate.HasValue == true) this.ctcgate = element.ctcgate;
			if(element.m_ctciid != null) this.ctciid = element.ctciid;
			if(element.m_ctcport.HasValue == true) this.ctcport = element.ctcport;
			if(element.m_curve.HasValue == true) this.curve = element.curve;
			if(element.m_cutoutaddr.HasValue == true) this.cutoutaddr = element.cutoutaddr;
			if(element.m_cutoutbus.HasValue == true) this.cutoutbus = element.cutoutbus;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_direction.HasValue == true) this.direction = element.direction;
			if(element.m_fbtype.HasValue == true) this.fbtype = element.fbtype;
			if(element.m_id != null) this.id = element.id;
			if(element.m_identifier != null) this.identifier = element.identifier;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_info != null) this.info = element.info;
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_oid != null) this.oid = element.oid;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_resetwc.HasValue == true) this.resetwc = element.resetwc;
			if(element.m_shortcut.HasValue == true) this.shortcut = element.shortcut;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_state.HasValue == true) this.state = element.state;
			if(element.m_timer.HasValue == true) this.timer = element.timer;
			if(element.m_val.HasValue == true) this.val = element.val;
			if(element.m_wheelcount.HasValue == true) this.wheelcount = element.wheelcount;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			if(element.m_zone != null) this.zone = element.zone;
            //this.actionctrllist = element.actionctrllist;

            if (element.m_routeids != null) this.routeids = element.routeids;
		}
	}
}
