using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class powercmd : CRocrailElements
	{
		public const string OFF = "off";
		public const string ON = "on";
		private string m_cmd;
		
		private string m_iid;
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// Booster ID; command for all not set.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		public powercmd()
		{
		}
		public static powercmd Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			powercmd _powercmd = new powercmd();
			_powercmd.m_rocrailClient = rocrailClient;
			_powercmd.m_cmd = (string)xml.Attribute("cmd");
			_powercmd.m_id = (string)xml.Attribute("id");
			_powercmd.m_iid = (string)xml.Attribute("iid");
			return _powercmd;
		}
		public void Update(powercmd element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
		}
	}
}
