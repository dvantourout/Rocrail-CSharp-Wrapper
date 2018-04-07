using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fbevent : CRocrailElements
	{
		public const string V_CRUISE_EVENT = "V_cruise";
		public const string V_MAX_EVENT = "V_max";
		public const string V_MID_EVENT = "V_mid";
		public const string V_MIN_EVENT = "V_min";
		public const string ENTER2IN_EVENT = "enter2in";
		public const string ENTER2PRE_EVENT = "enter2pre";
		public const string ENTER2ROUTE_EVENT = "enter2route";
		public const string ENTER2SHORTIN_EVENT = "enter2shortin";
		public const string ENTER_EVENT = "enter";
		public const string EXIT_EVENT = "exit";
		public const string FROM_ALL = "all";
		public const string FROM_ALL_REVERSE = "all-reverse";
		public const string IDENT_EVENT = "ident";
		public const string IN_EVENT = "in";
		public const string OCCUPIED_EVENT = "occupied";
		public const string PRE2IN_EVENT = "pre2in";
		public const string SECTION_EVENT = "section";
		public const string SHORTIN_EVENT = "shortin";
		private string m_action;
		private string m_byroute;
		private bool? m_endpuls;
		private string m_from;
		
		private bool? m_use_timer2;
		/// <summary>
		/// 
		/// </summary>
		public string action 
		{
			get { return this.m_action; }
			private set { this.SetField(ref this.m_action, value, "action"); }
		}
		/// <summary>
		/// Comming from block x by route y. (optional)
		/// </summary>
		public string byroute 
		{
			get { return this.m_byroute; }
			private set { this.SetField(ref this.m_byroute, value, "byroute"); }
		}
		/// <summary>
		/// use the down flank of the puls
		/// </summary>
		public bool endpuls 
		{
			get { return this.m_endpuls.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_endpuls, value, "endpuls"); }
		}
		/// <summary>
		/// from block id (csv list for more blocks)
		/// </summary>
		public string @from 
		{
			get { return this.m_from; }
			private set { this.SetField(ref this.m_from, value, "@from"); }
		}
		/// <summary>
		/// feedback ID
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// use reverse direction timer
		/// </summary>
		public bool use_timer2 
		{
			get { return this.m_use_timer2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_use_timer2, value, "use_timer2"); }
		}
		public fbevent()
		{
		}
		public static fbevent Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fbevent _fbevent = new fbevent();
			_fbevent.m_rocrailClient = rocrailClient;
			_fbevent.m_action = (string)xml.Attribute("action");
			_fbevent.m_byroute = (string)xml.Attribute("byroute");
			_fbevent.m_endpuls = (bool?)xml.Attribute("endpuls");
			_fbevent.m_from = (string)xml.Attribute("from");
			_fbevent.m_id = (string)xml.Attribute("id");
			_fbevent.m_use_timer2 = (bool?)xml.Attribute("use_timer2");
			return _fbevent;
		}
		public void Update(fbevent element)
		{
			if(element.m_action != null) this.action = element.action;
			if(element.m_byroute != null) this.byroute = element.byroute;
			if(element.m_endpuls.HasValue == true) this.endpuls = element.endpuls;
			if(element.m_from != null) this.@from = element.@from;
			if(element.m_id != null) this.id = element.id;
			if(element.m_use_timer2.HasValue == true) this.use_timer2 = element.use_timer2;
		}
	}
}
