/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XRGripSpace>))]
public class XRGripSpace : Group
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
        
        public bool hasLinearVelocity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasLinearVelocity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasLinearVelocity",
                    value
                );
            }
        }

        private Vector3 __linearVelocity;
        public Vector3 linearVelocity
        {
            get
            {
            if(__linearVelocity == null)
            {
                __linearVelocity = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "linearVelocity",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __linearVelocity;
            }
        }

        
        public bool hasAngularVelocity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasAngularVelocity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasAngularVelocity",
                    value
                );
            }
        }

        private Vector3 __angularVelocity;
        public Vector3 angularVelocity
        {
            get
            {
            if(__angularVelocity == null)
            {
                __angularVelocity = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "angularVelocity",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __angularVelocity;
            }
        }
    #endregion
    
    #region Constructor
        public XRGripSpace() : base() { }

        public XRGripSpace(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
