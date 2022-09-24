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

    
    
    [JsonConverter(typeof(CachedEntityConverter<GameObject>))]
    public class GameObject : EventEmitter
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal RENDER_MASK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Phaser",
                    "GameObjects.GameObject.RENDER_MASK"
                );
            }
        }
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
        #endregion
        
        #region Constructor
        public GameObject() : base() { }

        public GameObject(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GameObject(
            Scene scene, string type
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "GameObject" },
                scene, type
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public GameObject setActive(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActive" }, value
                }
            );
        }

        public GameObject setName(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, value
                }
            );
        }

        public GameObject setState(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setState" }, value
                }
            );
        }

        public GameObject setDataEnabled()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDataEnabled" }
                }
            );
        }

        public GameObject setData(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setData" }, key, data
                }
            );
        }

        public GameObject incData(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incData" }, key, data
                }
            );
        }

        public GameObject toggleData(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
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

        public GameObject setInteractive(InputConfiguration hitArea = null, HitAreaCallback callback = null, System.Nullable<bool> dropZone = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInteractive" }, hitArea, callback, dropZone
                }
            );
        }

        public GameObject disableInteractive()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disableInteractive" }
                }
            );
        }

        public GameObject removeInteractive()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
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

        public GameObject addToDisplayList(DisplayList displayList = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addToDisplayList" }, displayList
                }
            );
        }

        public GameObject addToUpdateList()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addToUpdateList" }
                }
            );
        }

        public GameObject removeFromDisplayList()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFromDisplayList" }
                }
            );
        }

        public GameObject removeFromUpdateList()
        {
            return EventHorizonBlazorInterop.FuncClass<GameObject>(
                entity => new GameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFromUpdateList" }
                }
            );
        }

        public void destroy(System.Nullable<bool> fromScene = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, fromScene
                }
            );
        }
        #endregion
    }
}