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
	public partial class @IfcStair : IIfcStair
	{
		Ifc4.Interfaces.IfcStairTypeEnum? IIfcStair.PredefinedType 
		{ 
			get
			{
				switch (ShapeType)
				{
					case IfcStairTypeEnum.STRAIGHT_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.STRAIGHT_RUN_STAIR;
					
					case IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR;
					
					case IfcStairTypeEnum.QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_WINDING_STAIR;
					
					case IfcStairTypeEnum.QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_TURN_STAIR;
					
					case IfcStairTypeEnum.HALF_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.HALF_WINDING_STAIR;
					
					case IfcStairTypeEnum.HALF_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.HALF_TURN_STAIR;
					
					case IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR;
					
					case IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR;
					
					case IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR;
					
					case IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR;
					
					case IfcStairTypeEnum.SPIRAL_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.SPIRAL_STAIR;
					
					case IfcStairTypeEnum.DOUBLE_RETURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.DOUBLE_RETURN_STAIR;
					
					case IfcStairTypeEnum.CURVED_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.CURVED_RUN_STAIR;
					
					case IfcStairTypeEnum.TWO_CURVED_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_CURVED_RUN_STAIR;
					
					case IfcStairTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcStairTypeEnum.USERDEFINED;
					
					case IfcStairTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStairTypeEnum.NOTDEFINED;
					
					
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