using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class cbnodevar : CRocrailElements
	{
		private int? m_nr;
		private int? m_val;
		/// <summary>
		/// Node variable index.
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// Node variable value.
		/// </summary>
		public int val 
		{
			get { return this.m_val.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val, value, "val"); }
		}
		public cbnodevar()
		{
		}
		public static cbnodevar Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			cbnodevar _cbnodevar = new cbnodevar();
			_cbnodevar.m_rocrailClient = rocrailClient;
			_cbnodevar.m_nr = (int?)xml.Attribute("nr");
			_cbnodevar.m_val = (int?)xml.Attribute("val");
			return _cbnodevar;
		}
		public void Update(cbnodevar element)
		{
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_val.HasValue == true) this.val = element.val;
		}
	}
}
