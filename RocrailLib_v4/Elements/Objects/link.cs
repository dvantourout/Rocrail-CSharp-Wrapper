using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class link : CRocrailElements
	{
		public const int USAGE_CRITSECT = 1;
		public const int USAGE_MANUAL = 0;
		private bool? m_active;
		private bool? m_allowfollowup;
		private string m_desc;
		private string m_dst;
		
		private int? m_maxfollowup;
		private string m_src;
		private int? m_usage;
		private List<linkcond> m_linkcondlist;
		/// <summary>
		/// Activates links: all blocks are set to manual mode.
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// Allow follow up in critsec for the same direction.
		/// </summary>
		public bool allowfollowup 
		{
			get { return this.m_allowfollowup.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_allowfollowup, value, "allowfollowup"); }
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
		/// destination blocks; id's in CSV format
		/// </summary>
		public string dst 
		{
			get { return this.m_dst; }
			private set { this.SetField(ref this.m_dst, value, "dst"); }
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
		/// Max. trains to follow up.
		/// </summary>
		public int maxfollowup 
		{
			get { return this.m_maxfollowup.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxfollowup, value, "maxfollowup"); }
		}
		/// <summary>
		/// source block
		/// </summary>
		public string src 
		{
			get { return this.m_src; }
			private set { this.SetField(ref this.m_src, value, "src"); }
		}
		/// <summary>
		/// group usage
		/// </summary>
		public int usage 
		{
			get { return this.m_usage.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usage, value, "usage"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<linkcond> linkcondlist 
		{
			get { return this.m_linkcondlist; }
			private set { this.SetField(ref this.m_linkcondlist, value, "linkcondlist"); }
		}
		public link()
		{
			this.m_linkcondlist = new List<linkcond>();
		}
		public static link Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			link _link = new link();
			_link.m_rocrailClient = rocrailClient;
			_link.m_active = (bool?)xml.Attribute("active");
			_link.m_allowfollowup = (bool?)xml.Attribute("allowfollowup");
			_link.m_desc = (string)xml.Attribute("desc");
			_link.m_dst = (string)xml.Attribute("dst");
			_link.m_id = (string)xml.Attribute("id");
			_link.m_maxfollowup = (int?)xml.Attribute("maxfollowup");
			_link.m_src = (string)xml.Attribute("src");
			_link.m_usage = (int?)xml.Attribute("usage");
			Definitions.Tools.ParseList<linkcond>(_link.m_linkcondlist, xml, "linkcond", linkcond.Parse, rocrailClient);
			return _link;
		}
		public void Update(link element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_allowfollowup.HasValue == true) this.allowfollowup = element.allowfollowup;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_dst != null) this.dst = element.dst;
			if(element.m_id != null) this.id = element.id;
			if(element.m_maxfollowup.HasValue == true) this.maxfollowup = element.maxfollowup;
			if(element.m_src != null) this.src = element.src;
			if(element.m_usage.HasValue == true) this.usage = element.usage;
			this.linkcondlist = element.linkcondlist;
		}
	}
}
