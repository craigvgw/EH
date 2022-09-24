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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PathConstraintPositionTimeline>))]
    public class PathConstraintPositionTimeline : CurveTimeline
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal ENTRIES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintPositionTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintPositionTimeline.ENTRIES",
                    value
                );
            }
        }

        
        public static decimal PREV_TIME
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintPositionTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintPositionTimeline.PREV_TIME",
                    value
                );
            }
        }

        
        public static decimal PREV_VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintPositionTimeline.PREV_VALUE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintPositionTimeline.PREV_VALUE",
                    value
                );
            }
        }

        
        public static decimal VALUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintPositionTimeline.VALUE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintPositionTimeline.VALUE",
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
        
        public decimal pathConstraintIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pathConstraintIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pathConstraintIndex",
                    value
                );
            }
        }

        
        public decimal[] frames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "frames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frames",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PathConstraintPositionTimeline() : base() { }

        public PathConstraintPositionTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PathConstraintPositionTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "PathConstraintPositionTimeline" },
                frameCount
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getPropertyId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPropertyId" }
                }
            );
        }

        public void setFrame(decimal frameIndex, decimal time, decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, value
                }
            );
        }

        public void apply(Skeleton skeleton, decimal lastTime, decimal time, string[] firedEvents, decimal alpha, int blend, int direction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }, skeleton, lastTime, time, firedEvents, alpha, blend, direction
                }
            );
        }
        #endregion
    }
}