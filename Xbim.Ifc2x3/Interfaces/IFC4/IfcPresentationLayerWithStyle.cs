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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcPresentationLayerWithStyle : IIfcPresentationLayerWithStyle
	{
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerOn 
		{ 
			get
			{
				//## Handle return of LayerOn for which no match was found
			    return new Ifc4.MeasureResource.IfcLogical(LayerOn);
			    //##
			} 
			set
			{
				//## Handle setting of LayerOn for which no match was found
				//TODO: Handle setting of LayerOn for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerFrozen 
		{ 
			get
			{
				//## Handle return of LayerFrozen for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(LayerFrozen);
				//##
			} 
			set
			{
				//## Handle setting of LayerFrozen for which no match was found
				//TODO: Handle setting of LayerFrozen for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerBlocked 
		{ 
			get
			{
				//## Handle return of LayerBlocked for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(LayerBlocked);
				//##
			} 
			set
			{
				//## Handle setting of LayerBlocked for which no match was found
				//TODO: Handle setting of LayerBlocked for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IEnumerable<IIfcPresentationStyle> IIfcPresentationLayerWithStyle.LayerStyles 
		{ 
			get
			{
				//## Handle return of LayerStyles for which no match was found
                return LayerStyles.OfType<IIfcPresentationStyle>();
			    //##
			} 
		}
	//## Custom code
	//##
	}
}