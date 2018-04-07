using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class macro : CRocrailElements
	{
		private int? m_class;
		private int? m_hours;
		private int? m_minutes;
		private int? m_nr;
		private int? m_repeat;
		private int? m_slowdown;
		private int? m_uid;
		private int? m_wday;
		private List<macroline> m_macrolinelist;
		/// <summary>
		/// Module class in case of an export.
		/// </summary>
		public int @class 
		{
			get { return this.m_class.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_class, value, "@class"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int hours 
		{
			get { return this.m_hours.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_hours, value, "hours"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int minutes 
		{
			get { return this.m_minutes.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minutes, value, "minutes"); }
		}
		/// <summary>
		/// Macro number in case of export.
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int repeat 
		{
			get { return this.m_repeat.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_repeat, value, "repeat"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int slowdown 
		{
			get { return this.m_slowdown.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_slowdown, value, "slowdown"); }
		}
		/// <summary>
		/// The unique ID in case of an export.
		/// </summary>
		public int uid 
		{
			get { return this.m_uid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_uid, value, "uid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int wday 
		{
			get { return this.m_wday.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wday, value, "wday"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<macroline> macrolinelist 
		{
			get { return this.m_macrolinelist; }
			private set { this.SetField(ref this.m_macrolinelist, value, "macrolinelist"); }
		}
		public macro()
		{
			this.m_macrolinelist = new List<macroline>();
		}
		public static macro Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			macro _macro = new macro();
			_macro.m_rocrailClient = rocrailClient;
			_macro.m_class = (int?)xml.Attribute("class");
			_macro.m_hours = (int?)xml.Attribute("hours");
			_macro.m_minutes = (int?)xml.Attribute("minutes");
			_macro.m_nr = (int?)xml.Attribute("nr");
			_macro.m_repeat = (int?)xml.Attribute("repeat");
			_macro.m_slowdown = (int?)xml.Attribute("slowdown");
			_macro.m_uid = (int?)xml.Attribute("uid");
			_macro.m_wday = (int?)xml.Attribute("wday");
			Definitions.Tools.ParseList<macroline>(_macro.m_macrolinelist, xml, "macroline", macroline.Parse, rocrailClient);
			return _macro;
		}
		public void Update(macro element)
		{
			if(element.m_class.HasValue == true) this.@class = element.@class;
			if(element.m_hours.HasValue == true) this.hours = element.hours;
			if(element.m_minutes.HasValue == true) this.minutes = element.minutes;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_repeat.HasValue == true) this.repeat = element.repeat;
			if(element.m_slowdown.HasValue == true) this.slowdown = element.slowdown;
			if(element.m_uid.HasValue == true) this.uid = element.uid;
			if(element.m_wday.HasValue == true) this.wday = element.wday;
			this.macrolinelist = element.macrolinelist;
		}
	}
}
