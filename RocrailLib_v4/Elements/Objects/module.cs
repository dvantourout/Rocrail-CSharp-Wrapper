using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class module : CRocrailElements
	{
		public const string CMD_CONNECT = "connect";
		public const string CMD_EAST = "east";
		public const string CMD_MOVE = "move";
		public const string CMD_NORTH = "north";
		public const string CMD_SOUTH = "south";
		public const string CMD_STATE = "state";
		public const string CMD_WEST = "west";
		public const string STATE_NORMAL = "normal";
		public const string STATE_SHORTCUT = "shortcut";
		private string m_cmd;
		private int? m_cx;
		private int? m_cy;
		private string m_filename;
		
		private string m_idprefix;
		private int? m_rotation;
		private string m_state;
		private bool? m_swaprrd;
		private string m_title;
		private int? m_x;
		private int? m_y;
		private List<connection> m_connectionlist;
		/// <summary>
		/// module command from rocgui
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cx 
		{
			get { return this.m_cx.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cx, value, "cx"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cy 
		{
			get { return this.m_cy.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cy, value, "cy"); }
		}
		/// <summary>
		/// File name of module track plan.
		/// </summary>
		public string filename 
		{
			get { return this.m_filename; }
			private set { this.SetField(ref this.m_filename, value, "filename"); }
		}
		/// <summary>
		/// Module ID.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Add a prefix to all objects to make them unique.
		/// </summary>
		public string idprefix 
		{
			get { return this.m_idprefix; }
			private set { this.SetField(ref this.m_idprefix, value, "idprefix"); }
		}
		/// <summary>
		/// rotation angle in degrees
		/// </summary>
		public int rotation 
		{
			get { return this.m_rotation.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rotation, value, "rotation"); }
		}
		/// <summary>
		/// module state
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Swap route running directions.
		/// </summary>
		public bool swaprrd 
		{
			get { return this.m_swaprrd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swaprrd, value, "swaprrd"); }
		}
		/// <summary>
		/// Text to show in the tab.
		/// </summary>
		public string title 
		{
			get { return this.m_title; }
			private set { this.SetField(ref this.m_title, value, "title"); }
		}
		/// <summary>
		/// x position on an overview panel
		/// </summary>
		public int x 
		{
			get { return this.m_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_x, value, "x"); }
		}
		/// <summary>
		/// y position on an overview panel
		/// </summary>
		public int y 
		{
			get { return this.m_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_y, value, "y"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<connection> connectionlist 
		{
			get { return this.m_connectionlist; }
			private set { this.SetField(ref this.m_connectionlist, value, "connectionlist"); }
		}
		public module()
		{
			this.m_connectionlist = new List<connection>();
		}
		public static module Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			module _module = new module();
			_module.m_rocrailClient = rocrailClient;
			_module.m_cmd = (string)xml.Attribute("cmd");
			_module.m_cx = (int?)xml.Attribute("cx");
			_module.m_cy = (int?)xml.Attribute("cy");
			_module.m_filename = (string)xml.Attribute("filename");
			_module.m_id = (string)xml.Attribute("id");
			_module.m_idprefix = (string)xml.Attribute("idprefix");
			_module.m_rotation = (int?)xml.Attribute("rotation");
			_module.m_state = (string)xml.Attribute("state");
			_module.m_swaprrd = (bool?)xml.Attribute("swaprrd");
			_module.m_title = (string)xml.Attribute("title");
			_module.m_x = (int?)xml.Attribute("x");
			_module.m_y = (int?)xml.Attribute("y");
			Definitions.Tools.ParseList<connection>(_module.m_connectionlist, xml, "connection", connection.Parse, rocrailClient);
			return _module;
		}
		public void Update(module element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_cx.HasValue == true) this.cx = element.cx;
			if(element.m_cy.HasValue == true) this.cy = element.cy;
			if(element.m_filename != null) this.filename = element.filename;
			if(element.m_id != null) this.id = element.id;
			if(element.m_idprefix != null) this.idprefix = element.idprefix;
			if(element.m_rotation.HasValue == true) this.rotation = element.rotation;
			if(element.m_state != null) this.state = element.state;
			if(element.m_swaprrd.HasValue == true) this.swaprrd = element.swaprrd;
			if(element.m_title != null) this.title = element.title;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			this.connectionlist = element.connectionlist;
		}
	}
}
