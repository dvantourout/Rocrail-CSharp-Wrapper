using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class ext : CRocrailElements
	{
		private string m_cmdline;
		/// <summary>
		/// 
		/// </summary>
		public string cmdline 
		{
			get { return this.m_cmdline; }
			private set { this.SetField(ref this.m_cmdline, value, "cmdline"); }
		}
		public ext()
		{
		}
		public static ext Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			ext _ext = new ext();
			_ext.m_rocrailClient = rocrailClient;
			_ext.m_cmdline = (string)xml.Attribute("cmdline");
			return _ext;
		}
		public void Update(ext element)
		{
			if(element.m_cmdline != null) this.cmdline = element.cmdline;
		}
	}
}
