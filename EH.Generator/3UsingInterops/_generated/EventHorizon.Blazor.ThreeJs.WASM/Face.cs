/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Face : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<FaceCachedEntity>))]
public class FaceCachedEntity : CachedEntityObject, Face
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
        
        public decimal a
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }

        
        public decimal c
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "c"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "c",
                    value
                );
            }
        }

        private Vector3 __normal;
        public Vector3 normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
            }
            set
            {
__normal = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
            }
        }

        
        public decimal materialIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialIndex",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public FaceCachedEntity() : base() { }

        public FaceCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
