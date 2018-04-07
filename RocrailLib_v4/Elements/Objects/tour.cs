using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class tour : CRocrailElements
	{
		
		private bool? m_recycle;
		private string m_schedules;
		/// <summary>
		/// tour name
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Recycle this tour.
		/// </summary>
		public bool recycle 
		{
			get { return this.m_recycle.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_recycle, value, "recycle"); }
		}
		/// <summary>
		/// csv list of schedules
		/// </summary>
		public string schedules 
		{
			get { return this.m_schedules; }
			private set { this.SetField(ref this.m_schedules, value, "schedules"); }
		}
		public tour()
		{
		}
		public static tour Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			tour _tour = new tour();
			_tour.m_rocrailClient = rocrailClient;
			_tour.m_id = (string)xml.Attribute("id");
			_tour.m_recycle = (bool?)xml.Attribute("recycle");
			_tour.m_schedules = (string)xml.Attribute("schedules");
			return _tour;
		}
		public void Update(tour element)
		{
			if(element.m_id != null) this.id = element.id;
			if(element.m_recycle.HasValue == true) this.recycle = element.recycle;
			if(element.m_schedules != null) this.schedules = element.schedules;
		}
	}
}
