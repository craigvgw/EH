/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IUploadHook : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IUploadHookCachedEntity>))]
public class IUploadHookCachedEntity : CachedEntityObject, IUploadHook
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
        public IUploadHookCachedEntity() : base() { }

        public IUploadHookCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
