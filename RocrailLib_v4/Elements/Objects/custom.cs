using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class custom : CRocrailElements
	{
		private string m_arg1;
		private string m_arg2;
		private string m_arg3;
		private string m_arg4;
		private string m_arg5;
		private string m_arg6;
		private string m_cmd;
		private string m_iid;
		/// <summary>
		/// 
		/// </summary>
		public string arg1 
		{
			get { return this.m_arg1; }
			private set { this.SetField(ref this.m_arg1, value, "arg1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string arg2 
		{
			get { return this.m_arg2; }
			private set { this.SetField(ref this.m_arg2, value, "arg2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string arg3 
		{
			get { return this.m_arg3; }
			private set { this.SetField(ref this.m_arg3, value, "arg3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string arg4 
		{
			get { return this.m_arg4; }
			private set { this.SetField(ref this.m_arg4, value, "arg4"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string arg5 
		{
			get { return this.m_arg5; }
			private set { this.SetField(ref this.m_arg5, value, "arg5"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string arg6 
		{
			get { return this.m_arg6; }
			private set { this.SetField(ref this.m_arg6, value, "arg6"); }
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
		/// Interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		public custom()
		{
		}
		public static custom Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			custom _custom = new custom();
			_custom.m_rocrailClient = rocrailClient;
			_custom.m_arg1 = (string)xml.Attribute("arg1");
			_custom.m_arg2 = (string)xml.Attribute("arg2");
			_custom.m_arg3 = (string)xml.Attribute("arg3");
			_custom.m_arg4 = (string)xml.Attribute("arg4");
			_custom.m_arg5 = (string)xml.Attribute("arg5");
			_custom.m_arg6 = (string)xml.Attribute("arg6");
			_custom.m_cmd = (string)xml.Attribute("cmd");
			_custom.m_iid = (string)xml.Attribute("iid");
			return _custom;
		}
		public void Update(custom element)
		{
			if(element.m_arg1 != null) this.arg1 = element.arg1;
			if(element.m_arg2 != null) this.arg2 = element.arg2;
			if(element.m_arg3 != null) this.arg3 = element.arg3;
			if(element.m_arg4 != null) this.arg4 = element.arg4;
			if(element.m_arg5 != null) this.arg5 = element.arg5;
			if(element.m_arg6 != null) this.arg6 = element.arg6;
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_iid != null) this.iid = element.iid;
		}
	}
}
