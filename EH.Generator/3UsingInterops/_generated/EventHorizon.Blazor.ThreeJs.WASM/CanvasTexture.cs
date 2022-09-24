/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CanvasTexture>))]
public class CanvasTexture : Texture
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
        
        public unknown isCanvasTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isCanvasTexture"
                );
            }
        }
    #endregion
    
    #region Constructor
        public CanvasTexture() : base() { }

        public CanvasTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CanvasTexture(
            HTMLImageElement canvas, System.Nullable<int> mapping = null, System.Nullable<int> wrapS = null, System.Nullable<int> wrapT = null, System.Nullable<int> magFilter = null, System.Nullable<int> minFilter = null, System.Nullable<int> format = null, System.Nullable<int> type = null, System.Nullable<decimal> anisotropy = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CanvasTexture" },
                canvas, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
