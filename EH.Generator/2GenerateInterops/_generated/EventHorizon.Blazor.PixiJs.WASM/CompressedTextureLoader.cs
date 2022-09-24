/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CompressedTextureLoader>))]
public class CompressedTextureLoader : CachedEntityObject
{
    #region Static Accessors
        
        public static CachedEntity textureExtensions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    "CompressedTextureLoader",
                    "textureExtensions"
                );
            }
        }

        
        public static int textureFormats
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "CompressedTextureLoader",
                    "textureFormats"
                );
            }
        }
    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "CompressedTextureLoader",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "CompressedTextureLoader",
                    "extension",
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
                    new string[] { "CompressedTextureLoader", "use" }, resource, next
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public CompressedTextureLoader() : base() { }

        public CompressedTextureLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
