using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class clock : CRocrailElements
	{
		public const string FREEZE = "freeze";
		public const string GO = "go";
		public const string SET = "set";
		public const string SYNC = "sync";
		private string m_cmd;
		private int? m_divider;
		private int? m_hour;
		private int? m_minute;
		private int? m_temp;
		private long? m_time;
		private int? m_update;
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// time devider: 1 = realtime
		/// </summary>
		public int divider 
		{
			get { return this.m_divider.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_divider, value, "divider"); }
		}
		/// <summary>
		/// start hour; 24 not used
		/// </summary>
		public int hour 
		{
			get { return this.m_hour.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_hour, value, "hour"); }
		}
		/// <summary>
		/// start minute; 60 not used
		/// </summary>
		public int minute 
		{
			get { return this.m_minute.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minute, value, "minute"); }
		}
		/// <summary>
		/// Model temperature.
		/// </summary>
		public int temp 
		{
			get { return this.m_temp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_temp, value, "temp"); }
		}
		/// <summary>
		/// time in seconds
		/// </summary>
		public long time 
		{
			get { return this.m_time.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_time, value, "time"); }
		}
		/// <summary>
		/// update frequency in minutes
		/// </summary>
		public int update 
		{
			get { return this.m_update.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_update, value, "update"); }
		}
		public clock()
		{
		}
		public static clock Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			clock _clock = new clock();
			_clock.m_rocrailClient = rocrailClient;
			_clock.m_cmd = (string)xml.Attribute("cmd");
			_clock.m_divider = (int?)xml.Attribute("divider");
			_clock.m_hour = (int?)xml.Attribute("hour");
			_clock.m_minute = (int?)xml.Attribute("minute");
			_clock.m_temp = (int?)xml.Attribute("temp");
			_clock.m_time = (long?)xml.Attribute("time");
			_clock.m_update = (int?)xml.Attribute("update");
			return _clock;
		}
		public void Update(clock element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_divider.HasValue == true) this.divider = element.divider;
			if(element.m_hour.HasValue == true) this.hour = element.hour;
			if(element.m_minute.HasValue == true) this.minute = element.minute;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_time.HasValue == true) this.time = element.time;
			if(element.m_update.HasValue == true) this.update = element.update;
		}
	}
}
