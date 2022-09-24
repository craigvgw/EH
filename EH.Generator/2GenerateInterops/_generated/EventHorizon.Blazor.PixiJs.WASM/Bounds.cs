/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Bounds>))]
public class Bounds : CachedEntityObject
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
        
        public decimal minX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minX",
                    value
                );
            }
        }

        
        public decimal minY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minY",
                    value
                );
            }
        }

        
        public decimal maxX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxX",
                    value
                );
            }
        }

        
        public decimal maxY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxY",
                    value
                );
            }
        }

        private Rectangle __rect;
        public Rectangle rect
        {
            get
            {
            if(__rect == null)
            {
                __rect = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "rect",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __rect;
            }
            set
            {
__rect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rect",
                    value
                );
            }
        }

        
        public decimal updateID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateID",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Bounds() : base() { }

        public Bounds(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public bool isEmpty()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isEmpty" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public Rectangle getRectangle(Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRectangle" }, rect
                }
            );
        }

        public void addPoint(IPointData point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addPoint" }, point
                }
            );
        }

        public void addPointMatrix(Matrix matrix, IPointData point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addPointMatrix" }, matrix, point
                }
            );
        }

        public void addQuad(decimal[] vertices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addQuad" }, vertices
                }
            );
        }

        public void addFrame(Transform transform, decimal x0, decimal y0, decimal x1, decimal y1)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addFrame" }, transform, x0, y0, x1, y1
                }
            );
        }

        public void addFrameMatrix(Matrix matrix, decimal x0, decimal y0, decimal x1, decimal y1)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addFrameMatrix" }, matrix, x0, y0, x1, y1
                }
            );
        }

        public void addVertexData(decimal[] vertexData, decimal beginOffset, decimal endOffset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addVertexData" }, vertexData, beginOffset, endOffset
                }
            );
        }

        public void addVertices(Transform transform, decimal[] vertices, decimal beginOffset, decimal endOffset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addVertices" }, transform, vertices, beginOffset, endOffset
                }
            );
        }

        public void addVerticesMatrix(Matrix matrix, decimal[] vertices, decimal beginOffset, decimal endOffset, System.Nullable<decimal> padX = null, System.Nullable<decimal> padY = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addVerticesMatrix" }, matrix, vertices, beginOffset, endOffset, padX, padY
                }
            );
        }

        public void addBounds(Bounds bounds)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addBounds" }, bounds
                }
            );
        }

        public void addBoundsMask(Bounds bounds, Bounds mask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addBoundsMask" }, bounds, mask
                }
            );
        }

        public void addBoundsMatrix(Bounds bounds, Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addBoundsMatrix" }, bounds, matrix
                }
            );
        }

        public void addBoundsArea(Bounds bounds, Rectangle area)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addBoundsArea" }, bounds, area
                }
            );
        }

        public void pad(System.Nullable<decimal> paddingX = null, System.Nullable<decimal> paddingY = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pad" }, paddingX, paddingY
                }
            );
        }

        public void addFramePad(decimal x0, decimal y0, decimal x1, decimal y1, decimal padX, decimal padY)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addFramePad" }, x0, y0, x1, y1, padX, padY
                }
            );
        }
    #endregion
}
