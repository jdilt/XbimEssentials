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
	public partial class @IfcProcess : IIfcProcess
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcProcess.Identification 
		{ 
			get
			{
				//## Handle return of Identification for which no match was found
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of Identification for which no match was found
				//TODO: Handle setting of Identification for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcProcess.LongDescription 
		{ 
			get
			{
				//## Handle return of LongDescription for which no match was found
                return null;
				//##
			} 
			set
			{
				//## Handle setting of LongDescription for which no match was found
				//TODO: Handle setting of LongDescription for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcRelSequence> IIfcProcess.IsPredecessorTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSequence>(e => (e.RelatingProcess as IfcProcess) == this, "RelatingProcess", this);
			} 
		}
		IEnumerable<IIfcRelSequence> IIfcProcess.IsSuccessorFrom 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSequence>(e => (e.RelatedProcess as IfcProcess) == this, "RelatedProcess", this);
			} 
		}
		IEnumerable<IIfcRelAssignsToProcess> IIfcProcess.OperatesOn 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToProcess>(e => (e.RelatingProcess as IfcProcess) == this, "RelatingProcess", this);
			} 
		}
	//## Custom code
	//##
	}
}