/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ArrayCamera>))]
public class ArrayCamera : PerspectiveCamera
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
        
        public PerspectiveCamera[] cameras
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PerspectiveCamera>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new PerspectiveCamera() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameras",
                    value
                );
            }
        }

        
        public unknown isArrayCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isArrayCamera"
                );
            }
        }
    #endregion
    
    #region Constructor
        public ArrayCamera() : base() { }

        public ArrayCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ArrayCamera(
            PerspectiveCamera[] cameras = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ArrayCamera" },
                cameras
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
