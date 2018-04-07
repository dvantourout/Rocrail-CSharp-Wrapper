using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class occ : CRocrailElements
	{
		private bool? m_auto;
		private string m_bkid;
		private int? m_blockenterside;
		private bool? m_closed;
		private string m_lcid;
		private int? m_placing;
		private string m_scid;
		private string m_secid;
		/// <summary>
		/// The occupying loco is in automode.
		/// </summary>
		public bool auto 
		{
			get { return this.m_auto.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_auto, value, "auto"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string bkid 
		{
			get { return this.m_bkid; }
			private set { this.SetField(ref this.m_bkid, value, "bkid"); }
		}
		/// <summary>
		/// Block enter side: 0 = Not set, 1 = True, 2 = False
		/// </summary>
		public int blockenterside 
		{
			get { return this.m_blockenterside.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockenterside, value, "blockenterside"); }
		}
		/// <summary>
		/// Signal this block as closed: Out of order.
		/// </summary>
		public bool closed 
		{
			get { return this.m_closed.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_closed, value, "closed"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string lcid 
		{
			get { return this.m_lcid; }
			private set { this.SetField(ref this.m_lcid, value, "lcid"); }
		}
		/// <summary>
		/// Loco placing: 0 = Not set, 1 = True, 2 = False
		/// </summary>
		public int placing 
		{
			get { return this.m_placing.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_placing, value, "placing"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string scid 
		{
			get { return this.m_scid; }
			private set { this.SetField(ref this.m_scid, value, "scid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string secid 
		{
			get { return this.m_secid; }
			private set { this.SetField(ref this.m_secid, value, "secid"); }
		}
		public occ()
		{
		}
		public static occ Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			occ _occ = new occ();
			_occ.m_rocrailClient = rocrailClient;
			_occ.m_auto = (bool?)xml.Attribute("auto");
			_occ.m_bkid = (string)xml.Attribute("bkid");
			_occ.m_blockenterside = (int?)xml.Attribute("blockenterside");
			_occ.m_closed = (bool?)xml.Attribute("closed");
			_occ.m_lcid = (string)xml.Attribute("lcid");
			_occ.m_placing = (int?)xml.Attribute("placing");
			_occ.m_scid = (string)xml.Attribute("scid");
			_occ.m_secid = (string)xml.Attribute("secid");
			return _occ;
		}
		public void Update(occ element)
		{
			if(element.m_auto.HasValue == true) this.auto = element.auto;
			if(element.m_bkid != null) this.bkid = element.bkid;
			if(element.m_blockenterside.HasValue == true) this.blockenterside = element.blockenterside;
			if(element.m_closed.HasValue == true) this.closed = element.closed;
			if(element.m_lcid != null) this.lcid = element.lcid;
			if(element.m_placing.HasValue == true) this.placing = element.placing;
			if(element.m_scid != null) this.scid = element.scid;
			if(element.m_secid != null) this.secid = element.secid;
		}
	}
}
