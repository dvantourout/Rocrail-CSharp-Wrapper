using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class dipgroup : CRocrailElements
	{
		public const int GROUPTYPE_BOX = 1;
		public const int GROUPTYPE_RADIOBOX = 0;
		private string m_caption;
		private int? m_mask;
		private int? m_ori;
		private int? m_spacing;
		private int? m_type;
		private List<dipvalue> m_dipvaluelist;
		/// <summary>
		/// 
		/// </summary>
		public string caption 
		{
			get { return this.m_caption; }
			private set { this.SetField(ref this.m_caption, value, "caption"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int mask 
		{
			get { return this.m_mask.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mask, value, "mask"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int ori 
		{
			get { return this.m_ori.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ori, value, "ori"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int spacing 
		{
			get { return this.m_spacing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_spacing, value, "spacing"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int type 
		{
			get { return this.m_type.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<dipvalue> dipvaluelist 
		{
			get { return this.m_dipvaluelist; }
			private set { this.SetField(ref this.m_dipvaluelist, value, "dipvaluelist"); }
		}
		public dipgroup()
		{
			this.m_dipvaluelist = new List<dipvalue>();
		}
		public static dipgroup Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			dipgroup _dipgroup = new dipgroup();
			_dipgroup.m_rocrailClient = rocrailClient;
			_dipgroup.m_caption = (string)xml.Attribute("caption");
			_dipgroup.m_mask = (int?)xml.Attribute("mask");
			_dipgroup.m_ori = (int?)xml.Attribute("ori");
			_dipgroup.m_spacing = (int?)xml.Attribute("spacing");
			_dipgroup.m_type = (int?)xml.Attribute("type");
			Definitions.Tools.ParseList<dipvalue>(_dipgroup.m_dipvaluelist, xml, "dipvalue", dipvalue.Parse, rocrailClient);
			return _dipgroup;
		}
		public void Update(dipgroup element)
		{
			if(element.m_caption != null) this.caption = element.caption;
			if(element.m_mask.HasValue == true) this.mask = element.mask;
			if(element.m_ori.HasValue == true) this.ori = element.ori;
			if(element.m_spacing.HasValue == true) this.spacing = element.spacing;
			if(element.m_type.HasValue == true) this.type = element.type;
			this.dipvaluelist = element.dipvaluelist;
		}
	}
}
