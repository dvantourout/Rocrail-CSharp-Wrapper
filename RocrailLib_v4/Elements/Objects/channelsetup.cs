using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class channelsetup : CRocrailElements
	{
		private int? m_channel;
		private int? m_delay;
		private int? m_offpos;
		private int? m_offsteps;
		private int? m_onpos;
		private int? m_onsteps;
		private int? m_options;
		private int? m_state;
		/// <summary>
		/// 
		/// </summary>
		public int channel 
		{
			get { return this.m_channel.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_channel, value, "channel"); }
		}
		/// <summary>
		/// 0=10ms, 1=20ms, ...
		/// </summary>
		public int delay 
		{
			get { return this.m_delay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_delay, value, "delay"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int offpos 
		{
			get { return this.m_offpos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_offpos, value, "offpos"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int offsteps 
		{
			get { return this.m_offsteps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_offsteps, value, "offsteps"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int onpos 
		{
			get { return this.m_onpos.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_onpos, value, "onpos"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int onsteps 
		{
			get { return this.m_onsteps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_onsteps, value, "onsteps"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int options 
		{
			get { return this.m_options.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_options, value, "options"); }
		}
		/// <summary>
		/// Saved output state.
		/// </summary>
		public int state 
		{
			get { return this.m_state.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		public channelsetup()
		{
		}
		public static channelsetup Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			channelsetup _channelsetup = new channelsetup();
			_channelsetup.m_rocrailClient = rocrailClient;
			_channelsetup.m_channel = (int?)xml.Attribute("channel");
			_channelsetup.m_delay = (int?)xml.Attribute("delay");
			_channelsetup.m_offpos = (int?)xml.Attribute("offpos");
			_channelsetup.m_offsteps = (int?)xml.Attribute("offsteps");
			_channelsetup.m_onpos = (int?)xml.Attribute("onpos");
			_channelsetup.m_onsteps = (int?)xml.Attribute("onsteps");
			_channelsetup.m_options = (int?)xml.Attribute("options");
			_channelsetup.m_state = (int?)xml.Attribute("state");
			return _channelsetup;
		}
		public void Update(channelsetup element)
		{
			if(element.m_channel.HasValue == true) this.channel = element.channel;
			if(element.m_delay.HasValue == true) this.delay = element.delay;
			if(element.m_offpos.HasValue == true) this.offpos = element.offpos;
			if(element.m_offsteps.HasValue == true) this.offsteps = element.offsteps;
			if(element.m_onpos.HasValue == true) this.onpos = element.onpos;
			if(element.m_onsteps.HasValue == true) this.onsteps = element.onsteps;
			if(element.m_options.HasValue == true) this.options = element.options;
			if(element.m_state.HasValue == true) this.state = element.state;
		}
	}
}
