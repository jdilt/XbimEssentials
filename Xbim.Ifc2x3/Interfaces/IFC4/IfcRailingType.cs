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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcRailingType : IIfcRailingType
	{
		Ifc4.Interfaces.IfcRailingTypeEnum IIfcRailingType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcRailingTypeEnum.HANDRAIL:
						return Ifc4.Interfaces.IfcRailingTypeEnum.HANDRAIL;
					
					case IfcRailingTypeEnum.GUARDRAIL:
						return Ifc4.Interfaces.IfcRailingTypeEnum.GUARDRAIL;
					
					case IfcRailingTypeEnum.BALUSTRADE:
						return Ifc4.Interfaces.IfcRailingTypeEnum.BALUSTRADE;
					
					case IfcRailingTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcRailingTypeEnum.USERDEFINED;
					
					case IfcRailingTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcRailingTypeEnum.NOTDEFINED;
					
					
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