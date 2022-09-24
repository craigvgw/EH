/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Attribute>))]
public class Attribute : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Attribute from(decimal buffer, System.Nullable<decimal> size = null, System.Nullable<bool> normalized = null, System.Nullable<int> type = null, System.Nullable<decimal> stride = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Attribute>(
                entity => new Attribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Attribute", "from" }, buffer, size, normalized, type, stride
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public decimal buffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffer",
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

        
        public bool normalized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "normalized"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalized",
                    value
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        
        public decimal stride
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stride"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stride",
                    value
                );
            }
        }

        
        public decimal start
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "start"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "start",
                    value
                );
            }
        }

        
        public bool instance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "instance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instance",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Attribute() : base() { }

        public Attribute(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Attribute(
            decimal buffer, System.Nullable<decimal> size = null, System.Nullable<bool> normalized = null, System.Nullable<int> type = null, System.Nullable<decimal> stride = null, System.Nullable<decimal> start = null, System.Nullable<bool> instance = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Attribute" },
                buffer, size, normalized, type, stride, start, instance
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
