/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<GameObjectCreator>))]
    public class GameObjectCreator : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void remove(string factoryType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Phaser", "GameObjects", "GameObjectCreator", "remove" }, factoryType
                }
            );
        }


        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public GameObjectCreator() : base() { }

        public GameObjectCreator(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GameObjectCreator(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "GameObjectCreator" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public DynamicBitmapText dynamicBitmapText(BitmapTextConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "dynamicBitmapText" }, config, addToScene
                }
            );
        }

        public BitmapText bitmapText(BitmapTextConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapText>(
                entity => new BitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bitmapText" }, config, addToScene
                }
            );
        }

        public Blitter blitter(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Blitter>(
                entity => new Blitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blitter" }, config, addToScene
                }
            );
        }

        public Container container(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "container" }, config, addToScene
                }
            );
        }

        public Graphics graphics(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "graphics" }, config, addToScene
                }
            );
        }

        public Group group(GroupConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "group" }, config
                }
            );
        }

        public Image image(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Image>(
                entity => new Image() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "image" }, config, addToScene
                }
            );
        }

        public Layer layer(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "layer" }, config, addToScene
                }
            );
        }

        public Mesh mesh(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mesh" }, config, addToScene
                }
            );
        }

        public ParticleEmitterManager particles(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "particles" }, config, addToScene
                }
            );
        }

        public PointLight pointlight(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pointlight" }, config, addToScene
                }
            );
        }

        public RenderTexture renderTexture(RenderTextureConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "renderTexture" }, config, addToScene
                }
            );
        }

        public Rope rope(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rope>(
                entity => new Rope() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rope" }, config, addToScene
                }
            );
        }

        public Shader shader(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shader" }, config, addToScene
                }
            );
        }

        public Sprite sprite(SpriteConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sprite" }, config, addToScene
                }
            );
        }

        public Text text(TextConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "text" }, config, addToScene
                }
            );
        }

        public TileSprite tileSprite(TileSpriteConfig config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileSprite>(
                entity => new TileSprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tileSprite" }, config, addToScene
                }
            );
        }

        public Video video(object config, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "video" }, config, addToScene
                }
            );
        }

        public Zone zone(object config)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "zone" }, config
                }
            );
        }

        public Tilemap tilemap(TilemapConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tilemap" }, config
                }
            );
        }

        public Tween tween(TweenBuilderConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tween" }, config
                }
            );
        }
        #endregion
    }
}