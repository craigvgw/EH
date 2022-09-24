/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface MeshBasicMaterialParameters : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MeshBasicMaterialParametersCachedEntity>))]
public class MeshBasicMaterialParametersCachedEntity : CachedEntityObject, MeshBasicMaterialParameters
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
        
        public Color color
        {
            get
            {
            return EventHorizonBlazorInterop.Get<Color>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal opacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "opacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacity",
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

        private Texture __lightMap;
        public Texture lightMap
        {
            get
            {
            if(__lightMap == null)
            {
                __lightMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "lightMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __lightMap;
            }
            set
            {
__lightMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightMap",
                    value
                );
            }
        }

        
        public decimal lightMapIntensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lightMapIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightMapIntensity",
                    value
                );
            }
        }

        private Texture __aoMap;
        public Texture aoMap
        {
            get
            {
            if(__aoMap == null)
            {
                __aoMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "aoMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __aoMap;
            }
            set
            {
__aoMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aoMap",
                    value
                );
            }
        }

        
        public decimal aoMapIntensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aoMapIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "aoMapIntensity",
                    value
                );
            }
        }

        private Texture __specularMap;
        public Texture specularMap
        {
            get
            {
            if(__specularMap == null)
            {
                __specularMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "specularMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularMap;
            }
            set
            {
__specularMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularMap",
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

        private Texture __envMap;
        public Texture envMap
        {
            get
            {
            if(__envMap == null)
            {
                __envMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "envMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __envMap;
            }
            set
            {
__envMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "envMap",
                    value
                );
            }
        }

        
        public int combine
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "combine"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "combine",
                    value
                );
            }
        }

        
        public decimal reflectivity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectivity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectivity",
                    value
                );
            }
        }

        
        public decimal refractionRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refractionRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refractionRatio",
                    value
                );
            }
        }

        
        public bool wireframe
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wireframe"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wireframe",
                    value
                );
            }
        }

        
        public decimal wireframeLinewidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wireframeLinewidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wireframeLinewidth",
                    value
                );
            }
        }

        
        public string wireframeLinecap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "wireframeLinecap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wireframeLinecap",
                    value
                );
            }
        }

        
        public string wireframeLinejoin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "wireframeLinejoin"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wireframeLinejoin",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MeshBasicMaterialParametersCachedEntity() : base() { }

        public MeshBasicMaterialParametersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
