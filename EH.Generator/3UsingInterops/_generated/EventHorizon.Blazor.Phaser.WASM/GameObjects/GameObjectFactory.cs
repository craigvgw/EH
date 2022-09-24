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

    
    
    [JsonConverter(typeof(CachedEntityConverter<GameObjectFactory>))]
    public class GameObjectFactory : CachedEntityObject
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
                    new string[] { "Phaser", "GameObjects", "GameObjectFactory", "remove" }, factoryType
                }
            );
        }


        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public GameObjectFactory() : base() { }

        public GameObjectFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GameObjectFactory(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "GameObjectFactory" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Path path(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Path>(
                entity => new Path() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "path" }, x, y
                }
            );
        }

        public DynamicBitmapText dynamicBitmapText(decimal x, decimal y, string font, string text = null, System.Nullable<decimal> size = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "dynamicBitmapText" }, x, y, font, text, size
                }
            );
        }

        public BitmapText bitmapText(decimal x, decimal y, string font, string text = null, System.Nullable<decimal> size = null, System.Nullable<decimal> align = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapText>(
                entity => new BitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bitmapText" }, x, y, font, text, size, align
                }
            );
        }

        public Blitter blitter(decimal x, decimal y, string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Blitter>(
                entity => new Blitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "blitter" }, x, y, key, frame
                }
            );
        }

        public Container container(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, GameObject children = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "container" }, x, y, children
                }
            );
        }

        public DOMElement dom(decimal x, decimal y, object element = null, string style = null, string innerText = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DOMElement>(
                entity => new DOMElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "dom" }, x, y, element, style, innerText
                }
            );
        }

        public Extern extern()
        {
            return EventHorizonBlazorInterop.FuncClass<Extern>(
                entity => new Extern() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extern" }
                }
            );
        }

        public G existing<G>(G child) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "existing" }, child
                }
            );
        }

        public Graphics graphics(Options config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "graphics" }, config
                }
            );
        }

        public Group group(GameObject[] children = null, GroupConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "group" }, children, config
                }
            );
        }

        public Image image(decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Image>(
                entity => new Image() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "image" }, x, y, texture, frame
                }
            );
        }

        public Layer layer(GameObject children = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "layer" }, children
                }
            );
        }

        public Mesh mesh(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string texture = null, string frame = null, decimal[] vertices = null, decimal[] uvs = null, decimal[] indicies = null, System.Nullable<bool> containsZ = null, decimal[] normals = null, System.Nullable<decimal> colors = null, System.Nullable<decimal> alphas = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mesh" }, x, y, texture, frame, vertices, uvs, indicies, containsZ, normals, colors, alphas
                }
            );
        }

        public ParticleEmitterManager particles(string texture, string frame = null, ParticleEmitterConfig emitters = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "particles" }, texture, frame, emitters
                }
            );
        }

        public PathFollower follower(Path path, decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PathFollower>(
                entity => new PathFollower() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "follower" }, path, x, y, texture, frame
                }
            );
        }

        public PointLight pointlight(decimal x, decimal y, System.Nullable<decimal> color = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> intensity = null, System.Nullable<decimal> attenuation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pointlight" }, x, y, color, radius, intensity, attenuation
                }
            );
        }

        public RenderTexture renderTexture(decimal x, decimal y, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTexture>(
                entity => new RenderTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "renderTexture" }, x, y, width, height
                }
            );
        }

        public Rope rope(decimal x, decimal y, string texture, string frame = null, Vector2Like[] points = null, System.Nullable<bool> horizontal = null, decimal[] colors = null, decimal[] alphas = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rope>(
                entity => new Rope() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rope" }, x, y, texture, frame, points, horizontal, colors, alphas
                }
            );
        }

        public Shader shader(string key, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string[] textures = null, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shader" }, key, x, y, width, height, textures, textureData
                }
            );
        }

        public Arc arc(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> startAngle = null, System.Nullable<decimal> endAngle = null, System.Nullable<bool> anticlockwise = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Arc>(
                entity => new Arc() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arc" }, x, y, radius, startAngle, endAngle, anticlockwise, fillColor, fillAlpha
                }
            );
        }

        public Arc circle(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Arc>(
                entity => new Arc() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "circle" }, x, y, radius, fillColor, fillAlpha
                }
            );
        }

        public Curve curve(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, Curve curve = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Curve>(
                entity => new Curve() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "curve" }, x, y, curve, fillColor, fillAlpha
                }
            );
        }

        public Ellipse ellipse(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ellipse>(
                entity => new Ellipse() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "ellipse" }, x, y, width, height, fillColor, fillAlpha
                }
            );
        }

        public Grid grid(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> cellWidth = null, System.Nullable<decimal> cellHeight = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null, System.Nullable<decimal> outlineFillColor = null, System.Nullable<decimal> outlineFillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "grid" }, x, y, width, height, cellWidth, cellHeight, fillColor, fillAlpha, outlineFillColor, outlineFillAlpha
                }
            );
        }

        public IsoBox isobox(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> size = null, System.Nullable<decimal> height = null, System.Nullable<decimal> fillTop = null, System.Nullable<decimal> fillLeft = null, System.Nullable<decimal> fillRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoBox>(
                entity => new IsoBox() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "isobox" }, x, y, size, height, fillTop, fillLeft, fillRight
                }
            );
        }

        public IsoTriangle isotriangle(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> size = null, System.Nullable<decimal> height = null, System.Nullable<bool> reversed = null, System.Nullable<decimal> fillTop = null, System.Nullable<decimal> fillLeft = null, System.Nullable<decimal> fillRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "isotriangle" }, x, y, size, height, reversed, fillTop, fillLeft, fillRight
                }
            );
        }

        public Line line(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> x1 = null, System.Nullable<decimal> y1 = null, System.Nullable<decimal> x2 = null, System.Nullable<decimal> y2 = null, System.Nullable<decimal> strokeColor = null, System.Nullable<decimal> strokeAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Line>(
                entity => new Line() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "line" }, x, y, x1, y1, x2, y2, strokeColor, strokeAlpha
                }
            );
        }

        public Polygon polygon(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, object points = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Polygon>(
                entity => new Polygon() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "polygon" }, x, y, points, fillColor, fillAlpha
                }
            );
        }

        public Rectangle rectangle(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rectangle" }, x, y, width, height, fillColor, fillAlpha
                }
            );
        }

        public Star star(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> points = null, System.Nullable<decimal> innerRadius = null, System.Nullable<decimal> outerRadius = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Star>(
                entity => new Star() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "star" }, x, y, points, innerRadius, outerRadius, fillColor, fillAlpha
                }
            );
        }

        public Triangle triangle(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> x1 = null, System.Nullable<decimal> y1 = null, System.Nullable<decimal> x2 = null, System.Nullable<decimal> y2 = null, System.Nullable<decimal> x3 = null, System.Nullable<decimal> y3 = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Triangle>(
                entity => new Triangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "triangle" }, x, y, x1, y1, x2, y2, x3, y3, fillColor, fillAlpha
                }
            );
        }

        public Sprite sprite(decimal x, decimal y, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sprite" }, x, y, texture, frame
                }
            );
        }

        public Text text(decimal x, decimal y, string text, TextStyle style = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Text>(
                entity => new Text() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "text" }, x, y, text, style
                }
            );
        }

        public TileSprite tileSprite(decimal x, decimal y, decimal width, decimal height, string texture, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TileSprite>(
                entity => new TileSprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tileSprite" }, x, y, width, height, texture, frame
                }
            );
        }

        public Video video(decimal x, decimal y, string key = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Video>(
                entity => new Video() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "video" }, x, y, key
                }
            );
        }

        public Zone zone(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Zone>(
                entity => new Zone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "zone" }, x, y, width, height
                }
            );
        }

        public Tilemap tilemap(string key = null, System.Nullable<decimal> tileWidth = null, System.Nullable<decimal> tileHeight = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, decimal[][] data = null, System.Nullable<bool> insertNull = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Tilemap>(
                entity => new Tilemap() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "tilemap" }, key, tileWidth, tileHeight, width, height, data, insertNull
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