using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class Global : CRocrailElements
	{
		public const string BUILDDATE = "$__DATE__";
		public const string BUILDTIME = "$__TIME__";
		public const int PATCH = 999;
		public const string PRODUCTNAME = "Rocrail";
		public const string RELEASENAME = "Sunrise";
		public const string RELEASESUFFIX = "snapshot";
		public const int VMAJOR = 2;
		public const int VMINOR = 0;
		public Global()
		{
		}
		public static Global Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			Global _Global = new Global();
			_Global.m_rocrailClient = rocrailClient;
			return _Global;
		}
		public void Update(Global element)
		{
		}
	}
}
