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

    
    
    [JsonConverter(typeof(CachedEntityConverter<DynamicBitmapText>))]
    public class DynamicBitmapText : BitmapText
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
        
        public decimal scrollX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollX",
                    value
                );
            }
        }

        
        public decimal scrollY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollY",
                    value
                );
            }
        }

        
        public decimal cropWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cropWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cropWidth",
                    value
                );
            }
        }

        
        public decimal cropHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cropHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cropHeight",
                    value
                );
            }
        }

        private DisplayCallback __displayCallback;
        public DisplayCallback displayCallback
        {
            get
            {
            if(__displayCallback == null)
            {
                __displayCallback = EventHorizonBlazorInterop.GetClass<DisplayCallback>(
                    this.___guid,
                    "displayCallback",
                    (entity) =>
                    {
                        return new DisplayCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayCallback;
            }
            set
            {
__displayCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayCallback",
                    value
                );
            }
        }

        private DisplayCallbackConfig __callbackData;
        public DisplayCallbackConfig callbackData
        {
            get
            {
            if(__callbackData == null)
            {
                __callbackData = EventHorizonBlazorInterop.GetClass<DisplayCallbackConfig>(
                    this.___guid,
                    "callbackData",
                    (entity) =>
                    {
                        return new DisplayCallbackConfig() { ___guid = entity.___guid };
                    }
                );
            }
            return __callbackData;
            }
            set
            {
__callbackData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callbackData",
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

        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        private Frame __frame;
        public Frame frame
        {
            get
            {
            if(__frame == null)
            {
                __frame = EventHorizonBlazorInterop.GetClass<Frame>(
                    this.___guid,
                    "frame",
                    (entity) =>
                    {
                        return new Frame() { ___guid = entity.___guid };
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

        
        public decimal tintTopLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopLeft",
                    value
                );
            }
        }

        
        public decimal tintTopRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintTopRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintTopRight",
                    value
                );
            }
        }

        
        public decimal tintBottomLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomLeft",
                    value
                );
            }
        }

        
        public decimal tintBottomRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tintBottomRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintBottomRight",
                    value
                );
            }
        }

        
        public bool tintFill
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "tintFill"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tintFill",
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

        
        public bool isTinted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isTinted"
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
        public DynamicBitmapText() : base() { }

        public DynamicBitmapText(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DynamicBitmapText(
            Scene scene, decimal x, decimal y, string font, string text = null, System.Nullable<decimal> size = null, System.Nullable<decimal> align = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "DynamicBitmapText" },
                scene, x, y, font, text, size, align
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public DynamicBitmapText setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public DynamicBitmapText setDisplayCallback(DisplayCallback callback)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayCallback" }, callback
                }
            );
        }

        public DynamicBitmapText setScrollX(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollX" }, value
                }
            );
        }

        public DynamicBitmapText setScrollY(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollY" }, value
                }
            );
        }

        public DynamicBitmapText clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public DynamicBitmapText setAlpha(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public DynamicBitmapText setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public DynamicBitmapText setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public DynamicBitmapText setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public DynamicBitmapText clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
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

        public DynamicBitmapText setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public DynamicBitmapText setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public DynamicBitmapText setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
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

        public DynamicBitmapText setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public DynamicBitmapText setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public DynamicBitmapText setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
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

        public DynamicBitmapText removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
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

        public DynamicBitmapText setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public DynamicBitmapText setTexture(string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, key, frame
                }
            );
        }

        public DynamicBitmapText setFrame(string frame, System.Nullable<bool> updateSize = null, System.Nullable<bool> updateOrigin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frame, updateSize, updateOrigin
                }
            );
        }

        public DynamicBitmapText clearTint()
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTint" }
                }
            );
        }

        public DynamicBitmapText setTint(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public DynamicBitmapText setTintFill(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTintFill" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public DynamicBitmapText setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public DynamicBitmapText copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public DynamicBitmapText setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public DynamicBitmapText setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public DynamicBitmapText setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public DynamicBitmapText setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public DynamicBitmapText setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public DynamicBitmapText setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public DynamicBitmapText setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public DynamicBitmapText setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
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

        public DynamicBitmapText setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicBitmapText>(
                entity => new DynamicBitmapText() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}