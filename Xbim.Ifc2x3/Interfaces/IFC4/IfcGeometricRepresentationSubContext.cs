// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.RepresentationResource
{
	public partial class @IfcGeometricRepresentationSubContext : IIfcGeometricRepresentationSubContext
	{
		IIfcGeometricRepresentationContext IIfcGeometricRepresentationSubContext.ParentContext 
		{ 
			get
			{
				return ParentContext;
			} 
			set
			{
				ParentContext = value as IfcGeometricRepresentationContext;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveRatioMeasure? IIfcGeometricRepresentationSubContext.TargetScale 
		{ 
			get
			{
				if (!TargetScale.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(TargetScale.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					TargetScale =  null ;
					return;
				}
				TargetScale = new MeasureResource.IfcPositiveRatioMeasure(value.Value);
				
			}
		}
		Ifc4.Interfaces.IfcGeometricProjectionEnum IIfcGeometricRepresentationSubContext.TargetView 
		{ 
			get
			{
				switch (TargetView)
				{
					case IfcGeometricProjectionEnum.GRAPH_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.GRAPH_VIEW;
					
					case IfcGeometricProjectionEnum.SKETCH_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.SKETCH_VIEW;
					
					case IfcGeometricProjectionEnum.MODEL_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.MODEL_VIEW;
					
					case IfcGeometricProjectionEnum.PLAN_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.PLAN_VIEW;
					
					case IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW;
					
					case IfcGeometricProjectionEnum.SECTION_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.SECTION_VIEW;
					
					case IfcGeometricProjectionEnum.ELEVATION_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.ELEVATION_VIEW;
					
					case IfcGeometricProjectionEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.USERDEFINED;
					
					case IfcGeometricProjectionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcGeometricRepresentationSubContext.UserDefinedTargetView 
		{ 
			get
			{
				if (!UserDefinedTargetView.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedTargetView.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					UserDefinedTargetView =  null ;
					return;
				}
				UserDefinedTargetView = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
	//## Custom code
	//##
	}
}