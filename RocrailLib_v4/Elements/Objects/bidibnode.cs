using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class bidibnode : CRocrailElements
	{
		public const string CLASS_ACCESSORY = "accessory";
		public const string CLASS_BOOSTER = "booster";
		public const string CLASS_BRIDGE = "bridge";
		public const string CLASS_DCC_MAIN = "dcc_main";
		public const string CLASS_DCC_PROG = "dcc_prog";
		public const string CLASS_SENSOR = "sensor";
		public const string CLASS_SWITCH = "switch";
		public const string CLASS_UI = "ui";
		private int? m_analogcnt;
		private string m_class;
		private string m_classmnemonic;
		private int? m_inputcnt;
		private int? m_lportcnt;
		private int? m_motorcnt;
		private string m_path;
		private int? m_sensorcnt;
		private int? m_servocnt;
		private int? m_soundcnt;
		private int? m_sportcnt;
		private int? m_uid;
		private int? m_vendor;
		private string m_version;
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int analogcnt 
		{
			get { return this.m_analogcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_analogcnt, value, "analogcnt"); }
		}
		/// <summary>
		/// Class ID.
		/// </summary>
		public string @class 
		{
			get { return this.m_class; }
			private set { this.SetField(ref this.m_class, value, "@class"); }
		}
		/// <summary>
		/// Class ID mnemonic.
		/// </summary>
		public string classmnemonic 
		{
			get { return this.m_classmnemonic; }
			private set { this.SetField(ref this.m_classmnemonic, value, "classmnemonic"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int inputcnt 
		{
			get { return this.m_inputcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inputcnt, value, "inputcnt"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int lportcnt 
		{
			get { return this.m_lportcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lportcnt, value, "lportcnt"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int motorcnt 
		{
			get { return this.m_motorcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_motorcnt, value, "motorcnt"); }
		}
		/// <summary>
		/// Local path.
		/// </summary>
		public string path 
		{
			get { return this.m_path; }
			private set { this.SetField(ref this.m_path, value, "path"); }
		}
		/// <summary>
		/// Number of sensors.
		/// </summary>
		public int sensorcnt 
		{
			get { return this.m_sensorcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sensorcnt, value, "sensorcnt"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int servocnt 
		{
			get { return this.m_servocnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_servocnt, value, "servocnt"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int soundcnt 
		{
			get { return this.m_soundcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_soundcnt, value, "soundcnt"); }
		}
		/// <summary>
		/// Number of ports.
		/// </summary>
		public int sportcnt 
		{
			get { return this.m_sportcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sportcnt, value, "sportcnt"); }
		}
		/// <summary>
		/// Vendor product/serialnumber ID.
		/// </summary>
		public int uid 
		{
			get { return this.m_uid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_uid, value, "uid"); }
		}
		/// <summary>
		/// DCC vendor ID.
		/// </summary>
		public int vendor 
		{
			get { return this.m_vendor.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_vendor, value, "vendor"); }
		}
		/// <summary>
		/// Software version.
		/// </summary>
		public string version 
		{
			get { return this.m_version; }
			private set { this.SetField(ref this.m_version, value, "version"); }
		}
		public bidibnode()
		{
		}
		public static bidibnode Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			bidibnode _bidibnode = new bidibnode();
			_bidibnode.m_rocrailClient = rocrailClient;
			_bidibnode.m_analogcnt = (int?)xml.Attribute("analogcnt");
			_bidibnode.m_class = (string)xml.Attribute("class");
			_bidibnode.m_classmnemonic = (string)xml.Attribute("classmnemonic");
			_bidibnode.m_inputcnt = (int?)xml.Attribute("inputcnt");
			_bidibnode.m_lportcnt = (int?)xml.Attribute("lportcnt");
			_bidibnode.m_motorcnt = (int?)xml.Attribute("motorcnt");
			_bidibnode.m_path = (string)xml.Attribute("path");
			_bidibnode.m_sensorcnt = (int?)xml.Attribute("sensorcnt");
			_bidibnode.m_servocnt = (int?)xml.Attribute("servocnt");
			_bidibnode.m_soundcnt = (int?)xml.Attribute("soundcnt");
			_bidibnode.m_sportcnt = (int?)xml.Attribute("sportcnt");
			_bidibnode.m_uid = (int?)xml.Attribute("uid");
			_bidibnode.m_vendor = (int?)xml.Attribute("vendor");
			_bidibnode.m_version = (string)xml.Attribute("version");
			return _bidibnode;
		}
		public void Update(bidibnode element)
		{
			if(element.m_analogcnt.HasValue == true) this.analogcnt = element.analogcnt;
			if(element.m_class != null) this.@class = element.@class;
			if(element.m_classmnemonic != null) this.classmnemonic = element.classmnemonic;
			if(element.m_inputcnt.HasValue == true) this.inputcnt = element.inputcnt;
			if(element.m_lportcnt.HasValue == true) this.lportcnt = element.lportcnt;
			if(element.m_motorcnt.HasValue == true) this.motorcnt = element.motorcnt;
			if(element.m_path != null) this.path = element.path;
			if(element.m_sensorcnt.HasValue == true) this.sensorcnt = element.sensorcnt;
			if(element.m_servocnt.HasValue == true) this.servocnt = element.servocnt;
			if(element.m_soundcnt.HasValue == true) this.soundcnt = element.soundcnt;
			if(element.m_sportcnt.HasValue == true) this.sportcnt = element.sportcnt;
			if(element.m_uid.HasValue == true) this.uid = element.uid;
			if(element.m_vendor.HasValue == true) this.vendor = element.vendor;
			if(element.m_version != null) this.version = element.version;
		}
	}
}
