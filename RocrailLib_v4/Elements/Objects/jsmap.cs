using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class jsmap : CRocrailElements
	{
		private int? m_f1;
		private int? m_f10;
		private int? m_f11;
		private int? m_f12;
		private int? m_f2;
		private int? m_f3;
		private int? m_f4;
		private int? m_f5;
		private int? m_f6;
		private int? m_f7;
		private int? m_f8;
		private int? m_f9;
		private int? m_leftright;
		private int? m_light;
		private int? m_poweroff;
		private int? m_poweron;
		private int? m_repeat;
		private int? m_reverse;
		private int? m_select;
		private int? m_step;
		private int? m_stop;
		private int? m_updown;
		/// <summary>
		/// 
		/// </summary>
		public int f1 
		{
			get { return this.m_f1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f1, value, "f1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f10 
		{
			get { return this.m_f10.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f10, value, "f10"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f11 
		{
			get { return this.m_f11.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f11, value, "f11"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f12 
		{
			get { return this.m_f12.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f12, value, "f12"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f2 
		{
			get { return this.m_f2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f2, value, "f2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f3 
		{
			get { return this.m_f3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f3, value, "f3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f4 
		{
			get { return this.m_f4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f4, value, "f4"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f5 
		{
			get { return this.m_f5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f5, value, "f5"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f6 
		{
			get { return this.m_f6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f6, value, "f6"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f7 
		{
			get { return this.m_f7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f7, value, "f7"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f8 
		{
			get { return this.m_f8.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f8, value, "f8"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int f9 
		{
			get { return this.m_f9.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f9, value, "f9"); }
		}
		/// <summary>
		/// X
		/// </summary>
		public int leftright 
		{
			get { return this.m_leftright.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_leftright, value, "leftright"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int light 
		{
			get { return this.m_light.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_light, value, "light"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int poweroff 
		{
			get { return this.m_poweroff.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroff, value, "poweroff"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int poweron 
		{
			get { return this.m_poweron.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweron, value, "poweron"); }
		}
		/// <summary>
		/// Repeat interval in ms for the updown axis. (value 0 disables the repeat)
		/// </summary>
		public int repeat 
		{
			get { return this.m_repeat.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_repeat, value, "repeat"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int reverse 
		{
			get { return this.m_reverse.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reverse, value, "reverse"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int @select 
		{
			get { return this.m_select.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_select, value, "@select"); }
		}
		/// <summary>
		/// speed step per click
		/// </summary>
		public int step 
		{
			get { return this.m_step.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_step, value, "step"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int stop 
		{
			get { return this.m_stop.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stop, value, "stop"); }
		}
		/// <summary>
		/// Y
		/// </summary>
		public int updown 
		{
			get { return this.m_updown.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_updown, value, "updown"); }
		}
		public jsmap()
		{
		}
		public static jsmap Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			jsmap _jsmap = new jsmap();
			_jsmap.m_rocrailClient = rocrailClient;
			_jsmap.m_f1 = (int?)xml.Attribute("f1");
			_jsmap.m_f10 = (int?)xml.Attribute("f10");
			_jsmap.m_f11 = (int?)xml.Attribute("f11");
			_jsmap.m_f12 = (int?)xml.Attribute("f12");
			_jsmap.m_f2 = (int?)xml.Attribute("f2");
			_jsmap.m_f3 = (int?)xml.Attribute("f3");
			_jsmap.m_f4 = (int?)xml.Attribute("f4");
			_jsmap.m_f5 = (int?)xml.Attribute("f5");
			_jsmap.m_f6 = (int?)xml.Attribute("f6");
			_jsmap.m_f7 = (int?)xml.Attribute("f7");
			_jsmap.m_f8 = (int?)xml.Attribute("f8");
			_jsmap.m_f9 = (int?)xml.Attribute("f9");
			_jsmap.m_leftright = (int?)xml.Attribute("leftright");
			_jsmap.m_light = (int?)xml.Attribute("light");
			_jsmap.m_poweroff = (int?)xml.Attribute("poweroff");
			_jsmap.m_poweron = (int?)xml.Attribute("poweron");
			_jsmap.m_repeat = (int?)xml.Attribute("repeat");
			_jsmap.m_reverse = (int?)xml.Attribute("reverse");
			_jsmap.m_select = (int?)xml.Attribute("select");
			_jsmap.m_step = (int?)xml.Attribute("step");
			_jsmap.m_stop = (int?)xml.Attribute("stop");
			_jsmap.m_updown = (int?)xml.Attribute("updown");
			return _jsmap;
		}
		public void Update(jsmap element)
		{
			if(element.m_f1.HasValue == true) this.f1 = element.f1;
			if(element.m_f10.HasValue == true) this.f10 = element.f10;
			if(element.m_f11.HasValue == true) this.f11 = element.f11;
			if(element.m_f12.HasValue == true) this.f12 = element.f12;
			if(element.m_f2.HasValue == true) this.f2 = element.f2;
			if(element.m_f3.HasValue == true) this.f3 = element.f3;
			if(element.m_f4.HasValue == true) this.f4 = element.f4;
			if(element.m_f5.HasValue == true) this.f5 = element.f5;
			if(element.m_f6.HasValue == true) this.f6 = element.f6;
			if(element.m_f7.HasValue == true) this.f7 = element.f7;
			if(element.m_f8.HasValue == true) this.f8 = element.f8;
			if(element.m_f9.HasValue == true) this.f9 = element.f9;
			if(element.m_leftright.HasValue == true) this.leftright = element.leftright;
			if(element.m_light.HasValue == true) this.light = element.light;
			if(element.m_poweroff.HasValue == true) this.poweroff = element.poweroff;
			if(element.m_poweron.HasValue == true) this.poweron = element.poweron;
			if(element.m_repeat.HasValue == true) this.repeat = element.repeat;
			if(element.m_reverse.HasValue == true) this.reverse = element.reverse;
			if(element.m_select.HasValue == true) this.@select = element.@select;
			if(element.m_step.HasValue == true) this.step = element.step;
			if(element.m_stop.HasValue == true) this.stop = element.stop;
			if(element.m_updown.HasValue == true) this.updown = element.updown;
		}
	}
}
