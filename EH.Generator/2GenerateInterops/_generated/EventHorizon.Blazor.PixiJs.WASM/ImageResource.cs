/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ImageResource>))]
public class ImageResource : BaseImageResource
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static string test(unknown source)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "ImageResource", "test" }, source
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string url
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "url"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "url",
                    value
                );
            }
        }

        
        public bool preserveBitmap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveBitmap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preserveBitmap",
                    value
                );
            }
        }

        
        public bool createBitmap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "createBitmap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "createBitmap",
                    value
                );
            }
        }

        
        public int alphaMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "alphaMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaMode",
                    value
                );
            }
        }

        private ImageBitmap __bitmap;
        public ImageBitmap bitmap
        {
            get
            {
            if(__bitmap == null)
            {
                __bitmap = EventHorizonBlazorInterop.GetClass<ImageBitmap>(
                    this.___guid,
                    "bitmap",
                    (entity) =>
                    {
                        return new ImageBitmap() { ___guid = entity.___guid };
                    }
                );
            }
            return __bitmap;
            }
            set
            {
__bitmap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bitmap",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ImageResource() : base() { }

        public ImageResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ImageResource(
            HTMLImageElement source, IImageResourceOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ImageResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ValueTask<ImageResource> load(System.Nullable<bool> createBitmap = null)
        {
            return EventHorizonBlazorInterop.TaskClass<ImageResource>(
                entity => new ImageResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }, createBitmap
                }
            );
        }

        public ValueTask<ImageResource> process()
        {
            return EventHorizonBlazorInterop.TaskClass<ImageResource>(
                entity => new ImageResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "process" }
                }
            );
        }

        public bool upload(Renderer renderer, BaseTexture baseTexture, GLTexture glTexture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, baseTexture, glTexture
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
