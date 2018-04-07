using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class exception : CRocrailElements
	{
		private int? m_level;
		private string m_text;
		/// <summary>
		/// 
		/// </summary>
		public int level 
		{
			get { return this.m_level.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_level, value, "level"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string text 
		{
			get { return this.m_text; }
			private set { this.SetField(ref this.m_text, value, "text"); }
		}
		public exception()
		{
		}
		public static exception Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			exception _exception = new exception();
			_exception.m_rocrailClient = rocrailClient;
			_exception.m_level = (int?)xml.Attribute("level");
			_exception.m_text = (string)xml.Attribute("text");
			return _exception;
		}
		public void Update(exception element)
		{
			if(element.m_level.HasValue == true) this.level = element.level;
			if(element.m_text != null) this.text = element.text;
		}
	}
}
