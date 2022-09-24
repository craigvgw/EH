/// Generated - Do Not Edit
namespace Phaser.Textures
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CanvasTexture>))]
    public class CanvasTexture : Texture
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
        private HTMLCanvasElement __canvas;
        public HTMLCanvasElement canvas
        {
            get
            {
            if(__canvas == null)
            {
                __canvas = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "canvas",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvas;
            }
        }

        private CanvasRenderingContext2D __context;
        public CanvasRenderingContext2D context
        {
            get
            {
            if(__context == null)
            {
                __context = EventHorizonBlazorInterop.GetClass<CanvasRenderingContext2D>(
                    this.___guid,
                    "context",
                    (entity) =>
                    {
                        return new CanvasRenderingContext2D() { ___guid = entity.___guid };
                    }
                );
            }
            return __context;
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
        }

        private ImageData __imageData;
        public ImageData imageData
        {
            get
            {
            if(__imageData == null)
            {
                __imageData = EventHorizonBlazorInterop.GetClass<ImageData>(
                    this.___guid,
                    "imageData",
                    (entity) =>
                    {
                        return new ImageData() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageData;
            }
            set
            {
__imageData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageData",
                    value
                );
            }
        }

        private Uint8ClampedArray __data;
        public Uint8ClampedArray data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<Uint8ClampedArray>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new Uint8ClampedArray() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        private Uint32Array __pixels;
        public Uint32Array pixels
        {
            get
            {
            if(__pixels == null)
            {
                __pixels = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "pixels",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __pixels;
            }
            set
            {
__pixels = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pixels",
                    value
                );
            }
        }

        private ArrayBuffer __buffer;
        public ArrayBuffer buffer
        {
            get
            {
            if(__buffer == null)
            {
                __buffer = EventHorizonBlazorInterop.GetClass<ArrayBuffer>(
                    this.___guid,
                    "buffer",
                    (entity) =>
                    {
                        return new ArrayBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __buffer;
            }
            set
            {
__buffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffer",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CanvasTexture() : base() { }

        public CanvasTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CanvasTexture(
            TextureManager manager, string key, HTMLCanvasElement source, decimal width, decimal height
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Textures", "CanvasTexture" },
                manager, key, source, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CanvasTexture update()
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public CanvasTexture draw(decimal x, decimal y, HTMLImageElement source)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "draw" }, x, y, source
                }
            );
        }

        public CanvasTexture drawFrame(string key, string frame = null, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawFrame" }, key, frame, x, y
                }
            );
        }

        public CanvasTexture setPixel(decimal x, decimal y, decimal red, decimal green, decimal blue, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPixel" }, x, y, red, green, blue, alpha
                }
            );
        }

        public CanvasTexture putData(ImageData imageData, decimal x, decimal y, System.Nullable<decimal> dirtyX = null, System.Nullable<decimal> dirtyY = null, System.Nullable<decimal> dirtyWidth = null, System.Nullable<decimal> dirtyHeight = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "putData" }, imageData, x, y, dirtyX, dirtyY, dirtyWidth, dirtyHeight
                }
            );
        }

        public ImageData getData(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageData>(
                entity => new ImageData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getData" }, x, y, width, height
                }
            );
        }

        public Color getPixel(decimal x, decimal y, Color out = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPixel" }, x, y, out
                }
            );
        }

// getPixels is not supported by the platform yet

        public decimal getIndex(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, x, y
                }
            );
        }

        public CanvasTexture refresh()
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refresh" }
                }
            );
        }

        public HTMLCanvasElement getCanvas()
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCanvasElement>(
                entity => new HTMLCanvasElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCanvas" }
                }
            );
        }

        public CanvasRenderingContext2D getContext()
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2D>(
                entity => new CanvasRenderingContext2D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" }
                }
            );
        }

        public CanvasTexture clear(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }, x, y, width, height
                }
            );
        }

        public CanvasTexture setSize(decimal width, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasTexture>(
                entity => new CanvasTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
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
}