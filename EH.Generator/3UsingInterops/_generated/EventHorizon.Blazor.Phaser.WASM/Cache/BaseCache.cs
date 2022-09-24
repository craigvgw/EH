/// Generated - Do Not Edit
namespace Phaser.Cache
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseCache>))]
    public class BaseCache : CachedEntityObject
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
// entries is not supported by the platform yet

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
        #endregion
        
        #region Constructor
        public BaseCache() : base() { }

        public BaseCache(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public BaseCache add(string key, object data)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCache>(
                entity => new BaseCache() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, data
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

        public bool exists(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, key
                }
            );
        }

        public CachedEntity get(string key)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public BaseCache remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseCache>(
                entity => new BaseCache() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
                }
            );
        }

        public string[] getKeys()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getKeys" }
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