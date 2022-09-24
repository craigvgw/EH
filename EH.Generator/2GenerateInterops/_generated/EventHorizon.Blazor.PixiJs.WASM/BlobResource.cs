/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BlobResource>))]
public class BlobResource : BufferResource
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
        public BlobResource() : base() { }

        public BlobResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BlobResource(
            string source, IBlobOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BlobResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ValueTask<Resource> load()
        {
            return EventHorizonBlazorInterop.TaskClass<Resource>(
                entity => new Resource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }
                }
            );
        }
    #endregion
}
