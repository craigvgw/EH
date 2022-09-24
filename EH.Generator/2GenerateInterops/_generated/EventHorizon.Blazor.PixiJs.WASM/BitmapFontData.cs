/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BitmapFontData>))]
public class BitmapFontData : CachedEntityObject
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
        
        public IBitmapFontDataInfoCachedEntity[] info
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataInfoCachedEntity>(
                    this.___guid,
                    "info",
                    (entity) =>
                    {
                        return new IBitmapFontDataInfoCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "info",
                    value
                );
            }
        }

        
        public IBitmapFontDataCommonCachedEntity[] common
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataCommonCachedEntity>(
                    this.___guid,
                    "common",
                    (entity) =>
                    {
                        return new IBitmapFontDataCommonCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "common",
                    value
                );
            }
        }

        
        public IBitmapFontDataPageCachedEntity[] page
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataPageCachedEntity>(
                    this.___guid,
                    "page",
                    (entity) =>
                    {
                        return new IBitmapFontDataPageCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "page",
                    value
                );
            }
        }

        
        public IBitmapFontDataCharCachedEntity[] char
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataCharCachedEntity>(
                    this.___guid,
                    "char",
                    (entity) =>
                    {
                        return new IBitmapFontDataCharCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "char",
                    value
                );
            }
        }

        
        public IBitmapFontDataKerningCachedEntity[] kerning
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataKerningCachedEntity>(
                    this.___guid,
                    "kerning",
                    (entity) =>
                    {
                        return new IBitmapFontDataKerningCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "kerning",
                    value
                );
            }
        }

        
        public IBitmapFontDataDistanceFieldCachedEntity[] distanceField
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IBitmapFontDataDistanceFieldCachedEntity>(
                    this.___guid,
                    "distanceField",
                    (entity) =>
                    {
                        return new IBitmapFontDataDistanceFieldCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distanceField",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BitmapFontData() : base() { }

        public BitmapFontData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
