/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Data3DTexture>))]
public class Data3DTexture : Texture
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
        
        public int magFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "magFilter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "magFilter",
                    value
                );
            }
        }

        
        public int minFilter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "minFilter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minFilter",
                    value
                );
            }
        }

        
        public bool wrapR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wrapR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapR",
                    value
                );
            }
        }

        
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

        
        public unknown isData3DTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isData3DTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public Data3DTexture() : base() { }

        public Data3DTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Data3DTexture(
            BufferSource data, decimal width, decimal height, decimal depth
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Data3DTexture" },
                data, width, height, depth
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
