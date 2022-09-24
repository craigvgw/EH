/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IResourcePlugin<R, RO> : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IResourcePluginCachedEntity<CachedEntity>>))]
public class IResourcePluginCachedEntity<R, RO> : CachedEntityObject, IResourcePlugin<R, RO> where R : CachedEntity, new() where RO : CachedEntity, new()
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
        public IResourcePluginCachedEntity() : base() { }

        public IResourcePluginCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public bool test(unknown source, string extension)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "test" }, source, extension
                }
            );
        }
    #endregion
}
