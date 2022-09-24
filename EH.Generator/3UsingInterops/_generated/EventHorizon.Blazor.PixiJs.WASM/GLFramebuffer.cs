/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GLFramebuffer>))]
public class GLFramebuffer : CachedEntityObject
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

        private WebGLRenderbuffer __stencil;
        public WebGLRenderbuffer stencil
        {
            get
            {
            if(__stencil == null)
            {
                __stencil = EventHorizonBlazorInterop.GetClass<WebGLRenderbuffer>(
                    this.___guid,
                    "stencil",
                    (entity) =>
                    {
                        return new WebGLRenderbuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __stencil;
            }
            set
            {
__stencil = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
                    value
                );
            }
        }

        private WebGLRenderbuffer __msaaBuffer;
        public WebGLRenderbuffer msaaBuffer
        {
            get
            {
            if(__msaaBuffer == null)
            {
                __msaaBuffer = EventHorizonBlazorInterop.GetClass<WebGLRenderbuffer>(
                    this.___guid,
                    "msaaBuffer",
                    (entity) =>
                    {
                        return new WebGLRenderbuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __msaaBuffer;
            }
            set
            {
__msaaBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msaaBuffer",
                    value
                );
            }
        }

        private Framebuffer __blitFramebuffer;
        public Framebuffer blitFramebuffer
        {
            get
            {
            if(__blitFramebuffer == null)
            {
                __blitFramebuffer = EventHorizonBlazorInterop.GetClass<Framebuffer>(
                    this.___guid,
                    "blitFramebuffer",
                    (entity) =>
                    {
                        return new Framebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __blitFramebuffer;
            }
            set
            {
__blitFramebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blitFramebuffer",
                    value
                );
            }
        }

        
        public decimal dirtyId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dirtyId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirtyId",
                    value
                );
            }
        }

        
        public decimal dirtyFormat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dirtyFormat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirtyFormat",
                    value
                );
            }
        }

        
        public decimal dirtySize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dirtySize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirtySize",
                    value
                );
            }
        }

        
        public decimal mipLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mipLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mipLevel",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public GLFramebuffer() : base() { }

        public GLFramebuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GLFramebuffer(
            WebGLTexture framebuffer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GLFramebuffer" },
                framebuffer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
