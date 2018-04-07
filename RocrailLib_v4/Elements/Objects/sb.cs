using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class sb : CRocrailElements
	{
		public const string CLOSED = "closed";
		public const string COMPRESS = "compress";
		public const string EXITCLOSED = "exitclosed";
		public const string EXITOPEN = "exitopen";
		public const string OPEN = "open";
		public const string STARTWD = "startwd";
		public const string STOPWD = "stopwd";
		private string m_cmd;
		private int? m_departdelay;
		private string m_desc;
		private bool? m_entering;
		private string m_entersignal;
		private string m_exitsignal;
		private string m_exitspeed;
		private int? m_exitspeedpercent;
		private string m_exitstate;
		private string m_fbenterid;
		private int? m_gap;
		
		private bool? m_inatlen;
		private string m_locid;
		private int? m_maxwaittime;
		private int? m_minwaittime;
		private bool? m_remote;
		private bool? m_reserved;
		public const string RRID = "";
		private string m_secid;
		private int? m_slen;
		private int? m_speedpercent;
		private string m_state;
		private string m_stopspeed;
		private bool? m_suitswell;
		private bool? m_usewd;
		private string m_waitmode;
		private int? m_waittime;
		private int? m_x;
		private int? m_y;
		private int? m_z;
		private List<actionctrl> m_actionctrllist;
		private List<section> m_sectionlist;
		/// <summary>
		/// 
		/// </summary>
		public string cmd 
		{
			get { return this.m_cmd; }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// delay time to wait before loco starts when depart is raised
		/// </summary>
		public int departdelay 
		{
			get { return this.m_departdelay.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_departdelay, value, "departdelay"); }
		}
		/// <summary>
		/// Description of stage block.
		/// </summary>
		public string desc 
		{
			get { return this.m_desc; }
			private set { this.SetField(ref this.m_desc, value, "desc"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool entering 
		{
			get { return this.m_entering.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_entering, value, "entering"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string entersignal 
		{
			get { return this.m_entersignal; }
			private set { this.SetField(ref this.m_entersignal, value, "entersignal"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string exitsignal 
		{
			get { return this.m_exitsignal; }
			private set { this.SetField(ref this.m_exitsignal, value, "exitsignal"); }
		}
		/// <summary>
		/// Block speed on departure.
		/// </summary>
		public string exitspeed 
		{
			get { return this.m_exitspeed; }
			private set { this.SetField(ref this.m_exitspeed, value, "exitspeed"); }
		}
		/// <summary>
		/// Block depart speed in percent.
		/// </summary>
		public int exitspeedpercent 
		{
			get { return this.m_exitspeedpercent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_exitspeedpercent, value, "exitspeedpercent"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string exitstate 
		{
			get { return this.m_exitstate; }
			private set { this.SetField(ref this.m_exitstate, value, "exitstate"); }
		}
		/// <summary>
		/// feedback ID
		/// </summary>
		public string fbenterid 
		{
			get { return this.m_fbenterid; }
			private set { this.SetField(ref this.m_fbenterid, value, "fbenterid"); }
		}
		/// <summary>
		/// Train gap.
		/// </summary>
		public int gap 
		{
			get { return this.m_gap.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_gap, value, "gap"); }
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
		/// In event if train length fits in the current sections.
		/// </summary>
		public bool inatlen 
		{
			get { return this.m_inatlen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_inatlen, value, "inatlen"); }
		}
		/// <summary>
		/// The loc which is actualy in the block or is comming or going.
		/// </summary>
		public string locid 
		{
			get { return this.m_locid; }
			private set { this.SetField(ref this.m_locid, value, "locid"); }
		}
		/// <summary>
		/// Max. wait time in case of wait_random.
		/// </summary>
		public int maxwaittime 
		{
			get { return this.m_maxwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxwaittime, value, "maxwaittime"); }
		}
		/// <summary>
		/// Min. wait time in case of wait_random.
		/// </summary>
		public int minwaittime 
		{
			get { return this.m_minwaittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minwaittime, value, "minwaittime"); }
		}
		/// <summary>
		/// This flag is set by the R2Rnet object.
		/// </summary>
		public bool remote 
		{
			get { return this.m_remote.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_remote, value, "remote"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool reserved 
		{
			get { return this.m_reserved.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_reserved, value, "reserved"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string secid 
		{
			get { return this.m_secid; }
			private set { this.SetField(ref this.m_secid, value, "secid"); }
		}
		/// <summary>
		/// Section length.
		/// </summary>
		public int slen 
		{
			get { return this.m_slen.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_slen, value, "slen"); }
		}
		/// <summary>
		/// Block arrive speed in percent.
		/// </summary>
		public int speedpercent 
		{
			get { return this.m_speedpercent.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_speedpercent, value, "speedpercent"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string state 
		{
			get { return this.m_state; }
			private set { this.SetField(ref this.m_state, value, "state"); }
		}
		/// <summary>
		/// Block speed on arrive and stop.
		/// </summary>
		public string stopspeed 
		{
			get { return this.m_stopspeed; }
			private set { this.SetField(ref this.m_stopspeed, value, "stopspeed"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool suitswell 
		{
			get { return this.m_suitswell.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_suitswell, value, "suitswell"); }
		}
		/// <summary>
		/// Use a watchdog for compressing when needed.
		/// </summary>
		public bool usewd 
		{
			get { return this.m_usewd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usewd, value, "usewd"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string waitmode 
		{
			get { return this.m_waitmode; }
			private set { this.SetField(ref this.m_waitmode, value, "waitmode"); }
		}
		/// <summary>
		/// Wait time in case of wait_fixed.
		/// </summary>
		public int waittime 
		{
			get { return this.m_waittime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_waittime, value, "waittime"); }
		}
		/// <summary>
		/// X-Position in the plan.
		/// </summary>
		public int x 
		{
			get { return this.m_x.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_x, value, "x"); }
		}
		/// <summary>
		/// Y-Position in the plan.
		/// </summary>
		public int y 
		{
			get { return this.m_y.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_y, value, "y"); }
		}
		/// <summary>
		/// Z-Position in the plan. (level)
		/// </summary>
		public int z 
		{
			get { return this.m_z.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_z, value, "z"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<actionctrl> actionctrllist 
		{
			get { return this.m_actionctrllist; }
			private set { this.SetField(ref this.m_actionctrllist, value, "actionctrllist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<section> sectionlist 
		{
			get { return this.m_sectionlist; }
			private set { this.SetField(ref this.m_sectionlist, value, "sectionlist"); }
		}
		public sb()
		{
			this.m_actionctrllist = new List<actionctrl>();
			this.m_sectionlist = new List<section>();
		}
		public static sb Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			sb _sb = new sb();
			_sb.m_rocrailClient = rocrailClient;
			_sb.m_cmd = (string)xml.Attribute("cmd");
			_sb.m_departdelay = (int?)xml.Attribute("departdelay");
			_sb.m_desc = (string)xml.Attribute("desc");
			_sb.m_entering = (bool?)xml.Attribute("entering");
			_sb.m_entersignal = (string)xml.Attribute("entersignal");
			_sb.m_exitsignal = (string)xml.Attribute("exitsignal");
			_sb.m_exitspeed = (string)xml.Attribute("exitspeed");
			_sb.m_exitspeedpercent = (int?)xml.Attribute("exitspeedpercent");
			_sb.m_exitstate = (string)xml.Attribute("exitstate");
			_sb.m_fbenterid = (string)xml.Attribute("fbenterid");
			_sb.m_gap = (int?)xml.Attribute("gap");
			_sb.m_id = (string)xml.Attribute("id");
			_sb.m_inatlen = (bool?)xml.Attribute("inatlen");
			_sb.m_locid = (string)xml.Attribute("locid");
			_sb.m_maxwaittime = (int?)xml.Attribute("maxwaittime");
			_sb.m_minwaittime = (int?)xml.Attribute("minwaittime");
			_sb.m_remote = (bool?)xml.Attribute("remote");
			_sb.m_reserved = (bool?)xml.Attribute("reserved");
			_sb.m_secid = (string)xml.Attribute("secid");
			_sb.m_slen = (int?)xml.Attribute("slen");
			_sb.m_speedpercent = (int?)xml.Attribute("speedpercent");
			_sb.m_state = (string)xml.Attribute("state");
			_sb.m_stopspeed = (string)xml.Attribute("stopspeed");
			_sb.m_suitswell = (bool?)xml.Attribute("suitswell");
			_sb.m_usewd = (bool?)xml.Attribute("usewd");
			_sb.m_waitmode = (string)xml.Attribute("waitmode");
			_sb.m_waittime = (int?)xml.Attribute("waittime");
			_sb.m_x = (int?)xml.Attribute("x");
			_sb.m_y = (int?)xml.Attribute("y");
			_sb.m_z = (int?)xml.Attribute("z");
			Definitions.Tools.ParseList<actionctrl>(_sb.m_actionctrllist, xml, "actionctrl", actionctrl.Parse, rocrailClient);
			Definitions.Tools.ParseList<section>(_sb.m_sectionlist, xml, "section", section.Parse, rocrailClient);
			return _sb;
		}
		public void Update(sb element)
		{
			if(element.m_cmd != null) this.cmd = element.cmd;
			if(element.m_departdelay.HasValue == true) this.departdelay = element.departdelay;
			if(element.m_desc != null) this.desc = element.desc;
			if(element.m_entering.HasValue == true) this.entering = element.entering;
			if(element.m_entersignal != null) this.entersignal = element.entersignal;
			if(element.m_exitsignal != null) this.exitsignal = element.exitsignal;
			if(element.m_exitspeed != null) this.exitspeed = element.exitspeed;
			if(element.m_exitspeedpercent.HasValue == true) this.exitspeedpercent = element.exitspeedpercent;
			if(element.m_exitstate != null) this.exitstate = element.exitstate;
			if(element.m_fbenterid != null) this.fbenterid = element.fbenterid;
			if(element.m_gap.HasValue == true) this.gap = element.gap;
			if(element.m_id != null) this.id = element.id;
			if(element.m_inatlen.HasValue == true) this.inatlen = element.inatlen;
			if(element.m_locid != null) this.locid = element.locid;
			if(element.m_maxwaittime.HasValue == true) this.maxwaittime = element.maxwaittime;
			if(element.m_minwaittime.HasValue == true) this.minwaittime = element.minwaittime;
			if(element.m_remote.HasValue == true) this.remote = element.remote;
			if(element.m_reserved.HasValue == true) this.reserved = element.reserved;
			if(element.m_secid != null) this.secid = element.secid;
			if(element.m_slen.HasValue == true) this.slen = element.slen;
			if(element.m_speedpercent.HasValue == true) this.speedpercent = element.speedpercent;
			if(element.m_state != null) this.state = element.state;
			if(element.m_stopspeed != null) this.stopspeed = element.stopspeed;
			if(element.m_suitswell.HasValue == true) this.suitswell = element.suitswell;
			if(element.m_usewd.HasValue == true) this.usewd = element.usewd;
			if(element.m_waitmode != null) this.waitmode = element.waitmode;
			if(element.m_waittime.HasValue == true) this.waittime = element.waittime;
			if(element.m_x.HasValue == true) this.x = element.x;
			if(element.m_y.HasValue == true) this.y = element.y;
			if(element.m_z.HasValue == true) this.z = element.z;
			this.actionctrllist = element.actionctrllist;
			this.sectionlist = element.sectionlist;
		}
	}
}
