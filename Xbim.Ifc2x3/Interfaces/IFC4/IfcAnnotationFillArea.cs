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
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcAnnotationFillArea : IIfcAnnotationFillArea
	{
		IIfcCurve IIfcAnnotationFillArea.OuterBoundary 
		{ 
			get
			{
				return OuterBoundary;
			} 
			set
			{
				OuterBoundary = value as GeometryResource.IfcCurve;
				
			}
		}
		IEnumerable<IIfcCurve> IIfcAnnotationFillArea.InnerBoundaries 
		{ 
			get
			{
				foreach (var member in InnerBoundaries)
				{
					yield return member as IIfcCurve;
				}
			} 
		}
	//## Custom code
	//##
	}
}