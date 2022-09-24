/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<StereoCamera>))]
public class StereoCamera : Camera
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal aspect
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspect"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aspect",
                    value
                );
            }
        }

        
        public decimal eyeSep
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "eyeSep"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "eyeSep",
                    value
                );
            }
        }

        private PerspectiveCamera __cameraL;
        public PerspectiveCamera cameraL
        {
            get
            {
            if(__cameraL == null)
            {
                __cameraL = EventHorizonBlazorInterop.GetClass<PerspectiveCamera>(
                    this.___guid,
                    "cameraL",
                    (entity) =>
                    {
                        return new PerspectiveCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraL;
            }
            set
            {
__cameraL = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraL",
                    value
                );
            }
        }

        private PerspectiveCamera __cameraR;
        public PerspectiveCamera cameraR
        {
            get
            {
            if(__cameraR == null)
            {
                __cameraR = EventHorizonBlazorInterop.GetClass<PerspectiveCamera>(
                    this.___guid,
                    "cameraR",
                    (entity) =>
                    {
                        return new PerspectiveCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraR;
            }
            set
            {
__cameraR = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraR",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public StereoCamera() : base() { }

        public StereoCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void update(PerspectiveCamera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, camera
                }
            );
        }
    #endregion
}
