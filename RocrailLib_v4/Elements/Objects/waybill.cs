using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class waybill : CRocrailElements
	{
		public const string STATUS_DELIVERED = "delivered";
		public const string STATUS_SHIPPING = "shipping";
		public const string STATUS_WAITING = "waiting";
		private string m_cartype;
		private string m_commodity;
		private string m_consignee;
		private string m_destination;
		
		private string m_origin;
		private string m_routing;
		private string m_shipper;
		private string m_status;
		/// <summary>
		/// 
		/// </summary>
		public string cartype 
		{
			get { return this.m_cartype; }
			private set { this.SetField(ref this.m_cartype, value, "cartype"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string commodity 
		{
			get { return this.m_commodity; }
			private set { this.SetField(ref this.m_commodity, value, "commodity"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string consignee 
		{
			get { return this.m_consignee; }
			private set { this.SetField(ref this.m_consignee, value, "consignee"); }
		}
		/// <summary>
		/// Consignee (local) block.
		/// </summary>
		public string destination 
		{
			get { return this.m_destination; }
			private set { this.SetField(ref this.m_destination, value, "destination"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string id 
		{
			get { return this.m_id; }
			private set { this.SetField(ref this.m_id, value, "id"); }
		}
		/// <summary>
		/// Shipper (local) block.
		/// </summary>
		public string origin 
		{
			get { return this.m_origin; }
			private set { this.SetField(ref this.m_origin, value, "origin"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string routing 
		{
			get { return this.m_routing; }
			private set { this.SetField(ref this.m_routing, value, "routing"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string shipper 
		{
			get { return this.m_shipper; }
			private set { this.SetField(ref this.m_shipper, value, "shipper"); }
		}
		/// <summary>
		/// Waybill status.
		/// </summary>
		public string status 
		{
			get { return this.m_status; }
			private set { this.SetField(ref this.m_status, value, "status"); }
		}
		public waybill()
		{
		}
		public static waybill Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			waybill _waybill = new waybill();
			_waybill.m_rocrailClient = rocrailClient;
			_waybill.m_cartype = (string)xml.Attribute("cartype");
			_waybill.m_commodity = (string)xml.Attribute("commodity");
			_waybill.m_consignee = (string)xml.Attribute("consignee");
			_waybill.m_destination = (string)xml.Attribute("destination");
			_waybill.m_id = (string)xml.Attribute("id");
			_waybill.m_origin = (string)xml.Attribute("origin");
			_waybill.m_routing = (string)xml.Attribute("routing");
			_waybill.m_shipper = (string)xml.Attribute("shipper");
			_waybill.m_status = (string)xml.Attribute("status");
			return _waybill;
		}
		public void Update(waybill element)
		{
			if(element.m_cartype != null) this.cartype = element.cartype;
			if(element.m_commodity != null) this.commodity = element.commodity;
			if(element.m_consignee != null) this.consignee = element.consignee;
			if(element.m_destination != null) this.destination = element.destination;
			if(element.m_id != null) this.id = element.id;
			if(element.m_origin != null) this.origin = element.origin;
			if(element.m_routing != null) this.routing = element.routing;
			if(element.m_shipper != null) this.shipper = element.shipper;
			if(element.m_status != null) this.status = element.status;
		}
	}
}
