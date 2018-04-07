using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class datareq : CRocrailElements
	{
		public const int GET = 0;
		public const int IMAGE = 0;
		public const int SMALLIMAGE = 1;
		private int? m_cmd;
		private string m_data;
		private string m_filename;
		private int? m_function;
		
		private int? m_type;
		/// <summary>
		/// 
		/// </summary>
		public int cmd 
		{
			get { return this.m_cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// one byte represented by 2 ascii chars; StrOp.byteToStr()
		/// </summary>
		public string data 
		{
			get { return this.m_data; }
			private set { this.SetField(ref this.m_data, value, "data"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string filename 
		{
			get { return this.m_filename; }
			private set { this.SetField(ref this.m_filename, value, "filename"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int function 
		{
			get { return this.m_function.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_function, value, "function"); }
		}
		/// <summary>
		/// reference ID
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int type 
		{
			get { return this.m_type.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		public datareq()
		{
		}
		public static datareq Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			datareq _datareq = new datareq();
			_datareq.m_rocrailClient = rocrailClient;
			_datareq.m_cmd = (int?)xml.Attribute("cmd");
			_datareq.m_data = (string)xml.Attribute("data");
			_datareq.m_filename = (string)xml.Attribute("filename");
			_datareq.m_function = (int?)xml.Attribute("function");
			_datareq.m_id = (string)xml.Attribute("id");
			_datareq.m_type = (int?)xml.Attribute("type");
			return _datareq;
		}
		public void Update(datareq element)
		{
			if(element.m_cmd.HasValue == true) this.cmd = element.cmd;
			if(element.m_data != null) this.data = element.data;
			if(element.m_filename != null) this.filename = element.filename;
			if(element.m_function.HasValue == true) this.function = element.function;
			if(element.m_id != null) this.id = element.id;
			if(element.m_type.HasValue == true) this.type = element.type;
		}
	}
}
