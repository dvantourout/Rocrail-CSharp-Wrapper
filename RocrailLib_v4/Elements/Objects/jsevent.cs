using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class jsevent : CRocrailElements
	{
		private int? m_device;
		private int? m_msec;
		private int? m_number;
		private int? m_type;
		private int? m_value;
		/// <summary>
		/// 
		/// </summary>
		public int device 
		{
			get { return this.m_device.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_device, value, "device"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int msec 
		{
			get { return this.m_msec.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_msec, value, "msec"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int number 
		{
			get { return this.m_number.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_number, value, "number"); }
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
		public int @value 
		{
			get { return this.m_value.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value, value, "@value"); }
		}
		public jsevent()
		{
		}
		public static jsevent Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			jsevent _jsevent = new jsevent();
			_jsevent.m_rocrailClient = rocrailClient;
			_jsevent.m_device = (int?)xml.Attribute("device");
			_jsevent.m_msec = (int?)xml.Attribute("msec");
			_jsevent.m_number = (int?)xml.Attribute("number");
			_jsevent.m_type = (int?)xml.Attribute("type");
			_jsevent.m_value = (int?)xml.Attribute("value");
			return _jsevent;
		}
		public void Update(jsevent element)
		{
			if(element.m_device.HasValue == true) this.device = element.device;
			if(element.m_msec.HasValue == true) this.msec = element.msec;
			if(element.m_number.HasValue == true) this.number = element.number;
			if(element.m_type.HasValue == true) this.type = element.type;
			if(element.m_value.HasValue == true) this.@value = element.@value;
		}
	}
}
