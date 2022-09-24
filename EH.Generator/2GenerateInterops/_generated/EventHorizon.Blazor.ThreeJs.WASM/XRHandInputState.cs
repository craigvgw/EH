/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRHandInputState : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRHandInputStateCachedEntity>))]
public class XRHandInputStateCachedEntity : CachedEntityObject, XRHandInputState
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
        
        public bool pinching
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pinching"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinching",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRHandInputStateCachedEntity() : base() { }

        public XRHandInputStateCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
