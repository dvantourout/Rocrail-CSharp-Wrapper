using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class webcam : CRocrailElements
	{
		private string m_imagefile;
		private string m_title;
		/// <summary>
		/// 
		/// </summary>
		public string imagefile 
		{
			get { return this.m_imagefile; }
			private set { this.SetField(ref this.m_imagefile, value, "imagefile"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string title 
		{
			get { return this.m_title; }
			private set { this.SetField(ref this.m_title, value, "title"); }
		}
		public webcam()
		{
		}
		public static webcam Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			webcam _webcam = new webcam();
			_webcam.m_rocrailClient = rocrailClient;
			_webcam.m_imagefile = (string)xml.Attribute("imagefile");
			_webcam.m_title = (string)xml.Attribute("title");
			return _webcam;
		}
		public void Update(webcam element)
		{
			if(element.m_imagefile != null) this.imagefile = element.imagefile;
			if(element.m_title != null) this.title = element.title;
		}
	}
}
