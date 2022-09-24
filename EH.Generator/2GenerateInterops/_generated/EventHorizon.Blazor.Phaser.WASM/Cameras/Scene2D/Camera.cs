/// Generated - Do Not Edit
namespace Phaser.Cameras.Scene2D
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Camera>))]
    public class Camera : BaseCamera, IFlip, ITint, IPipeline
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
        
        public bool inputEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputEnabled",
                    value
                );
            }
        }

        private Fade __fadeEffect;
        public Fade fadeEffect
        {
            get
            {
            if(__fadeEffect == null)
            {
                __fadeEffect = EventHorizonBlazorInterop.GetClass<Fade>(
                    this.___guid,
                    "fadeEffect",
                    (entity) =>
                    {
                        return new Fade() { ___guid = entity.___guid };
                    }
                );
            }
            return __fadeEffect;
            }
            set
            {
__fadeEffect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fadeEffect",
                    value
                );
            }
        }

        private Flash __flashEffect;
        public Flash flashEffect
        {
            get
            {
            if(__flashEffect == null)
            {
                __flashEffect = EventHorizonBlazorInterop.GetClass<Flash>(
                    this.___guid,
                    "flashEffect",
                    (entity) =>
                    {
                        return new Flash() { ___guid = entity.___guid };
                    }
                );
            }
            return __flashEffect;
            }
            set
            {
__flashEffect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flashEffect",
                    value
                );
            }
        }

        private Shake __shakeEffect;
        public Shake shakeEffect
        {
            get
            {
            if(__shakeEffect == null)
            {
                __shakeEffect = EventHorizonBlazorInterop.GetClass<Shake>(
                    this.___guid,
                    "shakeEffect",
                    (entity) =>
                    {
                        return new Shake() { ___guid = entity.___guid };
                    }
                );
            }
            return __shakeEffect;
            }
            set
            {
__shakeEffect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shakeEffect",
                    value
                );
            }
        }

        private Pan __panEffect;
        public Pan panEffect
        {
            get
            {
            if(__panEffect == null)
            {
                __panEffect = EventHorizonBlazorInterop.GetClass<Pan>(
                    this.___guid,
                    "panEffect",
                    (entity) =>
                    {
                        return new Pan() { ___guid = entity.___guid };
                    }
                );
            }
            return __panEffect;
            }
            set
            {
__panEffect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panEffect",
                    value
                );
            }
        }

        private RotateTo __rotateToEffect;
        public RotateTo rotateToEffect
        {
            get
            {
            if(__rotateToEffect == null)
            {
                __rotateToEffect = EventHorizonBlazorInterop.GetClass<RotateTo>(
                    this.___guid,
                    "rotateToEffect",
                    (entity) =>
                    {
                        return new RotateTo() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotateToEffect;
            }
            set
            {
__rotateToEffect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotateToEffect",
                    value
                );
            }
        }

        
        public int zoomEffect
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "zoomEffect"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomEffect",
                    value
                );
            }
        }

        private Vector2 __lerp;
        public Vector2 lerp
        {
            get
            {
            if(__lerp == null)
            {
                __lerp = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "lerp",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __lerp;
            }
            set
            {
__lerp = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lerp",
                    value
                );
            }
        }

        private Vector2 __followOffset;
        public Vector2 followOffset
        {
            get
            {
            if(__followOffset == null)
            {
                __followOffset = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "followOffset",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __followOffset;
            }
            set
            {
__followOffset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "followOffset",
                    value
                );
            }
        }

        private Rectangle __deadzone;
        public Rectangle deadzone
        {
            get
            {
            if(__deadzone == null)
            {
                __deadzone = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "deadzone",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __deadzone;
            }
            set
            {
__deadzone = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deadzone",
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
        #endregion
        
        #region Constructor
        public Camera() : base() { }

        public Camera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Camera(
            decimal x, decimal y, decimal width, decimal height
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Cameras", "Scene2D", "Camera" },
                x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Camera setDeadzone(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDeadzone" }, width, height
                }
            );
        }

        public Camera pan(decimal x, decimal y, System.Nullable<decimal> duration = null, string ease = null, System.Nullable<bool> force = null, CameraPanCallback callback = null, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pan" }, x, y, duration, ease, force, callback, context
                }
            );
        }

        public Camera rotateTo(decimal radians, System.Nullable<bool> shortestPath = null, System.Nullable<decimal> duration = null, string ease = null, System.Nullable<bool> force = null, ActionCallback<Camera, decimal, decimal> callback = null, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateTo" }, radians, shortestPath, duration, ease, force, callback, context
                }
            );
        }

        public Camera zoomTo(decimal zoom, System.Nullable<decimal> duration = null, string ease = null, System.Nullable<bool> force = null, CameraPanCallback callback = null, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "zoomTo" }, zoom, duration, ease, force, callback, context
                }
            );
        }

        public Camera setLerp(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setLerp" }, x, y
                }
            );
        }

        public Camera setFollowOffset(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFollowOffset" }, x, y
                }
            );
        }

        public Camera startFollow(GameObject target, System.Nullable<bool> roundPixels = null, System.Nullable<decimal> lerpX = null, System.Nullable<decimal> lerpY = null, System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "startFollow" }, target, roundPixels, lerpX, lerpY, offsetX, offsetY
                }
            );
        }

        public Camera stopFollow()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopFollow" }
                }
            );
        }

        public Camera resetFX()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFX" }
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

        public Camera clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Camera toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public Camera toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public Camera setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public Camera setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public Camera setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public Camera resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public Camera clearTint()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTint" }
                }
            );
        }

        public Camera setTint(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Camera setTintFill(System.Nullable<decimal> topLeft = null, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTintFill" }, topLeft, topRight, bottomLeft, bottomRight
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

        public Camera setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Camera setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Camera setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
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

        public Camera removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
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


        #endregion
    }
}