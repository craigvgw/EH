/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WEBGL_compressed_texture_etc_2 : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WEBGL_compressed_texture_etc_2CachedEntity>))]
public class WEBGL_compressed_texture_etc_2CachedEntity : CachedEntityObject, WEBGL_compressed_texture_etc_2
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
        
        public decimal COMPRESSED_R11_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_R11_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_R11_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_SIGNED_R11_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_SIGNED_R11_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_SIGNED_R11_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RG11_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RG11_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RG11_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_SIGNED_RG11_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_SIGNED_RG11_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_SIGNED_RG11_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGB8_ETC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB8_ETC2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB8_ETC2",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGBA8_ETC2_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGBA8_ETC2_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGBA8_ETC2_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_SRGB8_ETC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_SRGB8_ETC2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_SRGB8_ETC2",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_SRGB8_ALPHA8_ETC2_EAC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2",
                    value
                );
            }
        }

        
        public decimal COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WEBGL_compressed_texture_etc_2CachedEntity() : base() { }

        public WEBGL_compressed_texture_etc_2CachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
