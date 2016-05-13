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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcSurfaceStyle : IIfcSurfaceStyle
	{
		Ifc4.Interfaces.IfcSurfaceSide IIfcSurfaceStyle.Side 
		{ 
			get
			{
				switch (Side)
				{
					case IfcSurfaceSide.POSITIVE:
						return Ifc4.Interfaces.IfcSurfaceSide.POSITIVE;
					
					case IfcSurfaceSide.NEGATIVE:
						return Ifc4.Interfaces.IfcSurfaceSide.NEGATIVE;
					
					case IfcSurfaceSide.BOTH:
						return Ifc4.Interfaces.IfcSurfaceSide.BOTH;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		IEnumerable<IIfcSurfaceStyleElementSelect> IIfcSurfaceStyle.Styles 
		{ 
			get
			{
				foreach (var member in Styles)
				{
					var ifcsurfacestyleshading = member as IfcSurfaceStyleShading;
					if (ifcsurfacestyleshading != null) 
						yield return ifcsurfacestyleshading;
					var ifcsurfacestylelighting = member as IfcSurfaceStyleLighting;
					if (ifcsurfacestylelighting != null) 
						yield return ifcsurfacestylelighting;
					var ifcsurfacestylewithtextures = member as IfcSurfaceStyleWithTextures;
					if (ifcsurfacestylewithtextures != null) 
						yield return ifcsurfacestylewithtextures;
					var ifcexternallydefinedsurfacestyle = member as IfcExternallyDefinedSurfaceStyle;
					if (ifcexternallydefinedsurfacestyle != null) 
						yield return ifcexternallydefinedsurfacestyle;
					var ifcsurfacestylerefraction = member as IfcSurfaceStyleRefraction;
					if (ifcsurfacestylerefraction != null) 
						yield return ifcsurfacestylerefraction;
				}
			} 
		}
	//## Custom code
        public new IEnumerable<IIfcSurfaceStyle> SurfaceStyles { get { return new[] {this}; } }
	//##
	}
}