using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class connection : CRocrailElements
	{
		public const string POINT_E = "point-e";
		public const string POINT_N = "point-n";
		public const string POINT_S = "point-s";
		public const string POINT_W = "point-w";
		
		private string m_modid;
		private string m_side;
		/// <summary>
		/// Module ID; for internal use only.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Module ID which connects to this module.
		/// </summary>
		public string modid 
		{
			get { return this.m_modid; }
			private set { this.SetField(ref this.m_modid, value, "modid"); }
		}
		/// <summary>
		/// connection side
		/// </summary>
		public string side 
		{
			get { return this.m_side; }
			private set { this.SetField(ref this.m_side, value, "side"); }
		}
		public connection()
		{
		}
		public static connection Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			connection _connection = new connection();
			_connection.m_rocrailClient = rocrailClient;
			_connection.m_id = (string)xml.Attribute("id");
			_connection.m_modid = (string)xml.Attribute("modid");
			_connection.m_side = (string)xml.Attribute("side");
			return _connection;
		}
		public void Update(connection element)
		{
			if(element.m_id != null) this.id = element.id;
			if(element.m_modid != null) this.modid = element.modid;
			if(element.m_side != null) this.side = element.side;
		}
	}
}
