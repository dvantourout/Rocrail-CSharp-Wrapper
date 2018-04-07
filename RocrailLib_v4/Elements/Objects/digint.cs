using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class digint : CRocrailElements
	{
		private List<bidib> m_bidiblist;
		private List<cbus> m_cbuslist;
		private List<dcc232> m_dcc232list;
		private List<ddx> m_ddxlist;
		private List<hsi88> m_hsi88list;
		private List<loconet> m_loconetlist;
		private List<mcs2> m_mcs2list;
		private List<opendcc> m_opendcclist;
		private List<rocnet> m_rocnetlist;
		private List<srcp> m_srcplist;
		/// <summary>
		/// 
		/// </summary>
		public List<bidib> bidiblist 
		{
			get { return this.m_bidiblist; }
			private set { this.SetField(ref this.m_bidiblist, value, "bidiblist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cbus> cbuslist 
		{
			get { return this.m_cbuslist; }
			private set { this.SetField(ref this.m_cbuslist, value, "cbuslist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<dcc232> dcc232list 
		{
			get { return this.m_dcc232list; }
			private set { this.SetField(ref this.m_dcc232list, value, "dcc232list"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<ddx> ddxlist 
		{
			get { return this.m_ddxlist; }
			private set { this.SetField(ref this.m_ddxlist, value, "ddxlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<hsi88> hsi88list 
		{
			get { return this.m_hsi88list; }
			private set { this.SetField(ref this.m_hsi88list, value, "hsi88list"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<loconet> loconetlist 
		{
			get { return this.m_loconetlist; }
			private set { this.SetField(ref this.m_loconetlist, value, "loconetlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<mcs2> mcs2list 
		{
			get { return this.m_mcs2list; }
			private set { this.SetField(ref this.m_mcs2list, value, "mcs2list"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<opendcc> opendcclist 
		{
			get { return this.m_opendcclist; }
			private set { this.SetField(ref this.m_opendcclist, value, "opendcclist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<rocnet> rocnetlist 
		{
			get { return this.m_rocnetlist; }
			private set { this.SetField(ref this.m_rocnetlist, value, "rocnetlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<srcp> srcplist 
		{
			get { return this.m_srcplist; }
			private set { this.SetField(ref this.m_srcplist, value, "srcplist"); }
		}
		public digint()
		{
			this.m_bidiblist = new List<bidib>();
			this.m_cbuslist = new List<cbus>();
			this.m_dcc232list = new List<dcc232>();
			this.m_ddxlist = new List<ddx>();
			this.m_hsi88list = new List<hsi88>();
			this.m_loconetlist = new List<loconet>();
			this.m_mcs2list = new List<mcs2>();
			this.m_opendcclist = new List<opendcc>();
			this.m_rocnetlist = new List<rocnet>();
			this.m_srcplist = new List<srcp>();
		}
		public static digint Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			digint _digint = new digint();
			_digint.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<bidib>(_digint.m_bidiblist, xml, "bidib", bidib.Parse, rocrailClient);
			Definitions.Tools.ParseList<cbus>(_digint.m_cbuslist, xml, "cbus", cbus.Parse, rocrailClient);
			Definitions.Tools.ParseList<dcc232>(_digint.m_dcc232list, xml, "dcc232", dcc232.Parse, rocrailClient);
			Definitions.Tools.ParseList<ddx>(_digint.m_ddxlist, xml, "ddx", ddx.Parse, rocrailClient);
			Definitions.Tools.ParseList<hsi88>(_digint.m_hsi88list, xml, "hsi88", hsi88.Parse, rocrailClient);
			Definitions.Tools.ParseList<loconet>(_digint.m_loconetlist, xml, "loconet", loconet.Parse, rocrailClient);
			Definitions.Tools.ParseList<mcs2>(_digint.m_mcs2list, xml, "mcs2", mcs2.Parse, rocrailClient);
			Definitions.Tools.ParseList<opendcc>(_digint.m_opendcclist, xml, "opendcc", opendcc.Parse, rocrailClient);
			Definitions.Tools.ParseList<rocnet>(_digint.m_rocnetlist, xml, "rocnet", rocnet.Parse, rocrailClient);
			Definitions.Tools.ParseList<srcp>(_digint.m_srcplist, xml, "srcp", srcp.Parse, rocrailClient);
			return _digint;
		}
		public void Update(digint element)
		{
			this.bidiblist = element.bidiblist;
			this.cbuslist = element.cbuslist;
			this.dcc232list = element.dcc232list;
			this.ddxlist = element.ddxlist;
			this.hsi88list = element.hsi88list;
			this.loconetlist = element.loconetlist;
			this.mcs2list = element.mcs2list;
			this.opendcclist = element.opendcclist;
			this.rocnetlist = element.rocnetlist;
			this.srcplist = element.srcplist;
		}
	}
}
