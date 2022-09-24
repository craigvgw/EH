/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Cylindrical>))]
public class Cylindrical : CachedEntityObject
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
        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal theta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "theta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "theta",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Cylindrical() : base() { }

        public Cylindrical(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Cylindrical(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> theta = null, System.Nullable<decimal> y = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Cylindrical" },
                radius, theta, y
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Cylindrical clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Cylindrical>(
                entity => new Cylindrical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Cylindrical copy(Cylindrical other)
        {
            return EventHorizonBlazorInterop.FuncClass<Cylindrical>(
                entity => new Cylindrical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, other
                }
            );
        }

        public Cylindrical set(decimal radius, decimal theta, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Cylindrical>(
                entity => new Cylindrical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, radius, theta, y
                }
            );
        }

        public Cylindrical setFromVector3(Vector3 vec3)
        {
            return EventHorizonBlazorInterop.FuncClass<Cylindrical>(
                entity => new Cylindrical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromVector3" }, vec3
                }
            );
        }

        public Cylindrical setFromCartesianCoords(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Cylindrical>(
                entity => new Cylindrical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromCartesianCoords" }, x, y, z
                }
            );
        }
    #endregion
}
