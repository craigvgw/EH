/// Generated - Do Not Edit
namespace Phaser.Display.Masks
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<BitmapMask>))]
    public class BitmapMask : CachedEntityObject
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
        private CanvasRenderer __renderer;
        public CanvasRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<CanvasRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new CanvasRenderer() { ___guid = entity.___guid };
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

        private GameObject __bitmapMask;
        public GameObject bitmapMask
        {
            get
            {
            if(__bitmapMask == null)
            {
                __bitmapMask = EventHorizonBlazorInterop.GetClass<GameObject>(
                    this.___guid,
                    "bitmapMask",
                    (entity) =>
                    {
                        return new GameObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __bitmapMask;
            }
            set
            {
__bitmapMask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bitmapMask",
                    value
                );
            }
        }

        private WebGLTexture __maskTexture;
        public WebGLTexture maskTexture
        {
            get
            {
            if(__maskTexture == null)
            {
                __maskTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "maskTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskTexture;
            }
            set
            {
__maskTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskTexture",
                    value
                );
            }
        }

        private WebGLTexture __mainTexture;
        public WebGLTexture mainTexture
        {
            get
            {
            if(__mainTexture == null)
            {
                __mainTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "mainTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __mainTexture;
            }
            set
            {
__mainTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mainTexture",
                    value
                );
            }
        }

        
        public bool dirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirty",
                    value
                );
            }
        }

        private WebGLFramebuffer __mainFramebuffer;
        public WebGLFramebuffer mainFramebuffer
        {
            get
            {
            if(__mainFramebuffer == null)
            {
                __mainFramebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "mainFramebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __mainFramebuffer;
            }
            set
            {
__mainFramebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mainFramebuffer",
                    value
                );
            }
        }

        private WebGLFramebuffer __maskFramebuffer;
        public WebGLFramebuffer maskFramebuffer
        {
            get
            {
            if(__maskFramebuffer == null)
            {
                __maskFramebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "maskFramebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __maskFramebuffer;
            }
            set
            {
__maskFramebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskFramebuffer",
                    value
                );
            }
        }

        
        public bool invertAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertAlpha",
                    value
                );
            }
        }

        
        public bool isStencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStencil"
                );
            }
        }
        #endregion
        
        #region Constructor
        public BitmapMask() : base() { }

        public BitmapMask(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BitmapMask(
            Scene scene, GameObject renderable
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Display", "Masks", "BitmapMask" },
                scene, renderable
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void createMask()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createMask" }
                }
            );
        }

        public void clearMask()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }
                }
            );
        }

        public void setBitmap(GameObject renderable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBitmap" }, renderable
                }
            );
        }

        public void preRenderWebGL(CanvasRenderer renderer, GameObject maskedObject, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRenderWebGL" }, renderer, maskedObject, camera
                }
            );
        }

        public void postRenderWebGL(CanvasRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRenderWebGL" }, renderer
                }
            );
        }

        public void preRenderCanvas(CanvasRenderer renderer, GameObject mask, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preRenderCanvas" }, renderer, mask, camera
                }
            );
        }

        public void postRenderCanvas(CanvasRenderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postRenderCanvas" }, renderer
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}