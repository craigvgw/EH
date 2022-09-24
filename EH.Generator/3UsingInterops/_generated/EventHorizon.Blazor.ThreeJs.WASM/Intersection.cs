/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Intersection<TIntersected> : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IntersectionCachedEntity<CachedEntity>>))]
public class IntersectionCachedEntity<TIntersected> : CachedEntityObject, Intersection<TIntersected> where TIntersected : CachedEntity, new()
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
        
        public decimal distance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distance",
                    value
                );
            }
        }

        
        public decimal distanceToRay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distanceToRay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distanceToRay",
                    value
                );
            }
        }

        private Vector3 __point;
        public Vector3 point
        {
            get
            {
            if(__point == null)
            {
                __point = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "point",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __point;
            }
            set
            {
__point = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "point",
                    value
                );
            }
        }

        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        private FaceCachedEntity __face;
        public FaceCachedEntity face
        {
            get
            {
            if(__face == null)
            {
                __face = EventHorizonBlazorInterop.GetClass<FaceCachedEntity>(
                    this.___guid,
                    "face",
                    (entity) =>
                    {
                        return new FaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __face;
            }
            set
            {
__face = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "face",
                    value
                );
            }
        }

        
        public decimal faceIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "faceIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceIndex",
                    value
                );
            }
        }

        private TIntersected __object;
        public TIntersected @object
        {
            get
            {
            if(__object == null)
            {
                __object = EventHorizonBlazorInterop.GetClass<TIntersected>(
                    this.___guid,
                    "object",
                    (entity) =>
                    {
                        return new TIntersected() { ___guid = entity.___guid };
                    }
                );
            }
            return __object;
            }
            set
            {
__object = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "object",
                    value
                );
            }
        }

        private Vector2 __uv;
        public Vector2 uv
        {
            get
            {
            if(__uv == null)
            {
                __uv = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "uv",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __uv;
            }
            set
            {
__uv = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uv",
                    value
                );
            }
        }

        private Vector2 __uv2;
        public Vector2 uv2
        {
            get
            {
            if(__uv2 == null)
            {
                __uv2 = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "uv2",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __uv2;
            }
            set
            {
__uv2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uv2",
                    value
                );
            }
        }

        
        public decimal instanceId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instanceId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanceId",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IntersectionCachedEntity() : base() { }

        public IntersectionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
