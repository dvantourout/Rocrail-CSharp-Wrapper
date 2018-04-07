using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class acc : CRocrailElements
	{
		private bool? m_accevent;
		private int? m_devid;
		private string m_iid;
		private int? m_nodenr;
		private int? m_val1;
		private int? m_val2;
		private int? m_val3;
		private int? m_val4;
		/// <summary>
		/// To check in the model if it was an accessory event.
		/// </summary>
		public bool accevent 
		{
			get { return this.m_accevent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_accevent, value, "accevent"); }
		}
		/// <summary>
		/// Device ID
		/// </summary>
		public int devid 
		{
			get { return this.m_devid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_devid, value, "devid"); }
		}
		/// <summary>
		/// Interface ID
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// Node number
		/// </summary>
		public int nodenr 
		{
			get { return this.m_nodenr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nodenr, value, "nodenr"); }
		}
		/// <summary>
		/// Value
		/// </summary>
		public int val1 
		{
			get { return this.m_val1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val1, value, "val1"); }
		}
		/// <summary>
		/// Value
		/// </summary>
		public int val2 
		{
			get { return this.m_val2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val2, value, "val2"); }
		}
		/// <summary>
		/// Value
		/// </summary>
		public int val3 
		{
			get { return this.m_val3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val3, value, "val3"); }
		}
		/// <summary>
		/// Value
		/// </summary>
		public int val4 
		{
			get { return this.m_val4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val4, value, "val4"); }
		}
		public acc()
		{
		}
		public static acc Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			acc _acc = new acc();
			_acc.m_rocrailClient = rocrailClient;
			_acc.m_accevent = (bool?)xml.Attribute("accevent");
			_acc.m_devid = (int?)xml.Attribute("devid");
			_acc.m_iid = (string)xml.Attribute("iid");
			_acc.m_nodenr = (int?)xml.Attribute("nodenr");
			_acc.m_val1 = (int?)xml.Attribute("val1");
			_acc.m_val2 = (int?)xml.Attribute("val2");
			_acc.m_val3 = (int?)xml.Attribute("val3");
			_acc.m_val4 = (int?)xml.Attribute("val4");
			return _acc;
		}
		public void Update(acc element)
		{
			if(element.m_accevent.HasValue == true) this.accevent = element.accevent;
			if(element.m_devid.HasValue == true) this.devid = element.devid;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_nodenr.HasValue == true) this.nodenr = element.nodenr;
			if(element.m_val1.HasValue == true) this.val1 = element.val1;
			if(element.m_val2.HasValue == true) this.val2 = element.val2;
			if(element.m_val3.HasValue == true) this.val3 = element.val3;
			if(element.m_val4.HasValue == true) this.val4 = element.val4;
		}
	}
}
