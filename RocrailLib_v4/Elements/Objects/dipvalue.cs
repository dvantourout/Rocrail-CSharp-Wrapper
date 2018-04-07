using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class dipvalue : CRocrailElements
	{
		public const int VALUETYPE_CV = 1;
		public const int VALUETYPE_VALUE = 0;
		private string m_info;
		private string m_name;
		private int? m_type;
		private int? m_value;
		/// <summary>
		/// 
		/// </summary>
		public string info 
		{
			get { return this.m_info; }
			private set { this.SetField(ref this.m_info, value, "info"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string name 
		{
			get { return this.m_name; }
			private set { this.SetField(ref this.m_name, value, "name"); }
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
		public dipvalue()
		{
		}
		public static dipvalue Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			dipvalue _dipvalue = new dipvalue();
			_dipvalue.m_rocrailClient = rocrailClient;
			_dipvalue.m_info = (string)xml.Attribute("info");
			_dipvalue.m_name = (string)xml.Attribute("name");
			_dipvalue.m_type = (int?)xml.Attribute("type");
			_dipvalue.m_value = (int?)xml.Attribute("value");
			return _dipvalue;
		}
		public void Update(dipvalue element)
		{
			if(element.m_info != null) this.info = element.info;
			if(element.m_name != null) this.name = element.name;
			if(element.m_type.HasValue == true) this.type = element.type;
			if(element.m_value.HasValue == true) this.@value = element.@value;
		}
	}
}
