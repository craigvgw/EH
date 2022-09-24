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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Tile>))]
    public class Tile : CachedEntityObject, IAlpha, IFlip, IVisible
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
        private LayerData __layer;
        public LayerData layer
        {
            get
            {
            if(__layer == null)
            {
                __layer = EventHorizonBlazorInterop.GetClass<LayerData>(
                    this.___guid,
                    "layer",
                    (entity) =>
                    {
                        return new LayerData() { ___guid = entity.___guid };
                    }
                );
            }
            return __layer;
            }
            set
            {
__layer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layer",
                    value
                );
            }
        }

        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
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

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "right",
                    value
                );
            }
        }

        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bottom",
                    value
                );
            }
        }

        
        public decimal baseWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baseWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseWidth",
                    value
                );
            }
        }

        
        public decimal baseHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baseHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseHeight",
                    value
                );
            }
        }

        
        public decimal pixelX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pixelX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pixelX",
                    value
                );
            }
        }

        
        public decimal pixelY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pixelY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pixelY",
                    value
                );
            }
        }

        
        public CachedEntity properties
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "properties",
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
                    "properties",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public bool collideLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideLeft",
                    value
                );
            }
        }

        
        public bool collideRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideRight",
                    value
                );
            }
        }

        
        public bool collideUp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideUp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideUp",
                    value
                );
            }
        }

        
        public bool collideDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collideDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collideDown",
                    value
                );
            }
        }

        
        public bool faceLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "faceLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceLeft",
                    value
                );
            }
        }

        
        public bool faceRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "faceRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceRight",
                    value
                );
            }
        }

        
        public bool faceTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "faceTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceTop",
                    value
                );
            }
        }

        
        public bool faceBottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "faceBottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceBottom",
                    value
                );
            }
        }

        
        public CachedEntity collisionCallbackContext
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "collisionCallbackContext"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionCallbackContext",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public CachedEntity physics
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "physics"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physics",
                    value
                );
            }
        }

        
        public bool canCollide
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canCollide"
                );
            }
        }

        
        public bool collides
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collides"
                );
            }
        }

        
        public bool hasInterestingFace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInterestingFace"
                );
            }
        }

        private Tileset __tileset;
        public Tileset tileset
        {
            get
            {
            if(__tileset == null)
            {
                __tileset = EventHorizonBlazorInterop.GetClass<Tileset>(
                    this.___guid,
                    "tileset",
                    (entity) =>
                    {
                        return new Tileset() { ___guid = entity.___guid };
                    }
                );
            }
            return __tileset;
            }
        }

        private TilemapLayer __tilemapLayer;
        public TilemapLayer tilemapLayer
        {
            get
            {
            if(__tilemapLayer == null)
            {
                __tilemapLayer = EventHorizonBlazorInterop.GetClass<TilemapLayer>(
                    this.___guid,
                    "tilemapLayer",
                    (entity) =>
                    {
                        return new TilemapLayer() { ___guid = entity.___guid };
                    }
                );
            }
            return __tilemapLayer;
            }
        }

        private Tilemap __tilemap;
        public Tilemap tilemap
        {
            get
            {
            if(__tilemap == null)
            {
                __tilemap = EventHorizonBlazorInterop.GetClass<Tilemap>(
                    this.___guid,
                    "tilemap",
                    (entity) =>
                    {
                        return new Tilemap() { ___guid = entity.___guid };
                    }
                );
            }
            return __tilemap;
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal alphaTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopLeft",
                    value
                );
            }
        }

        
        public decimal alphaTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTopRight",
                    value
                );
            }
        }

        
        public decimal alphaBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomLeft",
                    value
                );
            }
        }

        
        public decimal alphaBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBottomRight",
                    value
                );
            }
        }

        
        public bool flipX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipX",
                    value
                );
            }
        }

        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Tile() : base() { }

        public Tile(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Tile(
            LayerData layer, decimal index, decimal x, decimal y, decimal width, decimal height, decimal baseWidth, decimal baseHeight
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tilemaps", "Tile" },
                layer, index, x, y, width, height, baseWidth, baseHeight
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void collisionCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "collisionCallback" }
                }
            );
        }

        public bool containsPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, x, y
                }
            );
        }

        public Tile copy(Tile tile)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, tile
                }
            );
        }

        public CachedEntity getCollisionGroup()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getCollisionGroup" }
                }
            );
        }

        public CachedEntity getTileData()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTileData" }
                }
            );
        }

        public decimal getLeft(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLeft" }, camera
                }
            );
        }

        public decimal getRight(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRight" }, camera
                }
            );
        }

        public decimal getTop(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTop" }, camera
                }
            );
        }

        public decimal getBottom(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBottom" }, camera
                }
            );
        }

        public Rectangle getBounds(Camera camera = null, Rectangle output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, camera, output
                }
            );
        }

        public decimal getCenterX(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCenterX" }, camera
                }
            );
        }

        public decimal getCenterY(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCenterY" }, camera
                }
            );
        }

        public bool intersects(decimal x, decimal y, decimal right, decimal bottom)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersects" }, x, y, right, bottom
                }
            );
        }

        public bool isInteresting(bool collides, bool faces)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isInteresting" }, collides, faces
                }
            );
        }

        public Tile resetCollision(System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetCollision" }, recalculateFaces
                }
            );
        }

        public Tile resetFaces()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFaces" }
                }
            );
        }

        public Tile setCollision(bool left, System.Nullable<bool> right = null, System.Nullable<bool> up = null, System.Nullable<bool> down = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollision" }, left, right, up, down, recalculateFaces
                }
            );
        }

        public Tile setSize(decimal tileWidth, decimal tileHeight, decimal baseWidth, decimal baseHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, tileWidth, tileHeight, baseWidth, baseHeight
                }
            );
        }

        public Tile updatePixelXY()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updatePixelXY" }
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

        public Tile clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Tile setAlpha(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Tile toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public Tile toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public Tile setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public Tile setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public Tile setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public Tile resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public Tile setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }


        #endregion
    }
}