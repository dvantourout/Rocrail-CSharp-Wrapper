using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fundef : CRocrailElements
	{
		public const string ENTER_BLOCK = "enter_block";
		public const string EXIT_BLOCK = "exit_block";
		public const string IN_BLOCK = "in_block";
		public const string RUN = "run";
		public const string STALL = "stall";
		private int? m_addr;
		private int? m_fn;
		private string m_icon;
		private int? m_mappedfn;
		private string m_offblockid;
		private string m_offevent;
		private bool? m_on;
		private string m_onblockid;
		private string m_onevent;
		private string m_sound;
		private string m_text;
		private int? m_timer;
		/// <summary>
		/// Function decoder address.
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// function number
		/// </summary>
		public int fn 
		{
			get { return this.m_fn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fn, value, "fn"); }
		}
		/// <summary>
		/// icon file
		/// </summary>
		public string icon 
		{
			get { return this.m_icon; }
			private set { this.SetField(ref this.m_icon, value, "icon"); }
		}
		/// <summary>
		/// Mapped function number in case of other address then main decodcer.
		/// </summary>
		public int mappedfn 
		{
			get { return this.m_mappedfn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mappedfn, value, "mappedfn"); }
		}
		/// <summary>
		/// BlockID.
		/// </summary>
		public string offblockid 
		{
			get { return this.m_offblockid; }
			private set { this.SetField(ref this.m_offblockid, value, "offblockid"); }
		}
		/// <summary>
		/// Deactivation event.
		/// </summary>
		public string offevent 
		{
			get { return this.m_offevent; }
			private set { this.SetField(ref this.m_offevent, value, "offevent"); }
		}
		/// <summary>
		/// activation
		/// </summary>
		public bool on 
		{
			get { return this.m_on.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_on, value, "on"); }
		}
		/// <summary>
		/// BlockID.
		/// </summary>
		public string onblockid 
		{
			get { return this.m_onblockid; }
			private set { this.SetField(ref this.m_onblockid, value, "onblockid"); }
		}
		/// <summary>
		/// Activation event.
		/// </summary>
		public string onevent 
		{
			get { return this.m_onevent; }
			private set { this.SetField(ref this.m_onevent, value, "onevent"); }
		}
		/// <summary>
		/// sound file
		/// </summary>
		public string sound 
		{
			get { return this.m_sound; }
			private set { this.SetField(ref this.m_sound, value, "sound"); }
		}
		/// <summary>
		/// function label
		/// </summary>
		public string text 
		{
			get { return this.m_text; }
			private set { this.SetField(ref this.m_text, value, "text"); }
		}
		/// <summary>
		/// function timer
		/// </summary>
		public int timer 
		{
			get { return this.m_timer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timer, value, "timer"); }
		}
		public fundef()
		{
		}
		public static fundef Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fundef _fundef = new fundef();
			_fundef.m_rocrailClient = rocrailClient;
			_fundef.m_addr = (int?)xml.Attribute("addr");
			_fundef.m_fn = (int?)xml.Attribute("fn");
			_fundef.m_icon = (string)xml.Attribute("icon");
			_fundef.m_mappedfn = (int?)xml.Attribute("mappedfn");
			_fundef.m_offblockid = (string)xml.Attribute("offblockid");
			_fundef.m_offevent = (string)xml.Attribute("offevent");
			_fundef.m_on = (bool?)xml.Attribute("on");
			_fundef.m_onblockid = (string)xml.Attribute("onblockid");
			_fundef.m_onevent = (string)xml.Attribute("onevent");
			_fundef.m_sound = (string)xml.Attribute("sound");
			_fundef.m_text = (string)xml.Attribute("text");
			_fundef.m_timer = (int?)xml.Attribute("timer");
			return _fundef;
		}
		public void Update(fundef element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_fn.HasValue == true) this.fn = element.fn;
			if(element.m_icon != null) this.icon = element.icon;
			if(element.m_mappedfn.HasValue == true) this.mappedfn = element.mappedfn;
			if(element.m_offblockid != null) this.offblockid = element.offblockid;
			if(element.m_offevent != null) this.offevent = element.offevent;
			if(element.m_on.HasValue == true) this.on = element.on;
			if(element.m_onblockid != null) this.onblockid = element.onblockid;
			if(element.m_onevent != null) this.onevent = element.onevent;
			if(element.m_sound != null) this.sound = element.sound;
			if(element.m_text != null) this.text = element.text;
			if(element.m_timer.HasValue == true) this.timer = element.timer;
		}
	}
}
