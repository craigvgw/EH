/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DisplayObject>))]
public class DisplayObject : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void mixin(CachedEntity source)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "DisplayObject", "mixin" }, source
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool destroyed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "destroyed"
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

        private Matrix __worldTransform;
        public Matrix worldTransform
        {
            get
            {
            if(__worldTransform == null)
            {
                __worldTransform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "worldTransform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldTransform;
            }
        }

        private Matrix __localTransform;
        public Matrix localTransform
        {
            get
            {
            if(__localTransform == null)
            {
                __localTransform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "localTransform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __localTransform;
            }
        }

        private ObservablePoint __position;
        public ObservablePoint position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private ObservablePoint __scale;
        public ObservablePoint scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        private ObservablePoint __pivot;
        public ObservablePoint pivot
        {
            get
            {
            if(__pivot == null)
            {
                __pivot = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "pivot",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __pivot;
            }
            set
            {
__pivot = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pivot",
                    value
                );
            }
        }

        private ObservablePoint __skew;
        public ObservablePoint skew
        {
            get
            {
            if(__skew == null)
            {
                __skew = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "skew",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __skew;
            }
            set
            {
__skew = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skew",
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

        
        public decimal zIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zIndex",
                    value
                );
            }
        }

        
        public bool worldVisible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "worldVisible"
                );
            }
        }

        private Container __mask;
        public Container mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<Container>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
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
    #endregion

    #region Properties
        
        public bool sortDirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortDirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortDirty",
                    value
                );
            }
        }

        private Container __parent;
        public Container parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<Container>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
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

        
        public decimal worldAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "worldAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldAlpha",
                    value
                );
            }
        }

        private Transform __transform;
        public Transform transform
        {
            get
            {
            if(__transform == null)
            {
                __transform = EventHorizonBlazorInterop.GetClass<Transform>(
                    this.___guid,
                    "transform",
                    (entity) =>
                    {
                        return new Transform() { ___guid = entity.___guid };
                    }
                );
            }
            return __transform;
            }
            set
            {
__transform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transform",
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

        
        public bool renderable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderable",
                    value
                );
            }
        }

        
        public bool cullable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cullable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullable",
                    value
                );
            }
        }

        private Rectangle __cullArea;
        public Rectangle cullArea
        {
            get
            {
            if(__cullArea == null)
            {
                __cullArea = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "cullArea",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __cullArea;
            }
            set
            {
__cullArea = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullArea",
                    value
                );
            }
        }

        private Rectangle __filterArea;
        public Rectangle filterArea
        {
            get
            {
            if(__filterArea == null)
            {
                __filterArea = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "filterArea",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __filterArea;
            }
            set
            {
__filterArea = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filterArea",
                    value
                );
            }
        }

        
        public Filter[] filters
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Filter>(
                    this.___guid,
                    "filters",
                    (entity) =>
                    {
                        return new Filter() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filters",
                    value
                );
            }
        }

        
        public bool isSprite
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSprite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSprite",
                    value
                );
            }
        }

        
        public bool isMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isMask",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public DisplayObject() : base() { }

        public DisplayObject(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        #region displayObjectUpdateTransform TODO: Get Comments as metadata identification
        private bool _isDisplayObjectUpdateTransformEnabled = false;
        private readonly IDictionary<string, Func<Task>> _displayObjectUpdateTransformActionMap = new Dictionary<string, Func<Task>>();

        public string displayObjectUpdateTransform(
            Func<Task> callback
        )
        {
            SetupDisplayObjectUpdateTransformLoop();

            var handle = Guid.NewGuid().ToString();
            _displayObjectUpdateTransformActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool displayObjectUpdateTransform_Remove(
            string handle
        )
        {
            return _displayObjectUpdateTransformActionMap.Remove(
                handle
            );
        }

        private void SetupDisplayObjectUpdateTransformLoop()
        {
            if (_isDisplayObjectUpdateTransformEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "displayObjectUpdateTransform",
                "CallDisplayObjectUpdateTransformActions",
                _invokableReference
            );
            _isDisplayObjectUpdateTransformEnabled = true;
        }

        [JSInvokable]
        public async Task CallDisplayObjectUpdateTransformActions()
        {
            foreach (var action in _displayObjectUpdateTransformActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void calculateBounds()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateBounds" }
                }
            );
        }

        public void removeChild(DisplayObject child)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeChild" }, child
                }
            );
        }

        public void render(Renderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, renderer
                }
            );
        }

        public void updateTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTransform" }
                }
            );
        }

        public Rectangle getBounds(System.Nullable<bool> skipUpdate = null, Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, skipUpdate, rect
                }
            );
        }

        public Rectangle getLocalBounds(Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect
                }
            );
        }

        public P toGlobal<P>(IPointData position, P point = null, System.Nullable<bool> skipUpdate = null) where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGlobal" }, position, point, skipUpdate
                }
            );
        }

        public P toLocal<P>(IPointData position, DisplayObject from = null, P point = null, System.Nullable<bool> skipUpdate = null) where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLocal" }, position, from, point, skipUpdate
                }
            );
        }

        public Container setParent(Container container)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setParent" }, container
                }
            );
        }

        public DisplayObject setTransform(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> scaleX = null, System.Nullable<decimal> scaleY = null, System.Nullable<decimal> rotation = null, System.Nullable<decimal> skewX = null, System.Nullable<decimal> skewY = null, System.Nullable<decimal> pivotX = null, System.Nullable<decimal> pivotY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DisplayObject>(
                entity => new DisplayObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, x, y, scaleX, scaleY, rotation, skewX, skewY, pivotX, pivotY
                }
            );
        }

        public void destroy(IDestroyOptions _options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, _options
                }
            );
        }

        public Container enableTempParent()
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableTempParent" }
                }
            );
        }

        public void disableTempParent(Container cacheParent)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableTempParent" }, cacheParent
                }
            );
        }
    #endregion
}
