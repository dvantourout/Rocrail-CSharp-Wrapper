using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class excl : CRocrailElements
	{
		
		/// <summary>
		/// Loc ID.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		public excl()
		{
		}
		public static excl Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			excl _excl = new excl();
			_excl.m_rocrailClient = rocrailClient;
			_excl.m_id = (string)xml.Attribute("id");
			return _excl;
		}
		public void Update(excl element)
		{
			if(element.m_id != null) this.id = element.id;
		}
	}
}
