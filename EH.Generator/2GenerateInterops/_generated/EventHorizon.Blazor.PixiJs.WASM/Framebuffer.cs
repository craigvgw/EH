/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Framebuffer>))]
public class Framebuffer : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private BaseTexture __colorTexture;
        public BaseTexture colorTexture
        {
            get
            {
            if(__colorTexture == null)
            {
                __colorTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "colorTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorTexture;
            }
        }
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

        
        public bool stencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencil"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
                    value
                );
            }
        }

        
        public bool depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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

        private BaseTexture __depthTexture;
        public BaseTexture depthTexture
        {
            get
            {
            if(__depthTexture == null)
            {
                __depthTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "depthTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
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

        
        public BaseTexture[] colorTextures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "colorTextures",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorTextures",
                    value
                );
            }
        }

        
        public CachedEntity glFramebuffers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "glFramebuffers",
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
                    "glFramebuffers",
                    value
                );
            }
        }

        private Runner __disposeRunner;
        public Runner disposeRunner
        {
            get
            {
            if(__disposeRunner == null)
            {
                __disposeRunner = EventHorizonBlazorInterop.GetClass<Runner>(
                    this.___guid,
                    "disposeRunner",
                    (entity) =>
                    {
                        return new Runner() { ___guid = entity.___guid };
                    }
                );
            }
            return __disposeRunner;
            }
            set
            {
__disposeRunner = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeRunner",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Framebuffer() : base() { }

        public Framebuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Framebuffer(
            decimal width, decimal height
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Framebuffer" },
                width, height
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Framebuffer addColorTexture(System.Nullable<decimal> index = null, BaseTexture texture = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Framebuffer>(
                entity => new Framebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addColorTexture" }, index, texture
                }
            );
        }

        public Framebuffer addDepthTexture(BaseTexture texture = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Framebuffer>(
                entity => new Framebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addDepthTexture" }, texture
                }
            );
        }

        public Framebuffer enableDepth()
        {
            return EventHorizonBlazorInterop.FuncClass<Framebuffer>(
                entity => new Framebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableDepth" }
                }
            );
        }

        public Framebuffer enableStencil()
        {
            return EventHorizonBlazorInterop.FuncClass<Framebuffer>(
                entity => new Framebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableStencil" }
                }
            );
        }

        public void resize(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, width, height
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

        public void destroyDepthTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroyDepthTexture" }
                }
            );
        }
    #endregion
}
