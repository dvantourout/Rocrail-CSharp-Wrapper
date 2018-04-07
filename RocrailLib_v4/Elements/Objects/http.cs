using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class http : CRocrailElements
	{
		private string m_path;
		private int? m_port;
		private int? m_refresh;
		private List<webclient> m_webclientlist;
		/// <summary>
		/// Path where to look for external HTML documents.
		/// </summary>
		public string path 
		{
			get { return this.m_path; }
			private set { this.SetField(ref this.m_path, value, "path"); }
		}
		/// <summary>
		/// Port number for server socket. Deactivated when 0.
		/// </summary>
		public int port 
		{
			get { return this.m_port.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// browser refresh time: 0=no refresh
		/// </summary>
		public int refresh 
		{
			get { return this.m_refresh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_refresh, value, "refresh"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<webclient> webclientlist 
		{
			get { return this.m_webclientlist; }
			private set { this.SetField(ref this.m_webclientlist, value, "webclientlist"); }
		}
		public http()
		{
			this.m_webclientlist = new List<webclient>();
		}
		public static http Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			http _http = new http();
			_http.m_rocrailClient = rocrailClient;
			_http.m_path = (string)xml.Attribute("path");
			_http.m_port = (int?)xml.Attribute("port");
			_http.m_refresh = (int?)xml.Attribute("refresh");
			Definitions.Tools.ParseList<webclient>(_http.m_webclientlist, xml, "webclient", webclient.Parse, rocrailClient);
			return _http;
		}
		public void Update(http element)
		{
			if(element.m_path != null) this.path = element.path;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_refresh.HasValue == true) this.refresh = element.refresh;
			this.webclientlist = element.webclientlist;
		}
	}
}
