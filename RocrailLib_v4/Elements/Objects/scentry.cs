using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class scentry : CRocrailElements
	{
		private string m_block;
		private bool? m_free2go;
		private int? m_hour;
		private int? m_indelay;
		private string m_location;
		private int? m_minute;
		private bool? m_swap;
		private List<actionctrl> m_actionctrllist;
		/// <summary>
		/// Block from the blocklist
		/// </summary>
		public string block 
		{
			get { return this.m_block; }
			private set { this.SetField(ref this.m_block, value, "block"); }
		}
		/// <summary>
		/// Block or location must be free before the schedule can start.
		/// </summary>
		public bool free2go 
		{
			get { return this.m_free2go.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_free2go, value, "free2go"); }
		}
		/// <summary>
		/// Departure hour
		/// </summary>
		public int hour 
		{
			get { return this.m_hour.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_hour, value, "hour"); }
		}
		/// <summary>
		/// in event delay timer
		/// </summary>
		public int indelay 
		{
			get { return this.m_indelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_indelay, value, "indelay"); }
		}
		/// <summary>
		/// Location from the locationlist
		/// </summary>
		public string location 
		{
			get { return this.m_location; }
			private set { this.SetField(ref this.m_location, value, "location"); }
		}
		/// <summary>
		/// Departure minute
		/// </summary>
		public int minute 
		{
			get { return this.m_minute.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minute, value, "minute"); }
		}
		/// <summary>
		/// swap the loc placing before traveling to this destination
		/// </summary>
		public bool swap 
		{
			get { return this.m_swap.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swap, value, "swap"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		public scentry()
		{
			this.m_actionctrllist = new List<actionctrl>();
		}
		public static scentry Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			scentry _scentry = new scentry();
			_scentry.m_rocrailClient = rocrailClient;
			_scentry.m_block = (string)xml.Attribute("block");
			_scentry.m_free2go = (bool?)xml.Attribute("free2go");
			_scentry.m_hour = (int?)xml.Attribute("hour");
			_scentry.m_indelay = (int?)xml.Attribute("indelay");
			_scentry.m_location = (string)xml.Attribute("location");
			_scentry.m_minute = (int?)xml.Attribute("minute");
			_scentry.m_swap = (bool?)xml.Attribute("swap");
			Definitions.Tools.ParseList<actionctrl>(_scentry.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			return _scentry;
		}
		public void Update(scentry element)
		{
			if(element.m_block != null) this.block = element.block;
			if(element.m_free2go.HasValue == true) this.free2go = element.free2go;
			if(element.m_hour.HasValue == true) this.hour = element.hour;
			if(element.m_indelay.HasValue == true) this.indelay = element.indelay;
			if(element.m_location != null) this.location = element.location;
			if(element.m_minute.HasValue == true) this.minute = element.minute;
			if(element.m_swap.HasValue == true) this.swap = element.swap;
			this.actionctrllist = element.actionctrllist;
		}
	}
}
