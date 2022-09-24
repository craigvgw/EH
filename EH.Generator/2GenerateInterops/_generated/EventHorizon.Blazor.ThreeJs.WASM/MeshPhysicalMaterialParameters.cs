/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface MeshPhysicalMaterialParameters : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MeshPhysicalMaterialParametersCachedEntity>))]
public class MeshPhysicalMaterialParametersCachedEntity : CachedEntityObject, MeshPhysicalMaterialParameters
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
        
        public decimal clearcoat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clearcoat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoat",
                    value
                );
            }
        }

        private Texture __clearcoatMap;
        public Texture clearcoatMap
        {
            get
            {
            if(__clearcoatMap == null)
            {
                __clearcoatMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "clearcoatMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearcoatMap;
            }
            set
            {
__clearcoatMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoatMap",
                    value
                );
            }
        }

        
        public decimal clearcoatRoughness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "clearcoatRoughness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoatRoughness",
                    value
                );
            }
        }

        private Texture __clearcoatRoughnessMap;
        public Texture clearcoatRoughnessMap
        {
            get
            {
            if(__clearcoatRoughnessMap == null)
            {
                __clearcoatRoughnessMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "clearcoatRoughnessMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearcoatRoughnessMap;
            }
            set
            {
__clearcoatRoughnessMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoatRoughnessMap",
                    value
                );
            }
        }

        private Vector2 __clearcoatNormalScale;
        public Vector2 clearcoatNormalScale
        {
            get
            {
            if(__clearcoatNormalScale == null)
            {
                __clearcoatNormalScale = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "clearcoatNormalScale",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearcoatNormalScale;
            }
            set
            {
__clearcoatNormalScale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoatNormalScale",
                    value
                );
            }
        }

        private Texture __clearcoatNormalMap;
        public Texture clearcoatNormalMap
        {
            get
            {
            if(__clearcoatNormalMap == null)
            {
                __clearcoatNormalMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "clearcoatNormalMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearcoatNormalMap;
            }
            set
            {
__clearcoatNormalMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearcoatNormalMap",
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

        
        public decimal ior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ior",
                    value
                );
            }
        }

        
        public decimal sheen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sheen"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sheen",
                    value
                );
            }
        }

        private Color __sheenColor;
        public Color sheenColor
        {
            get
            {
            if(__sheenColor == null)
            {
                __sheenColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "sheenColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __sheenColor;
            }
            set
            {
__sheenColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sheenColor",
                    value
                );
            }
        }

        
        public decimal sheenRoughness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sheenRoughness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sheenRoughness",
                    value
                );
            }
        }

        
        public decimal transmission
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transmission"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transmission",
                    value
                );
            }
        }

        private Texture __transmissionMap;
        public Texture transmissionMap
        {
            get
            {
            if(__transmissionMap == null)
            {
                __transmissionMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "transmissionMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __transmissionMap;
            }
            set
            {
__transmissionMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transmissionMap",
                    value
                );
            }
        }

        
        public decimal attenuationDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attenuationDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attenuationDistance",
                    value
                );
            }
        }

        private Color __attenuationColor;
        public Color attenuationColor
        {
            get
            {
            if(__attenuationColor == null)
            {
                __attenuationColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "attenuationColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __attenuationColor;
            }
            set
            {
__attenuationColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attenuationColor",
                    value
                );
            }
        }

        
        public decimal specularIntensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "specularIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularIntensity",
                    value
                );
            }
        }

        private Color __specularColor;
        public Color specularColor
        {
            get
            {
            if(__specularColor == null)
            {
                __specularColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "specularColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularColor;
            }
            set
            {
__specularColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularColor",
                    value
                );
            }
        }

        private Texture __specularIntensityMap;
        public Texture specularIntensityMap
        {
            get
            {
            if(__specularIntensityMap == null)
            {
                __specularIntensityMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "specularIntensityMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularIntensityMap;
            }
            set
            {
__specularIntensityMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularIntensityMap",
                    value
                );
            }
        }

        private Texture __specularColorMap;
        public Texture specularColorMap
        {
            get
            {
            if(__specularColorMap == null)
            {
                __specularColorMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "specularColorMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularColorMap;
            }
            set
            {
__specularColorMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularColorMap",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MeshPhysicalMaterialParametersCachedEntity() : base() { }

        public MeshPhysicalMaterialParametersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
