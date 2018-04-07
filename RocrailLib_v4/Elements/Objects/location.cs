using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class location : CRocrailElements
	{
		private string m_blocks;
		private bool? m_fifo;
		
		private int? m_minocc;
		/// <summary>
		/// location related blocks as csv
		/// </summary>
		public string blocks 
		{
			get { return this.m_blocks; }
			private set { this.SetField(ref this.m_blocks, value, "blocks"); }
		}
		/// <summary>
		/// Firts in, First out
		/// </summary>
		public bool fifo 
		{
			get { return this.m_fifo.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_fifo, value, "fifo"); }
		}
		/// <summary>
		/// location name
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// minimal tracks to be occupied before leaving the fiddle yard
		/// </summary>
		public int minocc 
		{
			get { return this.m_minocc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_minocc, value, "minocc"); }
		}
		public location()
		{
		}
		public static location Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			location _location = new location();
			_location.m_rocrailClient = rocrailClient;
			_location.m_blocks = (string)xml.Attribute("blocks");
			_location.m_fifo = (bool?)xml.Attribute("fifo");
			_location.m_id = (string)xml.Attribute("id");
			_location.m_minocc = (int?)xml.Attribute("minocc");
			return _location;
		}
		public void Update(location element)
		{
			if(element.m_blocks != null) this.blocks = element.blocks;
			if(element.m_fifo.HasValue == true) this.fifo = element.fifo;
			if(element.m_id != null) this.id = element.id;
			if(element.m_minocc.HasValue == true) this.minocc = element.minocc;
		}
	}
}
