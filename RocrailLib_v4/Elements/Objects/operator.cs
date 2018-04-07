using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class @operator : CRocrailElements
	{
		private string m_carids;
		private string m_cmd;
		
		private string m_lcid;
		/// <summary>
		/// Comma separated car IDs
		/// </summary>
		public string carids 
		{
			get { return this.m_carids; }
			private set { this.SetField(ref this.m_carids, value, "carids"); }
		}
		/// <summary>
		/// Operator command.
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lcid 
		{
			get { return this.m_lcid; }
			private set { this.SetField(ref this.m_lcid, value, "lcid"); }
		}
		public @operator()
		{
		}
		public static @operator Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			@operator _operator = new @operator();
			_operator.m_rocrailClient = rocrailClient;
			_operator.m_carids = (string)xml.Attribute("carids");
			_operator.m_cmd = (string)xml.Attribute("cmd");
			_operator.m_id = (string)xml.Attribute("id");
			_operator.m_lcid = (string)xml.Attribute("lcid");
			return _operator;
		}
		public void Update(@operator element)
		{
			if(element.m_carids != null) this.carids = element.carids;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_id != null) this.id = element.id;
			if(element.m_lcid != null) this.lcid = element.lcid;
		}
	}
}
