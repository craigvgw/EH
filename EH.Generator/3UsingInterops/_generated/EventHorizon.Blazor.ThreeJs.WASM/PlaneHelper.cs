/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PlaneHelper>))]
public class PlaneHelper : LineSegments
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

        private Plane __plane;
        public Plane plane
        {
            get
            {
            if(__plane == null)
            {
                __plane = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "plane",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __plane;
            }
            set
            {
__plane = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plane",
                    value
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public PlaneHelper() : base() { }

        public PlaneHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PlaneHelper(
            Plane plane, System.Nullable<decimal> size = null, System.Nullable<decimal> hex = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PlaneHelper" },
                plane, size, hex
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateMatrixWorld(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrixWorld" }, force
                }
            );
        }
    #endregion
}
