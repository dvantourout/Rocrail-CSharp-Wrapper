using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class dcc232 : CRocrailElements
	{
		private bool? m_fastcvget;
		private bool? m_inversedsr;
		private string m_port;
		private bool? m_purge;
		private int? m_purgetime;
		private bool? m_shortcut;
		private int? m_shortcutdelay;
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string port 
		{
			get { return this.m_port; }
			private set { this.SetField(ref this.m_port, value, "port"); }
		}
		/// <summary>
		/// Activate purging.
		/// </summary>
		public bool purge 
		{
			get { return this.m_purge.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_purge, value, "purge"); }
		}
		/// <summary>
		/// Idle time for purg a slot.
		/// </summary>
		public int purgetime 
		{
			get { return this.m_purgetime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_purgetime, value, "purgetime"); }
		}
		/// <summary>
		/// Use shortcut detection
		/// </summary>
		public bool shortcut 
		{
			get { return this.m_shortcut.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcut, value, "shortcut"); }
		}
		/// <summary>
		/// Shortcut events shorter than this time is ignored
		/// </summary>
		public int shortcutdelay 
		{
			get { return this.m_shortcutdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortcutdelay, value, "shortcutdelay"); }
		}
		public dcc232()
		{
		}
		public static dcc232 Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			dcc232 _dcc232 = new dcc232();
			_dcc232.m_rocrailClient = rocrailClient;
			_dcc232.m_fastcvget = (bool?)xml.Attribute("fastcvget");
			_dcc232.m_inversedsr = (bool?)xml.Attribute("inversedsr");
			_dcc232.m_port = (string)xml.Attribute("port");
			_dcc232.m_purge = (bool?)xml.Attribute("purge");
			_dcc232.m_purgetime = (int?)xml.Attribute("purgetime");
			_dcc232.m_shortcut = (bool?)xml.Attribute("shortcut");
			_dcc232.m_shortcutdelay = (int?)xml.Attribute("shortcutdelay");
			return _dcc232;
		}
		public void Update(dcc232 element)
		{
			if(element.m_fastcvget.HasValue == true) this.fastcvget = element.fastcvget;
			if(element.m_inversedsr.HasValue == true) this.inversedsr = element.inversedsr;
			if(element.m_port != null) this.port = element.port;
			if(element.m_purge.HasValue == true) this.purge = element.purge;
			if(element.m_purgetime.HasValue == true) this.purgetime = element.purgetime;
			if(element.m_shortcut.HasValue == true) this.shortcut = element.shortcut;
			if(element.m_shortcutdelay.HasValue == true) this.shortcutdelay = element.shortcutdelay;
		}
	}
}
