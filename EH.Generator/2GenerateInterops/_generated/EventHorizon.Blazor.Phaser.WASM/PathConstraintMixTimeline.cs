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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PathConstraintMixTimeline>))]
    public class PathConstraintMixTimeline : CurveTimeline
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
                    "PathConstraintMixTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.ENTRIES",
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
                    "PathConstraintMixTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.PREV_TIME",
                    value
                );
            }
        }

        
        public static decimal PREV_ROTATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintMixTimeline.PREV_ROTATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.PREV_ROTATE",
                    value
                );
            }
        }

        
        public static decimal PREV_TRANSLATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintMixTimeline.PREV_TRANSLATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.PREV_TRANSLATE",
                    value
                );
            }
        }

        
        public static decimal ROTATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintMixTimeline.ROTATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.ROTATE",
                    value
                );
            }
        }

        
        public static decimal TRANSLATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "PathConstraintMixTimeline.TRANSLATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "PathConstraintMixTimeline.TRANSLATE",
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
        public PathConstraintMixTimeline() : base() { }

        public PathConstraintMixTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PathConstraintMixTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "PathConstraintMixTimeline" },
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

        public void setFrame(decimal frameIndex, decimal time, decimal rotateMix, decimal translateMix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, rotateMix, translateMix
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