/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SVGResource>))]
public class SVGResource : BaseImageResource
{
    #region Static Accessors

    #endregion

    #region Static Properties
        private static RegExp __SVG_XML;
        public static RegExp SVG_XML
        {
            get
            {
            if(__SVG_XML == null)
            {
                __SVG_XML = EventHorizonBlazorInterop.GetClass<RegExp>(
                    "SVGResource",
                    "SVG_XML",
                    (entity) =>
                    {
                        return new RegExp() { ___guid = entity.___guid };
                    }
                );
            }
            return __SVG_XML;
            }
            set
            {
__SVG_XML = null;
                EventHorizonBlazorInterop.Set(
                    "SVGResource",
                    "SVG_XML",
                    value
                );
            }
        }

        private static RegExp __SVG_SIZE;
        public static RegExp SVG_SIZE
        {
            get
            {
            if(__SVG_SIZE == null)
            {
                __SVG_SIZE = EventHorizonBlazorInterop.GetClass<RegExp>(
                    "SVGResource",
                    "SVG_SIZE",
                    (entity) =>
                    {
                        return new RegExp() { ___guid = entity.___guid };
                    }
                );
            }
            return __SVG_SIZE;
            }
            set
            {
__SVG_SIZE = null;
                EventHorizonBlazorInterop.Set(
                    "SVGResource",
                    "SVG_SIZE",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static ISizeCachedEntity getSize(string svgString = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISizeCachedEntity>(
                entity => new ISizeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "SVGResource", "getSize" }, svgString
                }
            );
        }

        public static bool test(unknown source, string extension = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "SVGResource", "test" }, source, extension
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string svg
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "svg"
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
        }
    #endregion
    
    #region Constructor
        public SVGResource() : base() { }

        public SVGResource(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SVGResource(
            string sourceBase64, ISVGResourceOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SVGResource" },
                sourceBase64, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ValueTask<SVGResource> load()
        {
            return EventHorizonBlazorInterop.TaskClass<SVGResource>(
                entity => new SVGResource() { ___guid = entity.___guid },
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
