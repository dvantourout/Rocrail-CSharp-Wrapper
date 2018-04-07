using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class modplan : CRocrailElements
	{
		private bool? m_initfield;
		private string m_locs;
		private bool? m_modified;
		private bool? m_modroutes;
		private string m_routes;
		private bool? m_savemodplan;
		private bool? m_savemodules;
		private string m_subtitle;
		private string m_title;
		private List<module> m_modulelist;
		/// <summary>
		/// 
		/// </summary>
		public bool initfield 
		{
			get { return this.m_initfield.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_initfield, value, "initfield"); }
		}
		/// <summary>
		/// File name of locomotive definitions.
		/// </summary>
		public string locs 
		{
			get { return this.m_locs; }
			private set { this.SetField(ref this.m_locs, value, "locs"); }
		}
		/// <summary>
		/// Flags module as modified by the GUI. (Internal use only)
		/// </summary>
		public bool modified 
		{
			get { return this.m_modified.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modified, value, "modified"); }
		}
		/// <summary>
		/// Use internal module routes in conjunction with connections.
		/// </summary>
		public bool modroutes 
		{
			get { return this.m_modroutes.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modroutes, value, "modroutes"); }
		}
		/// <summary>
		/// File name of route and schedule definitions.
		/// </summary>
		public string routes 
		{
			get { return this.m_routes; }
			private set { this.SetField(ref this.m_routes, value, "routes"); }
		}
		/// <summary>
		/// Make sure locs and routes are in separate files and not part of a module!
		/// </summary>
		public bool savemodplan 
		{
			get { return this.m_savemodplan.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_savemodplan, value, "savemodplan"); }
		}
		/// <summary>
		/// Leave modules un touched if set to false, but all changes are lost.
		/// </summary>
		public bool savemodules 
		{
			get { return this.m_savemodules.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_savemodules, value, "savemodules"); }
		}
		/// <summary>
		/// Sub title of plan.
		/// </summary>
		public string subtitle 
		{
			get { return this.m_subtitle; }
			private set { this.SetField(ref this.m_subtitle, value, "subtitle"); }
		}
		/// <summary>
		/// Title of plan.
		/// </summary>
		public string title 
		{
			get { return this.m_title; }
			private set { this.SetField(ref this.m_title, value, "title"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<module> modulelist 
		{
			get { return this.m_modulelist; }
			private set { this.SetField(ref this.m_modulelist, value, "modulelist"); }
		}
		public modplan()
		{
			this.m_modulelist = new List<module>();
		}
		public static modplan Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			modplan _modplan = new modplan();
			_modplan.m_rocrailClient = rocrailClient;
			_modplan.m_initfield = (bool?)xml.Attribute("initfield");
			_modplan.m_locs = (string)xml.Attribute("locs");
			_modplan.m_modified = (bool?)xml.Attribute("modified");
			_modplan.m_modroutes = (bool?)xml.Attribute("modroutes");
			_modplan.m_routes = (string)xml.Attribute("routes");
			_modplan.m_savemodplan = (bool?)xml.Attribute("savemodplan");
			_modplan.m_savemodules = (bool?)xml.Attribute("savemodules");
			_modplan.m_subtitle = (string)xml.Attribute("subtitle");
			_modplan.m_title = (string)xml.Attribute("title");
			Definitions.Tools.ParseList<module>(_modplan.m_modulelist, xml, "module", module.Parse, rocrailClient);
			return _modplan;
		}
		public void Update(modplan element)
		{
			if(element.m_initfield.HasValue == true) this.initfield = element.initfield;
			if(element.m_locs != null) this.locs = element.locs;
			if(element.m_modified.HasValue == true) this.modified = element.modified;
			if(element.m_modroutes.HasValue == true) this.modroutes = element.modroutes;
			if(element.m_routes != null) this.routes = element.routes;
			if(element.m_savemodplan.HasValue == true) this.savemodplan = element.savemodplan;
			if(element.m_savemodules.HasValue == true) this.savemodules = element.savemodules;
			if(element.m_subtitle != null) this.subtitle = element.subtitle;
			if(element.m_title != null) this.title = element.title;
			this.modulelist = element.modulelist;
		}
	}
}
