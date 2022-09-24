/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InstancedInterleavedBuffer>))]
public class InstancedInterleavedBuffer : InterleavedBuffer
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
        
        public decimal meshPerAttribute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "meshPerAttribute"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "meshPerAttribute",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InstancedInterleavedBuffer() : base() { }

        public InstancedInterleavedBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public InstancedInterleavedBuffer(
            decimal[] array, decimal stride, System.Nullable<decimal> meshPerAttribute = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InstancedInterleavedBuffer" },
                array, stride, meshPerAttribute
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
