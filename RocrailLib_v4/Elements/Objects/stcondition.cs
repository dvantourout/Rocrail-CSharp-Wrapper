using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class stcondition : CRocrailElements
	{
		private bool? m_allowschedules;
		private bool? m_chdir;
		private bool? m_commuter;
		private bool? m_notprevbk;
		private string m_prevbkid;
		private string m_type;
		/// <summary>
		/// Allow schedules to use this route.
		/// </summary>
		public bool allowschedules 
		{
			get { return this.m_allowschedules.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_allowschedules, value, "allowschedules"); }
		}
		/// <summary>
		/// Must change direction.
		/// </summary>
		public bool chdir 
		{
			get { return this.m_chdir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_chdir, value, "chdir"); }
		}
		/// <summary>
		/// Commuter train.
		/// </summary>
		public bool commuter 
		{
			get { return this.m_commuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_commuter, value, "commuter"); }
		}
		/// <summary>
		/// Not from previous block X.
		/// </summary>
		public bool notprevbk 
		{
			get { return this.m_notprevbk.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_notprevbk, value, "notprevbk"); }
		}
		/// <summary>
		/// Previous block ID.
		/// </summary>
		public string prevbkid 
		{
			get { return this.m_prevbkid; }
			private set { this.SetField(ref this.m_prevbkid, value, "prevbkid"); }
		}
		/// <summary>
		/// Train type
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		public stcondition()
		{
		}
		public static stcondition Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			stcondition _stcondition = new stcondition();
			_stcondition.m_rocrailClient = rocrailClient;
			_stcondition.m_allowschedules = (bool?)xml.Attribute("allowschedules");
			_stcondition.m_chdir = (bool?)xml.Attribute("chdir");
			_stcondition.m_commuter = (bool?)xml.Attribute("commuter");
			_stcondition.m_notprevbk = (bool?)xml.Attribute("notprevbk");
			_stcondition.m_prevbkid = (string)xml.Attribute("prevbkid");
			_stcondition.m_type = (string)xml.Attribute("type");
			return _stcondition;
		}
		public void Update(stcondition element)
		{
			if(element.m_allowschedules.HasValue == true) this.allowschedules = element.allowschedules;
			if(element.m_chdir.HasValue == true) this.chdir = element.chdir;
			if(element.m_commuter.HasValue == true) this.commuter = element.commuter;
			if(element.m_notprevbk.HasValue == true) this.notprevbk = element.notprevbk;
			if(element.m_prevbkid != null) this.prevbkid = element.prevbkid;
			if(element.m_type != null) this.type = element.type;
		}
	}
}
