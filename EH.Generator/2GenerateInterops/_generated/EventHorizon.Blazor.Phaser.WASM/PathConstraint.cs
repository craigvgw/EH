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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PathConstraint>))]
    public class PathConstraint : CachedEntityObject, Updatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraint.NONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraint.NONE",
                    value
                );
            }
        }

        
        public static decimal BEFORE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraint.BEFORE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraint.BEFORE",
                    value
                );
            }
        }

        
        public static decimal AFTER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraint.AFTER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraint.AFTER",
                    value
                );
            }
        }

        
        public static decimal epsilon
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraint.epsilon"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraint.epsilon",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private PathConstraintData __data;
        public PathConstraintData data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<PathConstraintData>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new PathConstraintData() { ___guid = entity.___guid };
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

        
        public Bone[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bones",
                    value
                );
            }
        }

        private Slot __target;
        public Slot target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<Slot>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new Slot() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public decimal position
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "position"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        
        public decimal spacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spacing",
                    value
                );
            }
        }

        
        public decimal rotateMix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotateMix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotateMix",
                    value
                );
            }
        }

        
        public decimal translateMix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "translateMix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "translateMix",
                    value
                );
            }
        }

        
        public decimal[] spaces
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "spaces"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spaces",
                    value
                );
            }
        }

        
        public decimal[] positions
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "positions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positions",
                    value
                );
            }
        }

        
        public decimal[] world
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "world"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "world",
                    value
                );
            }
        }

        
        public decimal[] curves
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "curves"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "curves",
                    value
                );
            }
        }

        
        public decimal[] lengths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "lengths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lengths",
                    value
                );
            }
        }

        
        public decimal[] segments
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "segments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "segments",
                    value
                );
            }
        }

        
        public bool active
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "active"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "active",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PathConstraint() : base() { }

        public PathConstraint(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PathConstraint(
            PathConstraintData data, Skeleton skeleton
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "PathConstraint" },
                data, skeleton
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isActive()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActive" }
                }
            );
        }

        public void apply()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public decimal[] computeWorldPositions(PathAttachment path, decimal spacesCount, bool tangents, bool percentPosition, bool percentSpacing)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "computeWorldPositions" }, path, spacesCount, tangents, percentPosition, percentSpacing
                }
            );
        }

        public void addBeforePosition(decimal p, decimal[] temp, decimal i, decimal[] out, decimal o)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addBeforePosition" }, p, temp, i, out, o
                }
            );
        }

        public void addAfterPosition(decimal p, decimal[] temp, decimal i, decimal[] out, decimal o)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addAfterPosition" }, p, temp, i, out, o
                }
            );
        }

        public void addCurvePosition(decimal p, decimal x1, decimal y1, decimal cx1, decimal cy1, decimal cx2, decimal cy2, decimal x2, decimal y2, decimal[] out, decimal o, bool tangents)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCurvePosition" }, p, x1, y1, cx1, cy1, cx2, cy2, x2, y2, out, o, tangents
                }
            );
        }
        #endregion
    }
}