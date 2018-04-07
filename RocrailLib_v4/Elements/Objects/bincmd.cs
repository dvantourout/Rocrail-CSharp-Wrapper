using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class bincmd : CRocrailElements
	{
		private string m_iid;
		private int? m_inendbyte;
		private int? m_inlen;
		private string m_out;
		private int? m_outlen;
		/// <summary>
		/// 
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// Read response until detecting this byte within the inlen.
		/// </summary>
		public int inendbyte 
		{
			get { return this.m_inendbyte.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inendbyte, value, "inendbyte"); }
		}
		/// <summary>
		/// expected response length in bytes
		/// </summary>
		public int inlen 
		{
			get { return this.m_inlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inlen, value, "inlen"); }
		}
		/// <summary>
		/// one byte represented by 2 ascii chars; StrOp.byteToStr()
		/// </summary>
		public string @out 
		{
			get { return this.m_out; }
			private set { this.SetField(ref this.m_out, value, "@out"); }
		}
		/// <summary>
		/// out length in bytes
		/// </summary>
		public int outlen 
		{
			get { return this.m_outlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_outlen, value, "outlen"); }
		}
		public bincmd()
		{
		}
		public static bincmd Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			bincmd _bincmd = new bincmd();
			_bincmd.m_rocrailClient = rocrailClient;
			_bincmd.m_iid = (string)xml.Attribute("iid");
			_bincmd.m_inendbyte = (int?)xml.Attribute("inendbyte");
			_bincmd.m_inlen = (int?)xml.Attribute("inlen");
			_bincmd.m_out = (string)xml.Attribute("out");
			_bincmd.m_outlen = (int?)xml.Attribute("outlen");
			return _bincmd;
		}
		public void Update(bincmd element)
		{
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_inendbyte.HasValue == true) this.inendbyte = element.inendbyte;
			if(element.m_inlen.HasValue == true) this.inlen = element.inlen;
			if(element.m_out != null) this.@out = element.@out;
			if(element.m_outlen.HasValue == true) this.outlen = element.outlen;
		}
	}
}
