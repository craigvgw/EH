/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Scene>))]
public class Scene : Object3D
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
        
        public unknown type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
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

        private FogBaseCachedEntity __fog;
        public FogBaseCachedEntity fog
        {
            get
            {
            if(__fog == null)
            {
                __fog = EventHorizonBlazorInterop.GetClass<FogBaseCachedEntity>(
                    this.___guid,
                    "fog",
                    (entity) =>
                    {
                        return new FogBaseCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __fog;
            }
            set
            {
__fog = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fog",
                    value
                );
            }
        }

        private Material __overrideMaterial;
        public Material overrideMaterial
        {
            get
            {
            if(__overrideMaterial == null)
            {
                __overrideMaterial = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "overrideMaterial",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __overrideMaterial;
            }
            set
            {
__overrideMaterial = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overrideMaterial",
                    value
                );
            }
        }

        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }

        private Color __background;
        public Color background
        {
            get
            {
            if(__background == null)
            {
                __background = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "background",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __background;
            }
            set
            {
__background = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "background",
                    value
                );
            }
        }

        private Texture __environment;
        public Texture environment
        {
            get
            {
            if(__environment == null)
            {
                __environment = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "environment",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __environment;
            }
            set
            {
__environment = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environment",
                    value
                );
            }
        }

        
        public unknown isScene
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isScene"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Scene() : base() { }

        public Scene(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public CachedEntity toJSON(object meta = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, meta
                }
            );
        }
    #endregion
}
