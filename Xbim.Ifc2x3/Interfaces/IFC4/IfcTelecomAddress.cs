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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcTelecomAddress : IIfcTelecomAddress
	{
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.TelephoneNumbers 
		{ 
			get
			{
				foreach (var member in TelephoneNumbers)
				{
					yield return new Ifc4.MeasureResource.IfcLabel((string)member);
				}
			} 
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.FacsimileNumbers 
		{ 
			get
			{
				foreach (var member in FacsimileNumbers)
				{
					yield return new Ifc4.MeasureResource.IfcLabel((string)member);
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcTelecomAddress.PagerNumber 
		{ 
			get
			{
				if (!PagerNumber.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(PagerNumber.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					PagerNumber =  null ;
					return;
				}
				PagerNumber = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.ElectronicMailAddresses 
		{ 
			get
			{
				foreach (var member in ElectronicMailAddresses)
				{
					yield return new Ifc4.MeasureResource.IfcLabel((string)member);
				}
			} 
		}
		Ifc4.ExternalReferenceResource.IfcURIReference? IIfcTelecomAddress.WWWHomePageURL 
		{ 
			get
			{
				if (!WWWHomePageURL.HasValue) return null;
				return new Ifc4.ExternalReferenceResource.IfcURIReference(WWWHomePageURL.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					WWWHomePageURL =  null ;
					return;
				}
				WWWHomePageURL = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		IEnumerable<Xbim.Ifc4.ExternalReferenceResource.IfcURIReference> IIfcTelecomAddress.MessagingIDs 
		{ 
			get
			{
				//## Handle return of MessagingIDs for which no match was found
                return null;
				//##
			} 
		}
	//## Custom code
	//##
	}
}