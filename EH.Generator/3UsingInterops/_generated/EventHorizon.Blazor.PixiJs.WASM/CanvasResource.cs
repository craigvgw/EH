/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CanvasResource>))]
public class CanvasResource : BaseImageResource
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static OffscreenCanvas test(unknown source)
        {
            return EventHorizonBlazorInterop.FuncClass<OffscreenCanvas>(
                entity => new OffscreenCanvas() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "CanvasResource", "test" }, source
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public CanvasResource() : base() { }

        public CanvasResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CanvasResource(
            HTMLCanvasElement source
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CanvasResource" },
                source
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
