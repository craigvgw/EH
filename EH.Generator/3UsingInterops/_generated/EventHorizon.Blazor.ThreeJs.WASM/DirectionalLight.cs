/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DirectionalLight>))]
public class DirectionalLight : Light
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

        private DirectionalLightShadow __shadow;
        public DirectionalLightShadow shadow
        {
            get
            {
            if(__shadow == null)
            {
                __shadow = EventHorizonBlazorInterop.GetClass<DirectionalLightShadow>(
                    this.___guid,
                    "shadow",
                    (entity) =>
                    {
                        return new DirectionalLightShadow() { ___guid = entity.___guid };
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

        
        public unknown isDirectionalLight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isDirectionalLight"
                );
            }
        }
    #endregion
    
    #region Constructor
        public DirectionalLight() : base() { }

        public DirectionalLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DirectionalLight(
            Color color = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DirectionalLight" },
                color, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
