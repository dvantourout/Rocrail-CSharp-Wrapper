using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class dec : CRocrailElements
	{
		private int? m_addr;
		private int? m_bus;
		private string m_catnr;
		private string m_decfile;
		private string m_desc;
		private string m_docu;
		
		private string m_iid;
		private string m_image;
		private string m_manu;
		private string m_prev_id;
		private string m_prot;
		private int? m_protver;
		private List<cvbyte> m_cvbytelist;
		/// <summary>
		/// 
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int bus 
		{
			get { return this.m_bus.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_bus, value, "bus"); }
		}
		/// <summary>
		/// Catalog number.
		/// </summary>
		public string catnr 
		{
			get { return this.m_catnr; }
			private set { this.SetField(ref this.m_catnr, value, "catnr"); }
		}
		/// <summary>
		/// Decoder definition file.
		/// </summary>
		public string decfile 
		{
			get { return this.m_decfile; }
			private set { this.SetField(ref this.m_decfile, value, "decfile"); }
		}
		/// <summary>
		/// Description of loc.
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string docu 
		{
			get { return this.m_docu; }
			private set { this.SetField(ref this.m_docu, value, "docu"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Interface ID.
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// decoder image file
		/// </summary>
		public string image 
		{
			get { return this.m_image; }
			private set { this.SetField(ref this.m_image, value, "image"); }
		}
		/// <summary>
		/// Manufacturer.
		/// </summary>
		public string manu 
		{
			get { return this.m_manu; }
			private set { this.SetField(ref this.m_manu, value, "manu"); }
		}
		/// <summary>
		/// in case of an id change this should help to find the original in the loc table
		/// </summary>
		public string prev_id 
		{
			get { return this.m_prev_id; }
			private set { this.SetField(ref this.m_prev_id, value, "prev_id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string prot 
		{
			get { return this.m_prot; }
			private set { this.SetField(ref this.m_prot, value, "prot"); }
		}
		/// <summary>
		/// Protocol version
		/// </summary>
		public int protver 
		{
			get { return this.m_protver.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_protver, value, "protver"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cvbyte> cvbytelist 
		{
			get { return this.m_cvbytelist; }
			private set { this.SetField(ref this.m_cvbytelist, value, "cvbytelist"); }
		}
		public dec()
		{
			this.m_cvbytelist = new List<cvbyte>();
		}
		public static dec Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			dec _dec = new dec();
			_dec.m_rocrailClient = rocrailClient;
			_dec.m_addr = (int?)xml.Attribute("addr");
			_dec.m_bus = (int?)xml.Attribute("bus");
			_dec.m_catnr = (string)xml.Attribute("catnr");
			_dec.m_decfile = (string)xml.Attribute("decfile");
			_dec.m_desc = (string)xml.Attribute("desc");
			_dec.m_docu = (string)xml.Attribute("docu");
			_dec.m_id = (string)xml.Attribute("id");
			_dec.m_iid = (string)xml.Attribute("iid");
			_dec.m_image = (string)xml.Attribute("image");
			_dec.m_manu = (string)xml.Attribute("manu");
			_dec.m_prev_id = (string)xml.Attribute("prev_id");
			_dec.m_prot = (string)xml.Attribute("prot");
			_dec.m_protver = (int?)xml.Attribute("protver");
			Definitions.Tools.ParseList<cvbyte>(_dec.m_cvbytelist, xml, "cvbyte", cvbyte.Parse, rocrailClient);
			return _dec;
		}
		public void Update(dec element)
		{
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_bus.HasValue == true) this.bus = element.bus;
			if(element.m_catnr != null) this.catnr = element.catnr;
			if(element.m_decfile != null) this.decfile = element.decfile;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_docu != null) this.docu = element.docu;
			if(element.m_id != null) this.id = element.id;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_image != null) this.image = element.image;
			if(element.m_manu != null) this.manu = element.manu;
			if(element.m_prev_id != null) this.prev_id = element.prev_id;
			if(element.m_prot != null) this.prot = element.prot;
			if(element.m_protver.HasValue == true) this.protver = element.protver;
			this.cvbytelist = element.cvbytelist;
		}
	}
}
