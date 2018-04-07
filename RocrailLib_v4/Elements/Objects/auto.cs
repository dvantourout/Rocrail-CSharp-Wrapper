using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class auto : CRocrailElements
	{
		public const string OFF = "off";
		public const string ON = "on";
		public const string RESET = "reset";
		public const string RESUME = "resume";
		public const string SOFTRESET = "softreset";
		public const string START = "start";
		public const string STARTVIRTUAL = "startvirtual";
		public const string STOP = "stop";
		public const string V0LOCOS = "v0locos";
		private string m_cmd;
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		public auto()
		{
		}
		public static auto Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			auto _auto = new auto();
			_auto.m_rocrailClient = rocrailClient;
			_auto.m_cmd = (string)xml.Attribute("cmd");
			return _auto;
		}
		public void Update(auto element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
		}
	}
}
