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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcLightSourceGoniometric : IIfcLightSourceGoniometric
	{
		IIfcAxis2Placement3D IIfcLightSourceGoniometric.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
		IIfcColourRgb IIfcLightSourceGoniometric.ColourAppearance 
		{ 
			get
			{
				return ColourAppearance;
			} 
			set
			{
				ColourAppearance = value as PresentationResource.IfcColourRgb;
				
			}
		}
		Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure IIfcLightSourceGoniometric.ColourTemperature 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure(ColourTemperature);
			} 
			set
			{
				ColourTemperature = new MeasureResource.IfcThermodynamicTemperatureMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcLuminousFluxMeasure IIfcLightSourceGoniometric.LuminousFlux 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLuminousFluxMeasure(LuminousFlux);
			} 
			set
			{
				LuminousFlux = new MeasureResource.IfcLuminousFluxMeasure(value);
				
			}
		}
		Ifc4.Interfaces.IfcLightEmissionSourceEnum IIfcLightSourceGoniometric.LightEmissionSource 
		{ 
			get
			{
				switch (LightEmissionSource)
				{
					case IfcLightEmissionSourceEnum.COMPACTFLUORESCENT:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.COMPACTFLUORESCENT;
					
					case IfcLightEmissionSourceEnum.FLUORESCENT:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.FLUORESCENT;
					
					case IfcLightEmissionSourceEnum.HIGHPRESSUREMERCURY:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.HIGHPRESSUREMERCURY;
					
					case IfcLightEmissionSourceEnum.HIGHPRESSURESODIUM:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.HIGHPRESSURESODIUM;
					
					case IfcLightEmissionSourceEnum.LIGHTEMITTINGDIODE:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.LIGHTEMITTINGDIODE;
					
					case IfcLightEmissionSourceEnum.LOWPRESSURESODIUM:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.LOWPRESSURESODIUM;
					
					case IfcLightEmissionSourceEnum.LOWVOLTAGEHALOGEN:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.LOWVOLTAGEHALOGEN;
					
					case IfcLightEmissionSourceEnum.MAINVOLTAGEHALOGEN:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.MAINVOLTAGEHALOGEN;
					
					case IfcLightEmissionSourceEnum.METALHALIDE:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.METALHALIDE;
					
					case IfcLightEmissionSourceEnum.TUNGSTENFILAMENT:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.TUNGSTENFILAMENT;
					
					case IfcLightEmissionSourceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLightEmissionSourceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		IIfcLightDistributionDataSourceSelect IIfcLightSourceGoniometric.LightDistributionDataSource 
		{ 
			get
			{
				if (LightDistributionDataSource == null) return null;
				var ifcexternalreference = LightDistributionDataSource as ExternalReferenceResource.IfcExternalReference;
				if (ifcexternalreference != null) 
					return ifcexternalreference;
				var ifclightintensitydistribution = LightDistributionDataSource as IfcLightIntensityDistribution;
				if (ifclightintensitydistribution != null) 
					return ifclightintensitydistribution;
				return null;
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