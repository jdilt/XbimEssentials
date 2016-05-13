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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcBSplineCurve : IIfcBSplineCurve
	{
		Ifc4.MeasureResource.IfcInteger IIfcBSplineCurve.Degree 
		{ 
			get
			{
				//## Handle return of Degree for which no match was found
                return new Ifc4.MeasureResource.IfcInteger(Degree);
				//##
			} 
			set
			{
				//## Handle setting of Degree for which no match was found
				//TODO: Handle setting of Degree for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcCartesianPoint> IIfcBSplineCurve.ControlPointsList 
		{ 
			get
			{
				foreach (var member in ControlPointsList)
				{
					yield return member as IIfcCartesianPoint;
				}
			} 
		}
		Ifc4.Interfaces.IfcBSplineCurveForm IIfcBSplineCurve.CurveForm 
		{ 
			get
			{
				switch (CurveForm)
				{
					case IfcBSplineCurveForm.POLYLINE_FORM:
						return Ifc4.Interfaces.IfcBSplineCurveForm.POLYLINE_FORM;
					
					case IfcBSplineCurveForm.CIRCULAR_ARC:
						return Ifc4.Interfaces.IfcBSplineCurveForm.CIRCULAR_ARC;
					
					case IfcBSplineCurveForm.ELLIPTIC_ARC:
						return Ifc4.Interfaces.IfcBSplineCurveForm.ELLIPTIC_ARC;
					
					case IfcBSplineCurveForm.PARABOLIC_ARC:
						return Ifc4.Interfaces.IfcBSplineCurveForm.PARABOLIC_ARC;
					
					case IfcBSplineCurveForm.HYPERBOLIC_ARC:
						return Ifc4.Interfaces.IfcBSplineCurveForm.HYPERBOLIC_ARC;
					
					case IfcBSplineCurveForm.UNSPECIFIED:
						return Ifc4.Interfaces.IfcBSplineCurveForm.UNSPECIFIED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcBSplineCurve.ClosedCurve 
		{ 
			get
			{
				//## Handle return of ClosedCurve for which no match was found
			    return new Ifc4.MeasureResource.IfcLogical(ClosedCurve);
			    //##
			} 
			set
			{
				//## Handle setting of ClosedCurve for which no match was found
				//TODO: Handle setting of ClosedCurve for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcBSplineCurve.SelfIntersect 
		{ 
			get
			{
				//## Handle return of SelfIntersect for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(SelfIntersect);
				//##
			} 
			set
			{
				//## Handle setting of SelfIntersect for which no match was found
				//TODO: Handle setting of SelfIntersect for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcInteger IIfcBSplineCurve.UpperIndexOnControlPoints 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(UpperIndexOnControlPoints);
			}
		}

		List<Common.Geometry.XbimPoint3D> IIfcBSplineCurve.ControlPoints 
		{
			get 
			{
				return ControlPoints;
			}
		}

	//## Custom code
	//##
	}
}