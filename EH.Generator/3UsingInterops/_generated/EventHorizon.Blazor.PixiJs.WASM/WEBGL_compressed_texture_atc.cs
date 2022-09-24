/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WEBGL_compressed_texture_atc : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WEBGL_compressed_texture_atcCachedEntity>))]
public class WEBGL_compressed_texture_atcCachedEntity : CachedEntityObject, WEBGL_compressed_texture_atc
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
        
        public decimal COMPRESSED_RGB_ATC_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB_ATC_WEBGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB_ATC_WEBGL",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WEBGL_compressed_texture_atcCachedEntity() : base() { }

        public WEBGL_compressed_texture_atcCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
