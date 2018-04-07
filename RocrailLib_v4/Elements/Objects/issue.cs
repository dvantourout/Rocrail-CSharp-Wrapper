using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class issue : CRocrailElements
	{
		private bool? m_currenttrc;
		private string m_desc;
		private bool? m_ini;
		private bool? m_stat;
		private string m_subject;
		private bool? m_trc;
		private bool? m_xml;
		/// <summary>
		/// Current trace only.
		/// </summary>
		public bool currenttrc 
		{
			get { return this.m_currenttrc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_currenttrc, value, "currenttrc"); }
		}
		/// <summary>
		/// Description of the issue; UTF-8
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Include rocrail.ini.
		/// </summary>
		public bool ini 
		{
			get { return this.m_ini.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ini, value, "ini"); }
		}
		/// <summary>
		/// Include server statistics.
		/// </summary>
		public bool stat 
		{
			get { return this.m_stat.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stat, value, "stat"); }
		}
		/// <summary>
		/// Subject of the issue; 7bit ASCII
		/// </summary>
		public string subject 
		{
			get { return this.m_subject; }
			private set { this.SetField(ref this.m_subject, value, "subject"); }
		}
		/// <summary>
		/// Include all traces.
		/// </summary>
		public bool trc 
		{
			get { return this.m_trc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_trc, value, "trc"); }
		}
		/// <summary>
		/// Include all definitions.
		/// </summary>
		public bool xml 
		{
			get { return this.m_xml.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_xml, value, "xml"); }
		}
		public issue()
		{
		}
		public static issue Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			issue _issue = new issue();
			_issue.m_rocrailClient = rocrailClient;
			_issue.m_currenttrc = (bool?)xml.Attribute("currenttrc");
			_issue.m_desc = (string)xml.Attribute("desc");
			_issue.m_ini = (bool?)xml.Attribute("ini");
			_issue.m_stat = (bool?)xml.Attribute("stat");
			_issue.m_subject = (string)xml.Attribute("subject");
			_issue.m_trc = (bool?)xml.Attribute("trc");
			_issue.m_xml = (bool?)xml.Attribute("xml");
			return _issue;
		}
		public void Update(issue element)
		{
			if(element.m_currenttrc.HasValue == true) this.currenttrc = element.currenttrc;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_ini.HasValue == true) this.ini = element.ini;
			if(element.m_stat.HasValue == true) this.stat = element.stat;
			if(element.m_subject != null) this.subject = element.subject;
			if(element.m_trc.HasValue == true) this.trc = element.trc;
			if(element.m_xml.HasValue == true) this.xml = element.xml;
		}
	}
}
