using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class mcs2 : CRocrailElements
	{
		private bool? m_discovery;
		private int? m_fbdevid;
		private List<product> m_productlist;
		/// <summary>
		/// 
		/// </summary>
		public bool discovery 
		{
			get { return this.m_discovery.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_discovery, value, "discovery"); }
		}
		/// <summary>
		/// Sensor device ID
		/// </summary>
		public int fbdevid 
		{
			get { return this.m_fbdevid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fbdevid, value, "fbdevid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<product> productlist 
		{
			get { return this.m_productlist; }
			private set { this.SetField(ref this.m_productlist, value, "productlist"); }
		}
		public mcs2()
		{
			this.m_productlist = new List<product>();
		}
		public static mcs2 Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			mcs2 _mcs2 = new mcs2();
			_mcs2.m_rocrailClient = rocrailClient;
			_mcs2.m_discovery = (bool?)xml.Attribute("discovery");
			_mcs2.m_fbdevid = (int?)xml.Attribute("fbdevid");
			Definitions.Tools.ParseList<product>(_mcs2.m_productlist, xml, "product", product.Parse, rocrailClient);
			return _mcs2;
		}
		public void Update(mcs2 element)
		{
			if(element.m_discovery.HasValue == true) this.discovery = element.discovery;
			if(element.m_fbdevid.HasValue == true) this.fbdevid = element.fbdevid;
			this.productlist = element.productlist;
		}
	}
}
