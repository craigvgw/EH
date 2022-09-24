/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonClipping>))]
    public class SkeletonClipping : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void makeClockwise(decimal[] polygon)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "spine", "SkeletonClipping", "makeClockwise" }, polygon
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal[] clippedVertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "clippedVertices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clippedVertices",
                    value
                );
            }
        }

        
        public decimal[] clippedTriangles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "clippedTriangles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clippedTriangles",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkeletonClipping() : base() { }

        public SkeletonClipping(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public decimal clipStart(Slot slot, ClippingAttachment clip)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "clipStart" }, slot, clip
                }
            );
        }

        public void clipEndWithSlot(Slot slot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clipEndWithSlot" }, slot
                }
            );
        }

        public void clipEnd()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clipEnd" }
                }
            );
        }

        public bool isClipping()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isClipping" }
                }
            );
        }

        public void clipTriangles(decimal[] vertices, decimal verticesLength, decimal[] triangles, decimal trianglesLength, decimal[] uvs, Color light, Color dark, bool twoColor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clipTriangles" }, vertices, verticesLength, triangles, trianglesLength, uvs, light, dark, twoColor
                }
            );
        }

        public bool clip(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal[] clippingArea, decimal[] output)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "clip" }, x1, y1, x2, y2, x3, y3, clippingArea, output
                }
            );
        }
        #endregion
    }
}