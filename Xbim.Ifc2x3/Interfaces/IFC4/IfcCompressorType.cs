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
	public partial class @IfcCompressorType : IIfcCompressorType
	{
		Ifc4.Interfaces.IfcCompressorTypeEnum IIfcCompressorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCompressorTypeEnum.DYNAMIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.DYNAMIC;
					
					case IfcCompressorTypeEnum.RECIPROCATING:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.RECIPROCATING;
					
					case IfcCompressorTypeEnum.ROTARY:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARY;
					
					case IfcCompressorTypeEnum.SCROLL:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SCROLL;
					
					case IfcCompressorTypeEnum.TROCHOIDAL:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.TROCHOIDAL;
					
					case IfcCompressorTypeEnum.SINGLESTAGE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESTAGE;
					
					case IfcCompressorTypeEnum.BOOSTER:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.BOOSTER;
					
					case IfcCompressorTypeEnum.OPENTYPE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.OPENTYPE;
					
					case IfcCompressorTypeEnum.HERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.HERMETIC;
					
					case IfcCompressorTypeEnum.SEMIHERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SEMIHERMETIC;
					
					case IfcCompressorTypeEnum.WELDEDSHELLHERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.WELDEDSHELLHERMETIC;
					
					case IfcCompressorTypeEnum.ROLLINGPISTON:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROLLINGPISTON;
					
					case IfcCompressorTypeEnum.ROTARYVANE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARYVANE;
					
					case IfcCompressorTypeEnum.SINGLESCREW:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESCREW;
					
					case IfcCompressorTypeEnum.TWINSCREW:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.TWINSCREW;
					
					case IfcCompressorTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.USERDEFINED;
					
					case IfcCompressorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.NOTDEFINED;
					
					
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