using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class netreq : CRocrailElements
	{
		public const string REQ_CLIENTCONN = "clientconn";
		public const string REQ_GETBLOCK = "getblock";
		public const string REQ_ISFREE = "isfree";
		public const string REQ_LOCOISIN = "locoisin";
		public const string REQ_NETROUTES = "netroutes";
		public const string REQ_RESERVE = "reserve";
		public const string REQ_UNLOCK = "unlock";
		private string m_lcid;
		private string m_localbk;
		private string m_localid;
		private string m_remotebk;
		private string m_remoteid;
		private string m_req;
		private string m_routeid;
		/// <summary>
		/// Loc ID.
		/// </summary>
		public string lcid 
		{
			get { return this.m_lcid; }
			private set { this.SetField(ref this.m_lcid, value, "lcid"); }
		}
		/// <summary>
		/// Local block ID; rrid::bkid
		/// </summary>
		public string localbk 
		{
			get { return this.m_localbk; }
			private set { this.SetField(ref this.m_localbk, value, "localbk"); }
		}
		/// <summary>
		/// Local server name.
		/// </summary>
		public string localid 
		{
			get { return this.m_localid; }
			private set { this.SetField(ref this.m_localid, value, "localid"); }
		}
		/// <summary>
		/// Remote block ID; rrid::bkid
		/// </summary>
		public string remotebk 
		{
			get { return this.m_remotebk; }
			private set { this.SetField(ref this.m_remotebk, value, "remotebk"); }
		}
		/// <summary>
		/// Remote server name.
		/// </summary>
		public string remoteid 
		{
			get { return this.m_remoteid; }
			private set { this.SetField(ref this.m_remoteid, value, "remoteid"); }
		}
		/// <summary>
		/// Request type.
		/// </summary>
		public string req 
		{
			get { return this.m_req; }
			private set { this.SetField(ref this.m_req, value, "req"); }
		}
		/// <summary>
		/// Route ID.
		/// </summary>
		public string routeid 
		{
			get { return this.m_routeid; }
			private set { this.SetField(ref this.m_routeid, value, "routeid"); }
		}
		public netreq()
		{
		}
		public static netreq Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			netreq _netreq = new netreq();
			_netreq.m_rocrailClient = rocrailClient;
			_netreq.m_lcid = (string)xml.Attribute("lcid");
			_netreq.m_localbk = (string)xml.Attribute("localbk");
			_netreq.m_localid = (string)xml.Attribute("localid");
			_netreq.m_remotebk = (string)xml.Attribute("remotebk");
			_netreq.m_remoteid = (string)xml.Attribute("remoteid");
			_netreq.m_req = (string)xml.Attribute("req");
			_netreq.m_routeid = (string)xml.Attribute("routeid");
			return _netreq;
		}
		public void Update(netreq element)
		{
			if(element.m_lcid != null) this.lcid = element.lcid;
			if(element.m_localbk != null) this.localbk = element.localbk;
			if(element.m_localid != null) this.localid = element.localid;
			if(element.m_remotebk != null) this.remotebk = element.remotebk;
			if(element.m_remoteid != null) this.remoteid = element.remoteid;
			if(element.m_req != null) this.req = element.req;
			if(element.m_routeid != null) this.routeid = element.routeid;
		}
	}
}
