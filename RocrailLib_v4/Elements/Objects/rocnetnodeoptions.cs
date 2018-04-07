using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class rocnetnodeoptions : CRocrailElements
	{
		public const int IOTYPE_I2C0 = 1;
		public const int IOTYPE_I2C1 = 0;
		private int? m_iotype;
		private bool? m_rfid;
		private bool? m_sack;
		private string m_soundpath;
		private string m_soundplayer;
		private bool? m_usepb;
		/// <summary>
		/// 
		/// </summary>
		public int iotype 
		{
			get { return this.m_iotype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_iotype, value, "iotype"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool rfid 
		{
			get { return this.m_rfid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rfid, value, "rfid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool sack 
		{
			get { return this.m_sack.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sack, value, "sack"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string soundpath 
		{
			get { return this.m_soundpath; }
			private set { this.SetField(ref this.m_soundpath, value, "soundpath"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string soundplayer 
		{
			get { return this.m_soundplayer; }
			private set { this.SetField(ref this.m_soundplayer, value, "soundplayer"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool usepb 
		{
			get { return this.m_usepb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usepb, value, "usepb"); }
		}
		public rocnetnodeoptions()
		{
		}
		public static rocnetnodeoptions Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			rocnetnodeoptions _rocnetnodeoptions = new rocnetnodeoptions();
			_rocnetnodeoptions.m_rocrailClient = rocrailClient;
			_rocnetnodeoptions.m_iotype = (int?)xml.Attribute("iotype");
			_rocnetnodeoptions.m_rfid = (bool?)xml.Attribute("rfid");
			_rocnetnodeoptions.m_sack = (bool?)xml.Attribute("sack");
			_rocnetnodeoptions.m_soundpath = (string)xml.Attribute("soundpath");
			_rocnetnodeoptions.m_soundplayer = (string)xml.Attribute("soundplayer");
			_rocnetnodeoptions.m_usepb = (bool?)xml.Attribute("usepb");
			return _rocnetnodeoptions;
		}
		public void Update(rocnetnodeoptions element)
		{
			if(element.m_iotype.HasValue == true) this.iotype = element.iotype;
			if(element.m_rfid.HasValue == true) this.rfid = element.rfid;
			if(element.m_sack.HasValue == true) this.sack = element.sack;
			if(element.m_soundpath != null) this.soundpath = element.soundpath;
			if(element.m_soundplayer != null) this.soundplayer = element.soundplayer;
			if(element.m_usepb.HasValue == true) this.usepb = element.usepb;
		}
	}
}
