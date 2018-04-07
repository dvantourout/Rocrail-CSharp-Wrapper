using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class cbnode : CRocrailElements
	{
		public const int MTYP_CANACC4 = 1;
		public const int MTYP_CANACC4_2 = 8;
		public const int MTYP_CANACC5 = 2;
		public const int MTYP_CANACC8 = 3;
		public const int MTYP_CANACE3 = 4;
		public const int MTYP_CANACE8C = 5;
		public const int MTYP_CANBC = 12;
		public const int MTYP_CANCAB = 9;
		public const int MTYP_CANCMD = 10;
		public const int MTYP_CANLED = 6;
		public const int MTYP_CANLED64 = 7;
		public const int MTYP_CANRPI = 13;
		public const int MTYP_CANSERVO = 11;
		public const int MTYP_CANTTCA = 14;
		public const int MTYP_CANTTCB = 15;
		private int? m_canid;
		private int? m_manuid;
		private int? m_mtyp;
		private int? m_nr;
		private int? m_nrevt;
		private int? m_nrevtvar;
		private int? m_nrvar;
		private string m_version;
		private List<cbnodeevent> m_cbnodeeventlist;
		private List<cbnodevar> m_cbnodevarlist;
		/// <summary>
		/// CANID
		/// </summary>
		public int canid 
		{
			get { return this.m_canid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_canid, value, "canid"); }
		}
		/// <summary>
		/// NMRA manufacturer ID.
		/// </summary>
		public int manuid 
		{
			get { return this.m_manuid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manuid, value, "manuid"); }
		}
		/// <summary>
		/// Module type. See cbusdefs.h.
		/// </summary>
		public int mtyp 
		{
			get { return this.m_mtyp.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mtyp, value, "mtyp"); }
		}
		/// <summary>
		/// NodeNumber
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// Number of events allowed.
		/// </summary>
		public int nrevt 
		{
			get { return this.m_nrevt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrevt, value, "nrevt"); }
		}
		/// <summary>
		/// Number of event variable per event.
		/// </summary>
		public int nrevtvar 
		{
			get { return this.m_nrevtvar.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrevtvar, value, "nrevtvar"); }
		}
		/// <summary>
		/// Number of node variables.
		/// </summary>
		public int nrvar 
		{
			get { return this.m_nrvar.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrvar, value, "nrvar"); }
		}
		/// <summary>
		/// Firmware version.
		/// </summary>
		public string version 
		{
			get { return this.m_version; }
			private set { this.SetField(ref this.m_version, value, "version"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cbnodeevent> cbnodeeventlist 
		{
			get { return this.m_cbnodeeventlist; }
			private set { this.SetField(ref this.m_cbnodeeventlist, value, "cbnodeeventlist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cbnodevar> cbnodevarlist 
		{
			get { return this.m_cbnodevarlist; }
			private set { this.SetField(ref this.m_cbnodevarlist, value, "cbnodevarlist"); }
		}
		public cbnode()
		{
			this.m_cbnodeeventlist = new List<cbnodeevent>();
			this.m_cbnodevarlist = new List<cbnodevar>();
		}
		public static cbnode Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			cbnode _cbnode = new cbnode();
			_cbnode.m_rocrailClient = rocrailClient;
			_cbnode.m_canid = (int?)xml.Attribute("canid");
			_cbnode.m_manuid = (int?)xml.Attribute("manuid");
			_cbnode.m_mtyp = (int?)xml.Attribute("mtyp");
			_cbnode.m_nr = (int?)xml.Attribute("nr");
			_cbnode.m_nrevt = (int?)xml.Attribute("nrevt");
			_cbnode.m_nrevtvar = (int?)xml.Attribute("nrevtvar");
			_cbnode.m_nrvar = (int?)xml.Attribute("nrvar");
			_cbnode.m_version = (string)xml.Attribute("version");
			Definitions.Tools.ParseList<cbnodeevent>(_cbnode.m_cbnodeeventlist, xml, "cbnodeevent", cbnodeevent.Parse, rocrailClient);
			Definitions.Tools.ParseList<cbnodevar>(_cbnode.m_cbnodevarlist, xml, "cbnodevar", cbnodevar.Parse, rocrailClient);
			return _cbnode;
		}
		public void Update(cbnode element)
		{
			if(element.m_canid.HasValue == true) this.canid = element.canid;
			if(element.m_manuid.HasValue == true) this.manuid = element.manuid;
			if(element.m_mtyp.HasValue == true) this.mtyp = element.mtyp;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_nrevt.HasValue == true) this.nrevt = element.nrevt;
			if(element.m_nrevtvar.HasValue == true) this.nrevtvar = element.nrevtvar;
			if(element.m_nrvar.HasValue == true) this.nrvar = element.nrvar;
			if(element.m_version != null) this.version = element.version;
			this.cbnodeeventlist = element.cbnodeeventlist;
			this.cbnodevarlist = element.cbnodevarlist;
		}
	}
}
