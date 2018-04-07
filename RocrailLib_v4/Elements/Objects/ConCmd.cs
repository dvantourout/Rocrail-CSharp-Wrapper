using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class ConCmd : CRocrailElements
	{
		public const char ANALYSE = 'z';
		public const char ANALYSECLEAN = 'l';
		public const char AUTOMAT = 'a';
		public const char BYTE = 'b';
		public const char CONFIG = 'c';
		public const char DEBUG = 'd';
		public const char EBREAK = 'e';
		public const char HELP = '?';
		public const char HTTP = 'h';
		public const char INFO = 'n';
		public const char INITFIELD = 'i';
		public const char MEMORY = 'm';
		public const char MEMTRC = 'r';
		public const char MONITOR = 'o';
		public const char POWEROFF = 'y';
		public const char POWERON = 'p';
		public const char QUERY = '5';
		public const char QUIT = 'q';
		public const char SLOTS = 'x';
		public const char SOD = '8';
		public const char STOPAUTOMODE = 's';
		public const char THREADS = 't';
		public ConCmd()
		{
		}
		public static ConCmd Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			ConCmd _ConCmd = new ConCmd();
			_ConCmd.m_rocrailClient = rocrailClient;
			return _ConCmd;
		}
		public void Update(ConCmd element)
		{
		}
	}
}
