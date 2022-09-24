/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BitmapFontLoader>))]
public class BitmapFontLoader : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "BitmapFontLoader",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BitmapFontLoader",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static void add()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BitmapFontLoader", "add" }
                }
            );
        }

        public static void use(Loader @this, LoaderResource resource, ActionCallback<CachedEntity[]> next)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BitmapFontLoader", "use" }, @this, resource, next
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public BitmapFontLoader() : base() { }

        public BitmapFontLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
