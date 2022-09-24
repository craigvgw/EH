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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RotateTimeline>))]
    public class RotateTimeline : CurveTimeline
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
                    "RotateTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "RotateTimeline.ENTRIES",
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
                    "RotateTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "RotateTimeline.PREV_TIME",
                    value
                );
            }
        }

        
        public static decimal PREV_ROTATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "RotateTimeline.PREV_ROTATION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "RotateTimeline.PREV_ROTATION",
                    value
                );
            }
        }

        
        public static decimal ROTATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "RotateTimeline.ROTATION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "RotateTimeline.ROTATION",
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
        
        public decimal boneIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "boneIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneIndex",
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
        public RotateTimeline() : base() { }

        public RotateTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RotateTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "RotateTimeline" },
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

        public void setFrame(decimal frameIndex, decimal time, decimal degrees)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, degrees
                }
            );
        }

        public void apply(Skeleton skeleton, decimal lastTime, decimal time, string[] events, decimal alpha, int blend, int direction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }, skeleton, lastTime, time, events, alpha, blend, direction
                }
            );
        }
        #endregion
    }
}