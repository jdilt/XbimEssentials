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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelAssignsToProcess : IIfcRelAssignsToProcess
	{
		IIfcProcessSelect IIfcRelAssignsToProcess.RelatingProcess 
		{ 
			get
			{
				return RelatingProcess;
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		IIfcMeasureWithUnit IIfcRelAssignsToProcess.QuantityInProcess 
		{ 
			get
			{
				return QuantityInProcess;
			} 
			set
			{
				QuantityInProcess = value as MeasureResource.IfcMeasureWithUnit;
				
			}
		}
	//## Custom code
	//##
	}
}