/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpriteMaterial>))]
public class SpriteMaterial : Material
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

        private Texture __map;
        public Texture map
        {
            get
            {
            if(__map == null)
            {
                __map = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "map",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __map;
            }
            set
            {
__map = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "map",
                    value
                );
            }
        }

        private Texture __alphaMap;
        public Texture alphaMap
        {
            get
            {
            if(__alphaMap == null)
            {
                __alphaMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "alphaMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __alphaMap;
            }
            set
            {
__alphaMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaMap",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public bool sizeAttenuation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sizeAttenuation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sizeAttenuation",
                    value
                );
            }
        }

        
        public bool transparent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparent",
                    value
                );
            }
        }

        
        public bool fog
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fog"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fog",
                    value
                );
            }
        }

        
        public unknown isSpriteMaterial
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSpriteMaterial"
                );
            }
        }
    #endregion
    
    #region Constructor
        public SpriteMaterial() : base() { }

        public SpriteMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpriteMaterial(
            SpriteMaterialParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpriteMaterial" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setValues(SpriteMaterialParameters parameters)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValues" }, parameters
                }
            );
        }

        public SpriteMaterial copy(SpriteMaterial source)
        {
            return EventHorizonBlazorInterop.FuncClass<SpriteMaterial>(
                entity => new SpriteMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }
    #endregion
}
