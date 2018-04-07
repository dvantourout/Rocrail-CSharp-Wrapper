using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class r2rnet : CRocrailElements
	{
		private string m_addr;
		private bool? m_enable;
		
		private int? m_port;
		private string m_routes;
		/// <summary>
		/// multicast address
		/// </summary>
		public string addr 
		{
			get { return this.m_addr; }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// Enable R2Rnet.
		/// </summary>
		public bool enable 
		{
			get { return this.m_enable.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_enable, value, "enable"); }
		}
		/// <summary>
		/// R2Rnet ID.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// multicast port
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// R2Rnet routes file.
		/// </summary>
		public string routes 
		{
			get { return this.m_routes; }
			private set { this.SetField(ref this.m_routes, value, "routes"); }
		}
		public r2rnet()
		{
		}
		public static r2rnet Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			r2rnet _r2rnet = new r2rnet();
			_r2rnet.m_rocrailClient = rocrailClient;
			_r2rnet.m_addr = (string)xml.Attribute("addr");
			_r2rnet.m_enable = (bool?)xml.Attribute("enable");
			_r2rnet.m_id = (string)xml.Attribute("id");
			_r2rnet.m_port = (int?)xml.Attribute("port");
			_r2rnet.m_routes = (string)xml.Attribute("routes");
			return _r2rnet;
		}
		public void Update(r2rnet element)
		{
			if(element.m_addr != null) this.addr = element.addr;
			if(element.m_enable.HasValue == true) this.enable = element.enable;
			if(element.m_id != null) this.id = element.id;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_routes != null) this.routes = element.routes;
		}
	}
}
