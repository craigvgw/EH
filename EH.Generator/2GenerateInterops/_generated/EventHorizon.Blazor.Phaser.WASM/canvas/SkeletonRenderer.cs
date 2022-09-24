/// Generated - Do Not Edit
namespace spine.canvas
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonRenderer>))]
    public class SkeletonRenderer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal[] QUAD_TRIANGLES
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    "spine",
                    "canvas.SkeletonRenderer.QUAD_TRIANGLES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "canvas.SkeletonRenderer.QUAD_TRIANGLES",
                    value
                );
            }
        }

        
        public static decimal VERTEX_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "canvas.SkeletonRenderer.VERTEX_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "canvas.SkeletonRenderer.VERTEX_SIZE",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public bool triangleRendering
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "triangleRendering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "triangleRendering",
                    value
                );
            }
        }

        
        public bool debugRendering
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "debugRendering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debugRendering",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkeletonRenderer() : base() { }

        public SkeletonRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SkeletonRenderer(
            CanvasRenderingContext2D context
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "canvas", "SkeletonRenderer" },
                context
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void draw(Skeleton skeleton)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "draw" }, skeleton
                }
            );
        }
        #endregion
    }
}