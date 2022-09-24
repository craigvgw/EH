/// Generated - Do Not Edit
namespace Phaser.Tilemaps
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Tileset>))]
    public class Tileset : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal firstgid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "firstgid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "firstgid",
                    value
                );
            }
        }

        
        public decimal tileWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tileWidth"
                );
            }
        }

        
        public decimal tileHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tileHeight"
                );
            }
        }

        
        public decimal tileMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tileMargin"
                );
            }
        }

        
        public decimal tileSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tileSpacing"
                );
            }
        }

        
        public CachedEntity tileProperties
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "tileProperties"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileProperties",
                    value
                );
            }
        }

        
        public CachedEntity tileData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "tileData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileData",
                    value
                );
            }
        }

        private Texture __image;
        public Texture image
        {
            get
            {
            if(__image == null)
            {
                __image = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "image",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __image;
            }
        }

        private WebGLTexture __glTexture;
        public WebGLTexture glTexture
        {
            get
            {
            if(__glTexture == null)
            {
                __glTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "glTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __glTexture;
            }
        }

        
        public decimal rows
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rows"
                );
            }
        }

        
        public decimal columns
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "columns"
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
        }

        
        public CachedEntity[] texCoordinates
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "texCoordinates"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Tileset() : base() { }

        public Tileset(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Tileset(
            string name, decimal firstgid, System.Nullable<decimal> tileWidth = null, System.Nullable<decimal> tileHeight = null, System.Nullable<decimal> tileMargin = null, System.Nullable<decimal> tileSpacing = null, object tileProperties = null, object tileData = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tilemaps", "Tileset" },
                name, firstgid, tileWidth, tileHeight, tileMargin, tileSpacing, tileProperties, tileData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity getTileProperties(decimal tileIndex)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTileProperties" }, tileIndex
                }
            );
        }

        public CachedEntity getTileData(decimal tileIndex)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTileData" }, tileIndex
                }
            );
        }

        public CachedEntity getTileCollisionGroup(decimal tileIndex)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTileCollisionGroup" }, tileIndex
                }
            );
        }

        public bool containsTileIndex(decimal tileIndex)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsTileIndex" }, tileIndex
                }
            );
        }

        public CachedEntity getTileTextureCoordinates(decimal tileIndex)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTileTextureCoordinates" }, tileIndex
                }
            );
        }

        public Tileset setImage(Texture texture)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setImage" }, texture
                }
            );
        }

        public Tileset setTileSize(System.Nullable<decimal> tileWidth = null, System.Nullable<decimal> tileHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTileSize" }, tileWidth, tileHeight
                }
            );
        }

        public Tileset setSpacing(System.Nullable<decimal> margin = null, System.Nullable<decimal> spacing = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSpacing" }, margin, spacing
                }
            );
        }

        public Tileset updateTileData(decimal imageWidth, decimal imageHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateTileData" }, imageWidth, imageHeight
                }
            );
        }
        #endregion
    }
}