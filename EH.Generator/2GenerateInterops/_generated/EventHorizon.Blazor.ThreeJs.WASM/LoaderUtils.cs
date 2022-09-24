/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface LoaderUtils : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<LoaderUtilsCachedEntity>))]
public class LoaderUtilsCachedEntity : CachedEntityObject, LoaderUtils
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

    #endregion
    
    #region Constructor
        public LoaderUtilsCachedEntity() : base() { }

        public LoaderUtilsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public string decodeText(BufferSource array)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "decodeText" }, array
                }
            );
        }

        public string extractUrlBase(string url)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "extractUrlBase" }, url
                }
            );
        }

        public string resolveURL(string url, string path)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "resolveURL" }, url, path
                }
            );
        }
    #endregion
}
