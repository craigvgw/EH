/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Extract_2>))]
public class Extract_2 : CachedEntityObject, IRendererPlugin
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "Extract_2",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Extract_2",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        public static void arrayPostDivide(decimal[] pixels, decimal[] out)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "Extract_2", "arrayPostDivide" }, pixels, out
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public Extract_2() : base() { }

        public Extract_2(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Extract_2(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Extract_2" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public HTMLImageElement image(DisplayObject target, string format = null, System.Nullable<decimal> quality = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
                entity => new HTMLImageElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "image" }, target, format, quality
                }
            );
        }

        public string base64(DisplayObject target, string format = null, System.Nullable<decimal> quality = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "base64" }, target, format, quality
                }
            );
        }

        public HTMLCanvasElement canvas(DisplayObject target, Rectangle frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCanvasElement>(
                entity => new HTMLCanvasElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "canvas" }, target, frame
                }
            );
        }

        public decimal[] pixels(DisplayObject target = null, Rectangle frame = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "pixels" }, target, frame
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
