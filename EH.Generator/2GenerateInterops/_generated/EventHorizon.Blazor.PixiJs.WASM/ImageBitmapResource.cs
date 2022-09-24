/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ImageBitmapResource>))]
public class ImageBitmapResource : BaseImageResource
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static source test(unknown source)
        {
            return EventHorizonBlazorInterop.FuncClass<source>(
                entity => new source() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "ImageBitmapResource", "test" }, source
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public ImageBitmapResource() : base() { }

        public ImageBitmapResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ImageBitmapResource(
            ImageBitmap source
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ImageBitmapResource" },
                source
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
