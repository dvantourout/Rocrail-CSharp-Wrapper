using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class srcp : CRocrailElements
	{
		private int? m_cmdport;
		private int? m_srcpbusFB_i8255;
		private int? m_srcpbusFB_m6051;
		private int? m_srcpbusFB_s88;
		private int? m_srcpbusGA_m;
		private int? m_srcpbusGA_n;
		private int? m_srcpbusGA_ps;
		private int? m_srcpbusGL_m;
		private int? m_srcpbusGL_nl;
		private int? m_srcpbusGL_ns;
		private int? m_srcpbusGL_ps;
		private int? m_srcpbus_server;
		/// <summary>
		/// SRCP command port.
		/// </summary>
		public int cmdport 
		{
			get { return this.m_cmdport.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmdport, value, "cmdport"); }
		}
		/// <summary>
		/// i8255 feedback bus
		/// </summary>
		public int srcpbusFB_i8255 
		{
			get { return this.m_srcpbusFB_i8255.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusFB_i8255, value, "srcpbusFB_i8255"); }
		}
		/// <summary>
		/// m6051 feedback bus
		/// </summary>
		public int srcpbusFB_m6051 
		{
			get { return this.m_srcpbusFB_m6051.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusFB_m6051, value, "srcpbusFB_m6051"); }
		}
		/// <summary>
		/// s88 feedback bus
		/// </summary>
		public int srcpbusFB_s88 
		{
			get { return this.m_srcpbusFB_s88.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusFB_s88, value, "srcpbusFB_s88"); }
		}
		/// <summary>
		/// marklin generic accessorie bus
		/// </summary>
		public int srcpbusGA_m 
		{
			get { return this.m_srcpbusGA_m.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGA_m, value, "srcpbusGA_m"); }
		}
		/// <summary>
		/// nmra dcc generic accessorie bus
		/// </summary>
		public int srcpbusGA_n 
		{
			get { return this.m_srcpbusGA_n.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGA_n, value, "srcpbusGA_n"); }
		}
		/// <summary>
		/// protocol by server generic accessorie
		/// </summary>
		public int srcpbusGA_ps 
		{
			get { return this.m_srcpbusGA_ps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGA_ps, value, "srcpbusGA_ps"); }
		}
		/// <summary>
		/// maerklin generic loco bus
		/// </summary>
		public int srcpbusGL_m 
		{
			get { return this.m_srcpbusGL_m.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGL_m, value, "srcpbusGL_m"); }
		}
		/// <summary>
		/// nmra dcc generic loco with long addr bus
		/// </summary>
		public int srcpbusGL_nl 
		{
			get { return this.m_srcpbusGL_nl.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGL_nl, value, "srcpbusGL_nl"); }
		}
		/// <summary>
		/// nmra dcc generic loco with short addr bus
		/// </summary>
		public int srcpbusGL_ns 
		{
			get { return this.m_srcpbusGL_ns.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGL_ns, value, "srcpbusGL_ns"); }
		}
		/// <summary>
		/// protocol by server generic loco
		/// </summary>
		public int srcpbusGL_ps 
		{
			get { return this.m_srcpbusGL_ps.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbusGL_ps, value, "srcpbusGL_ps"); }
		}
		/// <summary>
		/// server bus
		/// </summary>
		public int srcpbus_server 
		{
			get { return this.m_srcpbus_server.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_srcpbus_server, value, "srcpbus_server"); }
		}
		public srcp()
		{
		}
		public static srcp Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			srcp _srcp = new srcp();
			_srcp.m_rocrailClient = rocrailClient;
			_srcp.m_cmdport = (int?)xml.Attribute("cmdport");
			_srcp.m_srcpbusFB_i8255 = (int?)xml.Attribute("srcpbusFB_i8255");
			_srcp.m_srcpbusFB_m6051 = (int?)xml.Attribute("srcpbusFB_m6051");
			_srcp.m_srcpbusFB_s88 = (int?)xml.Attribute("srcpbusFB_s88");
			_srcp.m_srcpbusGA_m = (int?)xml.Attribute("srcpbusGA_m");
			_srcp.m_srcpbusGA_n = (int?)xml.Attribute("srcpbusGA_n");
			_srcp.m_srcpbusGA_ps = (int?)xml.Attribute("srcpbusGA_ps");
			_srcp.m_srcpbusGL_m = (int?)xml.Attribute("srcpbusGL_m");
			_srcp.m_srcpbusGL_nl = (int?)xml.Attribute("srcpbusGL_nl");
			_srcp.m_srcpbusGL_ns = (int?)xml.Attribute("srcpbusGL_ns");
			_srcp.m_srcpbusGL_ps = (int?)xml.Attribute("srcpbusGL_ps");
			_srcp.m_srcpbus_server = (int?)xml.Attribute("srcpbus_server");
			return _srcp;
		}
		public void Update(srcp element)
		{
			if(element.m_cmdport.HasValue == true) this.cmdport = element.cmdport;
			if(element.m_srcpbusFB_i8255.HasValue == true) this.srcpbusFB_i8255 = element.srcpbusFB_i8255;
			if(element.m_srcpbusFB_m6051.HasValue == true) this.srcpbusFB_m6051 = element.srcpbusFB_m6051;
			if(element.m_srcpbusFB_s88.HasValue == true) this.srcpbusFB_s88 = element.srcpbusFB_s88;
			if(element.m_srcpbusGA_m.HasValue == true) this.srcpbusGA_m = element.srcpbusGA_m;
			if(element.m_srcpbusGA_n.HasValue == true) this.srcpbusGA_n = element.srcpbusGA_n;
			if(element.m_srcpbusGA_ps.HasValue == true) this.srcpbusGA_ps = element.srcpbusGA_ps;
			if(element.m_srcpbusGL_m.HasValue == true) this.srcpbusGL_m = element.srcpbusGL_m;
			if(element.m_srcpbusGL_nl.HasValue == true) this.srcpbusGL_nl = element.srcpbusGL_nl;
			if(element.m_srcpbusGL_ns.HasValue == true) this.srcpbusGL_ns = element.srcpbusGL_ns;
			if(element.m_srcpbusGL_ps.HasValue == true) this.srcpbusGL_ps = element.srcpbusGL_ps;
			if(element.m_srcpbus_server.HasValue == true) this.srcpbus_server = element.srcpbus_server;
		}
	}
}
