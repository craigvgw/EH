/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<FramebufferSystem>))]
public class FramebufferSystem : CachedEntityObject, ISystem
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public CachedEntity size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "size"
                );
            }
        }
    #endregion

    #region Properties
        
        public Framebuffer[] managedFramebuffers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Framebuffer>(
                    this.___guid,
                    "managedFramebuffers",
                    (entity) =>
                    {
                        return new Framebuffer() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private Framebuffer __current;
        public Framebuffer current
        {
            get
            {
            if(__current == null)
            {
                __current = EventHorizonBlazorInterop.GetClass<Framebuffer>(
                    this.___guid,
                    "current",
                    (entity) =>
                    {
                        return new Framebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __current;
            }
            set
            {
__current = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "current",
                    value
                );
            }
        }

        private Rectangle __viewport;
        public Rectangle viewport
        {
            get
            {
            if(__viewport == null)
            {
                __viewport = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
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

        
        public bool hasMRT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasMRT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasMRT",
                    value
                );
            }
        }

        
        public bool writeDepthTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "writeDepthTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "writeDepthTexture",
                    value
                );
            }
        }

        private Renderer __renderer;
        public Renderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<Renderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new Renderer() { ___guid = entity.___guid };
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
    #endregion
    
    #region Constructor
        public FramebufferSystem() : base() { }

        public FramebufferSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FramebufferSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "FramebufferSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void bind(Framebuffer framebuffer = null, Rectangle frame = null, System.Nullable<decimal> mipLevel = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, framebuffer, frame, mipLevel
                }
            );
        }

        public void setViewport(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" }, x, y, width, height
                }
            );
        }

        public void clear(decimal r, decimal g, decimal b, decimal a, System.Nullable<int> mask = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, r, g, b, a, mask
                }
            );
        }

        public GLFramebuffer initFramebuffer(Framebuffer framebuffer)
        {
            return EventHorizonBlazorInterop.FuncClass<GLFramebuffer>(
                entity => new GLFramebuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "initFramebuffer" }, framebuffer
                }
            );
        }

        public void resizeFramebuffer(Framebuffer framebuffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resizeFramebuffer" }, framebuffer
                }
            );
        }

        public void updateFramebuffer(Framebuffer framebuffer, decimal mipLevel)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateFramebuffer" }, framebuffer, mipLevel
                }
            );
        }

        public void blit(Framebuffer framebuffer = null, Rectangle sourcePixels = null, Rectangle destPixels = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "blit" }, framebuffer, sourcePixels, destPixels
                }
            );
        }

        public void disposeFramebuffer(Framebuffer framebuffer, System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeFramebuffer" }, framebuffer, contextLost
                }
            );
        }

        public void disposeAll(System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeAll" }, contextLost
                }
            );
        }

        public void forceStencil()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceStencil" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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
