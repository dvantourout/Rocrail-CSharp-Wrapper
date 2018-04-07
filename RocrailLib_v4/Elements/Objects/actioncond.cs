using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class actioncond : CRocrailElements
	{
		
		private string m_state;
		private string m_type;
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Activation state, empty is always.
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		public actioncond()
		{
		}
		public static actioncond Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			actioncond _actioncond = new actioncond();
			_actioncond.m_rocrailClient = rocrailClient;
			_actioncond.m_id = (string)xml.Attribute("id");
			_actioncond.m_state = (string)xml.Attribute("state");
			_actioncond.m_type = (string)xml.Attribute("type");
			return _actioncond;
		}
		public void Update(actioncond element)
		{
			if(element.m_id != null) this.id = element.id;
			if(element.m_state != null) this.state = element.state;
			if(element.m_type != null) this.type = element.type;
		}
	}
}
