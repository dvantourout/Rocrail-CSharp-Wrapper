using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class rocnetnode : CRocrailElements
	{
		private string m_class;
		private int? m_id;
		private int? m_location;
		private string m_mnemonic;
		private int? m_nrio;
		private int? m_revision;
		private int? m_subip;
		private int? m_vendor;
		private string m_version;
		/// <summary>
		/// Class ID.
		/// </summary>
		public string @class 
		{
			get { return this.m_class; }
			private set { this.SetField(ref this.m_class, value, "@class"); }
		}
		/// <summary>
		/// RocNet sender ID.
		/// </summary>
		public int id 
		{
			get { return this.m_id.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// RocNet sender ID.
		/// </summary>
		public int location 
		{
			get { return this.m_location.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_location, value, "location"); }
		}
		/// <summary>
		/// Class Mnemonic.
		/// </summary>
		public string mnemonic 
		{
			get { return this.m_mnemonic; }
			private set { this.SetField(ref this.m_mnemonic, value, "mnemonic"); }
		}
		/// <summary>
		/// Number of I/Os
		/// </summary>
		public int nrio 
		{
			get { return this.m_nrio.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nrio, value, "nrio"); }
		}
		/// <summary>
		/// Repository revision.
		/// </summary>
		public int revision 
		{
			get { return this.m_revision.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_revision, value, "revision"); }
		}
		/// <summary>
		/// Last 16 bits of the IP.
		/// </summary>
		public int subip 
		{
			get { return this.m_subip.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_subip, value, "subip"); }
		}
		/// <summary>
		/// NMRA vendor ID.
		/// </summary>
		public int vendor 
		{
			get { return this.m_vendor.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_vendor, value, "vendor"); }
		}
		/// <summary>
		/// Software version.
		/// </summary>
		public string version 
		{
			get { return this.m_version; }
			private set { this.SetField(ref this.m_version, value, "version"); }
		}
		public rocnetnode()
		{
		}
		public static rocnetnode Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			rocnetnode _rocnetnode = new rocnetnode();
			_rocnetnode.m_rocrailClient = rocrailClient;
			_rocnetnode.m_class = (string)xml.Attribute("class");
			_rocnetnode.m_id = (int?)xml.Attribute("id");
			_rocnetnode.m_location = (int?)xml.Attribute("location");
			_rocnetnode.m_mnemonic = (string)xml.Attribute("mnemonic");
			_rocnetnode.m_nrio = (int?)xml.Attribute("nrio");
			_rocnetnode.m_revision = (int?)xml.Attribute("revision");
			_rocnetnode.m_subip = (int?)xml.Attribute("subip");
			_rocnetnode.m_vendor = (int?)xml.Attribute("vendor");
			_rocnetnode.m_version = (string)xml.Attribute("version");
			return _rocnetnode;
		}
		public void Update(rocnetnode element)
		{
			if(element.m_class != null) this.@class = element.@class;
			if(element.m_id.HasValue == true) this.id = element.id;
			if(element.m_location.HasValue == true) this.location = element.location;
			if(element.m_mnemonic != null) this.mnemonic = element.mnemonic;
			if(element.m_nrio.HasValue == true) this.nrio = element.nrio;
			if(element.m_revision.HasValue == true) this.revision = element.revision;
			if(element.m_subip.HasValue == true) this.subip = element.subip;
			if(element.m_vendor.HasValue == true) this.vendor = element.vendor;
			if(element.m_version != null) this.version = element.version;
		}
	}
}
