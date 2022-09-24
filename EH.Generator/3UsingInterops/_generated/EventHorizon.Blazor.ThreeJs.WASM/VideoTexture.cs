/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<VideoTexture>))]
public class VideoTexture : Texture
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
        
        public unknown isVideoTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isVideoTexture"
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
    #endregion
    
    #region Constructor
        public VideoTexture() : base() { }

        public VideoTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public VideoTexture(
            HTMLVideoElement video, System.Nullable<int> mapping = null, System.Nullable<int> wrapS = null, System.Nullable<int> wrapT = null, System.Nullable<int> magFilter = null, System.Nullable<int> minFilter = null, System.Nullable<int> format = null, System.Nullable<int> type = null, System.Nullable<decimal> anisotropy = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "VideoTexture" },
                video, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
