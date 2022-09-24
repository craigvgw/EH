/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLArrayRenderTarget>))]
public class WebGLArrayRenderTarget : WebGLRenderTarget
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

        private DataArrayTexture __texture;
        public DataArrayTexture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<DataArrayTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new DataArrayTexture() { ___guid = entity.___guid };
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

        
        public unknown isWebGLArrayRenderTarget
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isWebGLArrayRenderTarget"
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLArrayRenderTarget() : base() { }

        public WebGLArrayRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLArrayRenderTarget(
            decimal width, decimal height, decimal depth
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLArrayRenderTarget" },
                width, height, depth
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
