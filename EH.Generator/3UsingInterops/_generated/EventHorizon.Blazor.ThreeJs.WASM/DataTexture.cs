/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DataTexture>))]
public class DataTexture : Texture
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private ImageData __image;
        public ImageData image
        {
            get
            {
            if(__image == null)
            {
                __image = EventHorizonBlazorInterop.GetClass<ImageData>(
                    this.___guid,
                    "image",
                    (entity) =>
                    {
                        return new ImageData() { ___guid = entity.___guid };
                    }
                );
            }
            return __image;
            }
            set
            {
__image = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "image",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }

        
        public bool generateMipmaps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateMipmaps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateMipmaps",
                    value
                );
            }
        }

        
        public decimal unpackAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "unpackAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "unpackAlignment",
                    value
                );
            }
        }

        
        public int format
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "format"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }

        
        public unknown isDataTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isDataTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public DataTexture() : base() { }

        public DataTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DataTexture(
            BufferSource data = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<int> format = null, System.Nullable<int> type = null, System.Nullable<int> mapping = null, System.Nullable<int> wrapS = null, System.Nullable<int> wrapT = null, System.Nullable<int> magFilter = null, System.Nullable<int> minFilter = null, System.Nullable<decimal> anisotropy = null, System.Nullable<int> encoding = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DataTexture" },
                data, width, height, format, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy, encoding
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
