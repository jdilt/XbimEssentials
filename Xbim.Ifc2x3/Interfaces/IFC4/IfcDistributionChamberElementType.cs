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
namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	public partial class @IfcDistributionChamberElementType : IIfcDistributionChamberElementType
	{
		Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum IIfcDistributionChamberElementType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcDistributionChamberElementTypeEnum.FORMEDDUCT:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.FORMEDDUCT;
					
					case IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.INSPECTIONPIT:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONPIT;
					
					case IfcDistributionChamberElementTypeEnum.MANHOLE:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.MANHOLE;
					
					case IfcDistributionChamberElementTypeEnum.METERCHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.METERCHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.SUMP:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.SUMP;
					
					case IfcDistributionChamberElementTypeEnum.TRENCH:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.TRENCH;
					
					case IfcDistributionChamberElementTypeEnum.VALVECHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.VALVECHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.USERDEFINED;
					
					case IfcDistributionChamberElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
	//## Custom code
	//##
	}
}