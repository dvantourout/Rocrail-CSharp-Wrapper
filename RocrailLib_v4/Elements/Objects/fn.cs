using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fn : CRocrailElements
	{
		private int? m_addr;
		private int? m_bus;
		public const string EVENT = "none";
		private string m_eventblock;
		private bool? m_f0;
		private bool? m_f1;
		private bool? m_f10;
		private bool? m_f11;
		private bool? m_f12;
		private bool? m_f13;
		private bool? m_f14;
		private bool? m_f15;
		private bool? m_f16;
		private bool? m_f17;
		private bool? m_f18;
		private bool? m_f19;
		private bool? m_f2;
		private bool? m_f20;
		private bool? m_f21;
		private bool? m_f22;
		private bool? m_f23;
		private bool? m_f24;
		private bool? m_f25;
		private bool? m_f26;
		private bool? m_f27;
		private bool? m_f28;
		private bool? m_f3;
		private bool? m_f4;
		private bool? m_f5;
		private bool? m_f6;
		private bool? m_f7;
		private bool? m_f8;
		private bool? m_f9;
		private int? m_fnchanged;
		private int? m_fncnt;
		private int? m_group;
		
		private int? m_timedfn;
		private int? m_timer;
		private int? m_timerf0;
		private int? m_timerf1;
		private int? m_timerf10;
		private int? m_timerf11;
		private int? m_timerf12;
		private int? m_timerf13;
		private int? m_timerf14;
		private int? m_timerf15;
		private int? m_timerf16;
		private int? m_timerf17;
		private int? m_timerf18;
		private int? m_timerf19;
		private int? m_timerf2;
		private int? m_timerf20;
		private int? m_timerf21;
		private int? m_timerf22;
		private int? m_timerf23;
		private int? m_timerf24;
		private int? m_timerf25;
		private int? m_timerf26;
		private int? m_timerf27;
		private int? m_timerf28;
		private int? m_timerf3;
		private int? m_timerf4;
		private int? m_timerf5;
		private int? m_timerf6;
		private int? m_timerf7;
		private int? m_timerf8;
		private int? m_timerf9;
		/// <summary>
		/// 
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// Some systems support more than one bus: SLX
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// function deactivation block
		/// </summary>
		public string eventblock 
		{
			get { return this.m_eventblock; }
			private set { this.SetField(ref this.m_eventblock, value, "eventblock"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f0 
		{
			get { return this.m_f0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f0, value, "f0"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f1 
		{
			get { return this.m_f1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f1, value, "f1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f10 
		{
			get { return this.m_f10.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f10, value, "f10"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f11 
		{
			get { return this.m_f11.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f11, value, "f11"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f12 
		{
			get { return this.m_f12.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f12, value, "f12"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f13 
		{
			get { return this.m_f13.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f13, value, "f13"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f14 
		{
			get { return this.m_f14.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f14, value, "f14"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f15 
		{
			get { return this.m_f15.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f15, value, "f15"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f16 
		{
			get { return this.m_f16.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f16, value, "f16"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f17 
		{
			get { return this.m_f17.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f17, value, "f17"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f18 
		{
			get { return this.m_f18.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f18, value, "f18"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f19 
		{
			get { return this.m_f19.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f19, value, "f19"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f2 
		{
			get { return this.m_f2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f2, value, "f2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f20 
		{
			get { return this.m_f20.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f20, value, "f20"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f21 
		{
			get { return this.m_f21.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f21, value, "f21"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f22 
		{
			get { return this.m_f22.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f22, value, "f22"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f23 
		{
			get { return this.m_f23.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f23, value, "f23"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f24 
		{
			get { return this.m_f24.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f24, value, "f24"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f25 
		{
			get { return this.m_f25.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f25, value, "f25"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f26 
		{
			get { return this.m_f26.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f26, value, "f26"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f27 
		{
			get { return this.m_f27.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f27, value, "f27"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f28 
		{
			get { return this.m_f28.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f28, value, "f28"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f3 
		{
			get { return this.m_f3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f3, value, "f3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f4 
		{
			get { return this.m_f4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f4, value, "f4"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f5 
		{
			get { return this.m_f5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f5, value, "f5"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f6 
		{
			get { return this.m_f6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f6, value, "f6"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f7 
		{
			get { return this.m_f7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f7, value, "f7"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f8 
		{
			get { return this.m_f8.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f8, value, "f8"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool f9 
		{
			get { return this.m_f9.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_f9, value, "f9"); }
		}
		/// <summary>
		/// actual changed function
		/// </summary>
		public int fnchanged 
		{
			get { return this.m_fnchanged.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fnchanged, value, "fnchanged"); }
		}
		/// <summary>
		/// number of decoder funktions
		/// </summary>
		public int fncnt 
		{
			get { return this.m_fncnt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fncnt, value, "fncnt"); }
		}
		/// <summary>
		/// 0=all, 1=f1-f4, 2=f5-f8, 3=f9-f12, 4=f13-f16, 5=f17-f20, 6=f21-f24, 7=f25-f28
		/// </summary>
		public int @group 
		{
			get { return this.m_group.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_group, value, "@group"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timedfn 
		{
			get { return this.m_timedfn.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timedfn, value, "timedfn"); }
		}
		/// <summary>
		/// function activation timer
		/// </summary>
		public int timer 
		{
			get { return this.m_timer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timer, value, "timer"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf0 
		{
			get { return this.m_timerf0.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf0, value, "timerf0"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf1 
		{
			get { return this.m_timerf1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf1, value, "timerf1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf10 
		{
			get { return this.m_timerf10.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf10, value, "timerf10"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf11 
		{
			get { return this.m_timerf11.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf11, value, "timerf11"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf12 
		{
			get { return this.m_timerf12.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf12, value, "timerf12"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf13 
		{
			get { return this.m_timerf13.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf13, value, "timerf13"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf14 
		{
			get { return this.m_timerf14.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf14, value, "timerf14"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf15 
		{
			get { return this.m_timerf15.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf15, value, "timerf15"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf16 
		{
			get { return this.m_timerf16.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf16, value, "timerf16"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf17 
		{
			get { return this.m_timerf17.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf17, value, "timerf17"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf18 
		{
			get { return this.m_timerf18.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf18, value, "timerf18"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf19 
		{
			get { return this.m_timerf19.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf19, value, "timerf19"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf2 
		{
			get { return this.m_timerf2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf2, value, "timerf2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf20 
		{
			get { return this.m_timerf20.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf20, value, "timerf20"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf21 
		{
			get { return this.m_timerf21.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf21, value, "timerf21"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf22 
		{
			get { return this.m_timerf22.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf22, value, "timerf22"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf23 
		{
			get { return this.m_timerf23.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf23, value, "timerf23"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf24 
		{
			get { return this.m_timerf24.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf24, value, "timerf24"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf25 
		{
			get { return this.m_timerf25.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf25, value, "timerf25"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf26 
		{
			get { return this.m_timerf26.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf26, value, "timerf26"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf27 
		{
			get { return this.m_timerf27.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf27, value, "timerf27"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf28 
		{
			get { return this.m_timerf28.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf28, value, "timerf28"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf3 
		{
			get { return this.m_timerf3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf3, value, "timerf3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf4 
		{
			get { return this.m_timerf4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf4, value, "timerf4"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf5 
		{
			get { return this.m_timerf5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf5, value, "timerf5"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf6 
		{
			get { return this.m_timerf6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf6, value, "timerf6"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf7 
		{
			get { return this.m_timerf7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf7, value, "timerf7"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf8 
		{
			get { return this.m_timerf8.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf8, value, "timerf8"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int timerf9 
		{
			get { return this.m_timerf9.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timerf9, value, "timerf9"); }
		}
		public fn()
		{
		}
		public static fn Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fn _fn = new fn();
			_fn.m_rocrailClient = rocrailClient;
			_fn.m_addr = (int?)xml.Attribute("addr");
			_fn.m_bus = (int?)xml.Attribute("bus");
			_fn.m_eventblock = (string)xml.Attribute("eventblock");
			_fn.m_f0 = (bool?)xml.Attribute("f0");
			_fn.m_f1 = (bool?)xml.Attribute("f1");
			_fn.m_f10 = (bool?)xml.Attribute("f10");
			_fn.m_f11 = (bool?)xml.Attribute("f11");
			_fn.m_f12 = (bool?)xml.Attribute("f12");
			_fn.m_f13 = (bool?)xml.Attribute("f13");
			_fn.m_f14 = (bool?)xml.Attribute("f14");
			_fn.m_f15 = (bool?)xml.Attribute("f15");
			_fn.m_f16 = (bool?)xml.Attribute("f16");
			_fn.m_f17 = (bool?)xml.Attribute("f17");
			_fn.m_f18 = (bool?)xml.Attribute("f18");
			_fn.m_f19 = (bool?)xml.Attribute("f19");
			_fn.m_f2 = (bool?)xml.Attribute("f2");
			_fn.m_f20 = (bool?)xml.Attribute("f20");
			_fn.m_f21 = (bool?)xml.Attribute("f21");
			_fn.m_f22 = (bool?)xml.Attribute("f22");
			_fn.m_f23 = (bool?)xml.Attribute("f23");
			_fn.m_f24 = (bool?)xml.Attribute("f24");
			_fn.m_f25 = (bool?)xml.Attribute("f25");
			_fn.m_f26 = (bool?)xml.Attribute("f26");
			_fn.m_f27 = (bool?)xml.Attribute("f27");
			_fn.m_f28 = (bool?)xml.Attribute("f28");
			_fn.m_f3 = (bool?)xml.Attribute("f3");
			_fn.m_f4 = (bool?)xml.Attribute("f4");
			_fn.m_f5 = (bool?)xml.Attribute("f5");
			_fn.m_f6 = (bool?)xml.Attribute("f6");
			_fn.m_f7 = (bool?)xml.Attribute("f7");
			_fn.m_f8 = (bool?)xml.Attribute("f8");
			_fn.m_f9 = (bool?)xml.Attribute("f9");
			_fn.m_fnchanged = (int?)xml.Attribute("fnchanged");
			_fn.m_fncnt = (int?)xml.Attribute("fncnt");
			_fn.m_group = (int?)xml.Attribute("group");
			_fn.m_id = (string)xml.Attribute("id");
			_fn.m_timedfn = (int?)xml.Attribute("timedfn");
			_fn.m_timer = (int?)xml.Attribute("timer");
			_fn.m_timerf0 = (int?)xml.Attribute("timerf0");
			_fn.m_timerf1 = (int?)xml.Attribute("timerf1");
			_fn.m_timerf10 = (int?)xml.Attribute("timerf10");
			_fn.m_timerf11 = (int?)xml.Attribute("timerf11");
			_fn.m_timerf12 = (int?)xml.Attribute("timerf12");
			_fn.m_timerf13 = (int?)xml.Attribute("timerf13");
			_fn.m_timerf14 = (int?)xml.Attribute("timerf14");
			_fn.m_timerf15 = (int?)xml.Attribute("timerf15");
			_fn.m_timerf16 = (int?)xml.Attribute("timerf16");
			_fn.m_timerf17 = (int?)xml.Attribute("timerf17");
			_fn.m_timerf18 = (int?)xml.Attribute("timerf18");
			_fn.m_timerf19 = (int?)xml.Attribute("timerf19");
			_fn.m_timerf2 = (int?)xml.Attribute("timerf2");
			_fn.m_timerf20 = (int?)xml.Attribute("timerf20");
			_fn.m_timerf21 = (int?)xml.Attribute("timerf21");
			_fn.m_timerf22 = (int?)xml.Attribute("timerf22");
			_fn.m_timerf23 = (int?)xml.Attribute("timerf23");
			_fn.m_timerf24 = (int?)xml.Attribute("timerf24");
			_fn.m_timerf25 = (int?)xml.Attribute("timerf25");
			_fn.m_timerf26 = (int?)xml.Attribute("timerf26");
			_fn.m_timerf27 = (int?)xml.Attribute("timerf27");
			_fn.m_timerf28 = (int?)xml.Attribute("timerf28");
			_fn.m_timerf3 = (int?)xml.Attribute("timerf3");
			_fn.m_timerf4 = (int?)xml.Attribute("timerf4");
			_fn.m_timerf5 = (int?)xml.Attribute("timerf5");
			_fn.m_timerf6 = (int?)xml.Attribute("timerf6");
			_fn.m_timerf7 = (int?)xml.Attribute("timerf7");
			_fn.m_timerf8 = (int?)xml.Attribute("timerf8");
			_fn.m_timerf9 = (int?)xml.Attribute("timerf9");
			return _fn;
		}
		public void Update(fn element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_eventblock != null) this.eventblock = element.eventblock;
			if(element.m_f0.HasValue == true) this.f0 = element.f0;
			if(element.m_f1.HasValue == true) this.f1 = element.f1;
			if(element.m_f10.HasValue == true) this.f10 = element.f10;
			if(element.m_f11.HasValue == true) this.f11 = element.f11;
			if(element.m_f12.HasValue == true) this.f12 = element.f12;
			if(element.m_f13.HasValue == true) this.f13 = element.f13;
			if(element.m_f14.HasValue == true) this.f14 = element.f14;
			if(element.m_f15.HasValue == true) this.f15 = element.f15;
			if(element.m_f16.HasValue == true) this.f16 = element.f16;
			if(element.m_f17.HasValue == true) this.f17 = element.f17;
			if(element.m_f18.HasValue == true) this.f18 = element.f18;
			if(element.m_f19.HasValue == true) this.f19 = element.f19;
			if(element.m_f2.HasValue == true) this.f2 = element.f2;
			if(element.m_f20.HasValue == true) this.f20 = element.f20;
			if(element.m_f21.HasValue == true) this.f21 = element.f21;
			if(element.m_f22.HasValue == true) this.f22 = element.f22;
			if(element.m_f23.HasValue == true) this.f23 = element.f23;
			if(element.m_f24.HasValue == true) this.f24 = element.f24;
			if(element.m_f25.HasValue == true) this.f25 = element.f25;
			if(element.m_f26.HasValue == true) this.f26 = element.f26;
			if(element.m_f27.HasValue == true) this.f27 = element.f27;
			if(element.m_f28.HasValue == true) this.f28 = element.f28;
			if(element.m_f3.HasValue == true) this.f3 = element.f3;
			if(element.m_f4.HasValue == true) this.f4 = element.f4;
			if(element.m_f5.HasValue == true) this.f5 = element.f5;
			if(element.m_f6.HasValue == true) this.f6 = element.f6;
			if(element.m_f7.HasValue == true) this.f7 = element.f7;
			if(element.m_f8.HasValue == true) this.f8 = element.f8;
			if(element.m_f9.HasValue == true) this.f9 = element.f9;
			if(element.m_fnchanged.HasValue == true) this.fnchanged = element.fnchanged;
			if(element.m_fncnt.HasValue == true) this.fncnt = element.fncnt;
			if(element.m_group.HasValue == true) this.@group = element.@group;
			if(element.m_id != null) this.id = element.id;
			if(element.m_timedfn.HasValue == true) this.timedfn = element.timedfn;
			if(element.m_timer.HasValue == true) this.timer = element.timer;
			if(element.m_timerf0.HasValue == true) this.timerf0 = element.timerf0;
			if(element.m_timerf1.HasValue == true) this.timerf1 = element.timerf1;
			if(element.m_timerf10.HasValue == true) this.timerf10 = element.timerf10;
			if(element.m_timerf11.HasValue == true) this.timerf11 = element.timerf11;
			if(element.m_timerf12.HasValue == true) this.timerf12 = element.timerf12;
			if(element.m_timerf13.HasValue == true) this.timerf13 = element.timerf13;
			if(element.m_timerf14.HasValue == true) this.timerf14 = element.timerf14;
			if(element.m_timerf15.HasValue == true) this.timerf15 = element.timerf15;
			if(element.m_timerf16.HasValue == true) this.timerf16 = element.timerf16;
			if(element.m_timerf17.HasValue == true) this.timerf17 = element.timerf17;
			if(element.m_timerf18.HasValue == true) this.timerf18 = element.timerf18;
			if(element.m_timerf19.HasValue == true) this.timerf19 = element.timerf19;
			if(element.m_timerf2.HasValue == true) this.timerf2 = element.timerf2;
			if(element.m_timerf20.HasValue == true) this.timerf20 = element.timerf20;
			if(element.m_timerf21.HasValue == true) this.timerf21 = element.timerf21;
			if(element.m_timerf22.HasValue == true) this.timerf22 = element.timerf22;
			if(element.m_timerf23.HasValue == true) this.timerf23 = element.timerf23;
			if(element.m_timerf24.HasValue == true) this.timerf24 = element.timerf24;
			if(element.m_timerf25.HasValue == true) this.timerf25 = element.timerf25;
			if(element.m_timerf26.HasValue == true) this.timerf26 = element.timerf26;
			if(element.m_timerf27.HasValue == true) this.timerf27 = element.timerf27;
			if(element.m_timerf28.HasValue == true) this.timerf28 = element.timerf28;
			if(element.m_timerf3.HasValue == true) this.timerf3 = element.timerf3;
			if(element.m_timerf4.HasValue == true) this.timerf4 = element.timerf4;
			if(element.m_timerf5.HasValue == true) this.timerf5 = element.timerf5;
			if(element.m_timerf6.HasValue == true) this.timerf6 = element.timerf6;
			if(element.m_timerf7.HasValue == true) this.timerf7 = element.timerf7;
			if(element.m_timerf8.HasValue == true) this.timerf8 = element.timerf8;
			if(element.m_timerf9.HasValue == true) this.timerf9 = element.timerf9;
		}
	}
}
