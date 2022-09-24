/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IBitmapFontDataCommon : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IBitmapFontDataCommonCachedEntity>))]
public class IBitmapFontDataCommonCachedEntity : CachedEntityObject, IBitmapFontDataCommon
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
        
        public decimal lineHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineHeight",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IBitmapFontDataCommonCachedEntity() : base() { }

        public IBitmapFontDataCommonCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
