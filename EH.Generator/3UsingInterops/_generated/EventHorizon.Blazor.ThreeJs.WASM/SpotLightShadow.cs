/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpotLightShadow>))]
public class SpotLightShadow : LightShadow
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
        private PerspectiveCamera __camera;
        public PerspectiveCamera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<PerspectiveCamera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new PerspectiveCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        
        public unknown isSpotLightShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSpotLightShadow"
                );
            }
        }

        
        public decimal focus
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "focus"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "focus",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpotLightShadow() : base() { }

        public SpotLightShadow(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
