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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Layer>))]
    public class Layer : List<GameObject>, IAlphaSingle, IBlendMode, IDepth, IMask, IPipeline, IVisible
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

        private DisplayList __displayList;
        public DisplayList displayList
        {
            get
            {
            if(__displayList == null)
            {
                __displayList = EventHorizonBlazorInterop.GetClass<DisplayList>(
                    this.___guid,
                    "displayList",
                    (entity) =>
                    {
                        return new DisplayList() { ___guid = entity.___guid };
                    }
                );
            }
            return __displayList;
            }
            set
            {
__displayList = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayList",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal state
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        private Container __parentContainer;
        public Container parentContainer
        {
            get
            {
            if(__parentContainer == null)
            {
                __parentContainer = EventHorizonBlazorInterop.GetClass<Container>(
                    this.___guid,
                    "parentContainer",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentContainer;
            }
            set
            {
__parentContainer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parentContainer",
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

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }

        
        public decimal tabIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tabIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tabIndex",
                    value
                );
            }
        }

        private DataManager __data;
        public DataManager data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<DataManager>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new DataManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal renderFlags
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderFlags"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderFlags",
                    value
                );
            }
        }

        
        public decimal cameraFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraFilter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraFilter",
                    value
                );
            }
        }

        private InteractiveObject __input;
        public InteractiveObject input
        {
            get
            {
            if(__input == null)
            {
                __input = EventHorizonBlazorInterop.GetClass<InteractiveObject>(
                    this.___guid,
                    "input",
                    (entity) =>
                    {
                        return new InteractiveObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __input;
            }
            set
            {
__input = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "input",
                    value
                );
            }
        }

        private Body __body;
        public Body body
        {
            get
            {
            if(__body == null)
            {
                __body = EventHorizonBlazorInterop.GetClass<Body>(
                    this.___guid,
                    "body",
                    (entity) =>
                    {
                        return new Body() { ___guid = entity.___guid };
                    }
                );
            }
            return __body;
            }
            set
            {
__body = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "body",
                    value
                );
            }
        }

        
        public bool ignoreDestroy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreDestroy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreDestroy",
                    value
                );
            }
        }

        private Systems __systems;
        public Systems systems
        {
            get
            {
            if(__systems == null)
            {
                __systems = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __systems;
            }
            set
            {
__systems = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
        }

        private EventEmitter __events;
        public EventEmitter events
        {
            get
            {
            if(__events == null)
            {
                __events = EventHorizonBlazorInterop.GetClass<EventEmitter>(
                    this.___guid,
                    "events",
                    (entity) =>
                    {
                        return new EventEmitter() { ___guid = entity.___guid };
                    }
                );
            }
            return __events;
            }
            set
            {
__events = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "events",
                    value
                );
            }
        }

        
        public bool sortChildrenFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortChildrenFlag"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortChildrenFlag",
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
        public Layer() : base() { }

        public Layer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Layer(
            Scene scene, GameObject[] children = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Layer" },
                scene, children
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Layer setActive(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActive" }, value
                }
            );
        }

        public Layer setName(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, value
                }
            );
        }

        public Layer setState(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setState" }, value
                }
            );
        }

        public Layer setDataEnabled()
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDataEnabled" }
                }
            );
        }

        public Layer setData(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setData" }, key, data
                }
            );
        }

        public Layer incData(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incData" }, key, data
                }
            );
        }

        public Layer toggleData(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleData" }, key
                }
            );
        }

        public CachedEntity getData(string key)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }, key
                }
            );
        }

        public Layer setInteractive()
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInteractive" }
                }
            );
        }

        public Layer disableInteractive()
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disableInteractive" }
                }
            );
        }

        public Layer removeInteractive()
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeInteractive" }
                }
            );
        }

        public void addedToScene()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addedToScene" }
                }
            );
        }

        public void removedFromScene()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removedFromScene" }
                }
            );
        }

        public void update(CachedEntity[] args)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, args
                }
            );
        }

        public JSONGameObject toJSON()
        {
            return EventHorizonBlazorInterop.FuncClass<JSONGameObject>(
                entity => new JSONGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public bool willRender(Camera camera)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willRender" }, camera
                }
            );
        }

        public decimal[] getIndexList()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndexList" }
                }
            );
        }

        public void queueDepthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "queueDepthSort" }
                }
            );
        }

        public void depthSort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "depthSort" }
                }
            );
        }

        public decimal sortByDepth(GameObject childA, GameObject childB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "sortByDepth" }, childA, childB
                }
            );
        }

        public GameObject[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
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

        public Layer clearAlpha()
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearAlpha" }
                }
            );
        }

        public Layer setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public Layer setBlendMode(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Layer setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public Layer setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Layer clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
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

        public Layer setPipeline(string pipeline, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPipeline" }, pipeline, pipelineData, copyData
                }
            );
        }

        public Layer setPostPipeline(string pipelines, object pipelineData = null, System.Nullable<bool> copyData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPostPipeline" }, pipelines, pipelineData, copyData
                }
            );
        }

        public Layer setPipelineData(string key, object value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
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

        public Layer removePostPipeline(string pipeline)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
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

        public Layer setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Layer>(
                entity => new Layer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}