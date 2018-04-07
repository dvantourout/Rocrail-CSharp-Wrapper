using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class tcp : CRocrailElements
	{
		private string m_controlcode;
		private int? m_maxcon;
		private bool? m_onlyfirstmaster;
		private int? m_port;
		private string m_slavecode;
		/// <summary>
		/// 
		/// </summary>
		public string controlcode 
		{
			get { return this.m_controlcode; }
			private set { this.SetField(ref this.m_controlcode, value, "controlcode"); }
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
		/// Only the first client is master.
		/// </summary>
		public bool onlyfirstmaster 
		{
			get { return this.m_onlyfirstmaster.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_onlyfirstmaster, value, "onlyfirstmaster"); }
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
		public string slavecode 
		{
			get { return this.m_slavecode; }
			private set { this.SetField(ref this.m_slavecode, value, "slavecode"); }
		}
		public tcp()
		{
		}
		public static tcp Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			tcp _tcp = new tcp();
			_tcp.m_rocrailClient = rocrailClient;
			_tcp.m_controlcode = (string)xml.Attribute("controlcode");
			_tcp.m_maxcon = (int?)xml.Attribute("maxcon");
			_tcp.m_onlyfirstmaster = (bool?)xml.Attribute("onlyfirstmaster");
			_tcp.m_port = (int?)xml.Attribute("port");
			_tcp.m_slavecode = (string)xml.Attribute("slavecode");
			return _tcp;
		}
		public void Update(tcp element)
		{
			if(element.m_controlcode != null) this.controlcode = element.controlcode;
			if(element.m_maxcon.HasValue == true) this.maxcon = element.maxcon;
			if(element.m_onlyfirstmaster.HasValue == true) this.onlyfirstmaster = element.onlyfirstmaster;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_slavecode != null) this.slavecode = element.slavecode;
		}
	}
}
