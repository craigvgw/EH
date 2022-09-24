/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Signal<CachedEntity>>))]
public class Signal<CbType> : CachedEntityObject where CbType : CachedEntity, new()
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
        public Signal() : base() { }

        public Signal(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public SignalBinding<CbType>[] handlers(System.Nullable<bool> exists = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<SignalBinding<CbType>>(
                entity => new SignalBinding<CbType>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "handlers" }, exists
                }
            );
        }

        public bool has(SignalBinding<CbType> node)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "has" }, node
                }
            );
        }

        public bool dispatch(CachedEntity[] args)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "dispatch" }, args
                }
            );
        }

        public SignalBinding<CbType> add(CbType fn, object thisArg = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SignalBinding<CbType>>(
                entity => new SignalBinding<CbType>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, fn, thisArg
                }
            );
        }

        public SignalBinding<CbType> once(CbType fn, object thisArg = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SignalBinding<CbType>>(
                entity => new SignalBinding<CbType>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "once" }, fn, thisArg
                }
            );
        }

        public Signal detach(SignalBinding<CbType> node)
        {
            return EventHorizonBlazorInterop.FuncClass<Signal>(
                entity => new Signal() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "detach" }, node
                }
            );
        }

        public Signal detachAll()
        {
            return EventHorizonBlazorInterop.FuncClass<Signal>(
                entity => new Signal() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "detachAll" }
                }
            );
        }
    #endregion
}
