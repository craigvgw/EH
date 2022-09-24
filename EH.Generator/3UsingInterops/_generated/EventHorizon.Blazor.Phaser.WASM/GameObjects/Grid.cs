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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Grid>))]
    public class Grid : Shape
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
        
        public decimal cellWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellWidth",
                    value
                );
            }
        }

        
        public decimal cellHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellHeight",
                    value
                );
            }
        }

        
        public bool showCells
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showCells"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showCells",
                    value
                );
            }
        }

        
        public decimal outlineFillColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineFillColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineFillColor",
                    value
                );
            }
        }

        
        public decimal outlineFillAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineFillAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineFillAlpha",
                    value
                );
            }
        }

        
        public bool showOutline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showOutline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showOutline",
                    value
                );
            }
        }

        
        public bool showAltCells
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showAltCells"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showAltCells",
                    value
                );
            }
        }

        
        public decimal altFillColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "altFillColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "altFillColor",
                    value
                );
            }
        }

        
        public decimal altFillAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "altFillAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "altFillAlpha",
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
        public Grid() : base() { }

        public Grid(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Grid(
            Scene scene, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> cellWidth = null, System.Nullable<decimal> cellHeight = null, System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null, System.Nullable<decimal> outlineFillColor = null, System.Nullable<decimal> outlineFillAlpha = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Grid" },
                scene, x, y, width, height, cellWidth, cellHeight, fillColor, fillAlpha, outlineFillColor, outlineFillAlpha
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Grid setFillStyle(System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFillStyle" }, fillColor, fillAlpha
                }
            );
        }

        public Grid setAltFillStyle(System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAltFillStyle" }, fillColor, fillAlpha
                }
            );
        }

        public Grid setOutlineStyle(System.Nullable<decimal> fillColor = null, System.Nullable<decimal> fillAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOutlineStyle" }, fillColor, fillAlpha
                }
            );
        }

        public Grid clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Grid setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public Grid setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Grid setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Grid clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public Grid setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public Grid setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public Grid updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Grid setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Grid setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public Grid setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Grid copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Grid setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Grid setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Grid setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Grid setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Grid setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Grid setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Grid setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Grid setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
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

        public Grid setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}