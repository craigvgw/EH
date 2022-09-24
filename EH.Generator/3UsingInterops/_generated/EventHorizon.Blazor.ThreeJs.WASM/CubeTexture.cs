/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CubeTexture>))]
public class CubeTexture : Texture
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
        
        public CachedEntity images
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "images",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "images",
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

        
        public unknown isCubeTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isCubeTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public CubeTexture() : base() { }

        public CubeTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CubeTexture(
            CachedEntity[] images = null, System.Nullable<int> mapping = null, System.Nullable<int> wrapS = null, System.Nullable<int> wrapT = null, System.Nullable<int> magFilter = null, System.Nullable<int> minFilter = null, System.Nullable<int> format = null, System.Nullable<int> type = null, System.Nullable<decimal> anisotropy = null, System.Nullable<int> encoding = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CubeTexture" },
                images, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy, encoding
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
