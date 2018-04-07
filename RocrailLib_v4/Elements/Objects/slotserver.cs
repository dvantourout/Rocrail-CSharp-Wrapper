using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class slotserver : CRocrailElements
	{
		private bool? m_active;
		private string m_format;
		private string m_iid;
		private bool? m_lconly;
		private bool? m_purge;
		private int? m_speedstep;
		private bool? m_stopatpurge;
		/// <summary>
		/// activate slot server support
		/// </summary>
		public bool active 
		{
			get { return this.m_active.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_active, value, "active"); }
		}
		/// <summary>
		/// default decoder digital format
		/// </summary>
		public string format 
		{
			get { return this.m_format; }
			private set { this.SetField(ref this.m_format, value, "format"); }
		}
		/// <summary>
		/// redirect commands to this interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// serve loco commands only
		/// </summary>
		public bool lconly 
		{
			get { return this.m_lconly.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lconly, value, "lconly"); }
		}
		/// <summary>
		/// activate slot purging (purgtime from parent node)
		/// </summary>
		public bool purge 
		{
			get { return this.m_purge.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_purge, value, "purge"); }
		}
		/// <summary>
		/// default decoder speed steps
		/// </summary>
		public int speedstep 
		{
			get { return this.m_speedstep.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_speedstep, value, "speedstep"); }
		}
		/// <summary>
		/// stop loc after purge
		/// </summary>
		public bool stopatpurge 
		{
			get { return this.m_stopatpurge.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stopatpurge, value, "stopatpurge"); }
		}
		public slotserver()
		{
		}
		public static slotserver Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			slotserver _slotserver = new slotserver();
			_slotserver.m_rocrailClient = rocrailClient;
			_slotserver.m_active = (bool?)xml.Attribute("active");
			_slotserver.m_format = (string)xml.Attribute("format");
			_slotserver.m_iid = (string)xml.Attribute("iid");
			_slotserver.m_lconly = (bool?)xml.Attribute("lconly");
			_slotserver.m_purge = (bool?)xml.Attribute("purge");
			_slotserver.m_speedstep = (int?)xml.Attribute("speedstep");
			_slotserver.m_stopatpurge = (bool?)xml.Attribute("stopatpurge");
			return _slotserver;
		}
		public void Update(slotserver element)
		{
			if(element.m_active.HasValue == true) this.active = element.active;
			if(element.m_format != null) this.format = element.format;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_lconly.HasValue == true) this.lconly = element.lconly;
			if(element.m_purge.HasValue == true) this.purge = element.purge;
			if(element.m_speedstep.HasValue == true) this.speedstep = element.speedstep;
			if(element.m_stopatpurge.HasValue == true) this.stopatpurge = element.stopatpurge;
		}
	}
}
