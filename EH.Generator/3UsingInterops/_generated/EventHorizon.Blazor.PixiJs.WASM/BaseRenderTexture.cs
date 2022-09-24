/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BaseRenderTexture>))]
public class BaseRenderTexture : BaseTexture
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
        
        public decimal[] clearColor
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "clearColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
            }
        }

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

        
        public MaskData[] maskStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<MaskData>(
                    this.___guid,
                    "maskStack",
                    (entity) =>
                    {
                        return new MaskData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maskStack",
                    value
                );
            }
        }

        
        public CachedEntity[] filterStack
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "filterStack",
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
                    "filterStack",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BaseRenderTexture() : base() { }

        public BaseRenderTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseRenderTexture(
            IBaseTextureOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BaseRenderTexture" },
                options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void resize(decimal desiredWidth, decimal desiredHeight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, desiredWidth, desiredHeight
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
