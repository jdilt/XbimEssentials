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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcTendon : IIfcTendon
	{
		Ifc4.Interfaces.IfcTendonTypeEnum? IIfcTendon.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcTendonTypeEnum.STRAND:
						return Ifc4.Interfaces.IfcTendonTypeEnum.STRAND;
					
					case IfcTendonTypeEnum.WIRE:
						return Ifc4.Interfaces.IfcTendonTypeEnum.WIRE;
					
					case IfcTendonTypeEnum.BAR:
						return Ifc4.Interfaces.IfcTendonTypeEnum.BAR;
					
					case IfcTendonTypeEnum.COATED:
						return Ifc4.Interfaces.IfcTendonTypeEnum.COATED;
					
					case IfcTendonTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcTendonTypeEnum.USERDEFINED;
					
					case IfcTendonTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTendonTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.NominalDiameter 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter);
			} 
			set
			{
				if (!value.HasValue)
				{
					NominalDiameter =  default(MeasureResource.IfcPositiveLengthMeasure) ;
					return;
				}
				NominalDiameter = new MeasureResource.IfcPositiveLengthMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcTendon.CrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(CrossSectionArea);
			} 
			set
			{
				if (!value.HasValue)
				{
					CrossSectionArea =  default(MeasureResource.IfcAreaMeasure) ;
					return;
				}
				CrossSectionArea = new MeasureResource.IfcAreaMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcForceMeasure? IIfcTendon.TensionForce 
		{ 
			get
			{
				if (!TensionForce.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(TensionForce.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					TensionForce =  null ;
					return;
				}
				TensionForce = new MeasureResource.IfcForceMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcPressureMeasure? IIfcTendon.PreStress 
		{ 
			get
			{
				if (!PreStress.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPressureMeasure(PreStress.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					PreStress =  null ;
					return;
				}
				PreStress = new MeasureResource.IfcPressureMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcTendon.FrictionCoefficient 
		{ 
			get
			{
				if (!FrictionCoefficient.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(FrictionCoefficient.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					FrictionCoefficient =  null ;
					return;
				}
				FrictionCoefficient = new MeasureResource.IfcNormalisedRatioMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.AnchorageSlip 
		{ 
			get
			{
				if (!AnchorageSlip.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(AnchorageSlip.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					AnchorageSlip =  null ;
					return;
				}
				AnchorageSlip = new MeasureResource.IfcPositiveLengthMeasure(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.MinCurvatureRadius 
		{ 
			get
			{
				if (!MinCurvatureRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(MinCurvatureRadius.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					MinCurvatureRadius =  null ;
					return;
				}
				MinCurvatureRadius = new MeasureResource.IfcPositiveLengthMeasure(value.Value);
				
			}
		}
	//## Custom code
	//##
	}
}