/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<KTXLoader>))]
public class KTXLoader : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "KTXLoader",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "KTXLoader",
                    "extension",
                    value
                );
            }
        }

        
        public static bool loadKeyValueData
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "KTXLoader",
                    "loadKeyValueData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "KTXLoader",
                    "loadKeyValueData",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static void use(LoaderResource resource, ActionCallback<CachedEntity[]> next)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "KTXLoader", "use" }, resource, next
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public KTXLoader() : base() { }

        public KTXLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
