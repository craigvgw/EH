/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpritesheetLoader>))]
public class SpritesheetLoader : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "SpritesheetLoader",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "SpritesheetLoader",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static void use(LoaderResource resource, ActionCallback<unknown[]> next)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "SpritesheetLoader", "use" }, resource, next
                }
            );
        }

        public static string getResourcePath(LoaderResource resource, string baseUrl)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "SpritesheetLoader", "getResourcePath" }, resource, baseUrl
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public SpritesheetLoader() : base() { }

        public SpritesheetLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
