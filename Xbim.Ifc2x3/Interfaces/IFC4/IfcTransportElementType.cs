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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcTransportElementType : IIfcTransportElementType
	{
		Ifc4.Interfaces.IfcTransportElementTypeEnum IIfcTransportElementType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcTransportElementTypeEnum.ELEVATOR:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.ELEVATOR;
					
					case IfcTransportElementTypeEnum.ESCALATOR:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.ESCALATOR;
					
					case IfcTransportElementTypeEnum.MOVINGWALKWAY:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.MOVINGWALKWAY;
					
					case IfcTransportElementTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.USERDEFINED;
					
					case IfcTransportElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.NOTDEFINED;
					
					
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