/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Container<CachedEntity>>))]
public class Container<T> : DisplayObject where T : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public T[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<T>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool sortableChildren
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortableChildren"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortableChildren",
                    value
                );
            }
        }

        
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
    #endregion
    
    #region Constructor
        public Container() : base() { }

        public Container(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region containerUpdateTransform TODO: Get Comments as metadata identification
        private bool _isContainerUpdateTransformEnabled = false;
        private readonly IDictionary<string, Func<Task>> _containerUpdateTransformActionMap = new Dictionary<string, Func<Task>>();

        public string containerUpdateTransform(
            Func<Task> callback
        )
        {
            SetupContainerUpdateTransformLoop();

            var handle = Guid.NewGuid().ToString();
            _containerUpdateTransformActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool containerUpdateTransform_Remove(
            string handle
        )
        {
            return _containerUpdateTransformActionMap.Remove(
                handle
            );
        }

        private void SetupContainerUpdateTransformLoop()
        {
            if (_isContainerUpdateTransformEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "containerUpdateTransform",
                "CallContainerUpdateTransformActions",
                _invokableReference
            );
            _isContainerUpdateTransformEnabled = true;
        }

        [JSInvokable]
        public async Task CallContainerUpdateTransformActions()
        {
            foreach (var action in _containerUpdateTransformActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public U addChild<U>(U children) where U : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<U>(
                entity => new U() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addChild" }, children
                }
            );
        }

        public U addChildAt<U>(U child, decimal index) where U : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<U>(
                entity => new U() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addChildAt" }, child, index
                }
            );
        }

        public void swapChildren(T child, T child2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "swapChildren" }, child, child2
                }
            );
        }

        public decimal getChildIndex(T child)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getChildIndex" }, child
                }
            );
        }

        public void setChildIndex(T child, decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setChildIndex" }, child, index
                }
            );
        }

        public T getChildAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildAt" }, index
                }
            );
        }

        public U removeChild<U>(U children) where U : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<U>(
                entity => new U() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeChild" }, children
                }
            );
        }

        public T removeChildAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeChildAt" }, index
                }
            );
        }

        public T[] removeChildren(System.Nullable<decimal> beginIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeChildren" }, beginIndex, endIndex
                }
            );
        }

        public void sortChildren()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortChildren" }
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

        public void calculateBounds()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateBounds" }
                }
            );
        }

        public Rectangle getLocalBounds(Rectangle rect = null, System.Nullable<bool> skipChildrenUpdate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalBounds" }, rect, skipChildrenUpdate
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

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
