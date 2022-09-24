/// Generated - Do Not Edit
namespace Phaser.GameObjects.Particles
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleEmitterManager>))]
    public class ParticleEmitterManager : GameObject, IDepth, IMask, IPipeline, ITransform, IVisible
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
        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
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

        
        public string[] frameNames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "frameNames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frameNames",
                    value
                );
            }
        }

        private List<ParticleEmitter> __emitters;
        public List<ParticleEmitter> emitters
        {
            get
            {
            if(__emitters == null)
            {
                __emitters = EventHorizonBlazorInterop.GetClass<List<ParticleEmitter>>(
                    this.___guid,
                    "emitters",
                    (entity) =>
                    {
                        return new List<ParticleEmitter>() { ___guid = entity.___guid };
                    }
                );
            }
            return __emitters;
            }
            set
            {
__emitters = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitters",
                    value
                );
            }
        }

        private List<GravityWell> __wells;
        public List<GravityWell> wells
        {
            get
            {
            if(__wells == null)
            {
                __wells = EventHorizonBlazorInterop.GetClass<List<GravityWell>>(
                    this.___guid,
                    "wells",
                    (entity) =>
                    {
                        return new List<GravityWell>() { ___guid = entity.___guid };
                    }
                );
            }
            return __wells;
            }
            set
            {
__wells = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wells",
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
        #endregion
        
        #region Constructor
        public ParticleEmitterManager() : base() { }

        public ParticleEmitterManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ParticleEmitterManager(
            Scene scene, string texture, string frame = null, ParticleEmitterConfig emitters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Particles", "ParticleEmitterManager" },
                scene, texture, frame, emitters
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ParticleEmitterManager setTexture(string key, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, key, frame
                }
            );
        }

        public ParticleEmitterManager setFrame(string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frame
                }
            );
        }

        public ParticleEmitterManager setEmitterFrames(Frame frames, ParticleEmitter emitter)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmitterFrames" }, frames, emitter
                }
            );
        }

        public ParticleEmitter addEmitter(ParticleEmitter emitter)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addEmitter" }, emitter
                }
            );
        }

        public ParticleEmitter createEmitter(ParticleEmitterConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createEmitter" }, config
                }
            );
        }

        public ParticleEmitter removeEmitter(ParticleEmitter emitter)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitter>(
                entity => new ParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeEmitter" }, emitter
                }
            );
        }

        public GravityWell addGravityWell(GravityWell well)
        {
            return EventHorizonBlazorInterop.FuncClass<GravityWell>(
                entity => new GravityWell() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addGravityWell" }, well
                }
            );
        }

        public GravityWell createGravityWell(GravityWellConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<GravityWell>(
                entity => new GravityWell() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createGravityWell" }, config
                }
            );
        }

        public ParticleEmitterManager emitParticle(System.Nullable<decimal> count = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "emitParticle" }, count, x, y
                }
            );
        }

        public ParticleEmitterManager emitParticleAt(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> count = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "emitParticleAt" }, x, y, count
                }
            );
        }

        public ParticleEmitterManager pause()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public ParticleEmitterManager resume()
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resume" }
                }
            );
        }

        public GravityWell[] getProcessors()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GravityWell>(
                entity => new GravityWell() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProcessors" }
                }
            );
        }

        public void preUpdate(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preUpdate" }, time, delta
                }
            );
        }

        public ParticleEmitterManager setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public ParticleEmitterManager setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public ParticleEmitterManager clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
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

        public ParticleEmitterManager setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public ParticleEmitterManager setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public ParticleEmitterManager setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
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

        public ParticleEmitterManager removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
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

        public ParticleEmitterManager setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public ParticleEmitterManager copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public ParticleEmitterManager setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public ParticleEmitterManager setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public ParticleEmitterManager setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public ParticleEmitterManager setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public ParticleEmitterManager setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public ParticleEmitterManager setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public ParticleEmitterManager setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public ParticleEmitterManager setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
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

        public ParticleEmitterManager setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleEmitterManager>(
                entity => new ParticleEmitterManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}