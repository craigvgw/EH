/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PointLight>))]
public class PointLight : Light
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
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

        
        public decimal intensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensity",
                    value
                );
            }
        }

        
        public decimal distance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distance",
                    value
                );
            }
        }

        
        public decimal decay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "decay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "decay",
                    value
                );
            }
        }

        private PointLightShadow __shadow;
        public PointLightShadow shadow
        {
            get
            {
            if(__shadow == null)
            {
                __shadow = EventHorizonBlazorInterop.GetClass<PointLightShadow>(
                    this.___guid,
                    "shadow",
                    (entity) =>
                    {
                        return new PointLightShadow() { ___guid = entity.___guid };
                    }
                );
            }
            return __shadow;
            }
            set
            {
__shadow = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadow",
                    value
                );
            }
        }

        
        public decimal power
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "power"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "power",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PointLight() : base() { }

        public PointLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PointLight(
            Color color = null, System.Nullable<decimal> intensity = null, System.Nullable<decimal> distance = null, System.Nullable<decimal> decay = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PointLight" },
                color, intensity, distance, decay
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
