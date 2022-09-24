/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IBitmapFontDataDistanceField : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IBitmapFontDataDistanceFieldCachedEntity>))]
public class IBitmapFontDataDistanceFieldCachedEntity : CachedEntityObject, IBitmapFontDataDistanceField
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
        
        public string fieldType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fieldType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fieldType",
                    value
                );
            }
        }

        
        public decimal distanceRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distanceRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distanceRange",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IBitmapFontDataDistanceFieldCachedEntity() : base() { }

        public IBitmapFontDataDistanceFieldCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
