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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Map<CachedEntity>>))]
    public class Map<K, V> : CachedEntityObject where K : CachedEntity, new() where V : CachedEntity, new()
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
        
        public CachedEntity entries
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "entries",
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
        public Map() : base() { }

        public Map(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Map(
            V[] elements
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Structs", "Map" },
                elements
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Map<K, V> set(K key, V value)
        {
            return EventHorizonBlazorInterop.FuncClass<Map<K, V>>(
                entity => new Map<K, V>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, key, value
                }
            );
        }

        public V get(K key)
        {
            return EventHorizonBlazorInterop.FuncClass<V>(
                entity => new V() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public V[] getArray()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<V>(
                entity => new V() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getArray" }
                }
            );
        }

        public bool has(K key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, key
                }
            );
        }

        public Map<K, V> delete(K key)
        {
            return EventHorizonBlazorInterop.FuncClass<Map<K, V>>(
                entity => new Map<K, V>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "delete" }, key
                }
            );
        }

        public Map<K, V> clear()
        {
            return EventHorizonBlazorInterop.FuncClass<Map<K, V>>(
                entity => new Map<K, V>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public K[] keys()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<K>(
                entity => new K() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "keys" }
                }
            );
        }

        public V[] values()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<V>(
                entity => new V() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "values" }
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

        public Map<K, V> each(ActionCallback<string, E> callback)
        {
            return EventHorizonBlazorInterop.FuncClass<Map<K, V>>(
                entity => new Map<K, V>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "each" }, callback
                }
            );
        }

        public bool contains(V value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, value
                }
            );
        }

        public Map<K, V> merge(Map<K, V> map, System.Nullable<bool> override = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Map<K, V>>(
                entity => new Map<K, V>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "merge" }, map, override
                }
            );
        }
        #endregion
    }
}