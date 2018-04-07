using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class options : CRocrailElements
	{
		private string m_opsw;
		private bool? m_store;
		/// <summary>
		/// zero based options list 0=open 1=set
		/// </summary>
		public string opsw 
		{
			get { return this.m_opsw; }
			private set { this.SetField(ref this.m_opsw, value, "opsw"); }
		}
		/// <summary>
		/// set by client to signal to store the options in the command station
		/// </summary>
		public bool store 
		{
			get { return this.m_store.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_store, value, "store"); }
		}
		public options()
		{
		}
		public static options Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			options _options = new options();
			_options.m_rocrailClient = rocrailClient;
			_options.m_opsw = (string)xml.Attribute("opsw");
			_options.m_store = (bool?)xml.Attribute("store");
			return _options;
		}
		public void Update(options element)
		{
			if(element.m_opsw != null) this.opsw = element.opsw;
			if(element.m_store.HasValue == true) this.store = element.store;
		}
	}
}
