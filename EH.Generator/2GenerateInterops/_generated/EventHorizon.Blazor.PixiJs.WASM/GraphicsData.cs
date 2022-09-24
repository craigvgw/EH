/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GraphicsData>))]
public class GraphicsData : CachedEntityObject
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
        
        public Circle shape
        {
            get
            {
            return EventHorizonBlazorInterop.Get<Circle>(
                    this.___guid,
                    "shape"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shape",
                    value
                );
            }
        }

        private LineStyle __lineStyle;
        public LineStyle lineStyle
        {
            get
            {
            if(__lineStyle == null)
            {
                __lineStyle = EventHorizonBlazorInterop.GetClass<LineStyle>(
                    this.___guid,
                    "lineStyle",
                    (entity) =>
                    {
                        return new LineStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __lineStyle;
            }
            set
            {
__lineStyle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineStyle",
                    value
                );
            }
        }

        private FillStyle __fillStyle;
        public FillStyle fillStyle
        {
            get
            {
            if(__fillStyle == null)
            {
                __fillStyle = EventHorizonBlazorInterop.GetClass<FillStyle>(
                    this.___guid,
                    "fillStyle",
                    (entity) =>
                    {
                        return new FillStyle() { ___guid = entity.___guid };
                    }
                );
            }
            return __fillStyle;
            }
            set
            {
__fillStyle = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillStyle",
                    value
                );
            }
        }

        private Matrix __matrix;
        public Matrix matrix
        {
            get
            {
            if(__matrix == null)
            {
                __matrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "matrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrix;
            }
            set
            {
__matrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal[] points
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "points"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "points",
                    value
                );
            }
        }

        
        public GraphicsData[] holes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GraphicsData>(
                    this.___guid,
                    "holes",
                    (entity) =>
                    {
                        return new GraphicsData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "holes",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public GraphicsData() : base() { }

        public GraphicsData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GraphicsData(
            Circle shape, FillStyle fillStyle = null, LineStyle lineStyle = null, Matrix matrix = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GraphicsData" },
                shape, fillStyle, lineStyle, matrix
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public GraphicsData clone()
        {
            return EventHorizonBlazorInterop.FuncClass<GraphicsData>(
                entity => new GraphicsData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
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
