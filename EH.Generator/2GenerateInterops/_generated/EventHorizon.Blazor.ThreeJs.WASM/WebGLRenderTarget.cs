/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLRenderTarget>))]
public class WebGLRenderTarget : EventDispatcher
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
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
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

        private Vector4 __scissor;
        public Vector4 scissor
        {
            get
            {
            if(__scissor == null)
            {
                __scissor = EventHorizonBlazorInterop.GetClass<Vector4>(
                    this.___guid,
                    "scissor",
                    (entity) =>
                    {
                        return new Vector4() { ___guid = entity.___guid };
                    }
                );
            }
            return __scissor;
            }
            set
            {
__scissor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scissor",
                    value
                );
            }
        }

        
        public bool scissorTest
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "scissorTest"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scissorTest",
                    value
                );
            }
        }

        private Vector4 __viewport;
        public Vector4 viewport
        {
            get
            {
            if(__viewport == null)
            {
                __viewport = EventHorizonBlazorInterop.GetClass<Vector4>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new Vector4() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewport;
            }
            set
            {
__viewport = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewport",
                    value
                );
            }
        }

        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
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

        
        public bool depthBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthBuffer",
                    value
                );
            }
        }

        
        public bool stencilBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencilBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilBuffer",
                    value
                );
            }
        }

        private DepthTexture __depthTexture;
        public DepthTexture depthTexture
        {
            get
            {
            if(__depthTexture == null)
            {
                __depthTexture = EventHorizonBlazorInterop.GetClass<DepthTexture>(
                    this.___guid,
                    "depthTexture",
                    (entity) =>
                    {
                        return new DepthTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __depthTexture;
            }
            set
            {
__depthTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthTexture",
                    value
                );
            }
        }

        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }

        
        public unknown isWebGLRenderTarget
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isWebGLRenderTarget"
                );
            }
        }

        
        public CachedEntity wrapS
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "wrapS",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapS",
                    value
                );
            }
        }

        
        public CachedEntity wrapT
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "wrapT",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapT",
                    value
                );
            }
        }

        
        public CachedEntity magFilter
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "magFilter",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "magFilter",
                    value
                );
            }
        }

        
        public CachedEntity minFilter
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "minFilter",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minFilter",
                    value
                );
            }
        }

        
        public CachedEntity anisotropy
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "anisotropy",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropy",
                    value
                );
            }
        }

        
        public CachedEntity offset
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "offset",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }

        
        public CachedEntity repeat
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "repeat",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeat",
                    value
                );
            }
        }

        
        public CachedEntity format
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "format",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }

        
        public CachedEntity type
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
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

        
        public CachedEntity generateMipmaps
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "generateMipmaps",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateMipmaps",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLRenderTarget() : base() { }

        public WebGLRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLRenderTarget(
            decimal width, decimal height, WebGLRenderTargetOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLRenderTarget" },
                width, height, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setSize(decimal width, decimal height, System.Nullable<decimal> depth = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, depth
                }
            );
        }

        public WebGLRenderTarget clone()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public WebGLRenderTarget copy(WebGLRenderTarget source)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
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
