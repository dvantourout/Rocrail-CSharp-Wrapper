using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class track : CRocrailElements
	{
		private string m_bkid;
		private int? m_decnr;
		private string m_desc;
		private int? m_nr;
		private int? m_oppositetrack;
		private bool? m_polarization;
		private string m_posfb;
		private bool? m_show;
		private bool? m_state;
		/// <summary>
		/// block id
		/// </summary>
		public string bkid 
		{
			get { return this.m_bkid; }
			private set { this.SetField(ref this.m_bkid, value, "bkid"); }
		}
		/// <summary>
		/// Decoder track number.
		/// </summary>
		public int decnr 
		{
			get { return this.m_decnr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_decnr, value, "decnr"); }
		}
		/// <summary>
		/// description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// Track number.
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// Opposite track to do a 180 degree turn.
		/// </summary>
		public int oppositetrack 
		{
			get { return this.m_oppositetrack.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_oppositetrack, value, "oppositetrack"); }
		}
		/// <summary>
		/// Flip bridge polarization when entering this track.
		/// </summary>
		public bool polarization 
		{
			get { return this.m_polarization.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_polarization, value, "polarization"); }
		}
		/// <summary>
		/// Feedback ID for positioning the TT.
		/// </summary>
		public string posfb 
		{
			get { return this.m_posfb; }
			private set { this.SetField(ref this.m_posfb, value, "posfb"); }
		}
		/// <summary>
		/// Visibility flag.
		/// </summary>
		public bool show 
		{
			get { return this.m_show.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_show, value, "show"); }
		}
		/// <summary>
		/// pos feedback state.
		/// </summary>
		public bool state 
		{
			get { return this.m_state.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		public track()
		{
		}
		public static track Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			track _track = new track();
			_track.m_rocrailClient = rocrailClient;
			_track.m_bkid = (string)xml.Attribute("bkid");
			_track.m_decnr = (int?)xml.Attribute("decnr");
			_track.m_desc = (string)xml.Attribute("desc");
			_track.m_nr = (int?)xml.Attribute("nr");
			_track.m_oppositetrack = (int?)xml.Attribute("oppositetrack");
			_track.m_polarization = (bool?)xml.Attribute("polarization");
			_track.m_posfb = (string)xml.Attribute("posfb");
			_track.m_show = (bool?)xml.Attribute("show");
			_track.m_state = (bool?)xml.Attribute("state");
			return _track;
		}
		public void Update(track element)
		{
			if(element.m_bkid != null) this.bkid = element.bkid;
			if(element.m_decnr.HasValue == true) this.decnr = element.decnr;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_oppositetrack.HasValue == true) this.oppositetrack = element.oppositetrack;
			if(element.m_polarization.HasValue == true) this.polarization = element.polarization;
			if(element.m_posfb != null) this.posfb = element.posfb;
			if(element.m_show.HasValue == true) this.show = element.show;
			if(element.m_state.HasValue == true) this.state = element.state;
		}
	}
}
