using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class description : CRocrailElements
	{
		private string m_lang;
		private string m_text;
		private string m_url;
		/// <summary>
		/// Language
		/// </summary>
		public string lang 
		{
			get { return this.m_lang; }
			private set { this.SetField(ref this.m_lang, value, "lang"); }
		}
		/// <summary>
		/// Description
		/// </summary>
		public string text 
		{
			get { return this.m_text; }
			private set { this.SetField(ref this.m_text, value, "text"); }
		}
		/// <summary>
		/// Documentation URL
		/// </summary>
		public string url 
		{
			get { return this.m_url; }
			private set { this.SetField(ref this.m_url, value, "url"); }
		}
		public description()
		{
		}
		public static description Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			description _description = new description();
			_description.m_rocrailClient = rocrailClient;
			_description.m_lang = (string)xml.Attribute("lang");
			_description.m_text = (string)xml.Attribute("text");
			_description.m_url = (string)xml.Attribute("url");
			return _description;
		}
		public void Update(description element)
		{
			if(element.m_lang != null) this.lang = element.lang;
			if(element.m_text != null) this.text = element.text;
			if(element.m_url != null) this.url = element.url;
		}
	}
}
