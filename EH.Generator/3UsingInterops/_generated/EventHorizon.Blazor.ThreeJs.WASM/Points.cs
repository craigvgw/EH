/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Points<CachedEntity>>))]
public class Points<TGeometry, Material> : Object3D where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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

        
        public unknown isPoints
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isPoints"
                );
            }
        }

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
    #endregion
    
    #region Constructor
        public Points() : base() { }

        public Points(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Points(
            TGeometry geometry = null, TMaterial material = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Points" },
                geometry, material
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void raycast(Raycaster raycaster, Intersection[] intersects)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "raycast" }, raycaster, intersects
                }
            );
        }

        public void updateMorphTargets()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMorphTargets" }
                }
            );
        }
    #endregion
}
