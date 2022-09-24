/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SignalBinding<CachedEntity>>))]
public class SignalBinding<CbType> : CachedEntityObject where CbType : CachedEntity, new()
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
        public SignalBinding() : base() { }

        public SignalBinding(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SignalBinding(
            CbType fn, bool once, object thisArg
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SignalBinding" },
                fn, once, thisArg
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool detach()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }
    #endregion
}
