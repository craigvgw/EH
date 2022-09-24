/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ShapeRenderer>))]
    public class ShapeRenderer : CachedEntityObject, Disposable
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
        public ShapeRenderer() : base() { }

        public ShapeRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ShapeRenderer(
            ManagedWebGLRenderingContext context, System.Nullable<decimal> maxVertices = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "webgl", "ShapeRenderer" },
                context, maxVertices
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void begin(Shader shader)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "begin" }, shader
                }
            );
        }

        public void setBlendMode(decimal srcBlend, decimal dstBlend)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBlendMode" }, srcBlend, dstBlend
                }
            );
        }

        public void setColor(Color color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColor" }, color
                }
            );
        }

        public void setColorWith(decimal r, decimal g, decimal b, decimal a)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColorWith" }, r, g, b, a
                }
            );
        }

        public void point(decimal x, decimal y, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "point" }, x, y, color
                }
            );
        }

        public void line(decimal x, decimal y, decimal x2, decimal y2, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "line" }, x, y, x2, y2, color
                }
            );
        }

        public void triangle(bool filled, decimal x, decimal y, decimal x2, decimal y2, decimal x3, decimal y3, Color color = null, Color color2 = null, Color color3 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "triangle" }, filled, x, y, x2, y2, x3, y3, color, color2, color3
                }
            );
        }

        public void quad(bool filled, decimal x, decimal y, decimal x2, decimal y2, decimal x3, decimal y3, decimal x4, decimal y4, Color color = null, Color color2 = null, Color color3 = null, Color color4 = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "quad" }, filled, x, y, x2, y2, x3, y3, x4, y4, color, color2, color3, color4
                }
            );
        }

        public void rect(bool filled, decimal x, decimal y, decimal width, decimal height, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rect" }, filled, x, y, width, height, color
                }
            );
        }

        public void rectLine(bool filled, decimal x1, decimal y1, decimal x2, decimal y2, decimal width, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rectLine" }, filled, x1, y1, x2, y2, width, color
                }
            );
        }

        public void x(decimal x, decimal y, decimal size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "x" }, x, y, size
                }
            );
        }

        public void polygon(decimal[] polygonVertices, decimal offset, decimal count, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "polygon" }, polygonVertices, offset, count, color
                }
            );
        }

        public void circle(bool filled, decimal x, decimal y, decimal radius, Color color = null, System.Nullable<decimal> segments = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "circle" }, filled, x, y, radius, color, segments
                }
            );
        }

        public void curve(decimal x1, decimal y1, decimal cx1, decimal cy1, decimal cx2, decimal cy2, decimal x2, decimal y2, decimal segments, Color color = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "curve" }, x1, y1, cx1, cy1, cx2, cy2, x2, y2, segments, color
                }
            );
        }

        public void end()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }
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
}