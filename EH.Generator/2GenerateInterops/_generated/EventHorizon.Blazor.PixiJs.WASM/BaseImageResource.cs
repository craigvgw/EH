/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BaseImageResource>))]
public class BaseImageResource : Resource
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void crossOrigin(HTMLImageElement element, string url, System.Nullable<bool> crossorigin = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BaseImageResource", "crossOrigin" }, element, url, crossorigin
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public HTMLImageElement source
        {
            get
            {
            return EventHorizonBlazorInterop.Get<HTMLImageElement>(
                    this.___guid,
                    "source"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public bool noSubImage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noSubImage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noSubImage",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BaseImageResource() : base() { }

        public BaseImageResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseImageResource(
            HTMLImageElement source
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BaseImageResource" },
                source
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public bool upload(Renderer renderer, BaseTexture baseTexture, GLTexture glTexture, HTMLImageElement source = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "upload" }, renderer, baseTexture, glTexture, source
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
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
