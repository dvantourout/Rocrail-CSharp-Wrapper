using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class decoder : CRocrailElements
	{
		private List<family> m_familylist;
		private List<variables> m_variableslist;
		/// <summary>
		/// 
		/// </summary>
		public List<family> familylist 
		{
			get { return this.m_familylist; }
			private set { this.SetField(ref this.m_familylist, value, "familylist"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public List<variables> variableslist 
		{
			get { return this.m_variableslist; }
			private set { this.SetField(ref this.m_variableslist, value, "variableslist"); }
		}
		public decoder()
		{
			this.m_familylist = new List<family>();
			this.m_variableslist = new List<variables>();
		}
		public static decoder Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			decoder _decoder = new decoder();
			_decoder.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<family>(_decoder.m_familylist, xml, "family", family.Parse, rocrailClient);
			Definitions.Tools.ParseList<variables>(_decoder.m_variableslist, xml, "variables", variables.Parse, rocrailClient);
			return _decoder;
		}
		public void Update(decoder element)
		{
			this.familylist = element.familylist;
			this.variableslist = element.variableslist;
		}
	}
}
