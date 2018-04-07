using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class srcpcon : CRocrailElements
	{
		private bool? m_active;
		private string m_device;
		private int? m_maxcon;
		private int? m_port;
		private List<srcpbus> m_srcpbuslist;
		/// <summary>
		/// Activate srcp service.
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// Optional serial device.
		/// </summary>
		public string device 
		{
			get { return this.m_device; }
			private set { this.SetField(ref this.m_device, value, "device"); }
		}
		/// <summary>
		/// Max. concurrent connected clients.
		/// </summary>
		public int maxcon 
		{
			get { return this.m_maxcon.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxcon, value, "maxcon"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<srcpbus> srcpbuslist 
		{
			get { return this.m_srcpbuslist; }
			private set { this.SetField(ref this.m_srcpbuslist, value, "srcpbuslist"); }
		}
		public srcpcon()
		{
			this.m_srcpbuslist = new List<srcpbus>();
		}
		public static srcpcon Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			srcpcon _srcpcon = new srcpcon();
			_srcpcon.m_rocrailClient = rocrailClient;
			_srcpcon.m_active = (bool?)xml.Attribute("active");
			_srcpcon.m_device = (string)xml.Attribute("device");
			_srcpcon.m_maxcon = (int?)xml.Attribute("maxcon");
			_srcpcon.m_port = (int?)xml.Attribute("port");
			Definitions.Tools.ParseList<srcpbus>(_srcpcon.m_srcpbuslist, xml, "srcpbus", srcpbus.Parse, rocrailClient);
			return _srcpcon;
		}
		public void Update(srcpcon element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_device != null) this.device = element.device;
			if(element.m_maxcon.HasValue == true) this.maxcon = element.maxcon;
			if(element.m_port.HasValue == true) this.port = element.port;
			this.srcpbuslist = element.srcpbuslist;
		}
	}
}
