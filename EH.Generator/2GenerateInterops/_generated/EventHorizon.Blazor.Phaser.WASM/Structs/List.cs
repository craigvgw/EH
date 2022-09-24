/// Generated - Do Not Edit
namespace Phaser.Structs
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<List<CachedEntity>>))]
    public class List<T> : CachedEntityObject where T : CachedEntity, new()
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
        
        public CachedEntity parent
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parent",
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
                    "parent",
                    value
                );
            }
        }

        
        public T[] list
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<T>(
                    this.___guid,
                    "list",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "list",
                    value
                );
            }
        }

        
        public decimal position
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "position"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

        private T __first;
        public T first
        {
            get
            {
            if(__first == null)
            {
                __first = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "first",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __first;
            }
        }

        private T __last;
        public T last
        {
            get
            {
            if(__last == null)
            {
                __last = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "last",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __last;
            }
        }

        private T __next;
        public T next
        {
            get
            {
            if(__next == null)
            {
                __next = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "next",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __next;
            }
        }

        private T __previous;
        public T previous
        {
            get
            {
            if(__previous == null)
            {
                __previous = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "previous",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __previous;
            }
        }
        #endregion
        
        #region Constructor
        public List() : base() { }

        public List(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public List(
            object parent
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Structs", "List" },
                parent
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void addCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCallback" }
                }
            );
        }

        public void removeCallback()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeCallback" }
                }
            );
        }

        public T add(T child, System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, child, skipCallback
                }
            );
        }

        public T addAt(T child, System.Nullable<decimal> index = null, System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAt" }, child, index, skipCallback
                }
            );
        }

        public T getAt(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAt" }, index
                }
            );
        }

        public decimal getIndex(T child)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, child
                }
            );
        }

        public T getByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getByName" }, name
                }
            );
        }

        public T getRandom(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> length = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRandom" }, startIndex, length
                }
            );
        }

        public T getFirst(string property, object value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFirst" }, property, value, startIndex, endIndex
                }
            );
        }

        public T[] getAll(string property = null, T value = null, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAll" }, property, value, startIndex, endIndex
                }
            );
        }

        public decimal count(string property, T value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "count" }, property, value
                }
            );
        }

        public void swap(T child1, T child2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "swap" }, child1, child2
                }
            );
        }

        public T moveTo(T child, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, child, index
                }
            );
        }

        public void moveAbove(T child1, T child2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveAbove" }, child1, child2
                }
            );
        }

        public void moveBelow(T child1, T child2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveBelow" }, child1, child2
                }
            );
        }

        public T remove(T child, System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, child, skipCallback
                }
            );
        }

        public T removeAt(decimal index, System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAt" }, index, skipCallback
                }
            );
        }

        public T[] removeBetween(System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null, System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeBetween" }, startIndex, endIndex, skipCallback
                }
            );
        }

        public List<T> removeAll(System.Nullable<bool> skipCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<List<T>>(
                entity => new List<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }, skipCallback
                }
            );
        }

        public T bringToTop(T child)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bringToTop" }, child
                }
            );
        }

        public T sendToBack(T child)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sendToBack" }, child
                }
            );
        }

        public T moveUp(T child)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveUp" }, child
                }
            );
        }

        public T moveDown(T child)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveDown" }, child
                }
            );
        }

        public List<T> reverse()
        {
            return EventHorizonBlazorInterop.FuncClass<List<T>>(
                entity => new List<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reverse" }
                }
            );
        }

        public List<T> shuffle()
        {
            return EventHorizonBlazorInterop.FuncClass<List<T>>(
                entity => new List<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }
                }
            );
        }

        public T replace(T oldChild, T newChild)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "replace" }, oldChild, newChild
                }
            );
        }

        public bool exists(T child)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, child
                }
            );
        }

        public void setAll(string property, T value, System.Nullable<decimal> startIndex = null, System.Nullable<decimal> endIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAll" }, property, value, startIndex, endIndex
                }
            );
        }

        public void each(ActionCallback<I, CachedEntity[]> callback, CachedEntity[] args, object context = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "each" }, callback, context, args
                }
            );
        }

        public void shutdown()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shutdown" }
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


        #endregion
    }
}