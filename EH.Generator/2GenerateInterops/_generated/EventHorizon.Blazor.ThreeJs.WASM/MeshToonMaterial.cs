/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshToonMaterial>))]
public class MeshToonMaterial : Material
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

        
        public CachedEntity defines
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "defines",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defines",
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

        private Texture __gradientMap;
        public Texture gradientMap
        {
            get
            {
            if(__gradientMap == null)
            {
                __gradientMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "gradientMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __gradientMap;
            }
            set
            {
__gradientMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradientMap",
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

        private Color __emissive;
        public Color emissive
        {
            get
            {
            if(__emissive == null)
            {
                __emissive = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "emissive",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __emissive;
            }
            set
            {
__emissive = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissive",
                    value
                );
            }
        }

        
        public decimal emissiveIntensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "emissiveIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissiveIntensity",
                    value
                );
            }
        }

        private Texture __emissiveMap;
        public Texture emissiveMap
        {
            get
            {
            if(__emissiveMap == null)
            {
                __emissiveMap = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "emissiveMap",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __emissiveMap;
            }
            set
            {
__emissiveMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissiveMap",
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
    #endregion
    
    #region Constructor
        public MeshToonMaterial() : base() { }

        public MeshToonMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshToonMaterial(
            MeshToonMaterialParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshToonMaterial" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setValues(MeshToonMaterialParameters parameters)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValues" }, parameters
                }
            );
        }
    #endregion
}