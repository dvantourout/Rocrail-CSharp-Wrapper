using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class car : CRocrailElements
	{
		public const string CARTYPE_FREIGHT = "goods";
		public const string CARTYPE_PASSENGER = "passenger";
		public const string FREIGHT_AUTOCARRIER = "autocarrier";
		public const string FREIGHT_AUTORACK = "autorack";
		public const string FREIGHT_BOXCAR = "boxcar";
		public const string FREIGHT_CABOOSE = "caboose";
		public const string FREIGHT_COILCAR = "coilcar";
		public const string FREIGHT_FLATCAR = "flatcar";
		public const string FREIGHT_GONDOLA = "gondola";
		public const string FREIGHT_HOPPER = "hopper";
		public const string FREIGHT_LOGDUMPCAR = "logdumpcar";
		public const string FREIGHT_REEFER = "reefer";
		public const string FREIGHT_STOCKCAR = "stockcar";
		public const string FREIGHT_TANKCAR = "tankcar";
		public const string FREIGHT_WELLCAR = "wellcar";
		public const string PASSENGER_BAGGAGE = "baggage";
		public const string PASSENGER_COACH = "coach";
		public const string PASSENGER_DINNER = "dinner";
		public const string PASSENGER_DOME = "dome";
		public const string PASSENGER_EXPRESS = "express";
		public const string PASSENGER_LOUNGE = "lounge";
		public const string PASSENGER_POSTOFFICE = "postoffice";
		public const string PASSENGER_SLEEPER = "sleeper";
		public const string STATUS_EMPTY = "empty";
		public const string STATUS_LOADED = "loaded";
		public const string STATUS_MAINTENANCE = "maintenance";
		private int? m_addr;
		private int? m_bus;
		private string m_cmd;
		private string m_color;
		private bool? m_commuter;
		private string m_decfile;
		private int? m_era;
		private bool? m_f0vcmd;
		private int? m_fnlights;
		
		private string m_ident;
		private string m_iid;
		private string m_image;
		private bool? m_invdir;
		private int? m_len;
		private string m_location;
		private string m_manuid;
		private string m_number;
		private string m_owner;
		private bool? m_placing;
		private string m_prot;
		private int? m_protver;
		private string m_remark;
		private string m_roadname;
		private bool? m_show;
		private string m_status;
		private string m_subtype;
		private string m_type;
		private bool? m_usedir;
		private bool? m_uselights;
		private string m_waybills;
		private int? m_weight_empty;
		private int? m_weight_loaded;
		private List<cvbyte> m_cvbytelist;
		private List<fundef> m_fundeflist;
		/// <summary>
		/// Digital address.
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
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
		/// Car command.
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string color 
		{
			get { return this.m_color; }
			private set { this.SetField(ref this.m_color, value, "color"); }
		}
		/// <summary>
		/// Commuter train?
		/// </summary>
		public bool commuter 
		{
			get { return this.m_commuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_commuter, value, "commuter"); }
		}
		/// <summary>
		/// Decoder definition file.
		/// </summary>
		public string decfile 
		{
			get { return this.m_decfile; }
			private set { this.SetField(ref this.m_decfile, value, "decfile"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int era 
		{
			get { return this.m_era.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_era, value, "era"); }
		}
		/// <summary>
		/// Use a speed command for F0.
		/// </summary>
		public bool f0vcmd 
		{
			get { return this.m_f0vcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f0vcmd, value, "f0vcmd"); }
		}
		/// <summary>
		/// Lights function number.
		/// </summary>
		public int fnlights 
		{
			get { return this.m_fnlights.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fnlights, value, "fnlights"); }
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
		public string ident 
		{
			get { return this.m_ident; }
			private set { this.SetField(ref this.m_ident, value, "ident"); }
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
		/// image file to show in dialogs
		/// </summary>
		public string image 
		{
			get { return this.m_image; }
			private set { this.SetField(ref this.m_image, value, "image"); }
		}
		/// <summary>
		/// Invert direction command.
		/// </summary>
		public bool invdir 
		{
			get { return this.m_invdir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_invdir, value, "invdir"); }
		}
		/// <summary>
		/// Car lenght.
		/// </summary>
		public int len 
		{
			get { return this.m_len.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_len, value, "len"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string location 
		{
			get { return this.m_location; }
			private set { this.SetField(ref this.m_location, value, "location"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string manuid 
		{
			get { return this.m_manuid; }
			private set { this.SetField(ref this.m_manuid, value, "manuid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string number 
		{
			get { return this.m_number; }
			private set { this.SetField(ref this.m_number, value, "number"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string owner 
		{
			get { return this.m_owner; }
			private set { this.SetField(ref this.m_owner, value, "owner"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool placing 
		{
			get { return this.m_placing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_placing, value, "placing"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string prot 
		{
			get { return this.m_prot; }
			private set { this.SetField(ref this.m_prot, value, "prot"); }
		}
		/// <summary>
		/// Protocol version
		/// </summary>
		public int protver 
		{
			get { return this.m_protver.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_protver, value, "protver"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark 
		{
			get { return this.m_remark; }
			private set { this.SetField(ref this.m_remark, value, "remark"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string roadname 
		{
			get { return this.m_roadname; }
			private set { this.SetField(ref this.m_roadname, value, "roadname"); }
		}
		/// <summary>
		/// Show in loco table.
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
		}
		/// <summary>
		/// Car status.
		/// </summary>
		public string status 
		{
			get { return this.m_status; }
			private set { this.SetField(ref this.m_status, value, "status"); }
		}
		/// <summary>
		/// Car sub type like Boxcar or gondola.
		/// </summary>
		public string subtype 
		{
			get { return this.m_subtype; }
			private set { this.SetField(ref this.m_subtype, value, "subtype"); }
		}
		/// <summary>
		/// Car main type.
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		/// <summary>
		/// Decoder can process direction command.
		/// </summary>
		public bool usedir 
		{
			get { return this.m_usedir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usedir, value, "usedir"); }
		}
		/// <summary>
		/// Decoder can process direction command.
		/// </summary>
		public bool uselights 
		{
			get { return this.m_uselights.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_uselights, value, "uselights"); }
		}
		/// <summary>
		/// Option for freight cars; where to go and what to load.
		/// </summary>
		public string waybills 
		{
			get { return this.m_waybills; }
			private set { this.SetField(ref this.m_waybills, value, "waybills"); }
		}
		/// <summary>
		/// Car weight empty.
		/// </summary>
		public int weight_empty 
		{
			get { return this.m_weight_empty.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_weight_empty, value, "weight_empty"); }
		}
		/// <summary>
		/// Car weight loaded.
		/// </summary>
		public int weight_loaded 
		{
			get { return this.m_weight_loaded.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_weight_loaded, value, "weight_loaded"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cvbyte> cvbytelist 
		{
			get { return this.m_cvbytelist; }
			private set { this.SetField(ref this.m_cvbytelist, value, "cvbytelist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<fundef> fundeflist 
		{
			get { return this.m_fundeflist; }
			private set { this.SetField(ref this.m_fundeflist, value, "fundeflist"); }
		}
		public car()
		{
			this.m_cvbytelist = new List<cvbyte>();
			this.m_fundeflist = new List<fundef>();
		}
		public static car Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			car _car = new car();
			_car.m_rocrailClient = rocrailClient;
			_car.m_addr = (int?)xml.Attribute("addr");
			_car.m_bus = (int?)xml.Attribute("bus");
			_car.m_cmd = (string)xml.Attribute("cmd");
			_car.m_color = (string)xml.Attribute("color");
			_car.m_commuter = (bool?)xml.Attribute("commuter");
			_car.m_decfile = (string)xml.Attribute("decfile");
			_car.m_era = (int?)xml.Attribute("era");
			_car.m_f0vcmd = (bool?)xml.Attribute("f0vcmd");
			_car.m_fnlights = (int?)xml.Attribute("fnlights");
			_car.m_id = (string)xml.Attribute("id");
			_car.m_ident = (string)xml.Attribute("ident");
			_car.m_iid = (string)xml.Attribute("iid");
			_car.m_image = (string)xml.Attribute("image");
			_car.m_invdir = (bool?)xml.Attribute("invdir");
			_car.m_len = (int?)xml.Attribute("len");
			_car.m_location = (string)xml.Attribute("location");
			_car.m_manuid = (string)xml.Attribute("manuid");
			_car.m_number = (string)xml.Attribute("number");
			_car.m_owner = (string)xml.Attribute("owner");
			_car.m_placing = (bool?)xml.Attribute("placing");
			_car.m_prot = (string)xml.Attribute("prot");
			_car.m_protver = (int?)xml.Attribute("protver");
			_car.m_remark = (string)xml.Attribute("remark");
			_car.m_roadname = (string)xml.Attribute("roadname");
			_car.m_show = (bool?)xml.Attribute("show");
			_car.m_status = (string)xml.Attribute("status");
			_car.m_subtype = (string)xml.Attribute("subtype");
			_car.m_type = (string)xml.Attribute("type");
			_car.m_usedir = (bool?)xml.Attribute("usedir");
			_car.m_uselights = (bool?)xml.Attribute("uselights");
			_car.m_waybills = (string)xml.Attribute("waybills");
			_car.m_weight_empty = (int?)xml.Attribute("weight_empty");
			_car.m_weight_loaded = (int?)xml.Attribute("weight_loaded");
			Definitions.Tools.ParseList<cvbyte>(_car.m_cvbytelist, xml, "cvbyte", cvbyte.Parse, rocrailClient);
			Definitions.Tools.ParseList<fundef>(_car.m_fundeflist, xml, "fundef", fundef.Parse, rocrailClient);
			return _car;
		}
		public void Update(car element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_color != null) this.color = element.color;
			if(element.m_commuter.HasValue == true) this.commuter = element.commuter;
			if(element.m_decfile != null) this.decfile = element.decfile;
			if(element.m_era.HasValue == true) this.era = element.era;
			if(element.m_f0vcmd.HasValue == true) this.f0vcmd = element.f0vcmd;
			if(element.m_fnlights.HasValue == true) this.fnlights = element.fnlights;
			if(element.m_id != null) this.id = element.id;
			if(element.m_ident != null) this.ident = element.ident;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_image != null) this.image = element.image;
			if(element.m_invdir.HasValue == true) this.invdir = element.invdir;
			if(element.m_len.HasValue == true) this.len = element.len;
			if(element.m_location != null) this.location = element.location;
			if(element.m_manuid != null) this.manuid = element.manuid;
			if(element.m_number != null) this.number = element.number;
			if(element.m_owner != null) this.owner = element.owner;
			if(element.m_placing.HasValue == true) this.placing = element.placing;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_protver.HasValue == true) this.protver = element.protver;
			if(element.m_remark != null) this.remark = element.remark;
			if(element.m_roadname != null) this.roadname = element.roadname;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_status != null) this.status = element.status;
			if(element.m_subtype != null) this.subtype = element.subtype;
			if(element.m_type != null) this.type = element.type;
			if(element.m_usedir.HasValue == true) this.usedir = element.usedir;
			if(element.m_uselights.HasValue == true) this.uselights = element.uselights;
			if(element.m_waybills != null) this.waybills = element.waybills;
			if(element.m_weight_empty.HasValue == true) this.weight_empty = element.weight_empty;
			if(element.m_weight_loaded.HasValue == true) this.weight_loaded = element.weight_loaded;
			this.cvbytelist = element.cvbytelist;
			this.fundeflist = element.fundeflist;
		}
	}
}
