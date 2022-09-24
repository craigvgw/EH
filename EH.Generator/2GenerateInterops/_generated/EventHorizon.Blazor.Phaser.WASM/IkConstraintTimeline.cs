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

    
    
    [JsonConverter(typeof(CachedEntityConverter<IkConstraintTimeline>))]
    public class IkConstraintTimeline : CurveTimeline
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
                    "IkConstraintTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.ENTRIES",
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
                    "IkConstraintTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_TIME",
                    value
                );
            }
        }

        
        public static decimal PREV_MIX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.PREV_MIX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_MIX",
                    value
                );
            }
        }

        
        public static decimal PREV_SOFTNESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.PREV_SOFTNESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_SOFTNESS",
                    value
                );
            }
        }

        
        public static decimal PREV_BEND_DIRECTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.PREV_BEND_DIRECTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_BEND_DIRECTION",
                    value
                );
            }
        }

        
        public static decimal PREV_COMPRESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.PREV_COMPRESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_COMPRESS",
                    value
                );
            }
        }

        
        public static decimal PREV_STRETCH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.PREV_STRETCH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.PREV_STRETCH",
                    value
                );
            }
        }

        
        public static decimal MIX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.MIX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.MIX",
                    value
                );
            }
        }

        
        public static decimal SOFTNESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.SOFTNESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.SOFTNESS",
                    value
                );
            }
        }

        
        public static decimal BEND_DIRECTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.BEND_DIRECTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.BEND_DIRECTION",
                    value
                );
            }
        }

        
        public static decimal COMPRESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.COMPRESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.COMPRESS",
                    value
                );
            }
        }

        
        public static decimal STRETCH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "IkConstraintTimeline.STRETCH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "IkConstraintTimeline.STRETCH",
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
        
        public decimal ikConstraintIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ikConstraintIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ikConstraintIndex",
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
        public IkConstraintTimeline() : base() { }

        public IkConstraintTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public IkConstraintTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "IkConstraintTimeline" },
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

        public void setFrame(decimal frameIndex, decimal time, decimal mix, decimal softness, decimal bendDirection, bool compress, bool stretch)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, mix, softness, bendDirection, compress, stretch
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