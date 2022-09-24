/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WEBGL_compressed_texture_pvrtc_2 : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WEBGL_compressed_texture_pvrtc_2CachedEntity>))]
public class WEBGL_compressed_texture_pvrtc_2CachedEntity : CachedEntityObject, WEBGL_compressed_texture_pvrtc_2
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
        
        public decimal COMPRESSED_RGB_PVRTC_4BPPV1_IMG
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB_PVRTC_4BPPV1_IMG"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB_PVRTC_4BPPV1_IMG",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGBA_PVRTC_4BPPV1_IMG
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGBA_PVRTC_4BPPV1_IMG"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGBA_PVRTC_4BPPV1_IMG",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGB_PVRTC_2BPPV1_IMG
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB_PVRTC_2BPPV1_IMG"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB_PVRTC_2BPPV1_IMG",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGBA_PVRTC_2BPPV1_IMG
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGBA_PVRTC_2BPPV1_IMG"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGBA_PVRTC_2BPPV1_IMG",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WEBGL_compressed_texture_pvrtc_2CachedEntity() : base() { }

        public WEBGL_compressed_texture_pvrtc_2CachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
