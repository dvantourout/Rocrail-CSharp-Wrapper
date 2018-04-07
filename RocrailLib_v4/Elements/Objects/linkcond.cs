using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class linkcond : CRocrailElements
	{
		private string m_first;
		private string m_free;
		/// <summary>
		/// First lock block.
		/// </summary>
		public string first 
		{
			get { return this.m_first; }
			private set { this.SetField(ref this.m_first, value, "first"); }
		}
		/// <summary>
		/// One of this blocks must be free. (csv)
		/// </summary>
		public string free 
		{
			get { return this.m_free; }
			private set { this.SetField(ref this.m_free, value, "free"); }
		}
		public linkcond()
		{
		}
		public static linkcond Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			linkcond _linkcond = new linkcond();
			_linkcond.m_rocrailClient = rocrailClient;
			_linkcond.m_first = (string)xml.Attribute("first");
			_linkcond.m_free = (string)xml.Attribute("free");
			return _linkcond;
		}
		public void Update(linkcond element)
		{
			if(element.m_first != null) this.first = element.first;
			if(element.m_free != null) this.free = element.free;
		}
	}
}
