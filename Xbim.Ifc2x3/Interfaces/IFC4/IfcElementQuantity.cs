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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcElementQuantity : IIfcElementQuantity
	{
		Ifc4.MeasureResource.IfcLabel? IIfcElementQuantity.MethodOfMeasurement 
		{ 
			get
			{
				if (!MethodOfMeasurement.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(MethodOfMeasurement.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					MethodOfMeasurement =  null ;
					return;
				}
				MethodOfMeasurement = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		IEnumerable<IIfcPhysicalQuantity> IIfcElementQuantity.Quantities 
		{ 
			get
			{
				foreach (var member in Quantities)
				{
					yield return member as IIfcPhysicalQuantity;
				}
			} 
		}
	//## Custom code
	//##
	}
}