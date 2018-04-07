using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class webclient : CRocrailElements
	{
		public const string BOTTOM = "bottom";
		public const string RIGHT = "right";
		private bool? m_me;
		private string m_planbackground;
		private int? m_port;
		private int? m_refresh;
		private string m_rulerbackground;
		private string m_symbolpath;
		private int? m_symbolsize;
		private string m_symboltype;
		private string m_webcampath;
		private string m_webcampos;
		private int? m_xsize;
		private int? m_ysize;
		private List<webcam> m_webcamlist;
		/// <summary>
		/// rocWeb Mobile Edition
		/// </summary>
		public bool me 
		{
			get { return this.m_me.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_me, value, "me"); }
		}
		/// <summary>
		/// background color
		/// </summary>
		public string planbackground 
		{
			get { return this.m_planbackground; }
			private set { this.SetField(ref this.m_planbackground, value, "planbackground"); }
		}
		/// <summary>
		/// Port number server socket for webclients. Deactivated when 0.
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
		/// background color
		/// </summary>
		public string rulerbackground 
		{
			get { return this.m_rulerbackground; }
			private set { this.SetField(ref this.m_rulerbackground, value, "rulerbackground"); }
		}
		/// <summary>
		/// where to look for symbol png's
		/// </summary>
		public string symbolpath 
		{
			get { return this.m_symbolpath; }
			private set { this.SetField(ref this.m_symbolpath, value, "symbolpath"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int symbolsize 
		{
			get { return this.m_symbolsize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_symbolsize, value, "symbolsize"); }
		}
		/// <summary>
		/// symbol type
		/// </summary>
		public string symboltype 
		{
			get { return this.m_symboltype; }
			private set { this.SetField(ref this.m_symboltype, value, "symboltype"); }
		}
		/// <summary>
		/// where to look for symbol png's
		/// </summary>
		public string webcampath 
		{
			get { return this.m_webcampath; }
			private set { this.SetField(ref this.m_webcampath, value, "webcampath"); }
		}
		/// <summary>
		/// where to locate the cam images
		/// </summary>
		public string webcampos 
		{
			get { return this.m_webcampos; }
			private set { this.SetField(ref this.m_webcampos, value, "webcampos"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int xsize 
		{
			get { return this.m_xsize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_xsize, value, "xsize"); }
		}
		/// <summary>
		/// no height is set when 0 which is recommended
		/// </summary>
		public int ysize 
		{
			get { return this.m_ysize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ysize, value, "ysize"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<webcam> webcamlist 
		{
			get { return this.m_webcamlist; }
			private set { this.SetField(ref this.m_webcamlist, value, "webcamlist"); }
		}
		public webclient()
		{
			this.m_webcamlist = new List<webcam>();
		}
		public static webclient Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			webclient _webclient = new webclient();
			_webclient.m_rocrailClient = rocrailClient;
			_webclient.m_me = (bool?)xml.Attribute("me");
			_webclient.m_planbackground = (string)xml.Attribute("planbackground");
			_webclient.m_port = (int?)xml.Attribute("port");
			_webclient.m_refresh = (int?)xml.Attribute("refresh");
			_webclient.m_rulerbackground = (string)xml.Attribute("rulerbackground");
			_webclient.m_symbolpath = (string)xml.Attribute("symbolpath");
			_webclient.m_symbolsize = (int?)xml.Attribute("symbolsize");
			_webclient.m_symboltype = (string)xml.Attribute("symboltype");
			_webclient.m_webcampath = (string)xml.Attribute("webcampath");
			_webclient.m_webcampos = (string)xml.Attribute("webcampos");
			_webclient.m_xsize = (int?)xml.Attribute("xsize");
			_webclient.m_ysize = (int?)xml.Attribute("ysize");
			Definitions.Tools.ParseList<webcam>(_webclient.m_webcamlist, xml, "webcam", webcam.Parse, rocrailClient);
			return _webclient;
		}
		public void Update(webclient element)
		{
			if(element.m_me.HasValue == true) this.me = element.me;
			if(element.m_planbackground != null) this.planbackground = element.planbackground;
			if(element.m_port.HasValue == true) this.port = element.port;
			if(element.m_refresh.HasValue == true) this.refresh = element.refresh;
			if(element.m_rulerbackground != null) this.rulerbackground = element.rulerbackground;
			if(element.m_symbolpath != null) this.symbolpath = element.symbolpath;
			if(element.m_symbolsize.HasValue == true) this.symbolsize = element.symbolsize;
			if(element.m_symboltype != null) this.symboltype = element.symboltype;
			if(element.m_webcampath != null) this.webcampath = element.webcampath;
			if(element.m_webcampos != null) this.webcampos = element.webcampos;
			if(element.m_xsize.HasValue == true) this.xsize = element.xsize;
			if(element.m_ysize.HasValue == true) this.ysize = element.ysize;
			this.webcamlist = element.webcamlist;
		}
	}
}
