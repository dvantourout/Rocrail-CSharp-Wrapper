using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class ctrl : CRocrailElements
	{
		private bool? m_actiontimer60;
		private bool? m_allowzerothrottleid;
		private int? m_blockinitpause;
		private bool? m_closenoevents;
		private bool? m_closeonghost;
		private bool? m_createguestonbidi;
		private string m_defaspect;
		private bool? m_disablerouteVreduce;
		private bool? m_disablesteal;
		private bool? m_ebreakatghost;
		private bool? m_ebreakforceunlock;
		private bool? m_enableanalyzer;
		private bool? m_enableswfb;
		private int? m_eventtimeout;
		private bool? m_greenaspect;
		private int? m_ignevt;
		private int? m_initfieldpause;
		private bool? m_initfieldpower;
		private bool? m_keepghost;
		private bool? m_loccnfg;
		private int? m_locostartgap;
		private int? m_minbklc;
		private bool? m_poweroffatghost;
		private bool? m_poweroffatreset;
		private bool? m_poweroffonidentmismatch;
		private bool? m_releaseonidle;
		private bool? m_restoreschedule;
		private int? m_routeswtime;
		private int? m_savepostime;
		private bool? m_secondnextblock;
		private int? m_seed;
		private bool? m_selectshortestblock;
		private int? m_semaphorewait;
		private bool? m_sgevents;
		private int? m_signalreset;
		private int? m_signalwait;
		private bool? m_skipsetsg;
		private bool? m_skipsetsw;
		private bool? m_stopnonecommuter;
		private int? m_swtimeout;
		private bool? m_syncroutes;
		private int? m_syncroutetimeout;
		private bool? m_timedsensors;
		private bool? m_usebicom;
		private bool? m_usebididir;
		private bool? m_useident;
		/// <summary>
		/// 
		/// </summary>
		public bool actiontimer60 
		{
			get { return this.m_actiontimer60.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actiontimer60, value, "actiontimer60"); }
		}
		/// <summary>
		/// Allow broadcasting event coming from zero throttle IDs.
		/// </summary>
		public bool allowzerothrottleid 
		{
			get { return this.m_allowzerothrottleid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_allowzerothrottleid, value, "allowzerothrottleid"); }
		}
		/// <summary>
		/// Pause between the block init commands.
		/// </summary>
		public int blockinitpause 
		{
			get { return this.m_blockinitpause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockinitpause, value, "blockinitpause"); }
		}
		/// <summary>
		/// Close block if no event is defined.
		/// </summary>
		public bool closenoevents 
		{
			get { return this.m_closenoevents.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_closenoevents, value, "closenoevents"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool closeonghost 
		{
			get { return this.m_closeonghost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_closeonghost, value, "closeonghost"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool createguestonbidi 
		{
			get { return this.m_createguestonbidi.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_createguestonbidi, value, "createguestonbidi"); }
		}
		/// <summary>
		/// Default signal aspect.
		/// </summary>
		public string defaspect 
		{
			get { return this.m_defaspect; }
			private set { this.SetField(ref this.m_defaspect, value, "defaspect"); }
		}
		/// <summary>
		/// Global disable route speed reducing by thrown switches.
		/// </summary>
		public bool disablerouteVreduce 
		{
			get { return this.m_disablerouteVreduce.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_disablerouteVreduce, value, "disablerouteVreduce"); }
		}
		/// <summary>
		/// Disable throttle to steal loco control.
		/// </summary>
		public bool disablesteal 
		{
			get { return this.m_disablesteal.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_disablesteal, value, "disablesteal"); }
		}
		/// <summary>
		/// Power off a ghost is detected when no ghost is accepted.
		/// </summary>
		public bool ebreakatghost 
		{
			get { return this.m_ebreakatghost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ebreakatghost, value, "ebreakatghost"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ebreakforceunlock 
		{
			get { return this.m_ebreakforceunlock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ebreakforceunlock, value, "ebreakforceunlock"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool enableanalyzer 
		{
			get { return this.m_enableanalyzer.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_enableanalyzer, value, "enableanalyzer"); }
		}
		/// <summary>
		/// Enable switch position feedbacks.
		/// </summary>
		public bool enableswfb 
		{
			get { return this.m_enableswfb.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_enableswfb, value, "enableswfb"); }
		}
		/// <summary>
		/// Time to wait for a next event. Disabled when set to zero.
		/// </summary>
		public int eventtimeout 
		{
			get { return this.m_eventtimeout.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_eventtimeout, value, "eventtimeout"); }
		}
		/// <summary>
		/// Use green aspect instead of yellow if next block has red.
		/// </summary>
		public bool greenaspect 
		{
			get { return this.m_greenaspect.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_greenaspect, value, "greenaspect"); }
		}
		/// <summary>
		/// Ignore multiple events for the same state if comming within this number of 10ms ticks.
		/// </summary>
		public int ignevt 
		{
			get { return this.m_ignevt.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_ignevt, value, "ignevt"); }
		}
		/// <summary>
		/// Pause between the switch commands.
		/// </summary>
		public int initfieldpause 
		{
			get { return this.m_initfieldpause.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_initfieldpause, value, "initfieldpause"); }
		}
		/// <summary>
		/// Set global power on before init field.
		/// </summary>
		public bool initfieldpower 
		{
			get { return this.m_initfieldpower.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_initfieldpower, value, "initfieldpower"); }
		}
		/// <summary>
		/// Keep ghost state until manual reset.
		/// </summary>
		public bool keepghost 
		{
			get { return this.m_keepghost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_keepghost, value, "keepghost"); }
		}
		/// <summary>
		/// send loco config commands to the CS
		/// </summary>
		public bool loccnfg 
		{
			get { return this.m_loccnfg.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_loccnfg, value, "loccnfg"); }
		}
		/// <summary>
		/// Time between signalling loco's to start in auto mode.
		/// </summary>
		public int locostartgap 
		{
			get { return this.m_locostartgap.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_locostartgap, value, "locostartgap"); }
		}
		/// <summary>
		/// Minimal blocklen - loclen.
		/// </summary>
		public int minbklc 
		{
			get { return this.m_minbklc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minbklc, value, "minbklc"); }
		}
		/// <summary>
		/// Power off a ghost is detected when no ghost is accepted.
		/// </summary>
		public bool poweroffatghost 
		{
			get { return this.m_poweroffatghost.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroffatghost, value, "poweroffatghost"); }
		}
		/// <summary>
		/// Power off at reset command.
		/// </summary>
		public bool poweroffatreset 
		{
			get { return this.m_poweroffatreset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroffatreset, value, "poweroffatreset"); }
		}
		/// <summary>
		/// Power off if the ident code does not match.
		/// </summary>
		public bool poweroffonidentmismatch 
		{
			get { return this.m_poweroffonidentmismatch.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_poweroffonidentmismatch, value, "poweroffonidentmismatch"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool releaseonidle 
		{
			get { return this.m_releaseonidle.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_releaseonidle, value, "releaseonidle"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool restoreschedule 
		{
			get { return this.m_restoreschedule.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_restoreschedule, value, "restoreschedule"); }
		}
		/// <summary>
		/// Time between switch commands in routes.
		/// </summary>
		public int routeswtime 
		{
			get { return this.m_routeswtime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_routeswtime, value, "routeswtime"); }
		}
		/// <summary>
		/// save positio timer
		/// </summary>
		public int savepostime 
		{
			get { return this.m_savepostime.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_savepostime, value, "savepostime"); }
		}
		/// <summary>
		/// Try to reserve a second next block.
		/// </summary>
		public bool secondnextblock 
		{
			get { return this.m_secondnextblock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_secondnextblock, value, "secondnextblock"); }
		}
		/// <summary>
		/// random seed for block selection
		/// </summary>
		public int seed 
		{
			get { return this.m_seed.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_seed, value, "seed"); }
		}
		/// <summary>
		/// Select shortest block in case block and train length are set.
		/// </summary>
		public bool selectshortestblock 
		{
			get { return this.m_selectshortestblock.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_selectshortestblock, value, "selectshortestblock"); }
		}
		/// <summary>
		/// Time needed by a semaphore to get in position.
		/// </summary>
		public int semaphorewait 
		{
			get { return this.m_semaphorewait.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_semaphorewait, value, "semaphorewait"); }
		}
		/// <summary>
		/// Process field events for signals.
		/// </summary>
		public bool sgevents 
		{
			get { return this.m_sgevents.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_sgevents, value, "sgevents"); }
		}
		/// <summary>
		/// Time to wait for resetting the signals of previous block. Disabled when set to zero.
		/// </summary>
		public int signalreset 
		{
			get { return this.m_signalreset.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_signalreset, value, "signalreset"); }
		}
		/// <summary>
		/// Time needed by a signal to set another aspect.
		/// </summary>
		public int signalwait 
		{
			get { return this.m_signalwait.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_signalwait, value, "signalwait"); }
		}
		/// <summary>
		/// Skip signal commands for signals already in model position.
		/// </summary>
		public bool skipsetsg 
		{
			get { return this.m_skipsetsg.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_skipsetsg, value, "skipsetsg"); }
		}
		/// <summary>
		/// Skip switch commands in routes for switches already in model position.
		/// </summary>
		public bool skipsetsw 
		{
			get { return this.m_skipsetsw.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_skipsetsw, value, "skipsetsw"); }
		}
		/// <summary>
		/// Stop auto mode for none commuter trains in terminal stations.
		/// </summary>
		public bool stopnonecommuter 
		{
			get { return this.m_stopnonecommuter.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_stopnonecommuter, value, "stopnonecommuter"); }
		}
		/// <summary>
		/// Switch activation time.
		/// </summary>
		public int swtimeout 
		{
			get { return this.m_swtimeout.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_swtimeout, value, "swtimeout"); }
		}
		/// <summary>
		/// Synchronize routes.
		/// </summary>
		public bool syncroutes 
		{
			get { return this.m_syncroutes.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_syncroutes, value, "syncroutes"); }
		}
		/// <summary>
		/// Timeout in ms for synchronizing routes.
		/// </summary>
		public int syncroutetimeout 
		{
			get { return this.m_syncroutetimeout.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_syncroutetimeout, value, "syncroutetimeout"); }
		}
		/// <summary>
		/// Activate timed sensors.
		/// </summary>
		public bool timedsensors 
		{
			get { return this.m_timedsensors.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_timedsensors, value, "timedsensors"); }
		}
		/// <summary>
		/// Use bi-directional communication.
		/// </summary>
		public bool usebicom 
		{
			get { return this.m_usebicom.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usebicom, value, "usebicom"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool usebididir 
		{
			get { return this.m_usebididir.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_usebididir, value, "usebididir"); }
		}
		/// <summary>
		/// Use bi-directional identifier for set in block.
		/// </summary>
		public bool useident 
		{
			get { return this.m_useident.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_useident, value, "useident"); }
		}
		public ctrl()
		{
		}
		public static ctrl Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			ctrl _ctrl = new ctrl();
			_ctrl.m_rocrailClient = rocrailClient;
			_ctrl.m_actiontimer60 = (bool?)xml.Attribute("actiontimer60");
			_ctrl.m_allowzerothrottleid = (bool?)xml.Attribute("allowzerothrottleid");
			_ctrl.m_blockinitpause = (int?)xml.Attribute("blockinitpause");
			_ctrl.m_closenoevents = (bool?)xml.Attribute("closenoevents");
			_ctrl.m_closeonghost = (bool?)xml.Attribute("closeonghost");
			_ctrl.m_createguestonbidi = (bool?)xml.Attribute("createguestonbidi");
			_ctrl.m_defaspect = (string)xml.Attribute("defaspect");
			_ctrl.m_disablerouteVreduce = (bool?)xml.Attribute("disablerouteVreduce");
			_ctrl.m_disablesteal = (bool?)xml.Attribute("disablesteal");
			_ctrl.m_ebreakatghost = (bool?)xml.Attribute("ebreakatghost");
			_ctrl.m_ebreakforceunlock = (bool?)xml.Attribute("ebreakforceunlock");
			_ctrl.m_enableanalyzer = (bool?)xml.Attribute("enableanalyzer");
			_ctrl.m_enableswfb = (bool?)xml.Attribute("enableswfb");
			_ctrl.m_eventtimeout = (int?)xml.Attribute("eventtimeout");
			_ctrl.m_greenaspect = (bool?)xml.Attribute("greenaspect");
			_ctrl.m_ignevt = (int?)xml.Attribute("ignevt");
			_ctrl.m_initfieldpause = (int?)xml.Attribute("initfieldpause");
			_ctrl.m_initfieldpower = (bool?)xml.Attribute("initfieldpower");
			_ctrl.m_keepghost = (bool?)xml.Attribute("keepghost");
			_ctrl.m_loccnfg = (bool?)xml.Attribute("loccnfg");
			_ctrl.m_locostartgap = (int?)xml.Attribute("locostartgap");
			_ctrl.m_minbklc = (int?)xml.Attribute("minbklc");
			_ctrl.m_poweroffatghost = (bool?)xml.Attribute("poweroffatghost");
			_ctrl.m_poweroffatreset = (bool?)xml.Attribute("poweroffatreset");
			_ctrl.m_poweroffonidentmismatch = (bool?)xml.Attribute("poweroffonidentmismatch");
			_ctrl.m_releaseonidle = (bool?)xml.Attribute("releaseonidle");
			_ctrl.m_restoreschedule = (bool?)xml.Attribute("restoreschedule");
			_ctrl.m_routeswtime = (int?)xml.Attribute("routeswtime");
			_ctrl.m_savepostime = (int?)xml.Attribute("savepostime");
			_ctrl.m_secondnextblock = (bool?)xml.Attribute("secondnextblock");
			_ctrl.m_seed = (int?)xml.Attribute("seed");
			_ctrl.m_selectshortestblock = (bool?)xml.Attribute("selectshortestblock");
			_ctrl.m_semaphorewait = (int?)xml.Attribute("semaphorewait");
			_ctrl.m_sgevents = (bool?)xml.Attribute("sgevents");
			_ctrl.m_signalreset = (int?)xml.Attribute("signalreset");
			_ctrl.m_signalwait = (int?)xml.Attribute("signalwait");
			_ctrl.m_skipsetsg = (bool?)xml.Attribute("skipsetsg");
			_ctrl.m_skipsetsw = (bool?)xml.Attribute("skipsetsw");
			_ctrl.m_stopnonecommuter = (bool?)xml.Attribute("stopnonecommuter");
			_ctrl.m_swtimeout = (int?)xml.Attribute("swtimeout");
			_ctrl.m_syncroutes = (bool?)xml.Attribute("syncroutes");
			_ctrl.m_syncroutetimeout = (int?)xml.Attribute("syncroutetimeout");
			_ctrl.m_timedsensors = (bool?)xml.Attribute("timedsensors");
			_ctrl.m_usebicom = (bool?)xml.Attribute("usebicom");
			_ctrl.m_usebididir = (bool?)xml.Attribute("usebididir");
			_ctrl.m_useident = (bool?)xml.Attribute("useident");
			return _ctrl;
		}
		public void Update(ctrl element)
		{
			if(element.m_actiontimer60.HasValue == true) this.actiontimer60 = element.actiontimer60;
			if(element.m_allowzerothrottleid.HasValue == true) this.allowzerothrottleid = element.allowzerothrottleid;
			if(element.m_blockinitpause.HasValue == true) this.blockinitpause = element.blockinitpause;
			if(element.m_closenoevents.HasValue == true) this.closenoevents = element.closenoevents;
			if(element.m_closeonghost.HasValue == true) this.closeonghost = element.closeonghost;
			if(element.m_createguestonbidi.HasValue == true) this.createguestonbidi = element.createguestonbidi;
			if(element.m_defaspect != null) this.defaspect = element.defaspect;
			if(element.m_disablerouteVreduce.HasValue == true) this.disablerouteVreduce = element.disablerouteVreduce;
			if(element.m_disablesteal.HasValue == true) this.disablesteal = element.disablesteal;
			if(element.m_ebreakatghost.HasValue == true) this.ebreakatghost = element.ebreakatghost;
			if(element.m_ebreakforceunlock.HasValue == true) this.ebreakforceunlock = element.ebreakforceunlock;
			if(element.m_enableanalyzer.HasValue == true) this.enableanalyzer = element.enableanalyzer;
			if(element.m_enableswfb.HasValue == true) this.enableswfb = element.enableswfb;
			if(element.m_eventtimeout.HasValue == true) this.eventtimeout = element.eventtimeout;
			if(element.m_greenaspect.HasValue == true) this.greenaspect = element.greenaspect;
			if(element.m_ignevt.HasValue == true) this.ignevt = element.ignevt;
			if(element.m_initfieldpause.HasValue == true) this.initfieldpause = element.initfieldpause;
			if(element.m_initfieldpower.HasValue == true) this.initfieldpower = element.initfieldpower;
			if(element.m_keepghost.HasValue == true) this.keepghost = element.keepghost;
			if(element.m_loccnfg.HasValue == true) this.loccnfg = element.loccnfg;
			if(element.m_locostartgap.HasValue == true) this.locostartgap = element.locostartgap;
			if(element.m_minbklc.HasValue == true) this.minbklc = element.minbklc;
			if(element.m_poweroffatghost.HasValue == true) this.poweroffatghost = element.poweroffatghost;
			if(element.m_poweroffatreset.HasValue == true) this.poweroffatreset = element.poweroffatreset;
			if(element.m_poweroffonidentmismatch.HasValue == true) this.poweroffonidentmismatch = element.poweroffonidentmismatch;
			if(element.m_releaseonidle.HasValue == true) this.releaseonidle = element.releaseonidle;
			if(element.m_restoreschedule.HasValue == true) this.restoreschedule = element.restoreschedule;
			if(element.m_routeswtime.HasValue == true) this.routeswtime = element.routeswtime;
			if(element.m_savepostime.HasValue == true) this.savepostime = element.savepostime;
			if(element.m_secondnextblock.HasValue == true) this.secondnextblock = element.secondnextblock;
			if(element.m_seed.HasValue == true) this.seed = element.seed;
			if(element.m_selectshortestblock.HasValue == true) this.selectshortestblock = element.selectshortestblock;
			if(element.m_semaphorewait.HasValue == true) this.semaphorewait = element.semaphorewait;
			if(element.m_sgevents.HasValue == true) this.sgevents = element.sgevents;
			if(element.m_signalreset.HasValue == true) this.signalreset = element.signalreset;
			if(element.m_signalwait.HasValue == true) this.signalwait = element.signalwait;
			if(element.m_skipsetsg.HasValue == true) this.skipsetsg = element.skipsetsg;
			if(element.m_skipsetsw.HasValue == true) this.skipsetsw = element.skipsetsw;
			if(element.m_stopnonecommuter.HasValue == true) this.stopnonecommuter = element.stopnonecommuter;
			if(element.m_swtimeout.HasValue == true) this.swtimeout = element.swtimeout;
			if(element.m_syncroutes.HasValue == true) this.syncroutes = element.syncroutes;
			if(element.m_syncroutetimeout.HasValue == true) this.syncroutetimeout = element.syncroutetimeout;
			if(element.m_timedsensors.HasValue == true) this.timedsensors = element.timedsensors;
			if(element.m_usebicom.HasValue == true) this.usebicom = element.usebicom;
			if(element.m_usebididir.HasValue == true) this.usebididir = element.usebididir;
			if(element.m_useident.HasValue == true) this.useident = element.useident;
		}
	}
}
