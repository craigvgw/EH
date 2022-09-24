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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TilemapLayer>))]
    public class TilemapLayer : GameObject, IAlpha, IBlendMode, IComputedSize, IDepth, IFlip, IGetBounds, IOrigin, IPipeline, IScrollFactor, ITransform, IVisible
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
        
        public bool isTilemap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTilemap"
                );
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
            set
            {
__tilemap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tilemap",
                    value
                );
            }
        }

        
        public decimal layerIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerIndex",
                    value
                );
            }
        }

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

        
        public Tileset[] tileset
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Tileset>(
                    this.___guid,
                    "tileset",
                    (entity) =>
                    {
                        return new Tileset() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileset",
                    value
                );
            }
        }

        
        public decimal tilesDrawn
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tilesDrawn"
                );
            }
        }

        
        public decimal tilesTotal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tilesTotal"
                );
            }
        }

        
        public Tile[] culledTiles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Tile>(
                    this.___guid,
                    "culledTiles",
                    (entity) =>
                    {
                        return new Tile() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "culledTiles",
                    value
                );
            }
        }

        
        public bool skipCull
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipCull"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipCull",
                    value
                );
            }
        }

        
        public decimal cullPaddingX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cullPaddingX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullPaddingX",
                    value
                );
            }
        }

        
        public decimal cullPaddingY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cullPaddingY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullPaddingY",
                    value
                );
            }
        }

        
        public Tileset[] gidMap
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Tileset>(
                    this.___guid,
                    "gidMap",
                    (entity) =>
                    {
                        return new Tileset() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gidMap",
                    value
                );
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

        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
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

        
        public decimal displayWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayWidth",
                    value
                );
            }
        }

        
        public decimal displayHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayHeight",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
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

        
        public decimal originX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originX",
                    value
                );
            }
        }

        
        public decimal originY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originY",
                    value
                );
            }
        }

        
        public decimal displayOriginX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginX",
                    value
                );
            }
        }

        
        public decimal displayOriginY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginY",
                    value
                );
            }
        }

        private WebGLPipeline __defaultPipeline;
        public WebGLPipeline defaultPipeline
        {
            get
            {
            if(__defaultPipeline == null)
            {
                __defaultPipeline = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "defaultPipeline",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultPipeline;
            }
            set
            {
__defaultPipeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultPipeline",
                    value
                );
            }
        }

        private WebGLPipeline __pipeline;
        public WebGLPipeline pipeline
        {
            get
            {
            if(__pipeline == null)
            {
                __pipeline = EventHorizonBlazorInterop.GetClass<WebGLPipeline>(
                    this.___guid,
                    "pipeline",
                    (entity) =>
                    {
                        return new WebGLPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            return __pipeline;
            }
            set
            {
__pipeline = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipeline",
                    value
                );
            }
        }

        
        public bool hasPostPipeline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPostPipeline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasPostPipeline",
                    value
                );
            }
        }

        
        public PostFXPipeline[] postPipelines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PostFXPipeline>(
                    this.___guid,
                    "postPipelines",
                    (entity) =>
                    {
                        return new PostFXPipeline() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postPipelines",
                    value
                );
            }
        }

        
        public CachedEntity pipelineData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "pipelineData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pipelineData",
                    value
                );
            }
        }

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
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

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal scaleX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        
        public decimal scaleY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleY",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
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
        public TilemapLayer() : base() { }

        public TilemapLayer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TilemapLayer(
            Scene scene, Tilemap tilemap, decimal layerIndex, string tileset, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tilemaps", "TilemapLayer" },
                scene, tilemap, layerIndex, tileset, x, y
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void cullCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cullCallback" }
                }
            );
        }

        public TilemapLayer setRenderOrder(decimal renderOrder)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRenderOrder" }, renderOrder
                }
            );
        }

        public TilemapLayer calculateFacesAt(decimal tileX, decimal tileY)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calculateFacesAt" }, tileX, tileY
                }
            );
        }

        public TilemapLayer calculateFacesWithin(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calculateFacesWithin" }, tileX, tileY, width, height
                }
            );
        }

        public Sprite[] createFromTiles(decimal indexes, decimal replacements, SpriteConfig spriteConfig = null, Scene scene = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromTiles" }, indexes, replacements, spriteConfig, scene, camera
                }
            );
        }

        public Tile[] cull(Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cull" }, camera
                }
            );
        }

        public TilemapLayer copy(decimal srcTileX, decimal srcTileY, decimal width, decimal height, decimal destTileX, decimal destTileY, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, srcTileX, srcTileY, width, height, destTileX, destTileY, recalculateFaces
                }
            );
        }

        public TilemapLayer fill(decimal index, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fill" }, index, tileX, tileY, width, height, recalculateFaces
                }
            );
        }

        public Tile findByIndex(decimal index, System.Nullable<decimal> skip = null, System.Nullable<bool> reverse = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findByIndex" }, index, skip, reverse
                }
            );
        }

        public Tile findTile(ActionCallback<Tile, decimal, Tile[]> callback, object context = null, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findTile" }, callback, context, tileX, tileY, width, height, filteringOptions
                }
            );
        }

        public TilemapLayer forEachTile(ActionCallback<Tile, decimal, Tile[]> callback, object context = null, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "forEachTile" }, callback, context, tileX, tileY, width, height, filteringOptions
                }
            );
        }

        public Tile getTileAt(decimal tileX, decimal tileY, System.Nullable<bool> nonNull = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTileAt" }, tileX, tileY, nonNull
                }
            );
        }

        public Tile getTileAtWorldXY(decimal worldX, decimal worldY, System.Nullable<bool> nonNull = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTileAtWorldXY" }, worldX, worldY, nonNull, camera
                }
            );
        }

        public Tile[] getTilesWithin(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithin" }, tileX, tileY, width, height, filteringOptions
                }
            );
        }

        public Tile[] getTilesWithinShape(Circle shape, FilteringOptions filteringOptions = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithinShape" }, shape, filteringOptions, camera
                }
            );
        }

        public Tile[] getTilesWithinWorldXY(decimal worldX, decimal worldY, decimal width, decimal height, FilteringOptions filteringOptions = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithinWorldXY" }, worldX, worldY, width, height, filteringOptions, camera
                }
            );
        }

        public bool hasTileAt(decimal tileX, decimal tileY)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTileAt" }, tileX, tileY
                }
            );
        }

        public bool hasTileAtWorldXY(decimal worldX, decimal worldY, Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTileAtWorldXY" }, worldX, worldY, camera
                }
            );
        }

        public Tile putTileAt(decimal tile, decimal tileX, decimal tileY, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTileAt" }, tile, tileX, tileY, recalculateFaces
                }
            );
        }

        public Tile putTileAtWorldXY(decimal tile, decimal worldX, decimal worldY, System.Nullable<bool> recalculateFaces = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTileAtWorldXY" }, tile, worldX, worldY, recalculateFaces, camera
                }
            );
        }

        public TilemapLayer putTilesAt(decimal[] tile, decimal tileX, decimal tileY, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTilesAt" }, tile, tileX, tileY, recalculateFaces
                }
            );
        }

        public TilemapLayer randomize(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, decimal[] indexes = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "randomize" }, tileX, tileY, width, height, indexes
                }
            );
        }

        public Tile removeTileAt(decimal tileX, decimal tileY, System.Nullable<bool> replaceWithNull = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeTileAt" }, tileX, tileY, replaceWithNull, recalculateFaces
                }
            );
        }

        public Tile removeTileAtWorldXY(decimal worldX, decimal worldY, System.Nullable<bool> replaceWithNull = null, System.Nullable<bool> recalculateFaces = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeTileAtWorldXY" }, worldX, worldY, replaceWithNull, recalculateFaces, camera
                }
            );
        }

        public TilemapLayer renderDebug(Graphics graphics, StyleConfig styleConfig = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "renderDebug" }, graphics, styleConfig
                }
            );
        }

        public TilemapLayer replaceByIndex(decimal findIndex, decimal newIndex, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replaceByIndex" }, findIndex, newIndex, tileX, tileY, width, height
                }
            );
        }

        public TilemapLayer setSkipCull(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkipCull" }, value
                }
            );
        }

        public TilemapLayer setCullPadding(System.Nullable<decimal> paddingX = null, System.Nullable<decimal> paddingY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCullPadding" }, paddingX, paddingY
                }
            );
        }

        public TilemapLayer setCollision(decimal indexes, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, System.Nullable<bool> updateLayer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollision" }, indexes, collides, recalculateFaces, updateLayer
                }
            );
        }

        public TilemapLayer setCollisionBetween(decimal start, decimal stop, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionBetween" }, start, stop, collides, recalculateFaces
                }
            );
        }

        public TilemapLayer setCollisionByProperty(object properties, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionByProperty" }, properties, collides, recalculateFaces
                }
            );
        }

        public TilemapLayer setCollisionByExclusion(decimal[] indexes, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionByExclusion" }, indexes, collides, recalculateFaces
                }
            );
        }

        public TilemapLayer setCollisionFromCollisionGroup(System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionFromCollisionGroup" }, collides, recalculateFaces
                }
            );
        }

        public TilemapLayer shuffle(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }, tileX, tileY, width, height
                }
            );
        }

        public TilemapLayer swapByIndex(decimal tileA, decimal tileB, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "swapByIndex" }, tileA, tileB, tileX, tileY, width, height
                }
            );
        }

        public decimal tileToWorldX(decimal tileX, Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldX" }, tileX, camera
                }
            );
        }

        public decimal tileToWorldY(decimal tileY, Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldY" }, tileY, camera
                }
            );
        }

        public Vector2 tileToWorldXY(decimal tileX, decimal tileY, Vector2 point = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldXY" }, tileX, tileY, point, camera
                }
            );
        }

        public TilemapLayer weightedRandomize(CachedEntity[] weightedIndexes, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "weightedRandomize" }, weightedIndexes, tileX, tileY, width, height
                }
            );
        }

        public decimal worldToTileX(decimal worldX, System.Nullable<bool> snapToFloor = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "worldToTileX" }, worldX, snapToFloor, camera
                }
            );
        }

        public decimal worldToTileY(decimal worldY, System.Nullable<bool> snapToFloor = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "worldToTileY" }, worldY, snapToFloor, camera
                }
            );
        }

        public Vector2 worldToTileXY(decimal worldX, decimal worldY, System.Nullable<bool> snapToFloor = null, Vector2 point = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "worldToTileXY" }, worldX, worldY, snapToFloor, point, camera
                }
            );
        }

        public void destroy(System.Nullable<bool> removeFromTilemap = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, removeFromTilemap
                }
            );
        }

        public TilemapLayer clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public TilemapLayer setAlpha(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public TilemapLayer setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public TilemapLayer setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public TilemapLayer setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public TilemapLayer setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public TilemapLayer toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public TilemapLayer toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public TilemapLayer setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public TilemapLayer setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public TilemapLayer setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public TilemapLayer resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public O getCenter<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, output
                }
            );
        }

        public O getTopLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopLeft" }, output, includeParent
                }
            );
        }

        public O getTopCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopCenter" }, output, includeParent
                }
            );
        }

        public O getTopRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopRight" }, output, includeParent
                }
            );
        }

        public O getLeftCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftCenter" }, output, includeParent
                }
            );
        }

        public O getRightCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightCenter" }, output, includeParent
                }
            );
        }

        public O getBottomLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomLeft" }, output, includeParent
                }
            );
        }

        public O getBottomCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomCenter" }, output, includeParent
                }
            );
        }

        public O getBottomRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomRight" }, output, includeParent
                }
            );
        }

        public O getBounds<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, output
                }
            );
        }

        public TilemapLayer setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public TilemapLayer setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public TilemapLayer setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public TilemapLayer updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }

        public bool initPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "initPipeline" }, pipeline
                }
            );
        }

        public TilemapLayer setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public TilemapLayer setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public TilemapLayer setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipelineData" }, key, value
                }
            );
        }

        public PostFXPipeline getPostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<PostFXPipeline>(
                entity => new PostFXPipeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPostPipeline" }, pipeline
                }
            );
        }

        public bool resetPipeline(System.Nullable<bool> resetPostPipelines = null, System.Nullable<bool> resetData = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "resetPipeline" }, resetPostPipelines, resetData
                }
            );
        }

        public void resetPostPipeline(System.Nullable<bool> resetData = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetPostPipeline" }, resetData
                }
            );
        }

        public TilemapLayer removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removePostPipeline" }, pipeline
                }
            );
        }

        public string getPipelineName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPipelineName" }
                }
            );
        }

        public TilemapLayer setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public TilemapLayer setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public TilemapLayer copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public TilemapLayer setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public TilemapLayer setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public TilemapLayer setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public TilemapLayer setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public TilemapLayer setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public TilemapLayer setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public TilemapLayer setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public TilemapLayer setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, value
                }
            );
        }

        public TransformMatrix getLocalTransformMatrix(TransformMatrix tempMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalTransformMatrix" }, tempMatrix
                }
            );
        }

        public TransformMatrix getWorldTransformMatrix(TransformMatrix tempMatrix = null, TransformMatrix parentMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldTransformMatrix" }, tempMatrix, parentMatrix
                }
            );
        }

        public Vector2 getLocalPoint(decimal x, decimal y, Vector2 point = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPoint" }, x, y, point, camera
                }
            );
        }

        public decimal getParentRotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParentRotation" }
                }
            );
        }

        public TilemapLayer setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }


        #endregion
    }
}