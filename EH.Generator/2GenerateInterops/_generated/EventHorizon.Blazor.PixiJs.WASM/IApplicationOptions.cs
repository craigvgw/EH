/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IApplicationOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IApplicationOptionsCachedEntity>))]
public class IApplicationOptionsCachedEntity : CachedEntityObject, IApplicationOptions
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
        public IApplicationOptionsCachedEntity() : base() { }

        public IApplicationOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
