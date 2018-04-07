using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class opendcc : CRocrailElements
	{
		private bool? m_bidi;
		private bool? m_fastclock;
		private string m_lib;
		private bool? m_loccnfg;
		/// <summary>
		/// Activate BiDi support.
		/// </summary>
		public bool bidi 
		{
			get { return this.m_bidi.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bidi, value, "bidi"); }
		}
		/// <summary>
		/// Fast clock flag read from SO 2.
		/// </summary>
		public bool fastclock 
		{
			get { return this.m_fastclock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fastclock, value, "fastclock"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lib 
		{
			get { return this.m_lib; }
			private set { this.SetField(ref this.m_lib, value, "lib"); }
		}
		/// <summary>
		/// send loco config commands
		/// </summary>
		public bool loccnfg 
		{
			get { return this.m_loccnfg.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_loccnfg, value, "loccnfg"); }
		}
		public opendcc()
		{
		}
		public static opendcc Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			opendcc _opendcc = new opendcc();
			_opendcc.m_rocrailClient = rocrailClient;
			_opendcc.m_bidi = (bool?)xml.Attribute("bidi");
			_opendcc.m_fastclock = (bool?)xml.Attribute("fastclock");
			_opendcc.m_lib = (string)xml.Attribute("lib");
			_opendcc.m_loccnfg = (bool?)xml.Attribute("loccnfg");
			return _opendcc;
		}
		public void Update(opendcc element)
		{
			if(element.m_bidi.HasValue == true) this.bidi = element.bidi;
			if(element.m_fastclock.HasValue == true) this.fastclock = element.fastclock;
			if(element.m_lib != null) this.lib = element.lib;
			if(element.m_loccnfg.HasValue == true) this.loccnfg = element.loccnfg;
		}
	}
}
