/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Fog>))]
public class Fog : CachedEntityObject, FogBase
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Color __color;
        public Color color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal near
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "near"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "near",
                    value
                );
            }
        }

        
        public decimal far
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "far"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "far",
                    value
                );
            }
        }

        
        public unknown isFog
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isFog"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Fog() : base() { }

        public Fog(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Fog(
            Color color, System.Nullable<decimal> near = null, System.Nullable<decimal> far = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Fog" },
                color, near, far
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Fog clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Fog>(
                entity => new Fog() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
    #endregion
}
