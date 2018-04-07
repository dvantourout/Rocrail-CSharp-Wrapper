using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class anaopt : CRocrailElements
	{
		private bool? m_actionCheck;
		private bool? m_actionClean;
		private bool? m_addFeedbackBlockAssignment;
		private bool? m_addSignalBlockAssignment;
		private bool? m_basicCheck;
		private bool? m_basicClean;
		private bool? m_blockCheck;
		private bool? m_blockClean;
		private bool? m_cleanRouteId;
		private int? m_maxRecursionDepth;
		private bool? m_resetBlockId;
		private bool? m_resetFeedbackBlockAssignment;
		private bool? m_resetSignalBlockAssignment;
		private bool? m_routeCheck;
		private bool? m_routeClean;
		private bool? m_setBlockId;
		private bool? m_setRouteId;
		/// <summary>
		/// Check actions and conditions
		/// </summary>
		public bool actionCheck 
		{
			get { return this.m_actionCheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actionCheck, value, "actionCheck"); }
		}
		/// <summary>
		/// Clean action and condition problems
		/// </summary>
		public bool actionClean 
		{
			get { return this.m_actionClean.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_actionClean, value, "actionClean"); }
		}
		/// <summary>
		/// Assign feedbacks to blocks
		/// </summary>
		public bool addFeedbackBlockAssignment 
		{
			get { return this.m_addFeedbackBlockAssignment.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addFeedbackBlockAssignment, value, "addFeedbackBlockAssignment"); }
		}
		/// <summary>
		/// Assign signals to blocks
		/// </summary>
		public bool addSignalBlockAssignment 
		{
			get { return this.m_addSignalBlockAssignment.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addSignalBlockAssignment, value, "addSignalBlockAssignment"); }
		}
		/// <summary>
		/// Basic checks on all items
		/// </summary>
		public bool basicCheck 
		{
			get { return this.m_basicCheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_basicCheck, value, "basicCheck"); }
		}
		/// <summary>
		/// Clean basic problems on all items
		/// </summary>
		public bool basicClean 
		{
			get { return this.m_basicClean.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_basicClean, value, "basicClean"); }
		}
		/// <summary>
		/// Checks concerning blocks
		/// </summary>
		public bool blockCheck 
		{
			get { return this.m_blockCheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockCheck, value, "blockCheck"); }
		}
		/// <summary>
		/// Clean block problems
		/// </summary>
		public bool blockClean 
		{
			get { return this.m_blockClean.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_blockClean, value, "blockClean"); }
		}
		/// <summary>
		/// Clean routeid of all automatic detected routes
		/// </summary>
		public bool cleanRouteId 
		{
			get { return this.m_cleanRouteId.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cleanRouteId, value, "cleanRouteId"); }
		}
		/// <summary>
		/// maximum recursion depth
		/// </summary>
		public int maxRecursionDepth 
		{
			get { return this.m_maxRecursionDepth.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_maxRecursionDepth, value, "maxRecursionDepth"); }
		}
		/// <summary>
		/// Reset blockid in whole plan
		/// </summary>
		public bool resetBlockId 
		{
			get { return this.m_resetBlockId.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetBlockId, value, "resetBlockId"); }
		}
		/// <summary>
		/// Reset feedback assignments in all blocks
		/// </summary>
		public bool resetFeedbackBlockAssignment 
		{
			get { return this.m_resetFeedbackBlockAssignment.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetFeedbackBlockAssignment, value, "resetFeedbackBlockAssignment"); }
		}
		/// <summary>
		/// Reset signal assignments in all blocks
		/// </summary>
		public bool resetSignalBlockAssignment 
		{
			get { return this.m_resetSignalBlockAssignment.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_resetSignalBlockAssignment, value, "resetSignalBlockAssignment"); }
		}
		/// <summary>
		/// Checks concerning routes
		/// </summary>
		public bool routeCheck 
		{
			get { return this.m_routeCheck.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_routeCheck, value, "routeCheck"); }
		}
		/// <summary>
		/// Clean route problems
		/// </summary>
		public bool routeClean 
		{
			get { return this.m_routeClean.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_routeClean, value, "routeClean"); }
		}
		/// <summary>
		/// Set blockid for all blocks
		/// </summary>
		public bool setBlockId 
		{
			get { return this.m_setBlockId.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_setBlockId, value, "setBlockId"); }
		}
		/// <summary>
		/// Set routeid for all automatic detected routes
		/// </summary>
		public bool setRouteId 
		{
			get { return this.m_setRouteId.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_setRouteId, value, "setRouteId"); }
		}
		public anaopt()
		{
		}
		public static anaopt Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			anaopt _anaopt = new anaopt();
			_anaopt.m_rocrailClient = rocrailClient;
			_anaopt.m_actionCheck = (bool?)xml.Attribute("actionCheck");
			_anaopt.m_actionClean = (bool?)xml.Attribute("actionClean");
			_anaopt.m_addFeedbackBlockAssignment = (bool?)xml.Attribute("addFeedbackBlockAssignment");
			_anaopt.m_addSignalBlockAssignment = (bool?)xml.Attribute("addSignalBlockAssignment");
			_anaopt.m_basicCheck = (bool?)xml.Attribute("basicCheck");
			_anaopt.m_basicClean = (bool?)xml.Attribute("basicClean");
			_anaopt.m_blockCheck = (bool?)xml.Attribute("blockCheck");
			_anaopt.m_blockClean = (bool?)xml.Attribute("blockClean");
			_anaopt.m_cleanRouteId = (bool?)xml.Attribute("cleanRouteId");
			_anaopt.m_maxRecursionDepth = (int?)xml.Attribute("maxRecursionDepth");
			_anaopt.m_resetBlockId = (bool?)xml.Attribute("resetBlockId");
			_anaopt.m_resetFeedbackBlockAssignment = (bool?)xml.Attribute("resetFeedbackBlockAssignment");
			_anaopt.m_resetSignalBlockAssignment = (bool?)xml.Attribute("resetSignalBlockAssignment");
			_anaopt.m_routeCheck = (bool?)xml.Attribute("routeCheck");
			_anaopt.m_routeClean = (bool?)xml.Attribute("routeClean");
			_anaopt.m_setBlockId = (bool?)xml.Attribute("setBlockId");
			_anaopt.m_setRouteId = (bool?)xml.Attribute("setRouteId");
			return _anaopt;
		}
		public void Update(anaopt element)
		{
			if(element.m_actionCheck.HasValue == true) this.actionCheck = element.actionCheck;
			if(element.m_actionClean.HasValue == true) this.actionClean = element.actionClean;
			if(element.m_addFeedbackBlockAssignment.HasValue == true) this.addFeedbackBlockAssignment = element.addFeedbackBlockAssignment;
			if(element.m_addSignalBlockAssignment.HasValue == true) this.addSignalBlockAssignment = element.addSignalBlockAssignment;
			if(element.m_basicCheck.HasValue == true) this.basicCheck = element.basicCheck;
			if(element.m_basicClean.HasValue == true) this.basicClean = element.basicClean;
			if(element.m_blockCheck.HasValue == true) this.blockCheck = element.blockCheck;
			if(element.m_blockClean.HasValue == true) this.blockClean = element.blockClean;
			if(element.m_cleanRouteId.HasValue == true) this.cleanRouteId = element.cleanRouteId;
			if(element.m_maxRecursionDepth.HasValue == true) this.maxRecursionDepth = element.maxRecursionDepth;
			if(element.m_resetBlockId.HasValue == true) this.resetBlockId = element.resetBlockId;
			if(element.m_resetFeedbackBlockAssignment.HasValue == true) this.resetFeedbackBlockAssignment = element.resetFeedbackBlockAssignment;
			if(element.m_resetSignalBlockAssignment.HasValue == true) this.resetSignalBlockAssignment = element.resetSignalBlockAssignment;
			if(element.m_routeCheck.HasValue == true) this.routeCheck = element.routeCheck;
			if(element.m_routeClean.HasValue == true) this.routeClean = element.routeClean;
			if(element.m_setBlockId.HasValue == true) this.setBlockId = element.setBlockId;
			if(element.m_setRouteId.HasValue == true) this.setRouteId = element.setRouteId;
		}
	}
}
