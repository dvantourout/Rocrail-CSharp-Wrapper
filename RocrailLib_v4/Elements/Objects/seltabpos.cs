using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class seltabpos : CRocrailElements
	{
		private string m_bkid;
		private string m_desc;
		private int? m_nr;
		private string m_s1id;
		private string m_s2id;
		/// <summary>
		/// block id
		/// </summary>
		public string bkid 
		{
			get { return this.m_bkid; }
			private set { this.SetField(ref this.m_bkid, value, "bkid"); }
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
		/// position
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// sensor 1 id for optical feedback of the selected position
		/// </summary>
		public string s1id 
		{
			get { return this.m_s1id; }
			private set { this.SetField(ref this.m_s1id, value, "s1id"); }
		}
		/// <summary>
		/// sensor 2 id for optical feedback of the selected position
		/// </summary>
		public string s2id 
		{
			get { return this.m_s2id; }
			private set { this.SetField(ref this.m_s2id, value, "s2id"); }
		}
		public seltabpos()
		{
		}
		public static seltabpos Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			seltabpos _seltabpos = new seltabpos();
			_seltabpos.m_rocrailClient = rocrailClient;
			_seltabpos.m_bkid = (string)xml.Attribute("bkid");
			_seltabpos.m_desc = (string)xml.Attribute("desc");
			_seltabpos.m_nr = (int?)xml.Attribute("nr");
			_seltabpos.m_s1id = (string)xml.Attribute("s1id");
			_seltabpos.m_s2id = (string)xml.Attribute("s2id");
			return _seltabpos;
		}
		public void Update(seltabpos element)
		{
			if(element.m_bkid != null) this.bkid = element.bkid;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_s1id != null) this.s1id = element.s1id;
			if(element.m_s2id != null) this.s2id = element.s2id;
		}
	}
}
