/// Generated - Do Not Edit
namespace Phaser.Textures
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextureManager>))]
    public class TextureManager : EventEmitter
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
            set
            {
__game = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "game",
                    value
                );
            }
        }

        
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

        
        public CachedEntity list
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "list"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "list",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextureManager() : base() { }

        public TextureManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextureManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Textures", "TextureManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool checkKey(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkKey" }, key
                }
            );
        }

        public TextureManager remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureManager>(
                entity => new TextureManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
                }
            );
        }

        public TextureManager removeKey(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureManager>(
                entity => new TextureManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeKey" }, key
                }
            );
        }

        public TextureManager addBase64(string key, object data)
        {
            return EventHorizonBlazorInterop.FuncClass<TextureManager>(
                entity => new TextureManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBase64" }, key, data
                }
            );
        }

        public string getBase64(string key, string frame = null, string type = null, System.Nullable<decimal> encoderOptions = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getBase64" }, key, frame, type, encoderOptions
                }
            );
        }

        public Texture addImage(string key, HTMLImageElement source, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addImage" }, key, source, dataSource
                }
            );
        }

        public Texture addGLTexture(string key, WebGLTexture glTexture, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addGLTexture" }, key, glTexture, width, height
                }
            );
        }

        public Texture addRenderTexture(string key, RenderTexture renderTexture)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addRenderTexture" }, key, renderTexture
                }
            );
        }

        public Texture generate(string key, GenerateTextureConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generate" }, key, config
                }
            );
        }

        public CanvasTexture createCanvas(string key, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCanvas" }, key, width, height
                }
            );
        }

        public CanvasTexture addCanvas(string key, HTMLCanvasElement source, System.Nullable<bool> skipCache = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addCanvas" }, key, source, skipCache
                }
            );
        }

        public Texture addAtlas(string key, HTMLImageElement source, object data, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAtlas" }, key, source, data, dataSource
                }
            );
        }

        public Texture addAtlasJSONArray(string key, HTMLImageElement source, object data, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAtlasJSONArray" }, key, source, data, dataSource
                }
            );
        }

        public Texture addAtlasJSONHash(string key, HTMLImageElement source, object data, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAtlasJSONHash" }, key, source, data, dataSource
                }
            );
        }

        public Texture addAtlasXML(string key, HTMLImageElement source, object data, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAtlasXML" }, key, source, data, dataSource
                }
            );
        }

        public Texture addUnityAtlas(string key, HTMLImageElement source, object data, HTMLImageElement dataSource = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addUnityAtlas" }, key, source, data, dataSource
                }
            );
        }

        public Texture addSpriteSheet(string key, HTMLImageElement source, SpriteSheetConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addSpriteSheet" }, key, source, config
                }
            );
        }

        public Texture addSpriteSheetFromAtlas(string key, SpriteSheetFromAtlasConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addSpriteSheetFromAtlas" }, key, config
                }
            );
        }

        public Texture create(string key, HTMLImageElement source, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, key, source, width, height
                }
            );
        }

        public bool exists(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, key
                }
            );
        }

        public Texture get(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public Frame cloneFrame(string key, string frame)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cloneFrame" }, key, frame
                }
            );
        }

        public Frame getFrame(string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Frame>(
                entity => new Frame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrame" }, key, frame
                }
            );
        }

        public string[] getTextureKeys()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getTextureKeys" }
                }
            );
        }

        public Color getPixel(decimal x, decimal y, string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPixel" }, x, y, key, frame
                }
            );
        }

        public decimal getPixelAlpha(decimal x, decimal y, string key, string frame = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPixelAlpha" }, x, y, key, frame
                }
            );
        }

        public GameObject setTexture(GameObject gameObject, string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, gameObject, key, frame
                }
            );
        }

        public bool renameTexture(string currentKey, string newKey)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "renameTexture" }, currentKey, newKey
                }
            );
        }

        public void each(ActionCallback<Texture, CachedEntity[]> callback, object scope, CachedEntity[] args)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "each" }, callback, scope, args
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