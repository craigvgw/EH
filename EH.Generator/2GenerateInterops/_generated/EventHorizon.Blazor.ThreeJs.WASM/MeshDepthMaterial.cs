/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshDepthMaterial>))]
public class MeshDepthMaterial : Material
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

        
        public int depthPacking
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "depthPacking"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthPacking",
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
        public MeshDepthMaterial() : base() { }

        public MeshDepthMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshDepthMaterial(
            MeshDepthMaterialParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshDepthMaterial" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setValues(MeshDepthMaterialParameters parameters)
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
