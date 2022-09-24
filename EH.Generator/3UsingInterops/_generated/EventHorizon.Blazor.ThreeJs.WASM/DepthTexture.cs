/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<DepthTexture>))]
public class DepthTexture : Texture
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public CachedEntity image
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "image"
                );
            }
            set
            {

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

        
        public unknown isDepthTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isDepthTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public DepthTexture() : base() { }

        public DepthTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DepthTexture(
            decimal width, decimal height, System.Nullable<int> type = null, System.Nullable<int> mapping = null, System.Nullable<int> wrapS = null, System.Nullable<int> wrapT = null, System.Nullable<int> magFilter = null, System.Nullable<int> minFilter = null, System.Nullable<decimal> anisotropy = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "DepthTexture" },
                width, height, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
