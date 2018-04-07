using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class plan : CRocrailElements
	{
		private bool? m_donkey;
		private bool? m_healthy;
		private bool? m_modplan;
		private string m_modtitle;
		private string m_name;
		private string m_rocguiversion;
		private string m_rocrailpwd;
		private string m_rocrailversion;
		private string m_themes;
		private string m_title;
		private List<ac> m_aclist;
		private List<bk> m_bklist;
		private List<booster> m_boosterlist;
		private List<car> m_carlist;
		private List<co> m_colist;
		private List<dec> m_declist;
		private List<digint> m_digintlist;
		private List<fb> m_fblist;
		private List<lc> m_lclist;
		private List<link> m_linklist;
		private List<location> m_locationlist;
		private List<mv> m_mvlist;
		private List<@operator> m_operatorlist;
		private List<sb> m_sblist;
		private List<sc> m_sclist;
		private List<seltab> m_seltablist;
		private List<sg> m_sglist;
		private List<st> m_stlist;
		private List<sw> m_swlist;
		private List<system> m_systemlist;
		private List<tk> m_tklist;
		private List<tour> m_tourlist;
		private List<traverser> m_traverserlist;
		private List<tt> m_ttlist;
		private List<tx> m_txlist;
		private List<waybill> m_waybilllist;
		private List<zlevel> m_zlevellist;
		/// <summary>
		/// Flags if a valid donation key is found.
		/// </summary>
		public bool donkey 
		{
			get { return this.m_donkey.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_donkey, value, "donkey"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool healthy 
		{
			get { return this.m_healthy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_healthy, value, "healthy"); }
		}
		/// <summary>
		/// Flags the Rocview if it is assembled from a modular layout definition.
		/// </summary>
		public bool modplan 
		{
			get { return this.m_modplan.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modplan, value, "modplan"); }
		}
		/// <summary>
		/// Title of plan.
		/// </summary>
		public string modtitle 
		{
			get { return this.m_modtitle; }
			private set { this.SetField(ref this.m_modtitle, value, "modtitle"); }
		}
		/// <summary>
		/// Filename of plan.
		/// </summary>
		public string name 
		{
			get { return this.m_name; }
			private set { this.SetField(ref this.m_name, value, "name"); }
		}
		/// <summary>
		/// Rocgui version at last save of a local plan.
		/// </summary>
		public string rocguiversion 
		{
			get { return this.m_rocguiversion; }
			private set { this.SetField(ref this.m_rocguiversion, value, "rocguiversion"); }
		}
		/// <summary>
		/// Rocrail working directory.
		/// </summary>
		public string rocrailpwd 
		{
			get { return this.m_rocrailpwd; }
			private set { this.SetField(ref this.m_rocrailpwd, value, "rocrailpwd"); }
		}
		/// <summary>
		/// Rocrail version at last save of a plan.
		/// </summary>
		public string rocrailversion 
		{
			get { return this.m_rocrailversion; }
			private set { this.SetField(ref this.m_rocrailversion, value, "rocrailversion"); }
		}
		/// <summary>
		/// Preferred themes for redndering this plan by Rocviews.
		/// </summary>
		public string themes 
		{
			get { return this.m_themes; }
			private set { this.SetField(ref this.m_themes, value, "themes"); }
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
		public List<ac> aclist 
		{
			get { return this.m_aclist; }
			private set { this.SetField(ref this.m_aclist, value, "aclist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<bk> bklist 
		{
			get { return this.m_bklist; }
			private set { this.SetField(ref this.m_bklist, value, "bklist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<booster> boosterlist 
		{
			get { return this.m_boosterlist; }
			private set { this.SetField(ref this.m_boosterlist, value, "boosterlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<car> carlist 
		{
			get { return this.m_carlist; }
			private set { this.SetField(ref this.m_carlist, value, "carlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<co> colist 
		{
			get { return this.m_colist; }
			private set { this.SetField(ref this.m_colist, value, "colist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<dec> declist 
		{
			get { return this.m_declist; }
			private set { this.SetField(ref this.m_declist, value, "declist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<digint> digintlist 
		{
			get { return this.m_digintlist; }
			private set { this.SetField(ref this.m_digintlist, value, "digintlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<fb> fblist 
		{
			get { return this.m_fblist; }
			private set { this.SetField(ref this.m_fblist, value, "fblist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<lc> lclist 
		{
			get { return this.m_lclist; }
			private set { this.SetField(ref this.m_lclist, value, "lclist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<link> linklist 
		{
			get { return this.m_linklist; }
			private set { this.SetField(ref this.m_linklist, value, "linklist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<location> locationlist 
		{
			get { return this.m_locationlist; }
			private set { this.SetField(ref this.m_locationlist, value, "locationlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<mv> mvlist 
		{
			get { return this.m_mvlist; }
			private set { this.SetField(ref this.m_mvlist, value, "mvlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<@operator> operatorlist 
		{
			get { return this.m_operatorlist; }
			private set { this.SetField(ref this.m_operatorlist, value, "operatorlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<sb> sblist 
		{
			get { return this.m_sblist; }
			private set { this.SetField(ref this.m_sblist, value, "sblist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<sc> sclist 
		{
			get { return this.m_sclist; }
			private set { this.SetField(ref this.m_sclist, value, "sclist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<seltab> seltablist 
		{
			get { return this.m_seltablist; }
			private set { this.SetField(ref this.m_seltablist, value, "seltablist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<sg> sglist 
		{
			get { return this.m_sglist; }
			private set { this.SetField(ref this.m_sglist, value, "sglist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<st> stlist 
		{
			get { return this.m_stlist; }
			private set { this.SetField(ref this.m_stlist, value, "stlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<sw> swlist 
		{
			get { return this.m_swlist; }
			private set { this.SetField(ref this.m_swlist, value, "swlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<system> systemlist 
		{
			get { return this.m_systemlist; }
			private set { this.SetField(ref this.m_systemlist, value, "systemlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<tk> tklist 
		{
			get { return this.m_tklist; }
			private set { this.SetField(ref this.m_tklist, value, "tklist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<tour> tourlist 
		{
			get { return this.m_tourlist; }
			private set { this.SetField(ref this.m_tourlist, value, "tourlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<traverser> traverserlist 
		{
			get { return this.m_traverserlist; }
			private set { this.SetField(ref this.m_traverserlist, value, "traverserlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<tt> ttlist 
		{
			get { return this.m_ttlist; }
			private set { this.SetField(ref this.m_ttlist, value, "ttlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<tx> txlist 
		{
			get { return this.m_txlist; }
			private set { this.SetField(ref this.m_txlist, value, "txlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<waybill> waybilllist 
		{
			get { return this.m_waybilllist; }
			private set { this.SetField(ref this.m_waybilllist, value, "waybilllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<zlevel> zlevellist 
		{
			get { return this.m_zlevellist; }
			private set { this.SetField(ref this.m_zlevellist, value, "zlevellist"); }
		}
		public plan()
		{
			this.m_aclist = new List<ac>();
			this.m_bklist = new List<bk>();
			this.m_boosterlist = new List<booster>();
			this.m_carlist = new List<car>();
			this.m_colist = new List<co>();
			this.m_declist = new List<dec>();
			this.m_digintlist = new List<digint>();
			this.m_fblist = new List<fb>();
			this.m_lclist = new List<lc>();
			this.m_linklist = new List<link>();
			this.m_locationlist = new List<location>();
			this.m_mvlist = new List<mv>();
			this.m_operatorlist = new List<@operator>();
			this.m_sblist = new List<sb>();
			this.m_sclist = new List<sc>();
			this.m_seltablist = new List<seltab>();
			this.m_sglist = new List<sg>();
			this.m_stlist = new List<st>();
			this.m_swlist = new List<sw>();
			this.m_systemlist = new List<system>();
			this.m_tklist = new List<tk>();
			this.m_tourlist = new List<tour>();
			this.m_traverserlist = new List<traverser>();
			this.m_ttlist = new List<tt>();
			this.m_txlist = new List<tx>();
			this.m_waybilllist = new List<waybill>();
			this.m_zlevellist = new List<zlevel>();
		}
		public static plan Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			plan _plan = new plan();
			_plan.m_rocrailClient = rocrailClient;
			_plan.m_donkey = (bool?)xml.Attribute("donkey");
			_plan.m_healthy = (bool?)xml.Attribute("healthy");
			_plan.m_modplan = (bool?)xml.Attribute("modplan");
			_plan.m_modtitle = (string)xml.Attribute("modtitle");
			_plan.m_name = (string)xml.Attribute("name");
			_plan.m_rocguiversion = (string)xml.Attribute("rocguiversion");
			_plan.m_rocrailpwd = (string)xml.Attribute("rocrailpwd");
			_plan.m_rocrailversion = (string)xml.Attribute("rocrailversion");
			_plan.m_themes = (string)xml.Attribute("themes");
			_plan.m_title = (string)xml.Attribute("title");

			Definitions.Tools.ParseList<ac>(_plan.m_aclist, xml, "ac", ac.Parse, rocrailClient);
			Definitions.Tools.ParseList<bk>(_plan.m_bklist, xml, "bk", bk.Parse, rocrailClient);
			Definitions.Tools.ParseList<booster>(_plan.m_boosterlist, xml, "booster", booster.Parse, rocrailClient);
			Definitions.Tools.ParseList<car>(_plan.m_carlist, xml, "car", car.Parse, rocrailClient);
			Definitions.Tools.ParseList<co>(_plan.m_colist, xml, "co", co.Parse, rocrailClient);
			Definitions.Tools.ParseList<dec>(_plan.m_declist, xml, "dec", dec.Parse, rocrailClient);
			Definitions.Tools.ParseList<digint>(_plan.m_digintlist, xml, "digint", digint.Parse, rocrailClient);
			Definitions.Tools.ParseList<fb>(_plan.m_fblist, xml, "fb", fb.Parse, rocrailClient);
			Definitions.Tools.ParseList<lc>(_plan.m_lclist, xml, "lc", lc.Parse, rocrailClient);
			Definitions.Tools.ParseList<link>(_plan.m_linklist, xml, "link", link.Parse, rocrailClient);
			Definitions.Tools.ParseList<location>(_plan.m_locationlist, xml, "location", location.Parse, rocrailClient);
			Definitions.Tools.ParseList<mv>(_plan.m_mvlist, xml, "mv", mv.Parse, rocrailClient);
			Definitions.Tools.ParseList<@operator>(_plan.m_operatorlist, xml, "operator", @operator.Parse, rocrailClient);
			Definitions.Tools.ParseList<sb>(_plan.m_sblist, xml, "sb", sb.Parse, rocrailClient);
			Definitions.Tools.ParseList<sc>(_plan.m_sclist, xml, "sc", sc.Parse, rocrailClient);
			Definitions.Tools.ParseList<seltab>(_plan.m_seltablist, xml, "seltab", seltab.Parse, rocrailClient);
			Definitions.Tools.ParseList<sg>(_plan.m_sglist, xml, "sg", sg.Parse, rocrailClient);
			Definitions.Tools.ParseList<st>(_plan.m_stlist, xml, "st", st.Parse, rocrailClient);
			Definitions.Tools.ParseList<sw>(_plan.m_swlist, xml, "sw", sw.Parse, rocrailClient);
			Definitions.Tools.ParseList<system>(_plan.m_systemlist, xml, "system", system.Parse, rocrailClient);
			Definitions.Tools.ParseList<tk>(_plan.m_tklist, xml, "tk", tk.Parse, rocrailClient);
			Definitions.Tools.ParseList<tour>(_plan.m_tourlist, xml, "tour", tour.Parse, rocrailClient);
			Definitions.Tools.ParseList<traverser>(_plan.m_traverserlist, xml, "traverser", traverser.Parse, rocrailClient);
			Definitions.Tools.ParseList<tt>(_plan.m_ttlist, xml, "tt", tt.Parse, rocrailClient);
			Definitions.Tools.ParseList<tx>(_plan.m_txlist, xml, "tx", tx.Parse, rocrailClient);
			Definitions.Tools.ParseList<waybill>(_plan.m_waybilllist, xml, "waybill", waybill.Parse, rocrailClient);
			Definitions.Tools.ParseList<zlevel>(_plan.m_zlevellist, xml, "zlevel", zlevel.Parse, rocrailClient);
			return _plan;
		}
		public void Update(plan element)
		{
			if(element.m_donkey.HasValue == true) this.donkey = element.donkey;
			if(element.m_healthy.HasValue == true) this.healthy = element.healthy;
			if(element.m_modplan.HasValue == true) this.modplan = element.modplan;
			if(element.m_modtitle != null) this.modtitle = element.modtitle;
			if(element.m_name != null) this.name = element.name;
			if(element.m_rocguiversion != null) this.rocguiversion = element.rocguiversion;
			if(element.m_rocrailpwd != null) this.rocrailpwd = element.rocrailpwd;
			if(element.m_rocrailversion != null) this.rocrailversion = element.rocrailversion;
			if(element.m_themes != null) this.themes = element.themes;
			if(element.m_title != null) this.title = element.title;
			this.aclist = element.aclist;
			this.bklist = element.bklist;
			this.boosterlist = element.boosterlist;
			this.carlist = element.carlist;
			this.colist = element.colist;
			this.declist = element.declist;
			this.digintlist = element.digintlist;
			this.fblist = element.fblist;
			this.lclist = element.lclist;
			this.linklist = element.linklist;
			this.locationlist = element.locationlist;
			this.mvlist = element.mvlist;
			this.operatorlist = element.operatorlist;
			this.sblist = element.sblist;
			this.sclist = element.sclist;
			this.seltablist = element.seltablist;
			this.sglist = element.sglist;
			this.stlist = element.stlist;
			this.swlist = element.swlist;
			this.systemlist = element.systemlist;
			this.tklist = element.tklist;
			this.tourlist = element.tourlist;
			this.traverserlist = element.traverserlist;
			this.ttlist = element.ttlist;
			this.txlist = element.txlist;
			this.waybilllist = element.waybilllist;
			this.zlevellist = element.zlevellist;
		}
	}
}
