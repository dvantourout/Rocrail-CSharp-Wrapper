using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class zlevel : CRocrailElements
	{
		private bool? m_active;
		private string m_modid;
		private int? m_modviewcx;
		private int? m_modviewcy;
		private int? m_modviewx;
		private int? m_modviewy;
		private string m_title;
		private int? m_z;
		/// <summary>
		/// active notebook page
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// module ID
		/// </summary>
		public string modid 
		{
			get { return this.m_modid; }
			private set { this.SetField(ref this.m_modid, value, "modid"); }
		}
		/// <summary>
		/// x size on an overview panel
		/// </summary>
		public int modviewcx 
		{
			get { return this.m_modviewcx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modviewcx, value, "modviewcx"); }
		}
		/// <summary>
		/// y size on an overview panel
		/// </summary>
		public int modviewcy 
		{
			get { return this.m_modviewcy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modviewcy, value, "modviewcy"); }
		}
		/// <summary>
		/// x position on an overview panel
		/// </summary>
		public int modviewx 
		{
			get { return this.m_modviewx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modviewx, value, "modviewx"); }
		}
		/// <summary>
		/// y position on an overview panel
		/// </summary>
		public int modviewy 
		{
			get { return this.m_modviewy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modviewy, value, "modviewy"); }
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
		public int z 
		{
			get { return this.m_z.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_z, value, "z"); }
		}
		public zlevel()
		{
		}
		public static zlevel Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			zlevel _zlevel = new zlevel();
			_zlevel.m_rocrailClient = rocrailClient;
			_zlevel.m_active = (bool?)xml.Attribute("active");
			_zlevel.m_modid = (string)xml.Attribute("modid");
			_zlevel.m_modviewcx = (int?)xml.Attribute("modviewcx");
			_zlevel.m_modviewcy = (int?)xml.Attribute("modviewcy");
			_zlevel.m_modviewx = (int?)xml.Attribute("modviewx");
			_zlevel.m_modviewy = (int?)xml.Attribute("modviewy");
			_zlevel.m_title = (string)xml.Attribute("title");
			_zlevel.m_z = (int?)xml.Attribute("z");
			return _zlevel;
		}
		public void Update(zlevel element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_modid != null) this.modid = element.modid;
			if(element.m_modviewcx.HasValue == true) this.modviewcx = element.modviewcx;
			if(element.m_modviewcy.HasValue == true) this.modviewcy = element.modviewcy;
			if(element.m_modviewx.HasValue == true) this.modviewx = element.modviewx;
			if(element.m_modviewy.HasValue == true) this.modviewy = element.modviewy;
			if(element.m_title != null) this.title = element.title;
			if(element.m_z.HasValue == true) this.z = element.z;
		}
	}
}
