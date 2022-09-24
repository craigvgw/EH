/// Generated - Do Not Edit
namespace Phaser.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<DataManager>))]
    public class DataManager : CachedEntityObject
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

        
        public CachedEntity list
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "list",
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
                    "list",
                    value
                );
            }
        }

        
        public CachedEntity values
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "values",
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
                    "values",
                    value
                );
            }
        }

        
        public bool freeze
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "freeze"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "freeze",
                    value
                );
            }
        }

        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "count",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DataManager() : base() { }

        public DataManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public DataManager(
            object parent, EventEmitter eventEmitter = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Data", "DataManager" },
                parent, eventEmitter
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity get(string key)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public CachedEntity getAll()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAll" }
                }
            );
        }

        public CachedEntity query(RegExp search)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "query" }, search
                }
            );
        }

        public DataManager set(string key, object data)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, key, data
                }
            );
        }

        public DataManager inc(string key, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "inc" }, key, data
                }
            );
        }

        public DataManager toggle(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggle" }, key
                }
            );
        }

        public DataManager each(ActionCallback<CachedEntity, string, CachedEntity, CachedEntity[]> callback, CachedEntity[] args, object context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "each" }, callback, context, args
                }
            );
        }

        public DataManager merge(object data, System.Nullable<bool> overwrite = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "merge" }, data, overwrite
                }
            );
        }

        public DataManager remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
                }
            );
        }

        public CachedEntity pop(string key)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pop" }, key
                }
            );
        }

        public bool has(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, key
                }
            );
        }

        public DataManager setFreeze(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFreeze" }, value
                }
            );
        }

        public DataManager reset()
        {
            return EventHorizonBlazorInterop.FuncClass<DataManager>(
                entity => new DataManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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