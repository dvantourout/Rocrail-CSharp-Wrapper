using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class cbus : CRocrailElements
	{
		private int? m_cid;
		private bool? m_commandack;
		private bool? m_fastclock;
		private int? m_fcaddr;
		private int? m_fcnode;
		private bool? m_fonfof;
		private int? m_loadertime;
		private int? m_purgetime;
		private bool? m_shortevents;
		private bool? m_slotserver;
		private int? m_sodaddr;
		private List<cbnode> m_cbnodelist;
		/// <summary>
		/// CANID
		/// </summary>
		public int cid 
		{
			get { return this.m_cid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cid, value, "cid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool commandack 
		{
			get { return this.m_commandack.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_commandack, value, "commandack"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool fastclock 
		{
			get { return this.m_fastclock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fastclock, value, "fastclock"); }
		}
		/// <summary>
		/// Fast clock event address.
		/// </summary>
		public int fcaddr 
		{
			get { return this.m_fcaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fcaddr, value, "fcaddr"); }
		}
		/// <summary>
		/// Fast clock node number.
		/// </summary>
		public int fcnode 
		{
			get { return this.m_fcnode.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fcnode, value, "fcnode"); }
		}
		/// <summary>
		/// Use the new opcodes for controlling functions.
		/// </summary>
		public bool fonfof 
		{
			get { return this.m_fonfof.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fonfof, value, "fonfof"); }
		}
		/// <summary>
		/// Sleep time between boot loader lines.
		/// </summary>
		public int loadertime 
		{
			get { return this.m_loadertime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_loadertime, value, "loadertime"); }
		}
		/// <summary>
		/// CS engine idle timeout.
		/// </summary>
		public int purgetime 
		{
			get { return this.m_purgetime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_purgetime, value, "purgetime"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool shortevents 
		{
			get { return this.m_shortevents.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_shortevents, value, "shortevents"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool slotserver 
		{
			get { return this.m_slotserver.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_slotserver, value, "slotserver"); }
		}
		/// <summary>
		/// Start of Day input address.
		/// </summary>
		public int sodaddr 
		{
			get { return this.m_sodaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sodaddr, value, "sodaddr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<cbnode> cbnodelist 
		{
			get { return this.m_cbnodelist; }
			private set { this.SetField(ref this.m_cbnodelist, value, "cbnodelist"); }
		}
		public cbus()
		{
			this.m_cbnodelist = new List<cbnode>();
		}
		public static cbus Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			cbus _cbus = new cbus();
			_cbus.m_rocrailClient = rocrailClient;
			_cbus.m_cid = (int?)xml.Attribute("cid");
			_cbus.m_commandack = (bool?)xml.Attribute("commandack");
			_cbus.m_fastclock = (bool?)xml.Attribute("fastclock");
			_cbus.m_fcaddr = (int?)xml.Attribute("fcaddr");
			_cbus.m_fcnode = (int?)xml.Attribute("fcnode");
			_cbus.m_fonfof = (bool?)xml.Attribute("fonfof");
			_cbus.m_loadertime = (int?)xml.Attribute("loadertime");
			_cbus.m_purgetime = (int?)xml.Attribute("purgetime");
			_cbus.m_shortevents = (bool?)xml.Attribute("shortevents");
			_cbus.m_slotserver = (bool?)xml.Attribute("slotserver");
			_cbus.m_sodaddr = (int?)xml.Attribute("sodaddr");
			Definitions.Tools.ParseList<cbnode>(_cbus.m_cbnodelist, xml, "cbnode", cbnode.Parse, rocrailClient);
			return _cbus;
		}
		public void Update(cbus element)
		{
			if(element.m_cid.HasValue == true) this.cid = element.cid;
			if(element.m_commandack.HasValue == true) this.commandack = element.commandack;
			if(element.m_fastclock.HasValue == true) this.fastclock = element.fastclock;
			if(element.m_fcaddr.HasValue == true) this.fcaddr = element.fcaddr;
			if(element.m_fcnode.HasValue == true) this.fcnode = element.fcnode;
			if(element.m_fonfof.HasValue == true) this.fonfof = element.fonfof;
			if(element.m_loadertime.HasValue == true) this.loadertime = element.loadertime;
			if(element.m_purgetime.HasValue == true) this.purgetime = element.purgetime;
			if(element.m_shortevents.HasValue == true) this.shortevents = element.shortevents;
			if(element.m_slotserver.HasValue == true) this.slotserver = element.slotserver;
			if(element.m_sodaddr.HasValue == true) this.sodaddr = element.sodaddr;
			this.cbnodelist = element.cbnodelist;
		}
	}
}
