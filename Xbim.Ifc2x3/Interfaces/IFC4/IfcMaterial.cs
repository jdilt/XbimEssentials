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
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterial : IIfcMaterial
	{
		Ifc4.MeasureResource.IfcLabel IIfcMaterial.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcMaterial.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of Description for which no match was found
				//TODO: Handle setting of Description for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMaterial.Category 
		{ 
			get
			{
				//## Handle return of Category for which no match was found
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of Category for which no match was found
				//TODO: Handle setting of Category for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcMaterialDefinitionRepresentation> IIfcMaterial.HasRepresentation 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialDefinitionRepresentation>(e => (e.RepresentedMaterial as IfcMaterial) == this, "RepresentedMaterial", this);
			} 
		}
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.IsRelatedWith 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialRelationship>(e => e.RelatedMaterials != null &&  e.RelatedMaterials.Contains(this), "RelatedMaterials", this);
			} 
		}
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.RelatesTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialRelationship>(e => (e.RelatingMaterial as IfcMaterial) == this, "RelatingMaterial", this);
			} 
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterial) == this, "RelatingMaterial", this);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcMaterialDefinition.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcMaterialProperties> IIfcMaterialDefinition.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialProperties>(e => (e.Material as IfcMaterial) == this, "Material", this);
			} 
		}
	//## Custom code
	//##
	}
}