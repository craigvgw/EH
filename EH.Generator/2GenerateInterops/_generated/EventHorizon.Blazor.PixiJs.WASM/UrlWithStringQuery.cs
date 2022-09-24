/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface UrlWithStringQuery : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<UrlWithStringQueryCachedEntity>))]
public class UrlWithStringQueryCachedEntity : CachedEntityObject, UrlWithStringQuery
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
        
        public string query
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "query"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "query",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public UrlWithStringQueryCachedEntity() : base() { }

        public UrlWithStringQueryCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
