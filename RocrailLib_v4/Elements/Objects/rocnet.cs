using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class rocnet : CRocrailElements
	{
		private string m_addr;
		private bool? m_crc;
		private int? m_id;
		private int? m_net;
		private int? m_port;
		private bool? m_wd;
		private List<channelsetup> m_channelsetuplist;
		private List<macro> m_macrolist;
		private List<portsetup> m_portsetuplist;
		private List<rocnetnode> m_rocnetnodelist;
		private List<rocnetnodeoptions> m_rocnetnodeoptionslist;
		/// <summary>
		/// multicast address
		/// </summary>
		public string addr 
		{
			get { return this.m_addr; }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool crc 
		{
			get { return this.m_crc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_crc, value, "crc"); }
		}
		/// <summary>
		/// RocNet sender ID, 1 is default for Rocrail.(Host)
		/// </summary>
		public int id 
		{
			get { return this.m_id.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int net 
		{
			get { return this.m_net.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_net, value, "net"); }
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
		/// 
		/// </summary>
		public bool wd 
		{
			get { return this.m_wd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_wd, value, "wd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<channelsetup> channelsetuplist 
		{
			get { return this.m_channelsetuplist; }
			private set { this.SetField(ref this.m_channelsetuplist, value, "channelsetuplist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<macro> macrolist 
		{
			get { return this.m_macrolist; }
			private set { this.SetField(ref this.m_macrolist, value, "macrolist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<portsetup> portsetuplist 
		{
			get { return this.m_portsetuplist; }
			private set { this.SetField(ref this.m_portsetuplist, value, "portsetuplist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<rocnetnode> rocnetnodelist 
		{
			get { return this.m_rocnetnodelist; }
			private set { this.SetField(ref this.m_rocnetnodelist, value, "rocnetnodelist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<rocnetnodeoptions> rocnetnodeoptionslist 
		{
			get { return this.m_rocnetnodeoptionslist; }
			private set { this.SetField(ref this.m_rocnetnodeoptionslist, value, "rocnetnodeoptionslist"); }
		}
		public rocnet()
		{
			this.m_channelsetuplist = new List<channelsetup>();
			this.m_macrolist = new List<macro>();
			this.m_portsetuplist = new List<portsetup>();
			this.m_rocnetnodelist = new List<rocnetnode>();
			this.m_rocnetnodeoptionslist = new List<rocnetnodeoptions>();
		}
		public static rocnet Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			rocnet _rocnet = new rocnet();
			_rocnet.m_rocrailClient = rocrailClient;
			_rocnet.m_addr = (string)xml.Attribute("addr");
			_rocnet.m_crc = (bool?)xml.Attribute("crc");
			_rocnet.m_id = (int?)xml.Attribute("id");
			_rocnet.m_net = (int?)xml.Attribute("net");
			_rocnet.m_port = (int?)xml.Attribute("port");
			_rocnet.m_wd = (bool?)xml.Attribute("wd");
			Definitions.Tools.ParseList<channelsetup>(_rocnet.m_channelsetuplist, xml, "channelsetup", channelsetup.Parse, rocrailClient);
			Definitions.Tools.ParseList<macro>(_rocnet.m_macrolist, xml, "macro", macro.Parse, rocrailClient);
			Definitions.Tools.ParseList<portsetup>(_rocnet.m_portsetuplist, xml, "portsetup", portsetup.Parse, rocrailClient);
			Definitions.Tools.ParseList<rocnetnode>(_rocnet.m_rocnetnodelist, xml, "rocnetnode", rocnetnode.Parse, rocrailClient);
			Definitions.Tools.ParseList<rocnetnodeoptions>(_rocnet.m_rocnetnodeoptionslist, xml, "rocnetnodeoptions", rocnetnodeoptions.Parse, rocrailClient);
			return _rocnet;
		}
		public void Update(rocnet element)
		{
			if(element.m_addr != null) this.addr = element.addr;
			if(element.m_crc.HasValue == true) this.crc = element.crc;
			if(element.m_id.HasValue == true) this.id = element.id;
			if(element.m_net.HasValue == true) this.net = element.net;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_wd.HasValue == true) this.wd = element.wd;
			this.channelsetuplist = element.channelsetuplist;
			this.macrolist = element.macrolist;
			this.portsetuplist = element.portsetuplist;
			this.rocnetnodelist = element.rocnetnodelist;
			this.rocnetnodeoptionslist = element.rocnetnodeoptionslist;
		}
	}
}
