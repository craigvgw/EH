/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLGeometries>))]
public class WebGLGeometries : CachedEntityObject
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
        public WebGLGeometries() : base() { }

        public WebGLGeometries(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLGeometries(
            WebGLRenderingContext gl, WebGLAttributes attributes, WebGLInfo info
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLGeometries" },
                gl, attributes, info
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public BufferGeometry get(Object3D @object, BufferGeometry geometry)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, @object, geometry
                }
            );
        }

        public void update(BufferGeometry geometry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, geometry
                }
            );
        }

        public BufferAttribute getWireframeAttribute(BufferGeometry geometry)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWireframeAttribute" }, geometry
                }
            );
        }
    #endregion
}
