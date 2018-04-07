using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class bidib : CRocrailElements
	{
		private bool? m_secAck;
		private int? m_secAckInt;
		private bool? m_watchdog;
		private int? m_watchdogInt;
		private List<bidibnode> m_bidibnodelist;
		/// <summary>
		/// Enable secure acknowledge.
		/// </summary>
		public bool secAck 
		{
			get { return this.m_secAck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_secAck, value, "secAck"); }
		}
		/// <summary>
		/// Secure acknowledge interval in 10ms units.
		/// </summary>
		public int secAckInt 
		{
			get { return this.m_secAckInt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_secAckInt, value, "secAckInt"); }
		}
		/// <summary>
		/// Enable watchdog.
		/// </summary>
		public bool watchdog 
		{
			get { return this.m_watchdog.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_watchdog, value, "watchdog"); }
		}
		/// <summary>
		/// Watchdog interval in 100ms units.
		/// </summary>
		public int watchdogInt 
		{
			get { return this.m_watchdogInt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_watchdogInt, value, "watchdogInt"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<bidibnode> bidibnodelist 
		{
			get { return this.m_bidibnodelist; }
			private set { this.SetField(ref this.m_bidibnodelist, value, "bidibnodelist"); }
		}
		public bidib()
		{
			this.m_bidibnodelist = new List<bidibnode>();
		}
		public static bidib Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			bidib _bidib = new bidib();
			_bidib.m_rocrailClient = rocrailClient;
			_bidib.m_secAck = (bool?)xml.Attribute("secAck");
			_bidib.m_secAckInt = (int?)xml.Attribute("secAckInt");
			_bidib.m_watchdog = (bool?)xml.Attribute("watchdog");
			_bidib.m_watchdogInt = (int?)xml.Attribute("watchdogInt");
			Definitions.Tools.ParseList<bidibnode>(_bidib.m_bidibnodelist, xml, "bidibnode", bidibnode.Parse, rocrailClient);
			return _bidib;
		}
		public void Update(bidib element)
		{
			if(element.m_secAck.HasValue == true) this.secAck = element.secAck;
			if(element.m_secAckInt.HasValue == true) this.secAckInt = element.secAckInt;
			if(element.m_watchdog.HasValue == true) this.watchdog = element.watchdog;
			if(element.m_watchdogInt.HasValue == true) this.watchdogInt = element.watchdogInt;
			this.bidibnodelist = element.bidibnodelist;
		}
	}
}
