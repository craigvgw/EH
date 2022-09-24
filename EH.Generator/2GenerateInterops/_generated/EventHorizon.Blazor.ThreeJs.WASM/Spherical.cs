/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Spherical>))]
public class Spherical : CachedEntityObject
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

        
        public decimal phi
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "phi"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "phi",
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
    #endregion
    
    #region Constructor
        public Spherical() : base() { }

        public Spherical(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Spherical(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> phi = null, System.Nullable<decimal> theta = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Spherical" },
                radius, phi, theta
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Spherical set(decimal radius, decimal phi, decimal theta)
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, radius, phi, theta
                }
            );
        }

        public Spherical clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Spherical copy(Spherical other)
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, other
                }
            );
        }

        public Spherical makeSafe()
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeSafe" }
                }
            );
        }

        public Spherical setFromVector3(Vector3 v)
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromVector3" }, v
                }
            );
        }

        public Spherical setFromCartesianCoords(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Spherical>(
                entity => new Spherical() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromCartesianCoords" }, x, y, z
                }
            );
        }
    #endregion
}
