/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AppLoaderPlugin>))]
public class AppLoaderPlugin : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "AppLoaderPlugin",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "AppLoaderPlugin",
                    "extension",
                    value
                );
            }
        }

        private static Loader __loader;
        public static Loader loader
        {
            get
            {
            if(__loader == null)
            {
                __loader = EventHorizonBlazorInterop.GetClass<Loader>(
                    "AppLoaderPlugin",
                    "loader",
                    (entity) =>
                    {
                        return new Loader() { ___guid = entity.___guid };
                    }
                );
            }
            return __loader;
            }
            set
            {
__loader = null;
                EventHorizonBlazorInterop.Set(
                    "AppLoaderPlugin",
                    "loader",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static void init(IApplicationOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "AppLoaderPlugin", "init" }, options
                }
            );
        }

        public static void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "AppLoaderPlugin", "destroy" }
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public AppLoaderPlugin() : base() { }

        public AppLoaderPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
