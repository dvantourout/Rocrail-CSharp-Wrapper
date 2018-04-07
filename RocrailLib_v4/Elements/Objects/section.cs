using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class section : CRocrailElements
	{
		private string m_action;
		private string m_fbid;
		private string m_fbidocc;
		
		private int? m_idx;
		private string m_lcid;
		private int? m_len;
		private int? m_nr;
		/// <summary>
		/// 
		/// </summary>
		public string action 
		{
			get { return this.m_action; }
			private set { this.SetField(ref this.m_action, value, "action"); }
		}
		/// <summary>
		/// feedback ID
		/// </summary>
		public string fbid 
		{
			get { return this.m_fbid; }
			private set { this.SetField(ref this.m_fbid, value, "fbid"); }
		}
		/// <summary>
		/// feedback ID of section body.
		/// </summary>
		public string fbidocc 
		{
			get { return this.m_fbidocc; }
			private set { this.SetField(ref this.m_fbidocc, value, "fbidocc"); }
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
		public int idx 
		{
			get { return this.m_idx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_idx, value, "idx"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lcid 
		{
			get { return this.m_lcid; }
			private set { this.SetField(ref this.m_lcid, value, "lcid"); }
		}
		/// <summary>
		/// Section length.
		/// </summary>
		public int len 
		{
			get { return this.m_len.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_len, value, "len"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		public section()
		{
		}
		public static section Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			section _section = new section();
			_section.m_rocrailClient = rocrailClient;
			_section.m_action = (string)xml.Attribute("action");
			_section.m_fbid = (string)xml.Attribute("fbid");
			_section.m_fbidocc = (string)xml.Attribute("fbidocc");
			_section.m_id = (string)xml.Attribute("id");
			_section.m_idx = (int?)xml.Attribute("idx");
			_section.m_lcid = (string)xml.Attribute("lcid");
			_section.m_len = (int?)xml.Attribute("len");
			_section.m_nr = (int?)xml.Attribute("nr");
			return _section;
		}
		public void Update(section element)
		{
			if(element.m_action != null) this.action = element.action;
			if(element.m_fbid != null) this.fbid = element.fbid;
			if(element.m_fbidocc != null) this.fbidocc = element.fbidocc;
			if(element.m_id != null) this.id = element.id;
			if(element.m_idx.HasValue == true) this.idx = element.idx;
			if(element.m_lcid != null) this.lcid = element.lcid;
			if(element.m_len.HasValue == true) this.len = element.len;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
		}
	}
}
