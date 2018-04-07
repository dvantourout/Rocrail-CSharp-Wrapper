using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class trace : CRocrailElements
	{
		private bool? m_automatic;
		private bool? m_byte;
		private bool? m_calc;
		private bool? m_debug;
		private int? m_dumpsize;
		private bool? m_exceptionfile;
		private string m_gfile;
		private bool? m_info;
		private string m_invoke;
		private bool? m_invokeasync;
		private bool? m_listen2all;
		private bool? m_meminfo;
		private bool? m_monitor;
		private int? m_nr;
		private bool? m_parse;
		private string m_protpath;
		private string m_rfile;
		private int? m_size;
		private bool? m_unique;
		/// <summary>
		/// Trace level for extra info in automatic mode.
		/// </summary>
		public bool automatic 
		{
			get { return this.m_automatic.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_automatic, value, "automatic"); }
		}
		/// <summary>
		/// Activates dump tracelevel.
		/// </summary>
		public bool @byte 
		{
			get { return this.m_byte.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_byte, value, "@byte"); }
		}
		/// <summary>
		/// Activates calculation trace level.
		/// </summary>
		public bool calc 
		{
			get { return this.m_calc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_calc, value, "calc"); }
		}
		/// <summary>
		/// Trace level debug.
		/// </summary>
		public bool debug 
		{
			get { return this.m_debug.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_debug, value, "debug"); }
		}
		/// <summary>
		/// Max. byte dump size.
		/// </summary>
		public int dumpsize 
		{
			get { return this.m_dumpsize.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_dumpsize, value, "dumpsize"); }
		}
		/// <summary>
		/// Create extra file for exceptions.
		/// </summary>
		public bool exceptionfile 
		{
			get { return this.m_exceptionfile.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_exceptionfile, value, "exceptionfile"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string gfile 
		{
			get { return this.m_gfile; }
			private set { this.SetField(ref this.m_gfile, value, "gfile"); }
		}
		/// <summary>
		/// Activates info trace level.
		/// </summary>
		public bool info 
		{
			get { return this.m_info.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_info, value, "info"); }
		}
		/// <summary>
		/// External program or script to invoke on exception file creation.
		/// </summary>
		public string invoke 
		{
			get { return this.m_invoke; }
			private set { this.SetField(ref this.m_invoke, value, "invoke"); }
		}
		/// <summary>
		/// The invokation will take place in a separate thread.
		/// </summary>
		public bool invokeasync 
		{
			get { return this.m_invokeasync.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_invokeasync, value, "invokeasync"); }
		}
		/// <summary>
		/// The trace listener will get all traces.
		/// </summary>
		public bool listen2all 
		{
			get { return this.m_listen2all.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_listen2all, value, "listen2all"); }
		}
		/// <summary>
		/// Activates memory info trace level.
		/// </summary>
		public bool meminfo 
		{
			get { return this.m_meminfo.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_meminfo, value, "meminfo"); }
		}
		/// <summary>
		/// Activates monitor tracelevel.
		/// </summary>
		public bool monitor 
		{
			get { return this.m_monitor.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_monitor, value, "monitor"); }
		}
		/// <summary>
		/// Number of continuous trace files. In case of 0 or 1: All traces are written in one file disregarding filesize.
		/// </summary>
		public int nr 
		{
			get { return this.m_nr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_nr, value, "nr"); }
		}
		/// <summary>
		/// Activates parse tracelevel.
		/// </summary>
		public bool parse 
		{
			get { return this.m_parse.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_parse, value, "parse"); }
		}
		/// <summary>
		/// Protocol path; Where to write the trace files. (Use relative only if using http service.) Path is relative to pwd!
		/// </summary>
		public string protpath 
		{
			get { return this.m_protpath; }
			private set { this.SetField(ref this.m_protpath, value, "protpath"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string rfile 
		{
			get { return this.m_rfile; }
			private set { this.SetField(ref this.m_rfile, value, "rfile"); }
		}
		/// <summary>
		/// Filesize of trace files.
		/// </summary>
		public int size 
		{
			get { return this.m_size.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_size, value, "size"); }
		}
		/// <summary>
		/// Create a unique trace filename at startup.
		/// </summary>
		public bool unique 
		{
			get { return this.m_unique.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_unique, value, "unique"); }
		}
		public trace()
		{
		}
		public static trace Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			trace _trace = new trace();
			_trace.m_rocrailClient = rocrailClient;
			_trace.m_automatic = (bool?)xml.Attribute("automatic");
			_trace.m_byte = (bool?)xml.Attribute("byte");
			_trace.m_calc = (bool?)xml.Attribute("calc");
			_trace.m_debug = (bool?)xml.Attribute("debug");
			_trace.m_dumpsize = (int?)xml.Attribute("dumpsize");
			_trace.m_exceptionfile = (bool?)xml.Attribute("exceptionfile");
			_trace.m_gfile = (string)xml.Attribute("gfile");
			_trace.m_info = (bool?)xml.Attribute("info");
			_trace.m_invoke = (string)xml.Attribute("invoke");
			_trace.m_invokeasync = (bool?)xml.Attribute("invokeasync");
			_trace.m_listen2all = (bool?)xml.Attribute("listen2all");
			_trace.m_meminfo = (bool?)xml.Attribute("meminfo");
			_trace.m_monitor = (bool?)xml.Attribute("monitor");
			_trace.m_nr = (int?)xml.Attribute("nr");
			_trace.m_parse = (bool?)xml.Attribute("parse");
			_trace.m_protpath = (string)xml.Attribute("protpath");
			_trace.m_rfile = (string)xml.Attribute("rfile");
			_trace.m_size = (int?)xml.Attribute("size");
			_trace.m_unique = (bool?)xml.Attribute("unique");
			return _trace;
		}
		public void Update(trace element)
		{
			if(element.m_automatic.HasValue == true) this.automatic = element.automatic;
			if(element.m_byte.HasValue == true) this.@byte = element.@byte;
			if(element.m_calc.HasValue == true) this.calc = element.calc;
			if(element.m_debug.HasValue == true) this.debug = element.debug;
			if(element.m_dumpsize.HasValue == true) this.dumpsize = element.dumpsize;
			if(element.m_exceptionfile.HasValue == true) this.exceptionfile = element.exceptionfile;
			if(element.m_gfile != null) this.gfile = element.gfile;
			if(element.m_info.HasValue == true) this.info = element.info;
			if(element.m_invoke != null) this.invoke = element.invoke;
			if(element.m_invokeasync.HasValue == true) this.invokeasync = element.invokeasync;
			if(element.m_listen2all.HasValue == true) this.listen2all = element.listen2all;
			if(element.m_meminfo.HasValue == true) this.meminfo = element.meminfo;
			if(element.m_monitor.HasValue == true) this.monitor = element.monitor;
			if(element.m_nr.HasValue == true) this.nr = element.nr;
			if(element.m_parse.HasValue == true) this.parse = element.parse;
			if(element.m_protpath != null) this.protpath = element.protpath;
			if(element.m_rfile != null) this.rfile = element.rfile;
			if(element.m_size.HasValue == true) this.size = element.size;
			if(element.m_unique.HasValue == true) this.unique = element.unique;
		}
	}
}
