/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Mesh<CachedEntity>>))]
public class Mesh<TGeometry, Material> : Object3D where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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
        private TGeometry __geometry;
        public TGeometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<TGeometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new TGeometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        private TMaterial __material;
        public TMaterial material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<TMaterial>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new TMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
            }
        }

        
        public decimal[] morphTargetInfluences
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "morphTargetInfluences"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphTargetInfluences",
                    value
                );
            }
        }

        
        public CachedEntity morphTargetDictionary
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "morphTargetDictionary",
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
                    "morphTargetDictionary",
                    value
                );
            }
        }

        
        public unknown isMesh
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isMesh"
                );
            }
        }

        
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
    #endregion
    
    #region Constructor
        public Mesh() : base() { }

        public Mesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Mesh(
            TGeometry geometry = null, TMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Mesh" },
                geometry, material
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateMorphTargets()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMorphTargets" }
                }
            );
        }

        public void raycast(Raycaster raycaster, Intersection[] intersects)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "raycast" }, raycaster, intersects
                }
            );
        }
    #endregion
}
