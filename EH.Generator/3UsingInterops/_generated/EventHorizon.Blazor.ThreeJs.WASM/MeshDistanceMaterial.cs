/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshDistanceMaterial>))]
public class MeshDistanceMaterial : Material
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

        
        public decimal farDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "farDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "farDistance",
                    value
                );
            }
        }

        
        public decimal nearDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "nearDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nearDistance",
                    value
                );
            }
        }

        private Vector3 __referencePosition;
        public Vector3 referencePosition
        {
            get
            {
            if(__referencePosition == null)
            {
                __referencePosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "referencePosition",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __referencePosition;
            }
            set
            {
__referencePosition = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "referencePosition",
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
        public MeshDistanceMaterial() : base() { }

        public MeshDistanceMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshDistanceMaterial(
            MeshDistanceMaterialParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshDistanceMaterial" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setValues(MeshDistanceMaterialParameters parameters)
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
