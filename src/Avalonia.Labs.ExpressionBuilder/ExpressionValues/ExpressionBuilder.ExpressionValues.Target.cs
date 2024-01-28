///---------------------------------------------------------------------------------------------------------------------
/// <copyright company="Microsoft">
///     Copyright (c) Microsoft Corporation.  All rights reserved.
/// </copyright>
///---------------------------------------------------------------------------------------------------------------------

namespace Avalonia.Labs.ExpressionBuilder
{
    ///---------------------------------------------------------------------------------------------------------------------
    /// 
    /// class ExpressionValues.Target
    ///    ToDo: Add description after docs written
    /// 
    ///---------------------------------------------------------------------------------------------------------------------

    // ExpressionValues is a static class instead of a namespace to improve intellisense discoverablity and consistency with the other helper classes.
    public static partial class ExpressionValues
    {        
        /// <summary> Create a reference to the CompositionObject this expression will be connected to. </summary>
        public static class Target
        {
#if AVALONIA_COMPOSITION_TODO
            /// <summary> Create a reference to the AmbientLight target that this expression will be connected to. </summary>
            public static AmbientLightReferenceNode       CreateAmbientLightTarget()       { return AmbientLightReferenceNode.CreateTargetReference();        }
            
            /// <summary> Create a reference to the ColorBrush target that this expression will be connected to. </summary>
            public static ColorBrushReferenceNode         CreateColorBrushTarget()         { return ColorBrushReferenceNode.CreateTargetReference();          }
            
            /// <summary> Create a reference to the DistantLight target that this expression will be connected to. </summary>
            public static DistantLightReferenceNode       CreateDistantLightTarget()       { return DistantLightReferenceNode.CreateTargetReference();        }
            
            /// <summary> Create a reference to the DropShadow target that this expression will be connected to. </summary>
            public static DropShadowReferenceNode         CreateDropShadowTarget()         { return DropShadowReferenceNode.CreateTargetReference();          }

            /// <summary> Create a reference to the InsetClip target that this expression will be connected to. </summary>
            public static InsetClipReferenceNode          CreateInsetClipTarget()          { return InsetClipReferenceNode.CreateTargetReference();           }
            
            /// <summary> Create a reference to the InteractionTracker target that this expression will be connected to. </summary>
            public static InteractionTrackerReferenceNode CreateInteractionTrackerTarget() { return InteractionTrackerReferenceNode.CreateTargetReference();  }
            
            /// <summary> Create a reference to the NineGridBrush target that this expression will be connected to. </summary>
            public static NineGridBrushReferenceNode      CreateNineGridBrushTarget()      { return NineGridBrushReferenceNode.CreateTargetReference();       }
            
            /// <summary> Create a reference to the PointLight target that this expression will be connected to. </summary>
            public static PointLightReferenceNode         CreatePointLightTarget()         { return PointLightReferenceNode.CreateTargetReference();          }
#endif
            /// <summary> Create a reference to the PropertySet target that this expression will be connected to. </summary>
            public static PropertySetReferenceNode        CreatePropertySetTarget()        { return PropertySetReferenceNode.CreateTargetReference();         }
#if AVALONIA_COMPOSITION_TODO
            /// <summary> Create a reference to the SpotLight target that this expression will be connected to. </summary>
            public static SpotLightReferenceNode          CreateSpotLightTarget()          { return SpotLightReferenceNode.CreateTargetReference();           }
#endif

            /// <summary> Create a reference to the SurfaceVisual target that this expression will be connected to. </summary>
            public static SurfaceVisualReferenceNode       CreateSurfaceVisualTarget()       { return SurfaceVisualReferenceNode.CreateTargetReference();        }

            /// <summary> Create a reference to the Visual target that this expression will be connected to. </summary>
            public static VisualReferenceNode             CreateVisualTarget()             { return VisualReferenceNode.CreateTargetReference();              }
        }
    }
}
