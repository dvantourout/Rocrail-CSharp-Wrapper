using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class SnmpService : CRocrailElements
	{
		public const string PRIVBUILDTIME = "1.3.6.1.4.1.37707.1.1.1.0";
		public const string PRIVCONNECTIONCNT = "1.3.6.1.4.1.37707.1.1.3.0";
		public const string PRIVLASTEXC = "1.3.6.1.4.1.37707.1.1.5.0";
		public const string PRIVMEMSTATS = "1.3.6.1.4.1.37707.1.1.4.0";
		public const string PRIVTHREADCNT = "1.3.6.1.4.1.37707.1.1.2.0";
		public const string PRIVTRAPEXCEPTION = "1.3.6.1.4.1.37707.1.1.10.1.0";
		public const string PRIVTRAPSHUTDOWN = "1.3.6.1.4.1.37707.1.1.10.2.0";
		public const string PRIVATELIST = "1.3.6.1.4.1.37707.1.1";
		public const string SYSCONTACT = "1.3.6.1.2.1.1.4.0";
		public const string SYSDESCR = "1.3.6.1.2.1.1.1.0";
		public const string SYSLOCATION = "1.3.6.1.2.1.1.6.0";
		public const string SYSNAME = "1.3.6.1.2.1.1.5.0";
		public const string SYSOBJECTID = "1.3.6.1.2.1.1.2.0";
		public const string SYSSERVICES = "1.3.6.1.2.1.1.7.0";
		public const string SYSUPTIME = "1.3.6.1.2.1.1.3.0";
		public const string SYSTEMLIST = "1.3.6.1.2.1.1";
		public const string TRAPCOLDSTART = "1.3.6.1.6.3.1.1.5.1.0";
		public const string TRAPLINKDOWN = "1.3.6.1.6.3.1.1.5.3.0";
		public const string TRAPLINKUP = "1.3.6.1.6.3.1.1.5.4.0";
		private bool? m_active;
		private string m_community;
		private string m_contact;
		private string m_description;
		private int? m_enterprise;
		private int? m_family;
		private string m_location;
		private int? m_port;
		private int? m_product;
		private string m_traphost;
		private int? m_trapport;
		private int? m_version;
		/// <summary>
		/// Activate snmp service.
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string community 
		{
			get { return this.m_community; }
			private set { this.SetField(ref this.m_community, value, "community"); }
		}
		/// <summary>
		/// Contact address.
		/// </summary>
		public string contact 
		{
			get { return this.m_contact; }
			private set { this.SetField(ref this.m_contact, value, "contact"); }
		}
		/// <summary>
		/// Rocrail server description.
		/// </summary>
		public string description 
		{
			get { return this.m_description; }
			private set { this.SetField(ref this.m_description, value, "description"); }
		}
		/// <summary>
		/// http://www.iana.org/assignments/enterprise-numbers
		/// </summary>
		public int enterprise 
		{
			get { return this.m_enterprise.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_enterprise, value, "enterprise"); }
		}
		/// <summary>
		/// Product family; Default Rocrail=1.
		/// </summary>
		public int family 
		{
			get { return this.m_family.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_family, value, "family"); }
		}
		/// <summary>
		/// Rocrail physical location.
		/// </summary>
		public string location 
		{
			get { return this.m_location; }
			private set { this.SetField(ref this.m_location, value, "location"); }
		}
		/// <summary>
		/// Port number for server socket.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// Product; Default Server=1.
		/// </summary>
		public int product 
		{
			get { return this.m_product.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_product, value, "product"); }
		}
		/// <summary>
		/// Trap host.
		/// </summary>
		public string traphost 
		{
			get { return this.m_traphost; }
			private set { this.SetField(ref this.m_traphost, value, "traphost"); }
		}
		/// <summary>
		/// Trap port number.
		/// </summary>
		public int trapport 
		{
			get { return this.m_trapport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_trapport, value, "trapport"); }
		}
		/// <summary>
		/// SNMP version.
		/// </summary>
		public int version 
		{
			get { return this.m_version.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_version, value, "version"); }
		}
		public SnmpService()
		{
		}
		public static SnmpService Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			SnmpService _SnmpService = new SnmpService();
			_SnmpService.m_rocrailClient = rocrailClient;
			_SnmpService.m_active = (bool?)xml.Attribute("active");
			_SnmpService.m_community = (string)xml.Attribute("community");
			_SnmpService.m_contact = (string)xml.Attribute("contact");
			_SnmpService.m_description = (string)xml.Attribute("description");
			_SnmpService.m_enterprise = (int?)xml.Attribute("enterprise");
			_SnmpService.m_family = (int?)xml.Attribute("family");
			_SnmpService.m_location = (string)xml.Attribute("location");
			_SnmpService.m_port = (int?)xml.Attribute("port");
			_SnmpService.m_product = (int?)xml.Attribute("product");
			_SnmpService.m_traphost = (string)xml.Attribute("traphost");
			_SnmpService.m_trapport = (int?)xml.Attribute("trapport");
			_SnmpService.m_version = (int?)xml.Attribute("version");
			return _SnmpService;
		}
		public void Update(SnmpService element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_community != null) this.community = element.community;
			if(element.m_contact != null) this.contact = element.contact;
			if(element.m_description != null) this.description = element.description;
			if(element.m_enterprise.HasValue == true) this.enterprise = element.enterprise;
			if(element.m_family.HasValue == true) this.family = element.family;
			if(element.m_location != null) this.location = element.location;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_product.HasValue == true) this.product = element.product;
			if(element.m_traphost != null) this.traphost = element.traphost;
			if(element.m_trapport.HasValue == true) this.trapport = element.trapport;
			if(element.m_version.HasValue == true) this.version = element.version;
		}
	}
}
