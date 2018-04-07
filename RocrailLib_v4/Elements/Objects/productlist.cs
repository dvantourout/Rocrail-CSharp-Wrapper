using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class productlist : CRocrailElements
	{
		private List<product> m_productlist;
		/// <summary>
		/// 
		/// </summary>
		public List<product> productlistP 
		{
			get { return this.m_productlist; }
			private set { this.SetField(ref this.m_productlist, value, "productlistP"); }
		}
		public productlist()
		{
			this.m_productlist = new List<product>();
		}
		public static productlist Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			productlist _productlist = new productlist();
			_productlist.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<product>(_productlist.m_productlist, xml, "product", product.Parse, rocrailClient);
			return _productlist;
		}
		public void Update(productlist element)
		{
			this.productlistP = element.productlistP;
		}
	}
}
