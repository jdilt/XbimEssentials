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
	public partial class @IfcProject : IIfcProject
	{
		Ifc4.MeasureResource.IfcLabel? IIfcContext.ObjectType 
		{ 
			get
			{
				//## Handle return of ObjectType for which no match was found
			    return ObjectType.HasValue
			        ? new Ifc4.MeasureResource.IfcLabel(ObjectType.Value)
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of ObjectType for which no match was found
				//TODO: Handle setting of ObjectType for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcContext.LongName 
		{ 
			get
			{
				//## Handle return of LongName for which no match was found
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of LongName for which no match was found
				//TODO: Handle setting of LongName for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcContext.Phase 
		{ 
			get
			{
				//## Handle return of Phase for which no match was found
			    return Phase.HasValue
			        ? new Ifc4.MeasureResource.IfcLabel(Phase.Value)
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of Phase for which no match was found
				//TODO: Handle setting of Phase for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcRepresentationContext> IIfcContext.RepresentationContexts 
		{ 
			get
			{
				//## Handle return of RepresentationContexts for which no match was found
			    return RepresentationContexts;
			    //##
			} 
		}
		IIfcUnitAssignment IIfcContext.UnitsInContext 
		{ 
			get
			{
				//## Handle return of UnitsInContext for which no match was found
			    return UnitsInContext;
			    //##
			} 
			set
			{
				//## Handle setting of UnitsInContext for which no match was found
				//TODO: Handle setting of UnitsInContext for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcRelDefinesByProperties> IIfcContext.IsDefinedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelDeclares> IIfcContext.Declares 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDeclares>(e => (e.RelatingContext as IfcProject) == this, "RelatingContext", this);
			} 
		}
	//## Custom code
	//##
	}
}