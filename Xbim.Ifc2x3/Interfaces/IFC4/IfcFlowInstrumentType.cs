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
namespace Xbim.Ifc2x3.BuildingcontrolsDomain
{
	public partial class @IfcFlowInstrumentType : IIfcFlowInstrumentType
	{
		Ifc4.Interfaces.IfcFlowInstrumentTypeEnum IIfcFlowInstrumentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcFlowInstrumentTypeEnum.PRESSUREGAUGE:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PRESSUREGAUGE;
					
					case IfcFlowInstrumentTypeEnum.THERMOMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.THERMOMETER;
					
					case IfcFlowInstrumentTypeEnum.AMMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.AMMETER;
					
					case IfcFlowInstrumentTypeEnum.FREQUENCYMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.FREQUENCYMETER;
					
					case IfcFlowInstrumentTypeEnum.POWERFACTORMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.POWERFACTORMETER;
					
					case IfcFlowInstrumentTypeEnum.PHASEANGLEMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PHASEANGLEMETER;
					
					case IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK;
					
					case IfcFlowInstrumentTypeEnum.VOLTMETER_RMS:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_RMS;
					
					case IfcFlowInstrumentTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.USERDEFINED;
					
					case IfcFlowInstrumentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.NOTDEFINED;
					
					
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