using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class variable : CRocrailElements
	{
		private int? m_CV;
		private string m_comment;
		private string m_item;
		private string m_label;
		private string m_mask;
		private string m_tooltip;
		/// <summary>
		/// 
		/// </summary>
		public int CV 
		{
			get { return this.m_CV.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_CV, value, "CV"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string comment 
		{
			get { return this.m_comment; }
			private set { this.SetField(ref this.m_comment, value, "comment"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string item 
		{
			get { return this.m_item; }
			private set { this.SetField(ref this.m_item, value, "item"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string label 
		{
			get { return this.m_label; }
			private set { this.SetField(ref this.m_label, value, "label"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string mask 
		{
			get { return this.m_mask; }
			private set { this.SetField(ref this.m_mask, value, "mask"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string tooltip 
		{
			get { return this.m_tooltip; }
			private set { this.SetField(ref this.m_tooltip, value, "tooltip"); }
		}
		public variable()
		{
		}
		public static variable Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			variable _variable = new variable();
			_variable.m_rocrailClient = rocrailClient;
			_variable.m_CV = (int?)xml.Attribute("CV");
			_variable.m_comment = (string)xml.Attribute("comment");
			_variable.m_item = (string)xml.Attribute("item");
			_variable.m_label = (string)xml.Attribute("label");
			_variable.m_mask = (string)xml.Attribute("mask");
			_variable.m_tooltip = (string)xml.Attribute("tooltip");
			return _variable;
		}
		public void Update(variable element)
		{
			if(element.m_CV.HasValue == true) this.CV = element.CV;
			if(element.m_comment != null) this.comment = element.comment;
			if(element.m_item != null) this.item = element.item;
			if(element.m_label != null) this.label = element.label;
			if(element.m_mask != null) this.mask = element.mask;
			if(element.m_tooltip != null) this.tooltip = element.tooltip;
		}
	}
}
