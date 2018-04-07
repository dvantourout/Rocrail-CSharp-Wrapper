using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class model : CRocrailElements
	{
		public const string ADD = "add";
		public const string ADDMODULE = "addmodule";
		public const string BKLIST = "bklist";
		public const string FSTAT = "fstat";
		public const string INITFIELD = "initfield";
		public const string LCLIST = "lclist";
		public const string LCPROPS = "lcprops";
		public const string MERGE = "merge";
		public const string MODIFY = "modify";
		public const string MOVE = "move";
		public const string PLAN = "plan";
		public const string PLANTITLE = "plantitle";
		public const string REMOVE = "remove";
		public const string SAVE = "save";
		public const string SCLIST = "sclist";
		public const string STLIST = "stlist";
		public const string SWLIST = "swlist";
		public const string THEMES = "themes";
		private string m_cmd;
		private string m_cmdfrom;
		private string m_controlcode;
		private bool? m_disablemonitor;
		private string m_val;
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
		public string cmdfrom 
		{
			get { return this.m_cmdfrom; }
			private set { this.SetField(ref this.m_cmdfrom, value, "cmdfrom"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string controlcode 
		{
			get { return this.m_controlcode; }
			private set { this.SetField(ref this.m_controlcode, value, "controlcode"); }
		}
		/// <summary>
		/// Client do not want to receive monitor messages embeded in exception wrappers.(iRoc)
		/// </summary>
		public bool disablemonitor 
		{
			get { return this.m_disablemonitor.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_disablemonitor, value, "disablemonitor"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string val 
		{
			get { return this.m_val; }
			private set { this.SetField(ref this.m_val, value, "val"); }
		}
		public model()
		{
		}
		public static model Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			model _model = new model();
			_model.m_rocrailClient = rocrailClient;
			_model.m_cmd = (string)xml.Attribute("cmd");
			_model.m_cmdfrom = (string)xml.Attribute("cmdfrom");
			_model.m_controlcode = (string)xml.Attribute("controlcode");
			_model.m_disablemonitor = (bool?)xml.Attribute("disablemonitor");
			_model.m_val = (string)xml.Attribute("val");
			return _model;
		}
		public void Update(model element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_cmdfrom != null) this.cmdfrom = element.cmdfrom;
			if(element.m_controlcode != null) this.controlcode = element.controlcode;
			if(element.m_disablemonitor.HasValue == true) this.disablemonitor = element.disablemonitor;
			if(element.m_val != null) this.val = element.val;
		}
	}
}
