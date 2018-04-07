using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class tk : CRocrailElements
	{
		public const string BUFFER = "buffer";
		public const string CONCURVELEFT = "concurveleft";
		public const string CONCURVERIGHT = "concurveright";
		public const string CONNECTOR = "connector";
		public const string CURVE = "curve";
		public const string CURVE90 = "curve90";
		public const string DCURVE = "dcurve";
		public const string DIR = "dir";
		public const string DIRALL = "dirall";
		public const string STRAIGHT = "straight";
		public const string TRACKNR = "tracknr";
		private string m_blockid;
		private string m_counterpartid;
		private string m_desc;
		
		private string m_ori;
		private int? m_tknr;
		private string m_type;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		/// <summary>
		/// 
		/// </summary>
		public string blockid 
		{
			get { return this.m_blockid; }
			private set { this.SetField(ref this.m_blockid, value, "blockid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string counterpartid 
		{
			get { return this.m_counterpartid; }
			private set { this.SetField(ref this.m_counterpartid, value, "counterpartid"); }
		}
		/// <summary>
		/// description
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
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
		/// 
		/// </summary>
		public string ori 
		{
			get { return this.m_ori; }
			private set { this.SetField(ref this.m_ori, value, "ori"); }
		}
		/// <summary>
		/// Track number.
		/// </summary>
		public int tknr 
		{
			get { return this.m_tknr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_tknr, value, "tknr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string type 
		{
			get { return this.m_type; }
			private set { this.SetField(ref this.m_type, value, "type"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int x 
		{
			get { return this.m_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_x, value, "x"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int y 
		{
			get { return this.m_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_y, value, "y"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int z 
		{
			get { return this.m_z.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_z, value, "z"); }
		}
		public tk()
		{
		}
		public static tk Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			tk _tk = new tk();
			_tk.m_rocrailClient = rocrailClient;
			_tk.m_blockid = (string)xml.Attribute("blockid");
			_tk.m_counterpartid = (string)xml.Attribute("counterpartid");
			_tk.m_desc = (string)xml.Attribute("desc");
			_tk.m_id = (string)xml.Attribute("id");
			_tk.m_ori = (string)xml.Attribute("ori");
			_tk.m_tknr = (int?)xml.Attribute("tknr");
			_tk.m_type = (string)xml.Attribute("type");
			_tk.m_x = (int?)xml.Attribute("x");
			_tk.m_y = (int?)xml.Attribute("y");
			_tk.m_z = (int?)xml.Attribute("z");
			return _tk;
		}
		public void Update(tk element)
		{
			if(element.m_blockid != null) this.blockid = element.blockid;
			if(element.m_counterpartid != null) this.counterpartid = element.counterpartid;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_id != null) this.id = element.id;
			if(element.m_ori != null) this.ori = element.ori;
			if(element.m_tknr.HasValue == true) this.tknr = element.tknr;
			if(element.m_type != null) this.type = element.type;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
		}
	}
}
