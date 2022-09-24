/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BaseTexture<CachedEntity>>))]
public class BaseTexture<R, RO> : CachedEntityObject where R : CachedEntity, new() where RO : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static BaseTexture<R> from<R, RO>(HTMLImageElement source, IBaseTextureOptions<RO> options = null, System.Nullable<bool> strict = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture<R>>(
                entity => new BaseTexture<R>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BaseTexture", "from" }, source, options, strict
                }
            );
        }

        public static BaseTexture<BufferResource> fromBuffer(decimal[] buffer, decimal width, decimal height, IBaseTextureOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture<BufferResource>>(
                entity => new BaseTexture<BufferResource>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BaseTexture", "fromBuffer" }, buffer, width, height, options
                }
            );
        }

        public static void addToCache(BaseTexture baseTexture, string id)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BaseTexture", "addToCache" }, baseTexture, id
                }
            );
        }

        public static BaseTexture removeFromCache(string baseTexture)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BaseTexture", "removeFromCache" }, baseTexture
                }
            );
        }
    #endregion

    #region Accessors
        
        public decimal realWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realWidth"
                );
            }
        }

        
        public decimal realHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realHeight"
                );
            }
        }

        
        public int mipmap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "mipmap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mipmap",
                    value
                );
            }
        }

        
        public int scaleMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "scaleMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
            }
        }

        
        public int wrapMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "wrapMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapMode",
                    value
                );
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

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }

        
        public int alphaMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "alphaMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaMode",
                    value
                );
            }
        }

        
        public decimal anisotropicLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "anisotropicLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropicLevel",
                    value
                );
            }
        }

        
        public int format
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "format"
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

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
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

        
        public int target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public decimal uid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uid"
                );
            }
        }

        
        public decimal touched
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "touched"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touched",
                    value
                );
            }
        }

        
        public bool isPowerOfTwo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPowerOfTwo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPowerOfTwo",
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

        
        public decimal dirtyStyleId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dirtyStyleId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirtyStyleId",
                    value
                );
            }
        }

        
        public string cacheId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cacheId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cacheId",
                    value
                );
            }
        }

        
        public bool valid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "valid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valid",
                    value
                );
            }
        }

        
        public string[] textureCacheIds
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "textureCacheIds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureCacheIds",
                    value
                );
            }
        }

        
        public bool destroyed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "destroyed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destroyed",
                    value
                );
            }
        }

        private R __resource;
        public R resource
        {
            get
            {
            if(__resource == null)
            {
                __resource = EventHorizonBlazorInterop.GetClass<R>(
                    this.___guid,
                    "resource",
                    (entity) =>
                    {
                        return new R() { ___guid = entity.___guid };
                    }
                );
            }
            return __resource;
            }
            set
            {
__resource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resource",
                    value
                );
            }
        }

        private BaseTexture __parentTextureArray;
        public BaseTexture parentTextureArray
        {
            get
            {
            if(__parentTextureArray == null)
            {
                __parentTextureArray = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "parentTextureArray",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentTextureArray;
            }
            set
            {
__parentTextureArray = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentTextureArray",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BaseTexture() : base() { }

        public BaseTexture(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BaseTexture(
            R resource = null, IBaseTextureOptions<RO> options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BaseTexture" },
                resource, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public BaseTexture setStyle(System.Nullable<int> scaleMode = null, System.Nullable<int> mipmap = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setStyle" }, scaleMode, mipmap
                }
            );
        }

        public BaseTexture setSize(decimal desiredWidth, decimal desiredHeight, System.Nullable<decimal> resolution = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, desiredWidth, desiredHeight, resolution
                }
            );
        }

        public BaseTexture setRealSize(decimal realWidth, decimal realHeight, System.Nullable<decimal> resolution = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRealSize" }, realWidth, realHeight, resolution
                }
            );
        }

        public BaseTexture setResolution(decimal resolution)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setResolution" }, resolution
                }
            );
        }

        public BaseTexture setResource(R resource)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setResource" }, resource
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void onError(ErrorEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onError" }, @event
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

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public BaseTexture castToBaseTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "castToBaseTexture" }
                }
            );
        }
    #endregion
}
