using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class bbt : CRocrailElements
	{
		private string m_bk;
		private int? m_count;
		private bool? m_fixed;
		private string m_frombk;
		private int? m_interval;
		private int? m_steps;
		/// <summary>
		/// Block ID.
		/// </summary>
		public string bk 
		{
			get { return this.m_bk; }
			private set { this.SetField(ref this.m_bk, value, "bk"); }
		}
		/// <summary>
		/// Counter for dynamically adjust the correction factor.
		/// </summary>
		public int count 
		{
			get { return this.m_count.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_count, value, "count"); }
		}
		/// <summary>
		/// Fixed block brake timer.
		/// </summary>
		public bool @fixed 
		{
			get { return this.m_fixed.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fixed, value, "@fixed"); }
		}
		/// <summary>
		/// From block ID.
		/// </summary>
		public string frombk 
		{
			get { return this.m_frombk; }
			private set { this.SetField(ref this.m_frombk, value, "frombk"); }
		}
		/// <summary>
		/// Brake interval.
		/// </summary>
		public int interval 
		{
			get { return this.m_interval.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_interval, value, "interval"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int steps 
		{
			get { return this.m_steps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_steps, value, "steps"); }
		}
		public bbt()
		{
		}
		public static bbt Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			bbt _bbt = new bbt();
			_bbt.m_rocrailClient = rocrailClient;
			_bbt.m_bk = (string)xml.Attribute("bk");
			_bbt.m_count = (int?)xml.Attribute("count");
			_bbt.m_fixed = (bool?)xml.Attribute("fixed");
			_bbt.m_frombk = (string)xml.Attribute("frombk");
			_bbt.m_interval = (int?)xml.Attribute("interval");
			_bbt.m_steps = (int?)xml.Attribute("steps");
			return _bbt;
		}
		public void Update(bbt element)
		{
			if(element.m_bk != null) this.bk = element.bk;
			if(element.m_count.HasValue == true) this.count = element.count;
			if(element.m_fixed.HasValue == true) this.@fixed = element.@fixed;
			if(element.m_frombk != null) this.frombk = element.frombk;
			if(element.m_interval.HasValue == true) this.interval = element.interval;
			if(element.m_steps.HasValue == true) this.steps = element.steps;
		}
	}
}
