using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class hsi88 : CRocrailElements
	{
		private int? m_fbleft;
		private int? m_fbmiddle;
		private int? m_fbright;
		private bool? m_smooth;
		private bool? m_usb;
		/// <summary>
		/// HSI-88 number of modules of 8 inputs on left port
		/// </summary>
		public int fbleft 
		{
			get { return this.m_fbleft.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbleft, value, "fbleft"); }
		}
		/// <summary>
		/// HSI-88 number of modules of 8 inputs on middle port
		/// </summary>
		public int fbmiddle 
		{
			get { return this.m_fbmiddle.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbmiddle, value, "fbmiddle"); }
		}
		/// <summary>
		/// HSI-88 number of modules of 8 inputs on right port
		/// </summary>
		public int fbright 
		{
			get { return this.m_fbright.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbright, value, "fbright"); }
		}
		/// <summary>
		/// HSI-88 smooth out fb contact noice; fb must be at least 100ms low before sending event.
		/// </summary>
		public bool smooth 
		{
			get { return this.m_smooth.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_smooth, value, "smooth"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool usb 
		{
			get { return this.m_usb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usb, value, "usb"); }
		}
		public hsi88()
		{
		}
		public static hsi88 Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			hsi88 _hsi88 = new hsi88();
			_hsi88.m_rocrailClient = rocrailClient;
			_hsi88.m_fbleft = (int?)xml.Attribute("fbleft");
			_hsi88.m_fbmiddle = (int?)xml.Attribute("fbmiddle");
			_hsi88.m_fbright = (int?)xml.Attribute("fbright");
			_hsi88.m_smooth = (bool?)xml.Attribute("smooth");
			_hsi88.m_usb = (bool?)xml.Attribute("usb");
			return _hsi88;
		}
		public void Update(hsi88 element)
		{
			if(element.m_fbleft.HasValue == true) this.fbleft = element.fbleft;
			if(element.m_fbmiddle.HasValue == true) this.fbmiddle = element.fbmiddle;
			if(element.m_fbright.HasValue == true) this.fbright = element.fbright;
			if(element.m_smooth.HasValue == true) this.smooth = element.smooth;
			if(element.m_usb.HasValue == true) this.usb = element.usb;
		}
	}
}
