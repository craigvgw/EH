/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PointLightShadow>))]
public class PointLightShadow : LightShadow
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
    #endregion
    
    #region Constructor
        public PointLightShadow() : base() { }

        public PointLightShadow(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
