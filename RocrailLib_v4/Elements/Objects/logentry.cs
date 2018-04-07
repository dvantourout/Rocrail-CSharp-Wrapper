using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class logentry : CRocrailElements
	{
		private int? m_revision;
		/// <summary>
		/// 
		/// </summary>
		public int revision 
		{
			get { return this.m_revision.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_revision, value, "revision"); }
		}
		public logentry()
		{
		}
		public static logentry Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			logentry _logentry = new logentry();
			_logentry.m_rocrailClient = rocrailClient;
			_logentry.m_revision = (int?)xml.Attribute("revision");
			return _logentry;
		}
		public void Update(logentry element)
		{
			if(element.m_revision.HasValue == true) this.revision = element.revision;
		}
	}
}
