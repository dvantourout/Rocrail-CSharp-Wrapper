using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class cvbyte : CRocrailElements
	{
		private string m_cat;
		private string m_desc;
		private string m_dipid;
		private string m_info;
		private int? m_nr;
		private bool? m_readonly;
		private string m_url;
		private int? m_value;
		private bool? m_word;
		private List<adip> m_adiplist;
		/// <summary>
		/// Category
		/// </summary>
		public string cat 
		{
			get { return this.m_cat; }
			private set { this.SetField(ref this.m_cat, value, "cat"); }
		}
		/// <summary>
		/// CV-Description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Reference to an existing DIP definition.
		/// </summary>
		public string dipid 
		{
			get { return this.m_dipid; }
			private set { this.SetField(ref this.m_dipid, value, "dipid"); }
		}
		/// <summary>
		/// Info
		/// </summary>
		public string info 
		{
			get { return this.m_info; }
			private set { this.SetField(ref this.m_info, value, "info"); }
		}
		/// <summary>
		/// CV-Number
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// Disable write operations.
		/// </summary>
		public bool @readonly 
		{
			get { return this.m_readonly.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_readonly, value, "@readonly"); }
		}
		/// <summary>
		/// CV-URL
		/// </summary>
		public string url 
		{
			get { return this.m_url; }
			private set { this.SetField(ref this.m_url, value, "url"); }
		}
		/// <summary>
		/// CV-Value
		/// </summary>
		public int @value 
		{
			get { return this.m_value.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value, value, "@value"); }
		}
		/// <summary>
		/// 16 bit word value
		/// </summary>
		public bool word 
		{
			get { return this.m_word.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_word, value, "word"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<adip> adiplist 
		{
			get { return this.m_adiplist; }
			private set { this.SetField(ref this.m_adiplist, value, "adiplist"); }
		}
		public cvbyte()
		{
			this.m_adiplist = new List<adip>();
		}
		public static cvbyte Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			cvbyte _cvbyte = new cvbyte();
			_cvbyte.m_rocrailClient = rocrailClient;
			_cvbyte.m_cat = (string)xml.Attribute("cat");
			_cvbyte.m_desc = (string)xml.Attribute("desc");
			_cvbyte.m_dipid = (string)xml.Attribute("dipid");
			_cvbyte.m_info = (string)xml.Attribute("info");
			_cvbyte.m_nr = (int?)xml.Attribute("nr");
			_cvbyte.m_readonly = (bool?)xml.Attribute("readonly");
			_cvbyte.m_url = (string)xml.Attribute("url");
			_cvbyte.m_value = (int?)xml.Attribute("value");
			_cvbyte.m_word = (bool?)xml.Attribute("word");
			Definitions.Tools.ParseList<adip>(_cvbyte.m_adiplist, xml, "adip", adip.Parse, rocrailClient);
			return _cvbyte;
		}
		public void Update(cvbyte element)
		{
			if(element.m_cat != null) this.cat = element.cat;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_dipid != null) this.dipid = element.dipid;
			if(element.m_info != null) this.info = element.info;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_readonly.HasValue == true) this.@readonly = element.@readonly;
			if(element.m_url != null) this.url = element.url;
			if(element.m_value.HasValue == true) this.@value = element.@value;
			if(element.m_word.HasValue == true) this.word = element.word;
			this.adiplist = element.adiplist;
		}
	}
}
