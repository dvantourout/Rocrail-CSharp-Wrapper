using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class fbinfo : CRocrailElements
	{
		private List<fbmods> m_fbmodslist;
		/// <summary>
		/// 
		/// </summary>
		public List<fbmods> fbmodslist 
		{
			get { return this.m_fbmodslist; }
			private set { this.SetField(ref this.m_fbmodslist, value, "fbmodslist"); }
		}
		public fbinfo()
		{
			this.m_fbmodslist = new List<fbmods>();
		}
		public static fbinfo Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			fbinfo _fbinfo = new fbinfo();
			_fbinfo.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<fbmods>(_fbinfo.m_fbmodslist, xml, "fbmods", fbmods.Parse, rocrailClient);
			return _fbinfo;
		}
		public void Update(fbinfo element)
		{
			this.fbmodslist = element.fbmodslist;
		}
	}
}
