/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpotLight>))]
public class SpotLight : Light
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

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Object3D __target;
        public Object3D target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<Object3D>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new Object3D() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
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

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
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

        private SpotLightShadow __shadow;
        public SpotLightShadow shadow
        {
            get
            {
            if(__shadow == null)
            {
                __shadow = EventHorizonBlazorInterop.GetClass<SpotLightShadow>(
                    this.___guid,
                    "shadow",
                    (entity) =>
                    {
                        return new SpotLightShadow() { ___guid = entity.___guid };
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

        
        public decimal penumbra
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "penumbra"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "penumbra",
                    value
                );
            }
        }

        
        public unknown isSpotLight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSpotLight"
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpotLight() : base() { }

        public SpotLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpotLight(
            Color color = null, System.Nullable<decimal> intensity = null, System.Nullable<decimal> distance = null, System.Nullable<decimal> angle = null, System.Nullable<decimal> penumbra = null, System.Nullable<decimal> decay = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpotLight" },
                color, intensity, distance, angle, penumbra, decay
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
