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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ProcessQueue<CachedEntity>>))]
    public class ProcessQueue<T> : EventEmitter where T : CachedEntity, new()
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
        
        public bool checkQueue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkQueue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkQueue",
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
        #endregion
        
        #region Constructor
        public ProcessQueue() : base() { }

        public ProcessQueue(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ProcessQueue<T> add(T item)
        {
            return EventHorizonBlazorInterop.FuncClass<ProcessQueue<T>>(
                entity => new ProcessQueue<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, item
                }
            );
        }

        public ProcessQueue<T> remove(T item)
        {
            return EventHorizonBlazorInterop.FuncClass<ProcessQueue<T>>(
                entity => new ProcessQueue<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, item
                }
            );
        }

        public ProcessQueue removeAll()
        {
            return EventHorizonBlazorInterop.FuncClass<ProcessQueue>(
                entity => new ProcessQueue() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }
                }
            );
        }

        public T[] update()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public T[] getActive()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActive" }
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