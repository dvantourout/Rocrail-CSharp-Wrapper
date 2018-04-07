using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class swcmd : CRocrailElements
	{
		public const string CMD_TRACK = "track";
		private string m_cmd;
		
		private bool? m_lock;
		private bool? m_reduceV;
		private int? m_track;
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// Switch ID.
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// lock the switch for exclusive use
		/// </summary>
		public bool @lock 
		{
			get { return this.m_lock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lock, value, "@lock"); }
		}
		/// <summary>
		/// reduce speed by thrown status
		/// </summary>
		public bool reduceV 
		{
			get { return this.m_reduceV.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reduceV, value, "reduceV"); }
		}
		/// <summary>
		/// turntable track
		/// </summary>
		public int track 
		{
			get { return this.m_track.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_track, value, "track"); }
		}
		public swcmd()
		{
		}
		public static swcmd Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			swcmd _swcmd = new swcmd();
			_swcmd.m_rocrailClient = rocrailClient;
			_swcmd.m_cmd = (string)xml.Attribute("cmd");
			_swcmd.m_id = (string)xml.Attribute("id");
			_swcmd.m_lock = (bool?)xml.Attribute("lock");
			_swcmd.m_reduceV = (bool?)xml.Attribute("reduceV");
			_swcmd.m_track = (int?)xml.Attribute("track");
			return _swcmd;
		}
		public void Update(swcmd element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_id != null) this.id = element.id;
			if(element.m_lock.HasValue == true) this.@lock = element.@lock;
			if(element.m_reduceV.HasValue == true) this.reduceV = element.reduceV;
			if(element.m_track.HasValue == true) this.track = element.track;
		}
	}
}
