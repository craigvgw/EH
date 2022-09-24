/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<VideoResource>))]
public class VideoResource : BaseImageResource
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static string[] TYPES
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    "VideoResource",
                    "TYPES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "VideoResource",
                    "TYPES",
                    value
                );
            }
        }

// MIME_TYPES is not supported by the platform yet
    #endregion

    #region Static Methods
        public static source test(unknown source, string extension = null)
        {
            return EventHorizonBlazorInterop.FuncClass<source>(
                entity => new source() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "VideoResource", "test" }, source, extension
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }

        
        public decimal updateFPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateFPS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateFPS",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private HTMLVideoElement __source;
        public HTMLVideoElement source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInterop.GetClass<HTMLVideoElement>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new HTMLVideoElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
            set
            {
__source = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public VideoResource() : base() { }

        public VideoResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public VideoResource(
            HTMLVideoElement source = null, IVideoResourceOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "VideoResource" },
                source, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(System.Nullable<decimal> _deltaTime = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, _deltaTime
                }
            );
        }

        public ValueTask<VideoResource> load()
        {
            return EventHorizonBlazorInterop.TaskClass<VideoResource>(
                entity => new VideoResource() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "load" }
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
