using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class modocc : CRocrailElements
	{
		private string m_title;
		private List<occ> m_occlist;
		/// <summary>
		/// Title of associated plan.
		/// </summary>
		public string title 
		{
			get { return this.m_title; }
			private set { this.SetField(ref this.m_title, value, "title"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<occ> occlist 
		{
			get { return this.m_occlist; }
			private set { this.SetField(ref this.m_occlist, value, "occlist"); }
		}
		public modocc()
		{
			this.m_occlist = new List<occ>();
		}
		public static modocc Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			modocc _modocc = new modocc();
			_modocc.m_rocrailClient = rocrailClient;
			_modocc.m_title = (string)xml.Attribute("title");
			Definitions.Tools.ParseList<occ>(_modocc.m_occlist, xml, "occ", occ.Parse, rocrailClient);
			return _modocc;
		}
		public void Update(modocc element)
		{
			if(element.m_title != null) this.title = element.title;
			this.occlist = element.occlist;
		}
	}
}
