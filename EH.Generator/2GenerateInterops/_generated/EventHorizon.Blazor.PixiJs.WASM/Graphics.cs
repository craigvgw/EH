/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Graphics>))]
public class Graphics : Container
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static bool nextRoundedRectBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "Graphics",
                    "nextRoundedRectBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Graphics",
                    "nextRoundedRectBehavior",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private GraphicsGeometry __geometry;
        public GraphicsGeometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<GraphicsGeometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new GraphicsGeometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
        }

        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        private FillStyle __fill;
        public FillStyle fill
        {
            get
            {
            if(__fill == null)
            {
                __fill = EventHorizonBlazorInterop.GetClass<FillStyle>(
                    this.___guid,
                    "fill",
                    (entity) =>
                    {
                        return new FillStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __fill;
            }
        }

        private LineStyle __line;
        public LineStyle line
        {
            get
            {
            if(__line == null)
            {
                __line = EventHorizonBlazorInterop.GetClass<LineStyle>(
                    this.___guid,
                    "line",
                    (entity) =>
                    {
                        return new LineStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __line;
            }
        }
    #endregion

    #region Properties
        private Shader __shader;
        public Shader shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<Shader>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new Shader() { ___guid = entity.___guid };
                    }
                );
            }
            return __shader;
            }
            set
            {
__shader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shader",
                    value
                );
            }
        }

        
        public string pluginName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pluginName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pluginName",
                    value
                );
            }
        }

        private Polygon __currentPath;
        public Polygon currentPath
        {
            get
            {
            if(__currentPath == null)
            {
                __currentPath = EventHorizonBlazorInterop.GetClass<Polygon>(
                    this.___guid,
                    "currentPath",
                    (entity) =>
                    {
                        return new Polygon() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentPath;
            }
            set
            {
__currentPath = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentPath",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Graphics() : base() { }

        public Graphics(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Graphics(
            GraphicsGeometry geometry = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Graphics" },
                geometry
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Graphics clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Graphics lineStyle(decimal width, System.Nullable<decimal> color = null, System.Nullable<decimal> alpha = null, System.Nullable<decimal> alignment = null, System.Nullable<bool> native = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineStyle" }, width, color, alpha, alignment, native
                }
            );
        }

        public Graphics lineTextureStyle(ILineStyleOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTextureStyle" }, options
                }
            );
        }

        public void finishPoly()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "finishPoly" }
                }
            );
        }

        public Graphics moveTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public Graphics lineTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public Graphics quadraticCurveTo(decimal cpX, decimal cpY, decimal toX, decimal toY)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quadraticCurveTo" }, cpX, cpY, toX, toY
                }
            );
        }

        public Graphics bezierCurveTo(decimal cpX, decimal cpY, decimal cpX2, decimal cpY2, decimal toX, decimal toY)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bezierCurveTo" }, cpX, cpY, cpX2, cpY2, toX, toY
                }
            );
        }

        public Graphics arcTo(decimal x1, decimal y1, decimal x2, decimal y2, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arcTo" }, x1, y1, x2, y2, radius
                }
            );
        }

        public Graphics arc(decimal cx, decimal cy, decimal radius, decimal startAngle, decimal endAngle, System.Nullable<bool> anticlockwise = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "arc" }, cx, cy, radius, startAngle, endAngle, anticlockwise
                }
            );
        }

        public Graphics beginFill(System.Nullable<decimal> color = null, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginFill" }, color, alpha
                }
            );
        }

        public Graphics beginTextureFill(IFillStyleOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginTextureFill" }, options
                }
            );
        }

        public Graphics endFill()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "endFill" }
                }
            );
        }

        public Graphics drawRect(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawRect" }, x, y, width, height
                }
            );
        }

        public Graphics drawRoundedRect(decimal x, decimal y, decimal width, decimal height, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawRoundedRect" }, x, y, width, height, radius
                }
            );
        }

        public Graphics drawCircle(decimal x, decimal y, decimal radius)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawCircle" }, x, y, radius
                }
            );
        }

        public Graphics drawEllipse(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawEllipse" }, x, y, width, height
                }
            );
        }

        public Graphics drawPolygon(decimal[] path)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawPolygon" }, path
                }
            );
        }

        public Graphics drawShape(Circle shape)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawShape" }, shape
                }
            );
        }

        public Graphics clear()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public bool isFastRect()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFastRect" }
                }
            );
        }

        public bool containsPoint(IPointData point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }

        public Graphics closePath()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "closePath" }
                }
            );
        }

        public Graphics setMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix" }, matrix
                }
            );
        }

        public Graphics beginHole()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginHole" }
                }
            );
        }

        public Graphics endHole()
        {
            return EventHorizonBlazorInterop.FuncClass<Graphics>(
                entity => new Graphics() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "endHole" }
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
