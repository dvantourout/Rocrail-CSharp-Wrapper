using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class service : CRocrailElements
	{
		private int? m_port;
		private string m_sname;
		/// <summary>
		/// Port number for server socket.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// Servicer name to use in NetReq and NetRsp.
		/// </summary>
		public string sname 
		{
			get { return this.m_sname; }
			private set { this.SetField(ref this.m_sname, value, "sname"); }
		}
		public service()
		{
		}
		public static service Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			service _service = new service();
			_service.m_rocrailClient = rocrailClient;
			_service.m_port = (int?)xml.Attribute("port");
			_service.m_sname = (string)xml.Attribute("sname");
			return _service;
		}
		public void Update(service element)
		{
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_sname != null) this.sname = element.sname;
		}
	}
}
