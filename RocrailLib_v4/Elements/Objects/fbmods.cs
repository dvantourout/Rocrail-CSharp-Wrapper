using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fbmods : CRocrailElements
	{
		private int? m_bus;
		private string m_modules;
		/// <summary>
		/// bus number
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// comma separated list of connected feedback module addresses
		/// </summary>
		public string modules 
		{
			get { return this.m_modules; }
			private set { this.SetField(ref this.m_modules, value, "modules"); }
		}
		public fbmods()
		{
		}
		public static fbmods Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fbmods _fbmods = new fbmods();
			_fbmods.m_rocrailClient = rocrailClient;
			_fbmods.m_bus = (int?)xml.Attribute("bus");
			_fbmods.m_modules = (string)xml.Attribute("modules");
			return _fbmods;
		}
		public void Update(fbmods element)
		{
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_modules != null) this.modules = element.modules;
		}
	}
}
