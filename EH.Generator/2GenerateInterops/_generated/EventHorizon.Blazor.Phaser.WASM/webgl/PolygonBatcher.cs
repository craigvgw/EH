/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PolygonBatcher>))]
    public class PolygonBatcher : CachedEntityObject, Disposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public PolygonBatcher() : base() { }

        public PolygonBatcher(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PolygonBatcher(
            ManagedWebGLRenderingContext context, System.Nullable<bool> twoColorTint = null, System.Nullable<decimal> maxVertices = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "PolygonBatcher" },
                context, twoColorTint, maxVertices
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void begin(Shader shader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "begin" }, shader
                }
            );
        }

        public void setBlendMode(decimal srcBlend, decimal dstBlend)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, srcBlend, dstBlend
                }
            );
        }

        public void draw(GLTexture texture, decimal[] vertices, decimal[] indices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "draw" }, texture, vertices, indices
                }
            );
        }

        public void end()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }
                }
            );
        }

        public decimal getDrawCalls()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDrawCalls" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}