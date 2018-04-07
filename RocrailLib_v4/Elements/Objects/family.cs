using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class family : CRocrailElements
	{
		private string m_mfg;
		private string m_name;
		/// <summary>
		/// 
		/// </summary>
		public string mfg 
		{
			get { return this.m_mfg; }
			private set { this.SetField(ref this.m_mfg, value, "mfg"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string name 
		{
			get { return this.m_name; }
			private set { this.SetField(ref this.m_name, value, "name"); }
		}
		public family()
		{
		}
		public static family Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			family _family = new family();
			_family.m_rocrailClient = rocrailClient;
			_family.m_mfg = (string)xml.Attribute("mfg");
			_family.m_name = (string)xml.Attribute("name");
			return _family;
		}
		public void Update(family element)
		{
			if(element.m_mfg != null) this.mfg = element.mfg;
			if(element.m_name != null) this.name = element.name;
		}
	}
}
