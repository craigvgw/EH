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

    
    
    [JsonConverter(typeof(CachedEntityConverter<IsoTriangle>))]
    public class IsoTriangle : Shape
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
        
        public decimal projection
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "projection"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projection",
                    value
                );
            }
        }

        
        public decimal fillTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillTop",
                    value
                );
            }
        }

        
        public decimal fillLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillLeft",
                    value
                );
            }
        }

        
        public decimal fillRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillRight",
                    value
                );
            }
        }

        
        public bool showTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showTop",
                    value
                );
            }
        }

        
        public bool showLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showLeft",
                    value
                );
            }
        }

        
        public bool showRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showRight",
                    value
                );
            }
        }

        
        public bool isReversed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isReversed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isReversed",
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
        public IsoTriangle() : base() { }

        public IsoTriangle(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public IsoTriangle(
            Scene scene, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> size = null, System.Nullable<decimal> height = null, System.Nullable<bool> reversed = null, System.Nullable<decimal> fillTop = null, System.Nullable<decimal> fillLeft = null, System.Nullable<decimal> fillRight = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "IsoTriangle" },
                scene, x, y, size, height, reversed, fillTop, fillLeft, fillRight
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public IsoTriangle setProjection(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setProjection" }, value
                }
            );
        }

        public IsoTriangle setReversed(bool reversed)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setReversed" }, reversed
                }
            );
        }

        public IsoTriangle setFaces(System.Nullable<bool> showTop = null, System.Nullable<bool> showLeft = null, System.Nullable<bool> showRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFaces" }, showTop, showLeft, showRight
                }
            );
        }

        public IsoTriangle setFillStyle(System.Nullable<decimal> fillTop = null, System.Nullable<decimal> fillLeft = null, System.Nullable<decimal> fillRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFillStyle" }, fillTop, fillLeft, fillRight
                }
            );
        }

        public IsoTriangle clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public IsoTriangle setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public IsoTriangle setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public IsoTriangle setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
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

        public IsoTriangle setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public IsoTriangle clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
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

        public IsoTriangle setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public IsoTriangle setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public IsoTriangle setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public IsoTriangle updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
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

        public IsoTriangle setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public IsoTriangle setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public IsoTriangle setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
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

        public IsoTriangle removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
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

        public IsoTriangle setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public IsoTriangle setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public IsoTriangle copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public IsoTriangle setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public IsoTriangle setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public IsoTriangle setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public IsoTriangle setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public IsoTriangle setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public IsoTriangle setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public IsoTriangle setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public IsoTriangle setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
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

        public IsoTriangle setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<IsoTriangle>(
                entity => new IsoTriangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}