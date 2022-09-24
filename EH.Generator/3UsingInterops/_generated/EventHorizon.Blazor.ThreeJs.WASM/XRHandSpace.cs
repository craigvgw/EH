/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XRHandSpace>))]
public class XRHandSpace : Group
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
        
        public Record<XRHandJoint, decimal> joints
        {
            get
            {
            return EventHorizonBlazorInterop.Get<Record<XRHandJoint, decimal>>(
                    this.___guid,
                    "joints"
                );
            }
        }

        private XRHandInputStateCachedEntity __inputState;
        public XRHandInputStateCachedEntity inputState
        {
            get
            {
            if(__inputState == null)
            {
                __inputState = EventHorizonBlazorInterop.GetClass<XRHandInputStateCachedEntity>(
                    this.___guid,
                    "inputState",
                    (entity) =>
                    {
                        return new XRHandInputStateCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputState;
            }
        }
    #endregion
    
    #region Constructor
        public XRHandSpace() : base() { }

        public XRHandSpace(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
