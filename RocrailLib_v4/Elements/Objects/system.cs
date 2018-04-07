using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class system : CRocrailElements
	{
		private List<actionctrl> m_actionctrllist;
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		public system()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static system Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			system _system = new system();
			_system.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<actionctrl>(_system.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			return _system;
		}
		public void Update(system element)
		{
			this.actionctrllist = element.actionctrllist;
		}
	}
}
