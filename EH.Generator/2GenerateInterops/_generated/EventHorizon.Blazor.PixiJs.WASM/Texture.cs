/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Texture<CachedEntity>>))]
public class Texture<R> : CachedEntityObject where R : CachedEntity, new()
{
    #region Static Accessors
        private static Texture<Resource> __EMPTY;
        public static Texture<Resource> EMPTY
        {
            get
            {
            if(__EMPTY == null)
            {
                __EMPTY = EventHorizonBlazorInterop.GetClass<Texture<Resource>>(
                    "Texture",
                    "EMPTY",
                    (entity) =>
                    {
                        return new Texture<Resource>() { ___guid = entity.___guid };
                    }
                );
            }
            return __EMPTY;
            }
        }

        private static Texture<CanvasResource> __WHITE;
        public static Texture<CanvasResource> WHITE
        {
            get
            {
            if(__WHITE == null)
            {
                __WHITE = EventHorizonBlazorInterop.GetClass<Texture<CanvasResource>>(
                    "Texture",
                    "WHITE",
                    (entity) =>
                    {
                        return new Texture<CanvasResource>() { ___guid = entity.___guid };
                    }
                );
            }
            return __WHITE;
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Texture<R> from<R, RO>(string source, IBaseTextureOptions<RO> options = null, System.Nullable<bool> strict = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture<R>>(
                entity => new Texture<R>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Texture", "from" }, source, options, strict
                }
            );
        }

        public static ValueTask<Texture<R>> fromURL<R, RO>(string url, IBaseTextureOptions<RO> options = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Texture<R>>(
                entity => new Texture<R>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Texture", "fromURL" }, url, options
                }
            );
        }

        public static Texture<BufferResource> fromBuffer(decimal[] buffer, decimal width, decimal height, IBaseTextureOptions<ISize> options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture<BufferResource>>(
                entity => new Texture<BufferResource>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Texture", "fromBuffer" }, buffer, width, height, options
                }
            );
        }

        public static ValueTask<Texture<R>> fromLoader<R>(HTMLImageElement source, string imageUrl, string name = null, IBaseTextureOptions options = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Texture<R>>(
                entity => new Texture<R>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Texture", "fromLoader" }, source, imageUrl, name, options
                }
            );
        }

        public static void addToCache(Texture texture, string id)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Texture", "addToCache" }, texture, id
                }
            );
        }

        public static Texture removeFromCache(string texture)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Texture", "removeFromCache" }, texture
                }
            );
        }
    #endregion

    #region Accessors
        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
        }

        private Rectangle __frame;
        public Rectangle frame
        {
            get
            {
            if(__frame == null)
            {
                __frame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __frame;
            }
            set
            {
__frame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public decimal rotate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotate",
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
    #endregion

    #region Properties
        private BaseTexture<R> __baseTexture;
        public BaseTexture<R> baseTexture
        {
            get
            {
            if(__baseTexture == null)
            {
                __baseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture<R>>(
                    this.___guid,
                    "baseTexture",
                    (entity) =>
                    {
                        return new BaseTexture<R>() { ___guid = entity.___guid };
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

        private Rectangle __orig;
        public Rectangle orig
        {
            get
            {
            if(__orig == null)
            {
                __orig = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "orig",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __orig;
            }
            set
            {
__orig = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orig",
                    value
                );
            }
        }

        private Rectangle __trim;
        public Rectangle trim
        {
            get
            {
            if(__trim == null)
            {
                __trim = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "trim",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __trim;
            }
            set
            {
__trim = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trim",
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

        
        public bool noFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noFrame",
                    value
                );
            }
        }

        private Point __defaultAnchor;
        public Point defaultAnchor
        {
            get
            {
            if(__defaultAnchor == null)
            {
                __defaultAnchor = EventHorizonBlazorInterop.GetClass<Point>(
                    this.___guid,
                    "defaultAnchor",
                    (entity) =>
                    {
                        return new Point() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultAnchor;
            }
            set
            {
__defaultAnchor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultAnchor",
                    value
                );
            }
        }

        private TextureMatrix __uvMatrix;
        public TextureMatrix uvMatrix
        {
            get
            {
            if(__uvMatrix == null)
            {
                __uvMatrix = EventHorizonBlazorInterop.GetClass<TextureMatrix>(
                    this.___guid,
                    "uvMatrix",
                    (entity) =>
                    {
                        return new TextureMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvMatrix;
            }
            set
            {
__uvMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvMatrix",
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
    #endregion
    
    #region Constructor
        public Texture() : base() { }

        public Texture(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Texture(
            BaseTexture<R> baseTexture, Rectangle frame = null, Rectangle orig = null, Rectangle trim = null, System.Nullable<decimal> rotate = null, IPointData anchor = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Texture" },
                baseTexture, frame, orig, trim, rotate, anchor
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void onBaseTextureUpdated(BaseTexture baseTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBaseTextureUpdated" }, baseTexture
                }
            );
        }

        public void destroy(System.Nullable<bool> destroyBase = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, destroyBase
                }
            );
        }

        public Texture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void updateUvs()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUvs" }
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
