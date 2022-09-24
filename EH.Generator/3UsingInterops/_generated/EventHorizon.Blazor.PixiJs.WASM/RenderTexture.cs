/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RenderTexture>))]
public class RenderTexture : Texture
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static RenderTexture create(decimal width, decimal height, System.Nullable<int> scaleMode = null, System.Nullable<decimal> resolution = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "RenderTexture", "create" }, width, height, scaleMode, resolution
                }
            );
        }
    #endregion

    #region Accessors
        private Framebuffer __framebuffer;
        public Framebuffer framebuffer
        {
            get
            {
            if(__framebuffer == null)
            {
                __framebuffer = EventHorizonBlazorInterop.GetClass<Framebuffer>(
                    this.___guid,
                    "framebuffer",
                    (entity) =>
                    {
                        return new Framebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __framebuffer;
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
    #endregion

    #region Properties
        private BaseRenderTexture __baseTexture;
        public BaseRenderTexture baseTexture
        {
            get
            {
            if(__baseTexture == null)
            {
                __baseTexture = EventHorizonBlazorInterop.GetClass<BaseRenderTexture>(
                    this.___guid,
                    "baseTexture",
                    (entity) =>
                    {
                        return new BaseRenderTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseTexture;
            }
            set
            {
__baseTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseTexture",
                    value
                );
            }
        }

        private Rectangle __filterFrame;
        public Rectangle filterFrame
        {
            get
            {
            if(__filterFrame == null)
            {
                __filterFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "filterFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __filterFrame;
            }
            set
            {
__filterFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filterFrame",
                    value
                );
            }
        }

        
        public string filterPoolKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "filterPoolKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filterPoolKey",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public RenderTexture() : base() { }

        public RenderTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RenderTexture(
            BaseRenderTexture baseRenderTexture, Rectangle frame = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RenderTexture" },
                baseRenderTexture, frame
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void resize(decimal desiredWidth, decimal desiredHeight, System.Nullable<bool> resizeBaseTexture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, desiredWidth, desiredHeight, resizeBaseTexture
                }
            );
        }

        public void setResolution(decimal resolution)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setResolution" }, resolution
                }
            );
        }
    #endregion
}
