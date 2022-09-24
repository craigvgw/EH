/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CubeCamera>))]
public class CubeCamera : Object3D
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private WebGLCubeRenderTarget __renderTarget;
        public WebGLCubeRenderTarget renderTarget
        {
            get
            {
            if(__renderTarget == null)
            {
                __renderTarget = EventHorizonBlazorInterop.GetClass<WebGLCubeRenderTarget>(
                    this.___guid,
                    "renderTarget",
                    (entity) =>
                    {
                        return new WebGLCubeRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTarget;
            }
            set
            {
__renderTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTarget",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CubeCamera() : base() { }

        public CubeCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CubeCamera(
            decimal near, decimal far, WebGLCubeRenderTarget renderTarget
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CubeCamera" },
                near, far, renderTarget
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(WebGLRenderer renderer, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, renderer, scene
                }
            );
        }
    #endregion
}
