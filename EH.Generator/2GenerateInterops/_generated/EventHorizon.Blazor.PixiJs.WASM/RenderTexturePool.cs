/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<RenderTexturePool>))]
public class RenderTexturePool : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static decimal SCREEN_KEY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "RenderTexturePool",
                    "SCREEN_KEY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "RenderTexturePool",
                    "SCREEN_KEY",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        private IBaseTextureOptionsCachedEntity __textureOptions;
        public IBaseTextureOptionsCachedEntity textureOptions
        {
            get
            {
            if(__textureOptions == null)
            {
                __textureOptions = EventHorizonBlazorInterop.GetClass<IBaseTextureOptionsCachedEntity>(
                    this.___guid,
                    "textureOptions",
                    (entity) =>
                    {
                        return new IBaseTextureOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureOptions;
            }
            set
            {
__textureOptions = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureOptions",
                    value
                );
            }
        }

        
        public bool enableFullScreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableFullScreen"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableFullScreen",
                    value
                );
            }
        }

        
        public string texturePool
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "texturePool"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturePool",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public RenderTexturePool() : base() { }

        public RenderTexturePool(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RenderTexturePool(
            IBaseTextureOptions textureOptions = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "RenderTexturePool" },
                textureOptions
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public RenderTexture createTexture(decimal realWidth, decimal realHeight, System.Nullable<int> multisample = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTexture" }, realWidth, realHeight, multisample
                }
            );
        }

        public RenderTexture getOptimalTexture(decimal minWidth, decimal minHeight, System.Nullable<decimal> resolution = null, System.Nullable<int> multisample = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getOptimalTexture" }, minWidth, minHeight, resolution, multisample
                }
            );
        }

        public RenderTexture getFilterTexture(RenderTexture input, System.Nullable<decimal> resolution = null, System.Nullable<int> multisample = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFilterTexture" }, input, resolution, multisample
                }
            );
        }

        public void returnTexture(RenderTexture renderTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "returnTexture" }, renderTexture
                }
            );
        }

        public void returnFilterTexture(RenderTexture renderTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "returnFilterTexture" }, renderTexture
                }
            );
        }

        public void clear(System.Nullable<bool> destroyTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, destroyTextures
                }
            );
        }

        public void setScreenSize(ISize size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScreenSize" }, size
                }
            );
        }
    #endregion
}
