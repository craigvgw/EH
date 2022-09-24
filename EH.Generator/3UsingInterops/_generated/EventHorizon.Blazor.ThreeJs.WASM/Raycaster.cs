/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Raycaster>))]
public class Raycaster : CachedEntityObject
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
        private Ray __ray;
        public Ray ray
        {
            get
            {
            if(__ray == null)
            {
                __ray = EventHorizonBlazorInterop.GetClass<Ray>(
                    this.___guid,
                    "ray",
                    (entity) =>
                    {
                        return new Ray() { ___guid = entity.___guid };
                    }
                );
            }
            return __ray;
            }
            set
            {
__ray = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ray",
                    value
                );
            }
        }

        
        public decimal near
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "near"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "near",
                    value
                );
            }
        }

        
        public decimal far
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "far"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "far",
                    value
                );
            }
        }

        private Camera __camera;
        public Camera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        private Layers __layers;
        public Layers layers
        {
            get
            {
            if(__layers == null)
            {
                __layers = EventHorizonBlazorInterop.GetClass<Layers>(
                    this.___guid,
                    "layers",
                    (entity) =>
                    {
                        return new Layers() { ___guid = entity.___guid };
                    }
                );
            }
            return __layers;
            }
            set
            {
__layers = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layers",
                    value
                );
            }
        }

        private RaycasterParametersCachedEntity __params;
        public RaycasterParametersCachedEntity @params
        {
            get
            {
            if(__params == null)
            {
                __params = EventHorizonBlazorInterop.GetClass<RaycasterParametersCachedEntity>(
                    this.___guid,
                    "params",
                    (entity) =>
                    {
                        return new RaycasterParametersCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __params;
            }
            set
            {
__params = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "params",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Raycaster() : base() { }

        public Raycaster(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Raycaster(
            Vector3 origin = null, Vector3 direction = null, System.Nullable<decimal> near = null, System.Nullable<decimal> far = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Raycaster" },
                origin, direction, near, far
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void set(Vector3 origin, Vector3 direction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "set" }, origin, direction
                }
            );
        }

        public void setFromCamera(object coords, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFromCamera" }, coords, camera
                }
            );
        }

        public IntersectionCachedEntity<TIntersected>[] intersectObject<TIntersected>(Object3D @object, System.Nullable<bool> recursive = null, Intersection<TIntersected>[] optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IntersectionCachedEntity<TIntersected>>(
                entity => new IntersectionCachedEntity<TIntersected>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectObject" }, @object, recursive, optionalTarget
                }
            );
        }

        public IntersectionCachedEntity<TIntersected>[] intersectObjects<TIntersected>(Object3D[] objects, System.Nullable<bool> recursive = null, Intersection<TIntersected>[] optionalTarget = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IntersectionCachedEntity<TIntersected>>(
                entity => new IntersectionCachedEntity<TIntersected>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectObjects" }, objects, recursive, optionalTarget
                }
            );
        }
    #endregion
}
