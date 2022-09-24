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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ColorTimeline>))]
    public class ColorTimeline : CurveTimeline
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
                    "ColorTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.ENTRIES",
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
                    "ColorTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.PREV_TIME",
                    value
                );
            }
        }

        
        public static decimal PREV_R
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.PREV_R"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.PREV_R",
                    value
                );
            }
        }

        
        public static decimal PREV_G
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.PREV_G"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.PREV_G",
                    value
                );
            }
        }

        
        public static decimal PREV_B
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.PREV_B"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.PREV_B",
                    value
                );
            }
        }

        
        public static decimal PREV_A
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.PREV_A"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.PREV_A",
                    value
                );
            }
        }

        
        public static decimal R
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.R"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.R",
                    value
                );
            }
        }

        
        public static decimal G
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.G"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.G",
                    value
                );
            }
        }

        
        public static decimal B
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.B"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.B",
                    value
                );
            }
        }

        
        public static decimal A
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "ColorTimeline.A"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "ColorTimeline.A",
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
        
        public decimal slotIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "slotIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slotIndex",
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
        public ColorTimeline() : base() { }

        public ColorTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ColorTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "ColorTimeline" },
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

        public void setFrame(decimal frameIndex, decimal time, decimal r, decimal g, decimal b, decimal a)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, r, g, b, a
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