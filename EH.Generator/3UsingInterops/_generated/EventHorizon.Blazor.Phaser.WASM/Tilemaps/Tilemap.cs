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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Tilemap>))]
    public class Tilemap : CachedEntityObject
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileWidth",
                    value
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tileHeight",
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

        
        public string orientation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "orientation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orientation",
                    value
                );
            }
        }

        
        public string renderOrder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "renderOrder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderOrder",
                    value
                );
            }
        }

        
        public decimal format
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        
        public decimal version
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "version"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "version",
                    value
                );
            }
        }

        
        public CachedEntity properties
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "properties"
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

        
        public decimal widthInPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "widthInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "widthInPixels",
                    value
                );
            }
        }

        
        public decimal heightInPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "heightInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "heightInPixels",
                    value
                );
            }
        }

        
        public ImageCollection[] imageCollections
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ImageCollection>(
                    this.___guid,
                    "imageCollections",
                    (entity) =>
                    {
                        return new ImageCollection() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageCollections",
                    value
                );
            }
        }

        
        public CachedEntity[] images
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "images",
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
                    "images",
                    value
                );
            }
        }

        
        public LayerData[] layers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<LayerData>(
                    this.___guid,
                    "layers",
                    (entity) =>
                    {
                        return new LayerData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layers",
                    value
                );
            }
        }

        
        public Tileset[] tilesets
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Tileset>(
                    this.___guid,
                    "tilesets",
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
                    "tilesets",
                    value
                );
            }
        }

        
        public ObjectLayer[] objects
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ObjectLayer>(
                    this.___guid,
                    "objects",
                    (entity) =>
                    {
                        return new ObjectLayer() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "objects",
                    value
                );
            }
        }

        
        public decimal currentLayerIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentLayerIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentLayerIndex",
                    value
                );
            }
        }

        
        public decimal hexSideLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "hexSideLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hexSideLength",
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
        #endregion
        
        #region Constructor
        public Tilemap() : base() { }

        public Tilemap(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Tilemap(
            Scene scene, MapData mapData
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tilemaps", "Tilemap" },
                scene, mapData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Tilemap setRenderOrder(decimal renderOrder)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRenderOrder" }, renderOrder
                }
            );
        }

        public Tileset addTilesetImage(string tilesetName, string key = null, System.Nullable<decimal> tileWidth = null, System.Nullable<decimal> tileHeight = null, System.Nullable<decimal> tileMargin = null, System.Nullable<decimal> tileSpacing = null, System.Nullable<decimal> gid = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addTilesetImage" }, tilesetName, key, tileWidth, tileHeight, tileMargin, tileSpacing, gid
                }
            );
        }

        public Tilemap copy(decimal srcTileX, decimal srcTileY, decimal width, decimal height, decimal destTileX, decimal destTileY, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, srcTileX, srcTileY, width, height, destTileX, destTileY, recalculateFaces, layer
                }
            );
        }

        public TilemapLayer createBlankLayer(string name, string tileset, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> tileWidth = null, System.Nullable<decimal> tileHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBlankLayer" }, name, tileset, x, y, width, height, tileWidth, tileHeight
                }
            );
        }

        public TilemapLayer createLayer(decimal layerID, string tileset, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TilemapLayer>(
                entity => new TilemapLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createLayer" }, layerID, tileset, x, y
                }
            );
        }

        public GameObject[] createFromObjects(string objectLayerName, CreateFromObjectLayerConfig config)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromObjects" }, objectLayerName, config
                }
            );
        }

        public Sprite[] createFromTiles(decimal indexes, decimal replacements, SpriteConfig spriteConfig, Scene scene = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromTiles" }, indexes, replacements, spriteConfig, scene, camera, layer
                }
            );
        }

        public Tilemap fill(decimal index, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fill" }, index, tileX, tileY, width, height, recalculateFaces, layer
                }
            );
        }

        public TiledObject[] filterObjects(ObjectLayer objectLayer, ActionCallback<GameObject, decimal, GameObject[]> callback, object context = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TiledObject>(
                entity => new TiledObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "filterObjects" }, objectLayer, callback, context
                }
            );
        }

        public Tile findByIndex(decimal index, System.Nullable<decimal> skip = null, System.Nullable<bool> reverse = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findByIndex" }, index, skip, reverse, layer
                }
            );
        }

        public TiledObject findObject(ObjectLayer objectLayer, ActionCallback<GameObject, decimal, GameObject[]> callback, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TiledObject>(
                entity => new TiledObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findObject" }, objectLayer, callback, context
                }
            );
        }

        public Tile findTile(ActionCallback<Tile, decimal, Tile[]> callback, object context = null, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findTile" }, callback, context, tileX, tileY, width, height, filteringOptions, layer
                }
            );
        }

        public Tilemap forEachTile(ActionCallback<Tile, decimal, Tile[]> callback, object context = null, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "forEachTile" }, callback, context, tileX, tileY, width, height, filteringOptions, layer
                }
            );
        }

        public decimal getImageIndex(string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getImageIndex" }, name
                }
            );
        }

        public string[] getImageLayerNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getImageLayerNames" }
                }
            );
        }

        public decimal getIndex(CachedEntity[] location, string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, location, name
                }
            );
        }

        public LayerData getLayer(string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LayerData>(
                entity => new LayerData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLayer" }, layer
                }
            );
        }

        public ObjectLayer getObjectLayer(string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ObjectLayer>(
                entity => new ObjectLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectLayer" }, name
                }
            );
        }

        public string[] getObjectLayerNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getObjectLayerNames" }
                }
            );
        }

        public decimal getLayerIndex(string layer = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLayerIndex" }, layer
                }
            );
        }

        public decimal getLayerIndexByName(string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLayerIndexByName" }, name
                }
            );
        }

        public Tile getTileAt(decimal tileX, decimal tileY, System.Nullable<bool> nonNull = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTileAt" }, tileX, tileY, nonNull, layer
                }
            );
        }

        public Tile getTileAtWorldXY(decimal worldX, decimal worldY, System.Nullable<bool> nonNull = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTileAtWorldXY" }, worldX, worldY, nonNull, camera, layer
                }
            );
        }

        public string[] getTileLayerNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getTileLayerNames" }
                }
            );
        }

        public Tile[] getTilesWithin(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, FilteringOptions filteringOptions = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithin" }, tileX, tileY, width, height, filteringOptions, layer
                }
            );
        }

        public Tile[] getTilesWithinShape(Circle shape, FilteringOptions filteringOptions = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithinShape" }, shape, filteringOptions, camera, layer
                }
            );
        }

        public Tile[] getTilesWithinWorldXY(decimal worldX, decimal worldY, decimal width, decimal height, FilteringOptions filteringOptions = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTilesWithinWorldXY" }, worldX, worldY, width, height, filteringOptions, camera, layer
                }
            );
        }

        public Tileset getTileset(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Tileset>(
                entity => new Tileset() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTileset" }, name
                }
            );
        }

        public decimal getTilesetIndex(string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTilesetIndex" }, name
                }
            );
        }

        public bool hasTileAt(decimal tileX, decimal tileY, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTileAt" }, tileX, tileY, layer
                }
            );
        }

        public bool hasTileAtWorldXY(decimal worldX, decimal worldY, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTileAtWorldXY" }, worldX, worldY, camera, layer
                }
            );
        }

        public Tile putTileAt(decimal tile, decimal tileX, decimal tileY, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTileAt" }, tile, tileX, tileY, recalculateFaces, layer
                }
            );
        }

        public Tile putTileAtWorldXY(decimal tile, decimal worldX, decimal worldY, System.Nullable<bool> recalculateFaces = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTileAtWorldXY" }, tile, worldX, worldY, recalculateFaces, camera, layer
                }
            );
        }

        public Tilemap putTilesAt(decimal[] tile, decimal tileX, decimal tileY, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putTilesAt" }, tile, tileX, tileY, recalculateFaces, layer
                }
            );
        }

        public Tilemap randomize(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, decimal[] indexes = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "randomize" }, tileX, tileY, width, height, indexes, layer
                }
            );
        }

        public Tilemap calculateFacesAt(decimal tileX, decimal tileY, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calculateFacesAt" }, tileX, tileY, layer
                }
            );
        }

        public Tilemap calculateFacesWithin(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calculateFacesWithin" }, tileX, tileY, width, height, layer
                }
            );
        }

        public Tilemap removeLayer(string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeLayer" }, layer
                }
            );
        }

        public Tilemap destroyLayer(string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "destroyLayer" }, layer
                }
            );
        }

        public Tilemap removeAllLayers()
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAllLayers" }
                }
            );
        }

        public Tile[] removeTile(Tile tiles, System.Nullable<decimal> replaceIndex = null, System.Nullable<bool> recalculateFaces = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeTile" }, tiles, replaceIndex, recalculateFaces
                }
            );
        }

        public Tile removeTileAt(decimal tileX, decimal tileY, System.Nullable<bool> replaceWithNull = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeTileAt" }, tileX, tileY, replaceWithNull, recalculateFaces, layer
                }
            );
        }

        public Tile removeTileAtWorldXY(decimal worldX, decimal worldY, System.Nullable<bool> replaceWithNull = null, System.Nullable<bool> recalculateFaces = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tile>(
                entity => new Tile() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeTileAtWorldXY" }, worldX, worldY, replaceWithNull, recalculateFaces, camera, layer
                }
            );
        }

        public Tilemap renderDebug(Graphics graphics, StyleConfig styleConfig = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "renderDebug" }, graphics, styleConfig, layer
                }
            );
        }

        public Tilemap renderDebugFull(Graphics graphics, StyleConfig styleConfig = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "renderDebugFull" }, graphics, styleConfig
                }
            );
        }

        public Tilemap replaceByIndex(decimal findIndex, decimal newIndex, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replaceByIndex" }, findIndex, newIndex, tileX, tileY, width, height, layer
                }
            );
        }

        public Tilemap setCollision(decimal indexes, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, string layer = null, System.Nullable<bool> updateLayer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollision" }, indexes, collides, recalculateFaces, layer, updateLayer
                }
            );
        }

        public Tilemap setCollisionBetween(decimal start, decimal stop, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionBetween" }, start, stop, collides, recalculateFaces, layer
                }
            );
        }

        public Tilemap setCollisionByProperty(object properties, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionByProperty" }, properties, collides, recalculateFaces, layer
                }
            );
        }

        public Tilemap setCollisionByExclusion(decimal[] indexes, System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionByExclusion" }, indexes, collides, recalculateFaces, layer
                }
            );
        }

        public Tilemap setCollisionFromCollisionGroup(System.Nullable<bool> collides = null, System.Nullable<bool> recalculateFaces = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCollisionFromCollisionGroup" }, collides, recalculateFaces, layer
                }
            );
        }

        public Tilemap setLayer(string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLayer" }, layer
                }
            );
        }

        public Tilemap setBaseTileSize(decimal tileWidth, decimal tileHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBaseTileSize" }, tileWidth, tileHeight
                }
            );
        }

        public Tilemap setLayerTileSize(decimal tileWidth, decimal tileHeight, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLayerTileSize" }, tileWidth, tileHeight, layer
                }
            );
        }

        public Tilemap shuffle(System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }, tileX, tileY, width, height, layer
                }
            );
        }

        public Tilemap swapByIndex(decimal tileA, decimal tileB, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "swapByIndex" }, tileA, tileB, tileX, tileY, width, height, layer
                }
            );
        }

        public decimal tileToWorldX(decimal tileX, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldX" }, tileX, camera, layer
                }
            );
        }

        public decimal tileToWorldY(decimal tileY, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldY" }, tileY, camera, layer
                }
            );
        }

        public Vector2 tileToWorldXY(decimal tileX, decimal tileY, Vector2 vec2 = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tileToWorldXY" }, tileX, tileY, vec2, camera, layer
                }
            );
        }

        public Tilemap weightedRandomize(CachedEntity[] weightedIndexes, System.Nullable<decimal> tileX = null, System.Nullable<decimal> tileY = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "weightedRandomize" }, weightedIndexes, tileX, tileY, width, height, layer
                }
            );
        }

        public decimal worldToTileX(decimal worldX, System.Nullable<bool> snapToFloor = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "worldToTileX" }, worldX, snapToFloor, camera, layer
                }
            );
        }

        public decimal worldToTileY(decimal worldY, System.Nullable<bool> snapToFloor = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "worldToTileY" }, worldY, snapToFloor, camera, layer
                }
            );
        }

        public Vector2 worldToTileXY(decimal worldX, decimal worldY, System.Nullable<bool> snapToFloor = null, Vector2 vec2 = null, Camera camera = null, string layer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "worldToTileXY" }, worldX, worldY, snapToFloor, vec2, camera, layer
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
}