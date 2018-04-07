using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class adip : CRocrailElements
	{
		
		private string m_title;
		private List<dipgroup> m_dipgrouplist;
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
		public string title 
		{
			get { return this.m_title; }
			private set { this.SetField(ref this.m_title, value, "title"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<dipgroup> dipgrouplist 
		{
			get { return this.m_dipgrouplist; }
			private set { this.SetField(ref this.m_dipgrouplist, value, "dipgrouplist"); }
		}
		public adip()
		{
			this.m_dipgrouplist = new List<dipgroup>();
		}
		public static adip Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			adip _adip = new adip();
			_adip.m_rocrailClient = rocrailClient;
			_adip.m_id = (string)xml.Attribute("id");
			_adip.m_title = (string)xml.Attribute("title");
			Definitions.Tools.ParseList<dipgroup>(_adip.m_dipgrouplist, xml, "dipgroup", dipgroup.Parse, rocrailClient);
			return _adip;
		}
		public void Update(adip element)
		{
			if(element.m_id != null) this.id = element.id;
			if(element.m_title != null) this.title = element.title;
			this.dipgrouplist = element.dipgrouplist;
		}
	}
}
