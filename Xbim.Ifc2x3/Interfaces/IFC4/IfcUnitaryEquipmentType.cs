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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcUnitaryEquipmentType : IIfcUnitaryEquipmentType
	{
		Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum IIfcUnitaryEquipmentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcUnitaryEquipmentTypeEnum.AIRHANDLER:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRHANDLER;
					
					case IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT;
					
					case IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM;
					
					case IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT;
					
					case IfcUnitaryEquipmentTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.USERDEFINED;
					
					case IfcUnitaryEquipmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.NOTDEFINED;
					
					
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