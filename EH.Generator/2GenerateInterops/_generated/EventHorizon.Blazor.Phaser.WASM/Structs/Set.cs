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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Set<CachedEntity>>))]
    public class Set<T> : CachedEntityObject where T : CachedEntity, new()
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
        
        public T[] entries
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<T>(
                    this.___guid,
                    "entries",
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
                    "entries",
                    value
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Set() : base() { }

        public Set(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Set(
            T[] elements = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Structs", "Set" },
                elements
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Set<T> set(T value)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, value
                }
            );
        }

        public T get(string property, T value)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, property, value
                }
            );
        }

        public T[] getArray()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getArray" }
                }
            );
        }

        public Set<T> delete(T value)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "delete" }, value
                }
            );
        }

        public void dump()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dump" }
                }
            );
        }

        public Set<T> each(ActionCallback<E, decimal> callback, object callbackScope = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "each" }, callback, callbackScope
                }
            );
        }

        public Set<T> iterate(ActionCallback<E, decimal> callback, object callbackScope = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "iterate" }, callback, callbackScope
                }
            );
        }

        public Set<T> iterateLocal(string callbackKey, CachedEntity[] args)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "iterateLocal" }, callbackKey, args
                }
            );
        }

        public Set<T> clear()
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public bool contains(T value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, value
                }
            );
        }

        public Set<T> union(Set<T> set)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "union" }, set
                }
            );
        }

        public Set<T> intersect(Set<T> set)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersect" }, set
                }
            );
        }

        public Set<T> difference(Set<T> set)
        {
            return EventHorizonBlazorInterop.FuncClass<Set<T>>(
                entity => new Set<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "difference" }, set
                }
            );
        }
        #endregion
    }
}