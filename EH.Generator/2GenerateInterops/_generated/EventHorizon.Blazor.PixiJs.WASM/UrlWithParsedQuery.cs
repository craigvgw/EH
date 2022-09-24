/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface UrlWithParsedQuery : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<UrlWithParsedQueryCachedEntity>))]
public class UrlWithParsedQueryCachedEntity : CachedEntityObject, UrlWithParsedQuery
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
        private ParsedUrlQueryCachedEntity __query;
        public ParsedUrlQueryCachedEntity query
        {
            get
            {
            if(__query == null)
            {
                __query = EventHorizonBlazorInterop.GetClass<ParsedUrlQueryCachedEntity>(
                    this.___guid,
                    "query",
                    (entity) =>
                    {
                        return new ParsedUrlQueryCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __query;
            }
            set
            {
__query = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "query",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public UrlWithParsedQueryCachedEntity() : base() { }

        public UrlWithParsedQueryCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
