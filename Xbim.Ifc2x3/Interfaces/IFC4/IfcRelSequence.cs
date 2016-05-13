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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelSequence : IIfcRelSequence
	{
		IIfcProcess IIfcRelSequence.RelatingProcess 
		{ 
			get
			{
				return RelatingProcess;
			} 
			set
			{
				RelatingProcess = value as IfcProcess;
				
			}
		}
		IIfcProcess IIfcRelSequence.RelatedProcess 
		{ 
			get
			{
				return RelatedProcess;
			} 
			set
			{
				RelatedProcess = value as IfcProcess;
				
			}
		}
		IIfcLagTime IIfcRelSequence.TimeLag 
		{ 
			get
			{
				//## Handle return of TimeLag for which no match was found
			    return new Interfaces.Conversions.IfcLagTimeTransient(TimeLag.ToISODateTimeString());
				//##
			} 
			set
			{
				//## Handle setting of TimeLag for which no match was found
				throw new System.PlatformNotSupportedException();
				//##
				
			}
		}
		Ifc4.Interfaces.IfcSequenceEnum? IIfcRelSequence.SequenceType 
		{ 
			get
			{
				switch (SequenceType)
				{
					case IfcSequenceEnum.START_START:
						return Ifc4.Interfaces.IfcSequenceEnum.START_START;
					
					case IfcSequenceEnum.START_FINISH:
						return Ifc4.Interfaces.IfcSequenceEnum.START_FINISH;
					
					case IfcSequenceEnum.FINISH_START:
						return Ifc4.Interfaces.IfcSequenceEnum.FINISH_START;
					
					case IfcSequenceEnum.FINISH_FINISH:
						return Ifc4.Interfaces.IfcSequenceEnum.FINISH_FINISH;
					
					case IfcSequenceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSequenceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRelSequence.UserDefinedSequenceType 
		{ 
			get
			{
				//## Handle return of UserDefinedSequenceType for which no match was found
                return null;
				//##
			} 
			set
			{
				//## Handle setting of UserDefinedSequenceType for which no match was found
                throw new System.PlatformNotSupportedException();
				//##
				
			}
		}
	//## Custom code
	//##
	}
}