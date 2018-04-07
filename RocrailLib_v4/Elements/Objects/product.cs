using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class product : CRocrailElements
	{
		private int? m_cid;
		private int? m_cidext;
		private string m_desc;
		private int? m_pid;
		private int? m_sid;
		private string m_url;
		private int? m_vid;
		private List<description> m_descriptionlist;
		/// <summary>
		/// Class ID
		/// </summary>
		public int cid 
		{
			get { return this.m_cid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cid, value, "cid"); }
		}
		/// <summary>
		/// Class ID extension
		/// </summary>
		public int cidext 
		{
			get { return this.m_cidext.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cidext, value, "cidext"); }
		}
		/// <summary>
		/// Description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Product ID
		/// </summary>
		public int pid 
		{
			get { return this.m_pid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pid, value, "pid"); }
		}
		/// <summary>
		/// System ID
		/// </summary>
		public int sid 
		{
			get { return this.m_sid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sid, value, "sid"); }
		}
		/// <summary>
		/// Documentation URL
		/// </summary>
		public string url 
		{
			get { return this.m_url; }
			private set { this.SetField(ref this.m_url, value, "url"); }
		}
		/// <summary>
		/// Vendor ID
		/// </summary>
		public int vid 
		{
			get { return this.m_vid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_vid, value, "vid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<description> descriptionlist 
		{
			get { return this.m_descriptionlist; }
			private set { this.SetField(ref this.m_descriptionlist, value, "descriptionlist"); }
		}
		public product()
		{
			this.m_descriptionlist = new List<description>();
		}
		public static product Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			product _product = new product();
			_product.m_rocrailClient = rocrailClient;
			_product.m_cid = (int?)xml.Attribute("cid");
			_product.m_cidext = (int?)xml.Attribute("cidext");
			_product.m_desc = (string)xml.Attribute("desc");
			_product.m_pid = (int?)xml.Attribute("pid");
			_product.m_sid = (int?)xml.Attribute("sid");
			_product.m_url = (string)xml.Attribute("url");
			_product.m_vid = (int?)xml.Attribute("vid");
			Definitions.Tools.ParseList<description>(_product.m_descriptionlist, xml, "description", description.Parse, rocrailClient);
			return _product;
		}
		public void Update(product element)
		{
			if(element.m_cid.HasValue == true) this.cid = element.cid;
			if(element.m_cidext.HasValue == true) this.cidext = element.cidext;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_pid.HasValue == true) this.pid = element.pid;
			if(element.m_sid.HasValue == true) this.sid = element.sid;
			if(element.m_url != null) this.url = element.url;
			if(element.m_vid.HasValue == true) this.vid = element.vid;
			this.descriptionlist = element.descriptionlist;
		}
	}
}
