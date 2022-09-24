/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGL3DRenderTarget>))]
public class WebGL3DRenderTarget : WebGLRenderTarget
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
        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        private Data3DTexture __texture;
        public Data3DTexture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Data3DTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Data3DTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public unknown isWebGL3DRenderTarget
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isWebGL3DRenderTarget"
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGL3DRenderTarget() : base() { }

        public WebGL3DRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGL3DRenderTarget(
            decimal width, decimal height, decimal depth
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGL3DRenderTarget" },
                width, height, depth
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
