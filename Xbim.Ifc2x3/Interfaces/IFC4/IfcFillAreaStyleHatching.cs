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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcFillAreaStyleHatching : IIfcFillAreaStyleHatching
	{
		IIfcCurveStyle IIfcFillAreaStyleHatching.HatchLineAppearance 
		{ 
			get
			{
				return HatchLineAppearance;
			} 
			set
			{
				HatchLineAppearance = value as IfcCurveStyle;
				
			}
		}
		IIfcHatchLineDistanceSelect IIfcFillAreaStyleHatching.StartOfNextHatchLine 
		{ 
			get
			{
				if (StartOfNextHatchLine == null) return null;
				var ifconedirectionrepeatfactor = StartOfNextHatchLine as IfcOneDirectionRepeatFactor;
				if (ifconedirectionrepeatfactor != null) 
					//## Handle entity IfcOneDirectionRepeatFactor which is not a part of the target select interface IIfcHatchLineDistanceSelect in property StartOfNextHatchLine
					//TODO: Handle entity IfcOneDirectionRepeatFactor which is not a part of the target select interface IIfcHatchLineDistanceSelect in property StartOfNextHatchLine
					throw new System.NotImplementedException();
					//##
				if (StartOfNextHatchLine is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(MeasureResource.IfcPositiveLengthMeasure)StartOfNextHatchLine);
				return null;
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PointOfReferenceHatchLine 
		{ 
			get
			{
				return PointOfReferenceHatchLine;
			} 
			set
			{
				PointOfReferenceHatchLine = value as GeometryResource.IfcCartesianPoint;
				
			}
		}
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PatternStart 
		{ 
			get
			{
				return PatternStart;
			} 
			set
			{
				PatternStart = value as GeometryResource.IfcCartesianPoint;
				
			}
		}
		Ifc4.MeasureResource.IfcPlaneAngleMeasure IIfcFillAreaStyleHatching.HatchLineAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(HatchLineAngle);
			} 
			set
			{
				HatchLineAngle = new MeasureResource.IfcPlaneAngleMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}