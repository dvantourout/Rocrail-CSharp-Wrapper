using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class mv : CRocrailElements
	{
		private int? m_distance;
		private bool? m_mph;
		private string m_s1;
		private string m_s2;
		private int? m_scale;
		/// <summary>
		/// Distance between the two events.
		/// </summary>
		public int distance 
		{
			get { return this.m_distance.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_distance, value, "distance"); }
		}
		/// <summary>
		/// convert to MPH
		/// </summary>
		public bool mph 
		{
			get { return this.m_mph.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mph, value, "mph"); }
		}
		/// <summary>
		/// Feedback ID
		/// </summary>
		public string s1 
		{
			get { return this.m_s1; }
			private set { this.SetField(ref this.m_s1, value, "s1"); }
		}
		/// <summary>
		/// Feedback ID
		/// </summary>
		public string s2 
		{
			get { return this.m_s2; }
			private set { this.SetField(ref this.m_s2, value, "s2"); }
		}
		/// <summary>
		/// Scale of locomotives.
		/// </summary>
		public int scale 
		{
			get { return this.m_scale.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_scale, value, "scale"); }
		}
		public mv()
		{
		}
		public static mv Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			mv _mv = new mv();
			_mv.m_rocrailClient = rocrailClient;
			_mv.m_distance = (int?)xml.Attribute("distance");
			_mv.m_mph = (bool?)xml.Attribute("mph");
			_mv.m_s1 = (string)xml.Attribute("s1");
			_mv.m_s2 = (string)xml.Attribute("s2");
			_mv.m_scale = (int?)xml.Attribute("scale");
			return _mv;
		}
		public void Update(mv element)
		{
			if(element.m_distance.HasValue == true) this.distance = element.distance;
			if(element.m_mph.HasValue == true) this.mph = element.mph;
			if(element.m_s1 != null) this.s1 = element.s1;
			if(element.m_s2 != null) this.s2 = element.s2;
			if(element.m_scale.HasValue == true) this.scale = element.scale;
		}
	}
}
