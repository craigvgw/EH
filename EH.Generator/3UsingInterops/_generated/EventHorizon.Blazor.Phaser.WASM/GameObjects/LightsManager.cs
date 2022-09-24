/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<LightsManager>))]
    public class LightsManager : CachedEntityObject
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
        
        public Light[] lights
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lights",
                    value
                );
            }
        }

        private RGB __ambientColor;
        public RGB ambientColor
        {
            get
            {
            if(__ambientColor == null)
            {
                __ambientColor = EventHorizonBlazorInterop.GetClass<RGB>(
                    this.___guid,
                    "ambientColor",
                    (entity) =>
                    {
                        return new RGB() { ___guid = entity.___guid };
                    }
                );
            }
            return __ambientColor;
            }
            set
            {
__ambientColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ambientColor",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }

        
        public decimal maxLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLights"
                );
            }
        }

        
        public decimal visibleLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "visibleLights"
                );
            }
        }
        #endregion
        
        #region Constructor
        public LightsManager() : base() { }

        public LightsManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public PointLight addPointLight(decimal x, decimal y, System.Nullable<decimal> color = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> intensity = null, System.Nullable<decimal> attenuation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPointLight" }, x, y, color, radius, intensity, attenuation
                }
            );
        }

        public LightsManager enable()
        {
            return EventHorizonBlazorInterop.FuncClass<LightsManager>(
                entity => new LightsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enable" }
                }
            );
        }

        public LightsManager disable()
        {
            return EventHorizonBlazorInterop.FuncClass<LightsManager>(
                entity => new LightsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disable" }
                }
            );
        }

        public Light[] getLights(Camera camera)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLights" }, camera
                }
            );
        }

        public LightsManager setAmbientColor(decimal rgb)
        {
            return EventHorizonBlazorInterop.FuncClass<LightsManager>(
                entity => new LightsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAmbientColor" }, rgb
                }
            );
        }

        public decimal getMaxVisibleLights()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxVisibleLights" }
                }
            );
        }

        public decimal getLightCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLightCount" }
                }
            );
        }

        public Light addLight(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> radius = null, System.Nullable<decimal> rgb = null, System.Nullable<decimal> intensity = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addLight" }, x, y, radius, rgb, intensity
                }
            );
        }

        public LightsManager removeLight(Light light)
        {
            return EventHorizonBlazorInterop.FuncClass<LightsManager>(
                entity => new LightsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeLight" }, light
                }
            );
        }

        public void shutdown()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shutdown" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}