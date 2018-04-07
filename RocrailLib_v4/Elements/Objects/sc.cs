using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sc : CRocrailElements
	{
		public const int TIME_HOURLY = 2;
		public const int TIME_REAL = 0;
		public const int TIME_RELATIVE = 1;
		public const string TYPE_COMMUTER = "commuter";
		public const string TYPE_CYCLE = "cycle";
		private int? m_cycles;
		private int? m_fromhour;
		
		private int? m_maxdelay;
		private string m_scaction;
		private int? m_timeframe;
		private int? m_timeprocessing;
		private int? m_tohour;
		private string m_type;
		private List<actionctrl> m_actionctrllist;
		private List<scentry> m_scentrylist;
		/// <summary>
		/// number of runs in case of cycle type: 0 is just one run
		/// </summary>
		public int cycles 
		{
			get { return this.m_cycles.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cycles, value, "cycles"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int fromhour 
		{
			get { return this.m_fromhour.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fromhour, value, "fromhour"); }
		}
		/// <summary>
		/// schedule name
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Depart only if the time is not delayed more than this number of minutes.
		/// </summary>
		public int maxdelay 
		{
			get { return this.m_maxdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxdelay, value, "maxdelay"); }
		}
		/// <summary>
		/// schedule action id
		/// </summary>
		public string scaction 
		{
			get { return this.m_scaction; }
			private set { this.SetField(ref this.m_scaction, value, "scaction"); }
		}
		/// <summary>
		/// time frame for accepting a delay
		/// </summary>
		public int timeframe 
		{
			get { return this.m_timeframe.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timeframe, value, "timeframe"); }
		}
		/// <summary>
		/// 0=real 1=relative 2=hourly
		/// </summary>
		public int timeprocessing 
		{
			get { return this.m_timeprocessing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timeprocessing, value, "timeprocessing"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int tohour 
		{
			get { return this.m_tohour.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tohour, value, "tohour"); }
		}
		/// <summary>
		/// how the schedule should be used
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<scentry> scentrylist 
		{
			get { return this.m_scentrylist; }
			private set { this.SetField(ref this.m_scentrylist, value, "scentrylist"); }
		}
		public sc()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_scentrylist = new List<scentry>();
		}
		public static sc Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sc _sc = new sc();
			_sc.m_rocrailClient = rocrailClient;
			_sc.m_cycles = (int?)xml.Attribute("cycles");
			_sc.m_fromhour = (int?)xml.Attribute("fromhour");
			_sc.m_id = (string)xml.Attribute("id");
			_sc.m_maxdelay = (int?)xml.Attribute("maxdelay");
			_sc.m_scaction = (string)xml.Attribute("scaction");
			_sc.m_timeframe = (int?)xml.Attribute("timeframe");
			_sc.m_timeprocessing = (int?)xml.Attribute("timeprocessing");
			_sc.m_tohour = (int?)xml.Attribute("tohour");
			_sc.m_type = (string)xml.Attribute("type");
			Definitions.Tools.ParseList<actionctrl>(_sc.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<scentry>(_sc.m_scentrylist, xml, "scentry", scentry.Parse, rocrailClient);
			return _sc;
		}
		public void Update(sc element)
		{
			if(element.m_cycles.HasValue == true) this.cycles = element.cycles;
			if(element.m_fromhour.HasValue == true) this.fromhour = element.fromhour;
			if(element.m_id != null) this.id = element.id;
			if(element.m_maxdelay.HasValue == true) this.maxdelay = element.maxdelay;
			if(element.m_scaction != null) this.scaction = element.scaction;
			if(element.m_timeframe.HasValue == true) this.timeframe = element.timeframe;
			if(element.m_timeprocessing.HasValue == true) this.timeprocessing = element.timeprocessing;
			if(element.m_tohour.HasValue == true) this.tohour = element.tohour;
			if(element.m_type != null) this.type = element.type;
			this.actionctrllist = element.actionctrllist;
			this.scentrylist = element.scentrylist;
		}
	}
}
