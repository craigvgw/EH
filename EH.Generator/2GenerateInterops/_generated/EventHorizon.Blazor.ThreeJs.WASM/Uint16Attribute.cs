/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Uint16Attribute>))]
public class Uint16Attribute : BufferAttribute
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
        public Uint16Attribute() : base() { }

        public Uint16Attribute(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Uint16Attribute(
            object array, decimal itemSize
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Uint16Attribute" },
                array, itemSize
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
