/// Generated - Do Not Edit
namespace Phaser.Renderer.WebGL
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RenderTarget>))]
    public class RenderTarget : CachedEntityObject
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
        private WebGLRenderer __renderer;
        public WebGLRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<WebGLRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new WebGLRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }

        private WebGLFramebuffer __framebuffer;
        public WebGLFramebuffer framebuffer
        {
            get
            {
            if(__framebuffer == null)
            {
                __framebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "framebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __framebuffer;
            }
            set
            {
__framebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framebuffer",
                    value
                );
            }
        }

        private WebGLTexture __texture;
        public WebGLTexture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
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

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
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
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal minFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minFilter"
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

        
        public bool autoClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
            }
        }

        
        public bool autoResize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoResize"
                );
            }
        }

        
        public CachedEntity unbind
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "unbind",
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
                    "unbind",
                    value
                );
            }
        }

        
        public CachedEntity destroy
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "destroy",
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
                    "destroy",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RenderTarget() : base() { }

        public RenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RenderTarget(
            WebGLRenderer renderer, decimal width, decimal height, System.Nullable<decimal> scale = null, System.Nullable<decimal> minFilter = null, System.Nullable<bool> autoClear = null, System.Nullable<bool> autoResize = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Renderer", "WebGL", "RenderTarget" },
                renderer, width, height, scale, minFilter, autoClear, autoResize
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public RenderTarget setAutoResize(bool autoResize)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTarget>(
                entity => new RenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAutoResize" }, autoResize
                }
            );
        }

        public RenderTarget resize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTarget>(
                entity => new RenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
                }
            );
        }

        public void bind(System.Nullable<bool> adjustViewport = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, adjustViewport, width, height
                }
            );
        }

        public void adjustViewport()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "adjustViewport" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
        #endregion
    }
}