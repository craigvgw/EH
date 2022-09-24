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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Graphics>))]
    public class Graphics : GameObject, IAlphaSingle, IBlendMode, IDepth, IMask, IPipeline, ITransform, IVisible, IScrollFactor
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Camera __TargetCamera;
        public static Camera TargetCamera
        {
            get
            {
            if(__TargetCamera == null)
            {
                __TargetCamera = EventHorizonBlazorInterop.GetClass<Camera>(
                    "Phaser",
                    "GameObjects.Graphics.TargetCamera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __TargetCamera;
            }
            set
            {
__TargetCamera = null;
                EventHorizonBlazorInterop.Set(
                    "Phaser",
                    "GameObjects.Graphics.TargetCamera",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
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

        
        public CachedEntity[] commandBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "commandBuffer",
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
                    "commandBuffer",
                    value
                );
            }
        }

        
        public decimal defaultFillColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultFillColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultFillColor",
                    value
                );
            }
        }

        
        public decimal defaultFillAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultFillAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultFillAlpha",
                    value
                );
            }
        }

        
        public decimal defaultStrokeWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultStrokeWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultStrokeWidth",
                    value
                );
            }
        }

        
        public decimal defaultStrokeColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultStrokeColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultStrokeColor",
                    value
                );
            }
        }

        
        public decimal defaultStrokeAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultStrokeAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultStrokeAlpha",
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

        private BitmapMask __mask;
        public BitmapMask mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<BitmapMask>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new BitmapMask() { ___guid = entity.___guid };
                    }
                );
            }
            return __mask;
            }
            set
            {
__mask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
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
        #endregion
        
        #region Constructor
        public Graphics() : base() { }

        public Graphics(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Graphics(
            Scene scene, Options options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Graphics" },
                scene, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Graphics setDefaultStyles(Styles options)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDefaultStyles" }, options
                }
            );
        }

        public Graphics lineStyle(decimal lineWidth, decimal color, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineStyle" }, lineWidth, color, alpha
                }
            );
        }

        public Graphics fillStyle(decimal color, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillStyle" }, color, alpha
                }
            );
        }

        public Graphics fillGradientStyle(decimal topLeft, decimal topRight, decimal bottomLeft, decimal bottomRight, System.Nullable<decimal> alphaTopLeft = null, System.Nullable<decimal> alphaTopRight = null, System.Nullable<decimal> alphaBottomLeft = null, System.Nullable<decimal> alphaBottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillGradientStyle" }, topLeft, topRight, bottomLeft, bottomRight, alphaTopLeft, alphaTopRight, alphaBottomLeft, alphaBottomRight
                }
            );
        }

        public Graphics lineGradientStyle(decimal lineWidth, decimal topLeft, decimal topRight, decimal bottomLeft, decimal bottomRight, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineGradientStyle" }, lineWidth, topLeft, topRight, bottomLeft, bottomRight, alpha
                }
            );
        }

        public Graphics beginPath()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginPath" }
                }
            );
        }

        public Graphics closePath()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closePath" }
                }
            );
        }

        public Graphics fillPath()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillPath" }
                }
            );
        }

        public Graphics fill()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fill" }
                }
            );
        }

        public Graphics strokePath()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokePath" }
                }
            );
        }

        public Graphics stroke()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stroke" }
                }
            );
        }

        public Graphics fillCircleShape(Circle circle)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillCircleShape" }, circle
                }
            );
        }

        public Graphics strokeCircleShape(Circle circle)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeCircleShape" }, circle
                }
            );
        }

        public Graphics fillCircle(decimal x, decimal y, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillCircle" }, x, y, radius
                }
            );
        }

        public Graphics strokeCircle(decimal x, decimal y, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeCircle" }, x, y, radius
                }
            );
        }

        public Graphics fillRectShape(Rectangle rect)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillRectShape" }, rect
                }
            );
        }

        public Graphics strokeRectShape(Rectangle rect)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeRectShape" }, rect
                }
            );
        }

        public Graphics fillRect(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillRect" }, x, y, width, height
                }
            );
        }

        public Graphics strokeRect(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeRect" }, x, y, width, height
                }
            );
        }

        public Graphics fillRoundedRect(decimal x, decimal y, decimal width, decimal height, RoundedRectRadius radius = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillRoundedRect" }, x, y, width, height, radius
                }
            );
        }

        public Graphics strokeRoundedRect(decimal x, decimal y, decimal width, decimal height, RoundedRectRadius radius = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeRoundedRect" }, x, y, width, height, radius
                }
            );
        }

        public Graphics fillPointShape(Point point, System.Nullable<decimal> size = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillPointShape" }, point, size
                }
            );
        }

        public Graphics fillPoint(decimal x, decimal y, System.Nullable<decimal> size = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillPoint" }, x, y, size
                }
            );
        }

        public Graphics fillTriangleShape(Triangle triangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillTriangleShape" }, triangle
                }
            );
        }

        public Graphics strokeTriangleShape(Triangle triangle)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeTriangleShape" }, triangle
                }
            );
        }

        public Graphics fillTriangle(decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillTriangle" }, x0, y0, x1, y1, x2, y2
                }
            );
        }

        public Graphics strokeTriangle(decimal x0, decimal y0, decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeTriangle" }, x0, y0, x1, y1, x2, y2
                }
            );
        }

        public Graphics strokeLineShape(Line line)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeLineShape" }, line
                }
            );
        }

        public Graphics lineBetween(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineBetween" }, x1, y1, x2, y2
                }
            );
        }

        public Graphics lineTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public Graphics moveTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public Graphics strokePoints(CachedEntity[] points, System.Nullable<bool> closeShape = null, System.Nullable<bool> closePath = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokePoints" }, points, closeShape, closePath, endIndex
                }
            );
        }

        public Graphics fillPoints(CachedEntity[] points, System.Nullable<bool> closeShape = null, System.Nullable<bool> closePath = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillPoints" }, points, closeShape, closePath, endIndex
                }
            );
        }

        public Graphics strokeEllipseShape(Ellipse ellipse, System.Nullable<decimal> smoothness = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeEllipseShape" }, ellipse, smoothness
                }
            );
        }

        public Graphics strokeEllipse(decimal x, decimal y, decimal width, decimal height, System.Nullable<decimal> smoothness = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "strokeEllipse" }, x, y, width, height, smoothness
                }
            );
        }

        public Graphics fillEllipseShape(Ellipse ellipse, System.Nullable<decimal> smoothness = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillEllipseShape" }, ellipse, smoothness
                }
            );
        }

        public Graphics fillEllipse(decimal x, decimal y, decimal width, decimal height, System.Nullable<decimal> smoothness = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fillEllipse" }, x, y, width, height, smoothness
                }
            );
        }

        public Graphics arc(decimal x, decimal y, decimal radius, decimal startAngle, decimal endAngle, System.Nullable<bool> anticlockwise = null, System.Nullable<decimal> overshoot = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arc" }, x, y, radius, startAngle, endAngle, anticlockwise, overshoot
                }
            );
        }

        public Graphics slice(decimal x, decimal y, decimal radius, decimal startAngle, decimal endAngle, System.Nullable<bool> anticlockwise = null, System.Nullable<decimal> overshoot = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "slice" }, x, y, radius, startAngle, endAngle, anticlockwise, overshoot
                }
            );
        }

        public Graphics save()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "save" }
                }
            );
        }

        public Graphics restore()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "restore" }
                }
            );
        }

        public Graphics translateCanvas(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateCanvas" }, x, y
                }
            );
        }

        public Graphics scaleCanvas(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleCanvas" }, x, y
                }
            );
        }

        public Graphics rotateCanvas(decimal radians)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateCanvas" }, radians
                }
            );
        }

        public Graphics clear()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public Graphics generateTexture(string key, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateTexture" }, key, width, height
                }
            );
        }

        public Graphics clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Graphics setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public Graphics setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Graphics setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public Graphics setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Graphics clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }, destroyMask
                }
            );
        }

        public BitmapMask createBitmapMask(GameObject renderable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapMask>(
                entity => new BitmapMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBitmapMask" }, renderable
                }
            );
        }

        public GeometryMask createGeometryMask(Graphics graphics = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createGeometryMask" }, graphics
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

        public Graphics setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Graphics setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Graphics setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
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

        public Graphics removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
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

        public Graphics setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Graphics copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Graphics setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Graphics setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Graphics setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Graphics setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Graphics setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Graphics setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Graphics setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Graphics setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
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

        public Graphics setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }

        public Graphics setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }
        #endregion
    }
}