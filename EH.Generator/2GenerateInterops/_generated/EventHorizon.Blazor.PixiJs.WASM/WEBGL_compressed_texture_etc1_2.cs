/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WEBGL_compressed_texture_etc1_2 : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WEBGL_compressed_texture_etc1_2CachedEntity>))]
public class WEBGL_compressed_texture_etc1_2CachedEntity : CachedEntityObject, WEBGL_compressed_texture_etc1_2
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
        
        public decimal COMPRESSED_RGB_ETC1_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB_ETC1_WEBGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB_ETC1_WEBGL",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WEBGL_compressed_texture_etc1_2CachedEntity() : base() { }

        public WEBGL_compressed_texture_etc1_2CachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
