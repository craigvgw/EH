/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<HemisphereLight>))]
public class HemisphereLight : Light
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

        private Color __groundColor;
        public Color groundColor
        {
            get
            {
            if(__groundColor == null)
            {
                __groundColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "groundColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundColor;
            }
            set
            {
__groundColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundColor",
                    value
                );
            }
        }

        
        public unknown isHemisphereLight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isHemisphereLight"
                );
            }
        }
    #endregion
    
    #region Constructor
        public HemisphereLight() : base() { }

        public HemisphereLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HemisphereLight(
            Color skyColor = null, Color groundColor = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "HemisphereLight" },
                skyColor, groundColor, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
