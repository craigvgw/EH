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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Group>))]
    public class Group : EventEmitter
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

        private Set<GameObject> __children;
        public Set<GameObject> children
        {
            get
            {
            if(__children == null)
            {
                __children = EventHorizonBlazorInterop.GetClass<Set<GameObject>>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Set<GameObject>() { ___guid = entity.___guid };
                    }
                );
            }
            return __children;
            }
            set
            {
__children = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
            }
        }

        
        public bool isParent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isParent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isParent",
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

        
        public decimal maxSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSize",
                    value
                );
            }
        }

        
        public string defaultKey
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultKey"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultKey",
                    value
                );
            }
        }

        
        public string defaultFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultFrame",
                    value
                );
            }
        }

        
        public bool runChildUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "runChildUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "runChildUpdate",
                    value
                );
            }
        }

        private GroupCallback __createCallback;
        public GroupCallback createCallback
        {
            get
            {
            if(__createCallback == null)
            {
                __createCallback = EventHorizonBlazorInterop.GetClass<GroupCallback>(
                    this.___guid,
                    "createCallback",
                    (entity) =>
                    {
                        return new GroupCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __createCallback;
            }
            set
            {
__createCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "createCallback",
                    value
                );
            }
        }

        private GroupCallback __removeCallback;
        public GroupCallback removeCallback
        {
            get
            {
            if(__removeCallback == null)
            {
                __removeCallback = EventHorizonBlazorInterop.GetClass<GroupCallback>(
                    this.___guid,
                    "removeCallback",
                    (entity) =>
                    {
                        return new GroupCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __removeCallback;
            }
            set
            {
__removeCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "removeCallback",
                    value
                );
            }
        }

        private GroupMultipleCreateCallback __createMultipleCallback;
        public GroupMultipleCreateCallback createMultipleCallback
        {
            get
            {
            if(__createMultipleCallback == null)
            {
                __createMultipleCallback = EventHorizonBlazorInterop.GetClass<GroupMultipleCreateCallback>(
                    this.___guid,
                    "createMultipleCallback",
                    (entity) =>
                    {
                        return new GroupMultipleCreateCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __createMultipleCallback;
            }
            set
            {
__createMultipleCallback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "createMultipleCallback",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Group() : base() { }

        public Group(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Group(
            Scene scene, GameObject[] children = null, GroupConfig config = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Group" },
                scene, children, config
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void classType()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "classType" }
                }
            );
        }

        public CachedEntity create(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null, System.Nullable<bool> active = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "create" }, x, y, key, frame, visible, active
                }
            );
        }

        public CachedEntity[] createMultiple(GroupCreateConfig config)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createMultiple" }, config
                }
            );
        }

        public CachedEntity[] createFromConfig(GroupCreateConfig options)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createFromConfig" }, options
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

        public Group add(GameObject child, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, child, addToScene
                }
            );
        }

        public Group addMultiple(GameObject[] children, System.Nullable<bool> addToScene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMultiple" }, children, addToScene
                }
            );
        }

        public Group remove(GameObject child, System.Nullable<bool> removeFromScene = null, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, child, removeFromScene, destroyChild
                }
            );
        }

        public Group clear(System.Nullable<bool> removeFromScene = null, System.Nullable<bool> destroyChild = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }, removeFromScene, destroyChild
                }
            );
        }

        public bool contains(GameObject child)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, child
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

        public decimal getLength()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLength" }
                }
            );
        }

        public CachedEntity[] getMatching(string property = null, object value = null, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getMatching" }, property, value, startIndex, endIndex
                }
            );
        }

        public CachedEntity getFirst(System.Nullable<bool> state = null, System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFirst" }, state, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity getFirstNth(decimal nth, System.Nullable<bool> state = null, System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFirstNth" }, nth, state, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity getLast(System.Nullable<bool> state = null, System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLast" }, state, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity getLastNth(decimal nth, System.Nullable<bool> state = null, System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLastNth" }, nth, state, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity get(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity getFirstAlive(System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFirstAlive" }, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public CachedEntity getFirstDead(System.Nullable<bool> createIfNull = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string key = null, string frame = null, System.Nullable<bool> visible = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFirstDead" }, createIfNull, x, y, key, frame, visible
                }
            );
        }

        public Group playAnimation(string key, string startFrame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "playAnimation" }, key, startFrame
                }
            );
        }

        public bool isFull()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFull" }
                }
            );
        }

        public decimal countActive(System.Nullable<bool> value = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "countActive" }, value
                }
            );
        }

        public decimal getTotalUsed()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalUsed" }
                }
            );
        }

        public decimal getTotalFree()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalFree" }
                }
            );
        }

        public Group setActive(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActive" }, value
                }
            );
        }

        public Group setName(string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setName" }, value
                }
            );
        }

        public Group propertyValueSet(string key, decimal value, System.Nullable<decimal> step = null, System.Nullable<decimal> index = null, System.Nullable<decimal> direction = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "propertyValueSet" }, key, value, step, index, direction
                }
            );
        }

        public Group propertyValueInc(string key, decimal value, System.Nullable<decimal> step = null, System.Nullable<decimal> index = null, System.Nullable<decimal> direction = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "propertyValueInc" }, key, value, step, index, direction
                }
            );
        }

        public Group setX(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value, step
                }
            );
        }

        public Group setY(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value, step
                }
            );
        }

        public Group setXY(decimal x, System.Nullable<decimal> y = null, System.Nullable<decimal> stepX = null, System.Nullable<decimal> stepY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXY" }, x, y, stepX, stepY
                }
            );
        }

        public Group incX(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incX" }, value, step
                }
            );
        }

        public Group incY(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incY" }, value, step
                }
            );
        }

        public Group incXY(decimal x, System.Nullable<decimal> y = null, System.Nullable<decimal> stepX = null, System.Nullable<decimal> stepY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incXY" }, x, y, stepX, stepY
                }
            );
        }

        public Group shiftPosition(decimal x, decimal y, System.Nullable<decimal> direction = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shiftPosition" }, x, y, direction
                }
            );
        }

        public Group angle(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "angle" }, value, step
                }
            );
        }

        public Group rotate(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, value, step
                }
            );
        }

        public Group rotateAround(Vector2Like point, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAround" }, point, angle
                }
            );
        }

        public Group rotateAroundDistance(Vector2Like point, decimal angle, decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAroundDistance" }, point, angle, distance
                }
            );
        }

        public Group setAlpha(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value, step
                }
            );
        }

        public Group setTint(decimal topLeft, System.Nullable<decimal> topRight = null, System.Nullable<decimal> bottomLeft = null, System.Nullable<decimal> bottomRight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, topLeft, topRight, bottomLeft, bottomRight
                }
            );
        }

        public Group setOrigin(decimal originX, System.Nullable<decimal> originY = null, System.Nullable<decimal> stepX = null, System.Nullable<decimal> stepY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, originX, originY, stepX, stepY
                }
            );
        }

        public Group scaleX(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleX" }, value, step
                }
            );
        }

        public Group scaleY(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleY" }, value, step
                }
            );
        }

        public Group scaleXY(decimal scaleX, System.Nullable<decimal> scaleY = null, System.Nullable<decimal> stepX = null, System.Nullable<decimal> stepY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleXY" }, scaleX, scaleY, stepX, stepY
                }
            );
        }

        public Group setDepth(decimal value, System.Nullable<decimal> step = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value, step
                }
            );
        }

        public Group setBlendMode(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, value
                }
            );
        }

        public Group setHitArea(object hitArea, HitAreaCallback hitAreaCallback)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setHitArea" }, hitArea, hitAreaCallback
                }
            );
        }

        public Group shuffle()
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }
                }
            );
        }

        public void kill(GameObject gameObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "kill" }, gameObject
                }
            );
        }

        public void killAndHide(GameObject gameObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "killAndHide" }, gameObject
                }
            );
        }

        public Group setVisible(bool value, System.Nullable<decimal> index = null, System.Nullable<decimal> direction = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value, index, direction
                }
            );
        }

        public Group toggleVisible()
        {
            return EventHorizonBlazorInterop.FuncClass<Group>(
                entity => new Group() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleVisible" }
                }
            );
        }

        public void destroy(System.Nullable<bool> destroyChildren = null, System.Nullable<bool> removeFromScene = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, destroyChildren, removeFromScene
                }
            );
        }
        #endregion
    }
}