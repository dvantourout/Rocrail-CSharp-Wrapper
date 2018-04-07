using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class variables : CRocrailElements
	{
		private List<variable> m_variablelist;
		/// <summary>
		/// 
		/// </summary>
		public List<variable> variablelist 
		{
			get { return this.m_variablelist; }
			private set { this.SetField(ref this.m_variablelist, value, "variablelist"); }
		}

		public variables()
		{
			this.m_variablelist = new List<variable>();
		}

		public static variables Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			variables _variables = new variables();
			_variables.m_rocrailClient = rocrailClient;
			Definitions.Tools.ParseList<variable>(_variables.m_variablelist, xml, "variable", variable.Parse, rocrailClient);
			return _variables;
		}

		public void Update(variables element)
		{
			this.variablelist = element.variablelist;
		}
	}
}
