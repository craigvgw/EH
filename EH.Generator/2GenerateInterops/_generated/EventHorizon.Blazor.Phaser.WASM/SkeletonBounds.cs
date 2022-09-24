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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonBounds>))]
    public class SkeletonBounds : CachedEntityObject
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

        
        public BoundingBoxAttachment[] boundingBoxes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BoundingBoxAttachment>(
                    this.___guid,
                    "boundingBoxes",
                    (entity) =>
                    {
                        return new BoundingBoxAttachment() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBoxes",
                    value
                );
            }
        }

// polygons is not supported by the platform yet
        #endregion
        
        #region Constructor
        public SkeletonBounds() : base() { }

        public SkeletonBounds(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void update(Skeleton skeleton, bool updateAabb)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, skeleton, updateAabb
                }
            );
        }

        public void aabbCompute()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "aabbCompute" }
                }
            );
        }

        public bool aabbContainsPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "aabbContainsPoint" }, x, y
                }
            );
        }

        public bool aabbIntersectsSegment(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "aabbIntersectsSegment" }, x1, y1, x2, y2
                }
            );
        }

        public bool aabbIntersectsSkeleton(SkeletonBounds bounds)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "aabbIntersectsSkeleton" }, bounds
                }
            );
        }

        public BoundingBoxAttachment containsPoint(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBoxAttachment>(
                entity => new BoundingBoxAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, x, y
                }
            );
        }

        public bool containsPointPolygon(decimal[] polygon, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPointPolygon" }, polygon, x, y
                }
            );
        }

        public BoundingBoxAttachment intersectsSegment(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBoxAttachment>(
                entity => new BoundingBoxAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsSegment" }, x1, y1, x2, y2
                }
            );
        }

        public bool intersectsSegmentPolygon(decimal[] polygon, decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSegmentPolygon" }, polygon, x1, y1, x2, y2
                }
            );
        }

        public decimal[] getPolygon(BoundingBoxAttachment boundingBox)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPolygon" }, boundingBox
                }
            );
        }

        public decimal getWidth()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getWidth" }
                }
            );
        }

        public decimal getHeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHeight" }
                }
            );
        }
        #endregion
    }
}