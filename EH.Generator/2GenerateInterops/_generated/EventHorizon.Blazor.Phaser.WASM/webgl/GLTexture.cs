/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<GLTexture>))]
    public class GLTexture : Texture, Disposable, Restorable
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

        #endregion
        
        #region Constructor
        public GLTexture() : base() { }

        public GLTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GLTexture(
            ManagedWebGLRenderingContext context, HTMLImageElement image, System.Nullable<bool> useMipMaps = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "GLTexture" },
                context, image, useMipMaps
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setFilters(int minFilter, int magFilter)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFilters" }, minFilter, magFilter
                }
            );
        }

        public void setWraps(int uWrap, int vWrap)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setWraps" }, uWrap, vWrap
                }
            );
        }

        public void update(bool useMipMaps)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, useMipMaps
                }
            );
        }

        public void restore()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "restore" }
                }
            );
        }

        public void bind(System.Nullable<decimal> unit = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, unit
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }
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
}