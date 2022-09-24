/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface MeshMatcapMaterialParameters : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MeshMatcapMaterialParametersCachedEntity>))]
public class MeshMatcapMaterialParametersCachedEntity : CachedEntityObject, MeshMatcapMaterialParameters
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

        private Texture __matcap;
        public Texture matcap
        {
            get
            {
            if(__matcap == null)
            {
                __matcap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "matcap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __matcap;
            }
            set
            {
__matcap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matcap",
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

        private Texture __bumpMap;
        public Texture bumpMap
        {
            get
            {
            if(__bumpMap == null)
            {
                __bumpMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "bumpMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __bumpMap;
            }
            set
            {
__bumpMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bumpMap",
                    value
                );
            }
        }

        
        public decimal bumpScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bumpScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bumpScale",
                    value
                );
            }
        }

        private Texture __normalMap;
        public Texture normalMap
        {
            get
            {
            if(__normalMap == null)
            {
                __normalMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "normalMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __normalMap;
            }
            set
            {
__normalMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalMap",
                    value
                );
            }
        }

        
        public int normalMapType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "normalMapType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalMapType",
                    value
                );
            }
        }

        private Vector2 __normalScale;
        public Vector2 normalScale
        {
            get
            {
            if(__normalScale == null)
            {
                __normalScale = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "normalScale",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __normalScale;
            }
            set
            {
__normalScale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalScale",
                    value
                );
            }
        }

        private Texture __displacementMap;
        public Texture displacementMap
        {
            get
            {
            if(__displacementMap == null)
            {
                __displacementMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "displacementMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __displacementMap;
            }
            set
            {
__displacementMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displacementMap",
                    value
                );
            }
        }

        
        public decimal displacementScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displacementScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displacementScale",
                    value
                );
            }
        }

        
        public decimal displacementBias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displacementBias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displacementBias",
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

        
        public bool flatShading
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flatShading"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flatShading",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MeshMatcapMaterialParametersCachedEntity() : base() { }

        public MeshMatcapMaterialParametersCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
