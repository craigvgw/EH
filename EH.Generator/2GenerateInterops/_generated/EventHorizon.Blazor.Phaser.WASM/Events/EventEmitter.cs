/// Generated - Do Not Edit
namespace Phaser.Events
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<EventEmitter>))]
    public class EventEmitter : CachedEntityObject
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

        #endregion
        
        #region Constructor
        public EventEmitter() : base() { }

        public EventEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
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

        public string[] eventNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "eventNames" }
                }
            );
        }

        public void[] listeners(string @event)
        {
            return EventHorizonBlazorInterop.FuncArray<void>(
                new object[]
                {
                    new string[] { this.___guid, "listeners" }, @event
                }
            );
        }

        public decimal listenerCount(string @event)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "listenerCount" }, @event
                }
            );
        }

        public bool emit(string @event, CachedEntity[] args)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "emit" }, @event, args
                }
            );
        }

        public EventEmitter removeAllListeners(string @event = null)
        {
            return EventHorizonBlazorInterop.FuncClass<EventEmitter>(
                entity => new EventEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAllListeners" }, @event
                }
            );
        }


        #endregion
    }
}