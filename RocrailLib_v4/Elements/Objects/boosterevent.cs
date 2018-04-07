using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class boosterevent : CRocrailElements
	{
		private int? m_load;
		private int? m_temp;
		private long? m_timestamp;
		private int? m_volt;
		/// <summary>
		/// 
		/// </summary>
		public int load 
		{
			get { return this.m_load.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_load, value, "load"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int temp 
		{
			get { return this.m_temp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_temp, value, "temp"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public long timestamp 
		{
			get { return this.m_timestamp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timestamp, value, "timestamp"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int volt 
		{
			get { return this.m_volt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_volt, value, "volt"); }
		}
		public boosterevent()
		{
		}
		public static boosterevent Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			boosterevent _boosterevent = new boosterevent();
			_boosterevent.m_rocrailClient = rocrailClient;
			_boosterevent.m_load = (int?)xml.Attribute("load");
			_boosterevent.m_temp = (int?)xml.Attribute("temp");
			_boosterevent.m_timestamp = (long?)xml.Attribute("timestamp");
			_boosterevent.m_volt = (int?)xml.Attribute("volt");
			return _boosterevent;
		}
		public void Update(boosterevent element)
		{
			if(element.m_load.HasValue == true) this.load = element.load;
			if(element.m_temp.HasValue == true) this.temp = element.temp;
			if(element.m_timestamp.HasValue == true) this.timestamp = element.timestamp;
			if(element.m_volt.HasValue == true) this.volt = element.volt;
		}
	}
}
