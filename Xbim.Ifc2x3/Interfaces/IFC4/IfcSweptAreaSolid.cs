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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcSweptAreaSolid : IIfcSweptAreaSolid
	{
		IIfcProfileDef IIfcSweptAreaSolid.SweptArea 
		{ 
			get
			{
				return SweptArea;
			} 
			set
			{
				SweptArea = value as ProfileResource.IfcProfileDef;
				
			}
		}
		IIfcAxis2Placement3D IIfcSweptAreaSolid.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
	//## Custom code
	//##
	}
}