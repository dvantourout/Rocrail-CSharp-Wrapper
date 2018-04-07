using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class netrsp : CRocrailElements
	{
		public const string RSP_BLOCK = "block";
		public const string RSP_CLIENTCONN = "clientconn";
		public const string RSP_ISFREE = "isfree";
		public const string RSP_OCCUPIED = "occupied";
		public const string RSP_RESERVED = "reserved";
		public const string RSP_UNLOCKED = "unlocked";
		private string m_host;
		private string m_localbk;
		private string m_localid;
		private string m_plan;
		private int? m_port;
		private string m_remotebk;
		private string m_remoteid;
		private string m_rsp;
		/// <summary>
		/// Server client service.
		/// </summary>
		public string host 
		{
			get { return this.m_host; }
			private set { this.SetField(ref this.m_host, value, "host"); }
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
		/// Plan title.
		/// </summary>
		public string plan 
		{
			get { return this.m_plan; }
			private set { this.SetField(ref this.m_plan, value, "plan"); }
		}
		/// <summary>
		/// Rocrail Client Service.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
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
		/// 
		/// </summary>
		public string rsp 
		{
			get { return this.m_rsp; }
			private set { this.SetField(ref this.m_rsp, value, "rsp"); }
		}
		public netrsp()
		{
		}
		public static netrsp Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			netrsp _netrsp = new netrsp();
			_netrsp.m_rocrailClient = rocrailClient;
			_netrsp.m_host = (string)xml.Attribute("host");
			_netrsp.m_localbk = (string)xml.Attribute("localbk");
			_netrsp.m_localid = (string)xml.Attribute("localid");
			_netrsp.m_plan = (string)xml.Attribute("plan");
			_netrsp.m_port = (int?)xml.Attribute("port");
			_netrsp.m_remotebk = (string)xml.Attribute("remotebk");
			_netrsp.m_remoteid = (string)xml.Attribute("remoteid");
			_netrsp.m_rsp = (string)xml.Attribute("rsp");
			return _netrsp;
		}
		public void Update(netrsp element)
		{
			if(element.m_host != null) this.host = element.host;
			if(element.m_localbk != null) this.localbk = element.localbk;
			if(element.m_localid != null) this.localid = element.localid;
			if(element.m_plan != null) this.plan = element.plan;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_remotebk != null) this.remotebk = element.remotebk;
			if(element.m_remoteid != null) this.remoteid = element.remoteid;
			if(element.m_rsp != null) this.rsp = element.rsp;
		}
	}
}
