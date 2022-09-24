/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TextureLoader>))]
public class TextureLoader : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "TextureLoader",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TextureLoader",
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
                    new string[] { "TextureLoader", "add" }
                }
            );
        }

        public static void use(LoaderResource resource, ActionCallback<CachedEntity[]> next)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "TextureLoader", "use" }, resource, next
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public TextureLoader() : base() { }

        public TextureLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
