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
namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	public partial class @IfcConstructionResource : IIfcConstructionResource
	{
		IIfcResourceTime IIfcConstructionResource.Usage 
		{ 
			get
			{
				//## Handle return of Usage for which no match was found
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of Usage for which no match was found
				//TODO: Handle setting of Usage for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcAppliedValue> IIfcConstructionResource.BaseCosts 
		{ 
			get
			{
				//## Handle return of BaseCosts for which no match was found
				yield break;
				//##
			} 
		}
		IIfcPhysicalQuantity IIfcConstructionResource.BaseQuantity 
		{ 
			get
			{
				//## Handle return of BaseQuantity for which no match was found
			    return BaseQuantity.ToPhysicalSimpleQuantity();
				//##
			} 
			set
			{
				//## Handle setting of BaseQuantity for which no match was found
				//TODO: Handle setting of BaseQuantity for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
	//## Custom code
	//##
	}
}