using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class log : CRocrailElements
	{
		private List<logentry> m_logentrylist;
		/// <summary>
		/// 
		/// </summary>
		public List<logentry> logentrylist 
		{
			get { return this.m_logentrylist; }
			private set { this.SetField(ref this.m_logentrylist, value, "logentrylist"); }
		}
		public log()
		{
			this.m_logentrylist = new List<logentry>();
		}
		public static log Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			log _log = new log();
			_log.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<logentry>(_log.m_logentrylist, xml, "logentry", logentry.Parse, rocrailClient);
			return _log;
		}
		public void Update(log element)
		{
			this.logentrylist = element.logentrylist;
		}
	}
}
