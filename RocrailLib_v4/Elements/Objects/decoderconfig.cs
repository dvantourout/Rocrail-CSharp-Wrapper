using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class decoderconfig : CRocrailElements
	{
		private List<decoder> m_decoderlist;
		/// <summary>
		/// 
		/// </summary>
		public List<decoder> decoderlist 
		{
			get { return this.m_decoderlist; }
			private set { this.SetField(ref this.m_decoderlist, value, "decoderlist"); }
		}
		public decoderconfig()
		{
			this.m_decoderlist = new List<decoder>();
		}
		public static decoderconfig Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			decoderconfig _decoderconfig = new decoderconfig();
			_decoderconfig.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<decoder>(_decoderconfig.m_decoderlist, xml, "decoder", decoder.Parse, rocrailClient);
			return _decoderconfig;
		}
		public void Update(decoderconfig element)
		{
			this.decoderlist = element.decoderlist;
		}
	}
}
