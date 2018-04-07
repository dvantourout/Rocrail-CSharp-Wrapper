using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class Cmdline : CRocrailElements
	{
		public const string AUTOMODE = "-auto";
		public const string BYTE = "-byte";
		public const string CONSOLE = "-console";
		public const string DEBUG = "-debug";
		public const string DELETESERVICE = "-deleteservice";
		public const string DOC = "-doc";
		public const string HELP = "--help";
		public const string IMGPATH = "-img";
		public const string INFO = "-info";
		public const string INIFILE = "-i";
		public const string INITFIELD = "-f";
		public const string INSTALLSERVICE = "-installservice";
		public const string LCD = "-lcd";
		public const string LIBPATH = "-l";
		public const string LOCOFILE = "-lf";
		public const string MODPLAN = "-modplan";
		public const string MONITOR = "-monitor";
		public const string NOCOM = "-nocom";
		public const string NODEVCHECK = "-nodevcheck";
		public const string PARSE = "-parse";
		public const string PLANFILE = "-x";
		public const string PORT = "-p";
		public const string RESUME = "-resume";
		public const string RUN = "-run";
		public const string SERVICE = "-service";
		public const string STRESS = "-stress";
		public const string TRCFILE = "-t";
		public const string VERSION = "-version";
		public const string WORKDIR = "-w";
		public Cmdline()
		{
		}
		public static Cmdline Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			Cmdline _Cmdline = new Cmdline();
			_Cmdline.m_rocrailClient = rocrailClient;
			return _Cmdline;
		}
		public void Update(Cmdline element)
		{
		}
	}
}
