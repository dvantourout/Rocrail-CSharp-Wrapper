using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class response : CRocrailElements
	{
		public const string CTSERR = "ctserr";
		public const string OK = "ok";
		public const string RCVERR = "rcverr";
		public const string SNDERR = "snderr";
		private string m_data;
		private bool? m_error;
		private string m_iid;
		private string m_msg;
		private int? m_rc;
		private bool? m_retry;
		private string m_sender;
		private string m_state;
		/// <summary>
		/// 
		/// </summary>
		public string data 
		{
			get { return this.m_data; }
			private set { this.SetField(ref this.m_data, value, "data"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool error 
		{
			get { return this.m_error.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_error, value, "error"); }
		}
		/// <summary>
		/// Interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg 
		{
			get { return this.m_msg; }
			private set { this.SetField(ref this.m_msg, value, "msg"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int rc 
		{
			get { return this.m_rc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rc, value, "rc"); }
		}
		/// <summary>
		/// controller buffer full; try again.
		/// </summary>
		public bool retry 
		{
			get { return this.m_retry.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_retry, value, "retry"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string sender 
		{
			get { return this.m_sender; }
			private set { this.SetField(ref this.m_sender, value, "sender"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		public response()
		{
		}
		public static response Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			response _response = new response();
			_response.m_rocrailClient = rocrailClient;
			_response.m_data = (string)xml.Attribute("data");
			_response.m_error = (bool?)xml.Attribute("error");
			_response.m_iid = (string)xml.Attribute("iid");
			_response.m_msg = (string)xml.Attribute("msg");
			_response.m_rc = (int?)xml.Attribute("rc");
			_response.m_retry = (bool?)xml.Attribute("retry");
			_response.m_sender = (string)xml.Attribute("sender");
			_response.m_state = (string)xml.Attribute("state");
			return _response;
		}
		public void Update(response element)
		{
			if(element.m_data != null) this.data = element.data;
			if(element.m_error.HasValue == true) this.error = element.error;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_msg != null) this.msg = element.msg;
			if(element.m_rc.HasValue == true) this.rc = element.rc;
			if(element.m_retry.HasValue == true) this.retry = element.retry;
			if(element.m_sender != null) this.sender = element.sender;
			if(element.m_state != null) this.state = element.state;
		}
	}
}
