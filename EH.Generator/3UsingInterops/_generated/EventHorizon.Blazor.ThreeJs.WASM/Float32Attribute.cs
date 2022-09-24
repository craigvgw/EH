/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Float32Attribute>))]
public class Float32Attribute : BufferAttribute
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

    #endregion
    
    #region Constructor
        public Float32Attribute() : base() { }

        public Float32Attribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Float32Attribute(
            object array, decimal itemSize
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Float32Attribute" },
                array, itemSize
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
