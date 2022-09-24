/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LightProbe>))]
public class LightProbe : Light
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

        
        public unknown isLightProbe
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isLightProbe"
                );
            }
        }

        private SphericalHarmonics3 __sh;
        public SphericalHarmonics3 sh
        {
            get
            {
            if(__sh == null)
            {
                __sh = EventHorizonBlazorInterop.GetClass<SphericalHarmonics3>(
                    this.___guid,
                    "sh",
                    (entity) =>
                    {
                        return new SphericalHarmonics3() { ___guid = entity.___guid };
                    }
                );
            }
            return __sh;
            }
            set
            {
__sh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sh",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public LightProbe() : base() { }

        public LightProbe(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LightProbe(
            SphericalHarmonics3 sh = null, System.Nullable<decimal> intensity = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LightProbe" },
                sh, intensity
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public LightProbe fromJSON(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<LightProbe>(
                entity => new LightProbe() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, json
                }
            );
        }
    #endregion
}
