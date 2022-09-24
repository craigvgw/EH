/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Euler>))]
public class Euler : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static string[] RotationOrders
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    "Euler",
                    "RotationOrders"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Euler",
                    "RotationOrders",
                    value
                );
            }
        }

        
        public static string DefaultOrder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "Euler",
                    "DefaultOrder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Euler",
                    "DefaultOrder",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
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

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public string order
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "order"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "order",
                    value
                );
            }
        }

        
        public unknown isEuler
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isEuler"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Euler() : base() { }

        public Euler(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Euler(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, string order = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Euler" },
                x, y, z, order
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Euler set(decimal x, decimal y, decimal z, string order = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z, order
                }
            );
        }

        public Euler clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Euler copy(Euler euler)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, euler
                }
            );
        }

        public Euler setFromRotationMatrix(Matrix4 m, string order = null, System.Nullable<bool> update = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromRotationMatrix" }, m, order, update
                }
            );
        }

        public Euler setFromQuaternion(Quaternion q, string order = null, System.Nullable<bool> update = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromQuaternion" }, q, order, update
                }
            );
        }

        public Euler setFromVector3(Vector3 v, string order = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromVector3" }, v, order
                }
            );
        }

        public Euler reorder(string newOrder)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reorder" }, newOrder
                }
            );
        }

        public bool equals(Euler euler)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, euler
                }
            );
        }

        public Euler fromArray(CachedEntity[] xyzo)
        {
            return EventHorizonBlazorInterop.FuncClass<Euler>(
                entity => new Euler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, xyzo
                }
            );
        }

        public decimal[] toArray(decimal[] array = null, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, offset
                }
            );
        }
    #endregion
}
