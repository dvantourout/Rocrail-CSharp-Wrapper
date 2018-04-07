using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class command : CRocrailElements
	{
		public const string FBMODS = "fbmods";
		private string m_arg;
		private string m_cmd;
		
		private string m_iid;
		private string m_server;
		/// <summary>
		/// command arguments
		/// </summary>
		public string arg 
		{
			get { return this.m_arg; }
			private set { this.SetField(ref this.m_arg, value, "arg"); }
		}
		/// <summary>
		/// 
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
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string server 
		{
			get { return this.m_server; }
			private set { this.SetField(ref this.m_server, value, "server"); }
		}
		public command()
		{
		}
		public static command Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			command _command = new command();
			_command.m_rocrailClient = rocrailClient;
			_command.m_arg = (string)xml.Attribute("arg");
			_command.m_cmd = (string)xml.Attribute("cmd");
			_command.m_id = (string)xml.Attribute("id");
			_command.m_iid = (string)xml.Attribute("iid");
			_command.m_server = (string)xml.Attribute("server");
			return _command;
		}
		public void Update(command element)
		{
			if(element.m_arg != null) this.arg = element.arg;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_server != null) this.server = element.server;
		}
	}
}
