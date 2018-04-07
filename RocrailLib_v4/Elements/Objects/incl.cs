using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class incl : CRocrailElements
	{
		
		/// <summary>
		/// Loc ID.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		public incl()
		{
		}
		public static incl Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			incl _incl = new incl();
			_incl.m_rocrailClient = rocrailClient;
			_incl.m_id = (string)xml.Attribute("id");
			return _incl;
		}
		public void Update(incl element)
		{
			if(element.m_id != null) this.id = element.id;
		}
	}
}
