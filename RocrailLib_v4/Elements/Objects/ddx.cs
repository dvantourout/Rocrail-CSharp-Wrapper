using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class ddx : CRocrailElements
	{
		private bool? m_dcc;
		private bool? m_fastcvget;
		private bool? m_inversedsr;
		private bool? m_mmlongpause;
		private bool? m_motorola;
		private bool? m_motorolarefresh;
		private string m_port;
		private string m_portbase;
		private bool? m_queuecheck;
		private bool? m_realnmratiming;
		private int? m_s88b0modcnt;
		private int? m_s88b1modcnt;
		private int? m_s88b2modcnt;
		private int? m_s88b3modcnt;
		private int? m_s88busses;
		private int? m_s88clockscale;
		private string m_s88port;
		private int? m_s88refresh;
		private bool? m_shortcutchecking;
		private int? m_shortcutdelay;
		/// <summary>
		/// generate the NMRA DCC protocol
		/// </summary>
		public bool dcc 
		{
			get { return this.m_dcc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dcc, value, "dcc"); }
		}
		/// <summary>
		/// Fast cv get for real rs232.
		/// </summary>
		public bool fastcvget 
		{
			get { return this.m_fastcvget.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fastcvget, value, "fastcvget"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool inversedsr 
		{
			get { return this.m_inversedsr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inversedsr, value, "inversedsr"); }
		}
		/// <summary>
		/// Use long packet pause.
		/// </summary>
		public bool mmlongpause 
		{
			get { return this.m_mmlongpause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mmlongpause, value, "mmlongpause"); }
		}
		/// <summary>
		/// generate the motorola protocol
		/// </summary>
		public bool motorola 
		{
			get { return this.m_motorola.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_motorola, value, "motorola"); }
		}
		/// <summary>
		/// set to false if no MM locdecoders are used and accessory are MM
		/// </summary>
		public bool motorolarefresh 
		{
			get { return this.m_motorolarefresh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_motorolarefresh, value, "motorolarefresh"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string port 
		{
			get { return this.m_port; }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string portbase 
		{
			get { return this.m_portbase; }
			private set { this.SetField(ref this.m_portbase, value, "portbase"); }
		}
		/// <summary>
		/// Check if there are bytes left in the send queue and sleep.
		/// </summary>
		public bool queuecheck 
		{
			get { return this.m_queuecheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_queuecheck, value, "queuecheck"); }
		}
		/// <summary>
		/// experimental: do not use
		/// </summary>
		public bool realnmratiming 
		{
			get { return this.m_realnmratiming.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_realnmratiming, value, "realnmratiming"); }
		}
		/// <summary>
		/// one module represents 8 inputs (one byte)
		/// </summary>
		public int s88b0modcnt 
		{
			get { return this.m_s88b0modcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88b0modcnt, value, "s88b0modcnt"); }
		}
		/// <summary>
		/// one module represents 8 inputs (one byte)
		/// </summary>
		public int s88b1modcnt 
		{
			get { return this.m_s88b1modcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88b1modcnt, value, "s88b1modcnt"); }
		}
		/// <summary>
		/// one module represents 8 inputs (one byte)
		/// </summary>
		public int s88b2modcnt 
		{
			get { return this.m_s88b2modcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88b2modcnt, value, "s88b2modcnt"); }
		}
		/// <summary>
		/// one module represents 8 inputs (one byte)
		/// </summary>
		public int s88b3modcnt 
		{
			get { return this.m_s88b3modcnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88b3modcnt, value, "s88b3modcnt"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int s88busses 
		{
			get { return this.m_s88busses.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88busses, value, "s88busses"); }
		}
		/// <summary>
		/// clock=166kHz divided by S88CLOCK_SCALE
		/// </summary>
		public int s88clockscale 
		{
			get { return this.m_s88clockscale.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88clockscale, value, "s88clockscale"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string s88port 
		{
			get { return this.m_s88port; }
			private set { this.SetField(ref this.m_s88port, value, "s88port"); }
		}
		/// <summary>
		/// time between the bus polling
		/// </summary>
		public int s88refresh 
		{
			get { return this.m_s88refresh.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_s88refresh, value, "s88refresh"); }
		}
		/// <summary>
		/// Use shortcut detection
		/// </summary>
		public bool shortcutchecking 
		{
			get { return this.m_shortcutchecking.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcutchecking, value, "shortcutchecking"); }
		}
		/// <summary>
		/// Shortcut events shorter than this time is ignored
		/// </summary>
		public int shortcutdelay 
		{
			get { return this.m_shortcutdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcutdelay, value, "shortcutdelay"); }
		}
		public ddx()
		{
		}
		public static ddx Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			ddx _ddx = new ddx();
			_ddx.m_rocrailClient = rocrailClient;
			_ddx.m_dcc = (bool?)xml.Attribute("dcc");
			_ddx.m_fastcvget = (bool?)xml.Attribute("fastcvget");
			_ddx.m_inversedsr = (bool?)xml.Attribute("inversedsr");
			_ddx.m_mmlongpause = (bool?)xml.Attribute("mmlongpause");
			_ddx.m_motorola = (bool?)xml.Attribute("motorola");
			_ddx.m_motorolarefresh = (bool?)xml.Attribute("motorolarefresh");
			_ddx.m_port = (string)xml.Attribute("port");
			_ddx.m_portbase = (string)xml.Attribute("portbase");
			_ddx.m_queuecheck = (bool?)xml.Attribute("queuecheck");
			_ddx.m_realnmratiming = (bool?)xml.Attribute("realnmratiming");
			_ddx.m_s88b0modcnt = (int?)xml.Attribute("s88b0modcnt");
			_ddx.m_s88b1modcnt = (int?)xml.Attribute("s88b1modcnt");
			_ddx.m_s88b2modcnt = (int?)xml.Attribute("s88b2modcnt");
			_ddx.m_s88b3modcnt = (int?)xml.Attribute("s88b3modcnt");
			_ddx.m_s88busses = (int?)xml.Attribute("s88busses");
			_ddx.m_s88clockscale = (int?)xml.Attribute("s88clockscale");
			_ddx.m_s88port = (string)xml.Attribute("s88port");
			_ddx.m_s88refresh = (int?)xml.Attribute("s88refresh");
			_ddx.m_shortcutchecking = (bool?)xml.Attribute("shortcutchecking");
			_ddx.m_shortcutdelay = (int?)xml.Attribute("shortcutdelay");
			return _ddx;
		}
		public void Update(ddx element)
		{
			if(element.m_dcc.HasValue == true) this.dcc = element.dcc;
			if(element.m_fastcvget.HasValue == true) this.fastcvget = element.fastcvget;
			if(element.m_inversedsr.HasValue == true) this.inversedsr = element.inversedsr;
			if(element.m_mmlongpause.HasValue == true) this.mmlongpause = element.mmlongpause;
			if(element.m_motorola.HasValue == true) this.motorola = element.motorola;
			if(element.m_motorolarefresh.HasValue == true) this.motorolarefresh = element.motorolarefresh;
			if(element.m_port != null) this.port = element.port;
			if(element.m_portbase != null) this.portbase = element.portbase;
			if(element.m_queuecheck.HasValue == true) this.queuecheck = element.queuecheck;
			if(element.m_realnmratiming.HasValue == true) this.realnmratiming = element.realnmratiming;
			if(element.m_s88b0modcnt.HasValue == true) this.s88b0modcnt = element.s88b0modcnt;
			if(element.m_s88b1modcnt.HasValue == true) this.s88b1modcnt = element.s88b1modcnt;
			if(element.m_s88b2modcnt.HasValue == true) this.s88b2modcnt = element.s88b2modcnt;
			if(element.m_s88b3modcnt.HasValue == true) this.s88b3modcnt = element.s88b3modcnt;
			if(element.m_s88busses.HasValue == true) this.s88busses = element.s88busses;
			if(element.m_s88clockscale.HasValue == true) this.s88clockscale = element.s88clockscale;
			if(element.m_s88port != null) this.s88port = element.s88port;
			if(element.m_s88refresh.HasValue == true) this.s88refresh = element.s88refresh;
			if(element.m_shortcutchecking.HasValue == true) this.shortcutchecking = element.shortcutchecking;
			if(element.m_shortcutdelay.HasValue == true) this.shortcutdelay = element.shortcutdelay;
		}
	}
}
