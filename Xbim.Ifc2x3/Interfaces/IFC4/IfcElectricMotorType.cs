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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcElectricMotorType : IIfcElectricMotorType
	{
		Ifc4.Interfaces.IfcElectricMotorTypeEnum IIfcElectricMotorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElectricMotorTypeEnum.DC:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.DC;
					
					case IfcElectricMotorTypeEnum.INDUCTION:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.INDUCTION;
					
					case IfcElectricMotorTypeEnum.POLYPHASE:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.POLYPHASE;
					
					case IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS;
					
					case IfcElectricMotorTypeEnum.SYNCHRONOUS:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.SYNCHRONOUS;
					
					case IfcElectricMotorTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.USERDEFINED;
					
					case IfcElectricMotorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.NOTDEFINED;
					
					
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