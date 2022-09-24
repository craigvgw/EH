/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Object3D<CachedEntity>>))]
public class Object3D<E> : EventDispatcher<E> where E : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties
        private static Vector3 __DefaultUp;
        public static Vector3 DefaultUp
        {
            get
            {
            if(__DefaultUp == null)
            {
                __DefaultUp = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "Object3D",
                    "DefaultUp",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __DefaultUp;
            }
            set
            {
__DefaultUp = null;
                EventHorizonBlazorInterop.Set(
                    "Object3D",
                    "DefaultUp",
                    value
                );
            }
        }

        
        public static bool DefaultMatrixAutoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "Object3D",
                    "DefaultMatrixAutoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Object3D",
                    "DefaultMatrixAutoUpdate",
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
        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public string uuid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uuid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uuid",
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

        private Object3D __parent;
        public Object3D parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<Object3D>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Object3D() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public Object3D[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Object3D>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Object3D() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
            }
        }

        private Vector3 __up;
        public Vector3 up
        {
            get
            {
            if(__up == null)
            {
                __up = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "up",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __up;
            }
            set
            {
__up = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "up",
                    value
                );
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
        }

        private Euler __rotation;
        public Euler rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInterop.GetClass<Euler>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Euler() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotation;
            }
        }

        private Quaternion __quaternion;
        public Quaternion quaternion
        {
            get
            {
            if(__quaternion == null)
            {
                __quaternion = EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "quaternion",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __quaternion;
            }
        }

        private Vector3 __scale;
        public Vector3 scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
        }

        private Matrix4 __modelViewMatrix;
        public Matrix4 modelViewMatrix
        {
            get
            {
            if(__modelViewMatrix == null)
            {
                __modelViewMatrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "modelViewMatrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __modelViewMatrix;
            }
        }

        private Matrix3 __normalMatrix;
        public Matrix3 normalMatrix
        {
            get
            {
            if(__normalMatrix == null)
            {
                __normalMatrix = EventHorizonBlazorInterop.GetClass<Matrix3>(
                    this.___guid,
                    "normalMatrix",
                    (entity) =>
                    {
                        return new Matrix3() { ___guid = entity.___guid };
                    }
                );
            }
            return __normalMatrix;
            }
        }

        private Matrix4 __matrix;
        public Matrix4 matrix
        {
            get
            {
            if(__matrix == null)
            {
                __matrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrix;
            }
            set
            {
__matrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        private Matrix4 __matrixWorld;
        public Matrix4 matrixWorld
        {
            get
            {
            if(__matrixWorld == null)
            {
                __matrixWorld = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrixWorld",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrixWorld;
            }
            set
            {
__matrixWorld = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixWorld",
                    value
                );
            }
        }

        
        public bool matrixAutoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "matrixAutoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixAutoUpdate",
                    value
                );
            }
        }

        
        public bool matrixWorldNeedsUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "matrixWorldNeedsUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixWorldNeedsUpdate",
                    value
                );
            }
        }

        private Layers __layers;
        public Layers layers
        {
            get
            {
            if(__layers == null)
            {
                __layers = EventHorizonBlazorInterop.GetClass<Layers>(
                    this.___guid,
                    "layers",
                    (entity) =>
                    {
                        return new Layers() { ___guid = entity.___guid };
                    }
                );
            }
            return __layers;
            }
            set
            {
__layers = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layers",
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

        
        public bool castShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "castShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "castShadow",
                    value
                );
            }
        }

        
        public bool receiveShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "receiveShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "receiveShadow",
                    value
                );
            }
        }

        
        public bool frustumCulled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "frustumCulled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frustumCulled",
                    value
                );
            }
        }

        
        public decimal renderOrder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderOrder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderOrder",
                    value
                );
            }
        }

        
        public AnimationClip[] animations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AnimationClip>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new AnimationClip() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public CachedEntity userData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "userData",
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
                    "userData",
                    value
                );
            }
        }

        private Material __customDepthMaterial;
        public Material customDepthMaterial
        {
            get
            {
            if(__customDepthMaterial == null)
            {
                __customDepthMaterial = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "customDepthMaterial",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __customDepthMaterial;
            }
            set
            {
__customDepthMaterial = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customDepthMaterial",
                    value
                );
            }
        }

        private Material __customDistanceMaterial;
        public Material customDistanceMaterial
        {
            get
            {
            if(__customDistanceMaterial == null)
            {
                __customDistanceMaterial = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "customDistanceMaterial",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __customDistanceMaterial;
            }
            set
            {
__customDistanceMaterial = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customDistanceMaterial",
                    value
                );
            }
        }

        
        public unknown isObject3D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isObject3D"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Object3D() : base() { }

        public Object3D(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region onBeforeRender TODO: Get Comments as metadata identification
        private bool _isOnBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string onBeforeRender(
            Func<Task> callback
        )
        {
            SetupOnBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _onBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onBeforeRender_Remove(
            string handle
        )
        {
            return _onBeforeRenderActionMap.Remove(
                handle
            );
        }

        private void SetupOnBeforeRenderLoop()
        {
            if (_isOnBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onBeforeRender",
                "CallOnBeforeRenderActions",
                _invokableReference
            );
            _isOnBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnBeforeRenderActions()
        {
            foreach (var action in _onBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onAfterRender TODO: Get Comments as metadata identification
        private bool _isOnAfterRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onAfterRenderActionMap = new Dictionary<string, Func<Task>>();

        public string onAfterRender(
            Func<Task> callback
        )
        {
            SetupOnAfterRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _onAfterRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onAfterRender_Remove(
            string handle
        )
        {
            return _onAfterRenderActionMap.Remove(
                handle
            );
        }

        private void SetupOnAfterRenderLoop()
        {
            if (_isOnAfterRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onAfterRender",
                "CallOnAfterRenderActions",
                _invokableReference
            );
            _isOnAfterRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnAfterRenderActions()
        {
            foreach (var action in _onAfterRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void applyMatrix4(Matrix4 matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix
                }
            );
        }

        public Object3D applyQuaternion(Quaternion quaternion)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyQuaternion" }, quaternion
                }
            );
        }

        public void setRotationFromAxisAngle(Vector3 axis, decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationFromAxisAngle" }, axis, angle
                }
            );
        }

        public void setRotationFromEuler(Euler euler)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationFromEuler" }, euler
                }
            );
        }

        public void setRotationFromMatrix(Matrix4 m)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationFromMatrix" }, m
                }
            );
        }

        public void setRotationFromQuaternion(Quaternion q)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationFromQuaternion" }, q
                }
            );
        }

        public Object3D rotateOnAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateOnAxis" }, axis, angle
                }
            );
        }

        public Object3D rotateOnWorldAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateOnWorldAxis" }, axis, angle
                }
            );
        }

        public Object3D rotateX(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateX" }, angle
                }
            );
        }

        public Object3D rotateY(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateY" }, angle
                }
            );
        }

        public Object3D rotateZ(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateZ" }, angle
                }
            );
        }

        public Object3D translateOnAxis(Vector3 axis, decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateOnAxis" }, axis, distance
                }
            );
        }

        public Object3D translateX(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateX" }, distance
                }
            );
        }

        public Object3D translateY(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateY" }, distance
                }
            );
        }

        public Object3D translateZ(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translateZ" }, distance
                }
            );
        }

        public Vector3 localToWorld(Vector3 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "localToWorld" }, vector
                }
            );
        }

        public Vector3 worldToLocal(Vector3 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "worldToLocal" }, vector
                }
            );
        }

        public void lookAt(Vector3 vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, vector
                }
            );
        }

        public Object3D add(Object3D[] @object)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, @object
                }
            );
        }

        public Object3D remove(Object3D[] @object)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, @object
                }
            );
        }

        public Object3D removeFromParent()
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeFromParent" }
                }
            );
        }

        public Object3D clear()
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public Object3D attach(Object3D @object)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "attach" }, @object
                }
            );
        }

        public Object3D getObjectById(decimal id)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectById" }, id
                }
            );
        }

        public Object3D getObjectByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectByName" }, name
                }
            );
        }

        public Object3D getObjectByProperty(string name, string value)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectByProperty" }, name, value
                }
            );
        }

        public Vector3 getWorldPosition(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldPosition" }, target
                }
            );
        }

        public Quaternion getWorldQuaternion(Quaternion target)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldQuaternion" }, target
                }
            );
        }

        public Vector3 getWorldScale(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldScale" }, target
                }
            );
        }

        public Vector3 getWorldDirection(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldDirection" }, target
                }
            );
        }

        public void raycast(Raycaster raycaster, Intersection[] intersects)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "raycast" }, raycaster, intersects
                }
            );
        }

        #region traverse TODO: Get Comments as metadata identification
        private bool _isTraverseEnabled = false;
        private readonly IDictionary<string, Func<Object3D, Task>> _traverseActionMap = new Dictionary<string, Func<Object3D, Task>>();

        public string traverse(
            Func<Object3D, Task> callback
        )
        {
            SetupTraverseLoop();

            var handle = Guid.NewGuid().ToString();
            _traverseActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool traverse_Remove(
            string handle
        )
        {
            return _traverseActionMap.Remove(
                handle
            );
        }

        private void SetupTraverseLoop()
        {
            if (_isTraverseEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "traverse",
                "CallTraverseActions",
                _invokableReference
            );
            _isTraverseEnabled = true;
        }

        [JSInvokable]
        public async Task CallTraverseActions(Object3D @object)
        {
            foreach (var action in _traverseActionMap.Values)
            {
                await action(@object);
            }
        }
        #endregion

        #region traverseVisible TODO: Get Comments as metadata identification
        private bool _isTraverseVisibleEnabled = false;
        private readonly IDictionary<string, Func<Object3D, Task>> _traverseVisibleActionMap = new Dictionary<string, Func<Object3D, Task>>();

        public string traverseVisible(
            Func<Object3D, Task> callback
        )
        {
            SetupTraverseVisibleLoop();

            var handle = Guid.NewGuid().ToString();
            _traverseVisibleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool traverseVisible_Remove(
            string handle
        )
        {
            return _traverseVisibleActionMap.Remove(
                handle
            );
        }

        private void SetupTraverseVisibleLoop()
        {
            if (_isTraverseVisibleEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "traverseVisible",
                "CallTraverseVisibleActions",
                _invokableReference
            );
            _isTraverseVisibleEnabled = true;
        }

        [JSInvokable]
        public async Task CallTraverseVisibleActions(Object3D @object)
        {
            foreach (var action in _traverseVisibleActionMap.Values)
            {
                await action(@object);
            }
        }
        #endregion

        #region traverseAncestors TODO: Get Comments as metadata identification
        private bool _isTraverseAncestorsEnabled = false;
        private readonly IDictionary<string, Func<Object3D, Task>> _traverseAncestorsActionMap = new Dictionary<string, Func<Object3D, Task>>();

        public string traverseAncestors(
            Func<Object3D, Task> callback
        )
        {
            SetupTraverseAncestorsLoop();

            var handle = Guid.NewGuid().ToString();
            _traverseAncestorsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool traverseAncestors_Remove(
            string handle
        )
        {
            return _traverseAncestorsActionMap.Remove(
                handle
            );
        }

        private void SetupTraverseAncestorsLoop()
        {
            if (_isTraverseAncestorsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "traverseAncestors",
                "CallTraverseAncestorsActions",
                _invokableReference
            );
            _isTraverseAncestorsEnabled = true;
        }

        [JSInvokable]
        public async Task CallTraverseAncestorsActions(Object3D @object)
        {
            foreach (var action in _traverseAncestorsActionMap.Values)
            {
                await action(@object);
            }
        }
        #endregion

        public void updateMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrix" }
                }
            );
        }

        public void updateMatrixWorld(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrixWorld" }, force
                }
            );
        }

        public void updateWorldMatrix(bool updateParents, bool updateChildren)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateWorldMatrix" }, updateParents, updateChildren
                }
            );
        }

        public CachedEntity toJSON(object meta = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, meta
                }
            );
        }

        public Object3D clone(System.Nullable<bool> recursive = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, recursive
                }
            );
        }

        public Object3D copy(Object3D source, System.Nullable<bool> recursive = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Object3D>(
                entity => new Object3D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source, recursive
                }
            );
        }
    #endregion
}
