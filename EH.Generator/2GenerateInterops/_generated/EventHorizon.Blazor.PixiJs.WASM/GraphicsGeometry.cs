/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GraphicsGeometry>))]
public class GraphicsGeometry : BatchGeometry
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static decimal BATCHABLE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "GraphicsGeometry",
                    "BATCHABLE_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "GraphicsGeometry",
                    "BATCHABLE_SIZE",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private Bounds __bounds;
        public Bounds bounds
        {
            get
            {
            if(__bounds == null)
            {
                __bounds = EventHorizonBlazorInterop.GetClass<Bounds>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new Bounds() { ___guid = entity.___guid };
                    }
                );
            }
            return __bounds;
            }
        }
    #endregion

    #region Properties
        
        public decimal closePointEps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "closePointEps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "closePointEps",
                    value
                );
            }
        }

        
        public decimal boundsPadding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "boundsPadding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundsPadding",
                    value
                );
            }
        }

        
        public decimal[] uvsFloat32
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvsFloat32"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvsFloat32",
                    value
                );
            }
        }

        private Uint16Array __indicesUint16;
        public Uint16Array indicesUint16
        {
            get
            {
            if(__indicesUint16 == null)
            {
                __indicesUint16 = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "indicesUint16",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __indicesUint16;
            }
            set
            {
__indicesUint16 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indicesUint16",
                    value
                );
            }
        }

        
        public bool batchable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "batchable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batchable",
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

        
        public decimal[] colors
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "colors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colors",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        
        public decimal[] indices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "indices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }

        
        public decimal[] textureIds
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "textureIds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureIds",
                    value
                );
            }
        }

        
        public GraphicsData[] graphicsData
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<GraphicsData>(
                    this.___guid,
                    "graphicsData",
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
                    "graphicsData",
                    value
                );
            }
        }

        
        public BatchDrawCall[] drawCalls
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BatchDrawCall>(
                    this.___guid,
                    "drawCalls",
                    (entity) =>
                    {
                        return new BatchDrawCall() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawCalls",
                    value
                );
            }
        }

        
        public decimal batchDirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "batchDirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batchDirty",
                    value
                );
            }
        }

        
        public BatchPart[] batches
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BatchPart>(
                    this.___guid,
                    "batches",
                    (entity) =>
                    {
                        return new BatchPart() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batches",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public GraphicsGeometry() : base() { }

        public GraphicsGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public GraphicsGeometry clear()
        {
            return EventHorizonBlazorInterop.FuncClass<GraphicsGeometry>(
                entity => new GraphicsGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public GraphicsGeometry drawShape(Circle shape, FillStyle fillStyle = null, LineStyle lineStyle = null, Matrix matrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GraphicsGeometry>(
                entity => new GraphicsGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawShape" }, shape, fillStyle, lineStyle, matrix
                }
            );
        }

        public GraphicsGeometry drawHole(Circle shape, Matrix matrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GraphicsGeometry>(
                entity => new GraphicsGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "drawHole" }, shape, matrix
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

        public bool containsPoint(IPointData point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }

        public void updateBatches()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateBatches" }
                }
            );
        }
    #endregion
}
