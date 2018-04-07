using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class powerevent : CRocrailElements
	{
		
		private bool? m_power;
		private bool? m_shortcut;
		/// <summary>
		/// Booster ID; command for all not set.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool power 
		{
			get { return this.m_power.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_power, value, "power"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool shortcut 
		{
			get { return this.m_shortcut.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcut, value, "shortcut"); }
		}
		public powerevent()
		{
		}
		public static powerevent Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			powerevent _powerevent = new powerevent();
			_powerevent.m_rocrailClient = rocrailClient;
			_powerevent.m_id = (string)xml.Attribute("id");
			_powerevent.m_power = (bool?)xml.Attribute("power");
			_powerevent.m_shortcut = (bool?)xml.Attribute("shortcut");
			return _powerevent;
		}
		public void Update(powerevent element)
		{
			if(element.m_id != null) this.id = element.id;
			if(element.m_power.HasValue == true) this.power = element.power;
			if(element.m_shortcut.HasValue == true) this.shortcut = element.shortcut;
		}
	}
}
