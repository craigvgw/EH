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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CurveTimeline>))]
    public class CurveTimeline : CachedEntityObject, ITimeline
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "CurveTimeline.LINEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "CurveTimeline.LINEAR",
                    value
                );
            }
        }

        
        public static decimal STEPPED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "CurveTimeline.STEPPED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "CurveTimeline.STEPPED",
                    value
                );
            }
        }

        
        public static decimal BEZIER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "CurveTimeline.BEZIER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "CurveTimeline.BEZIER",
                    value
                );
            }
        }

        
        public static decimal BEZIER_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "CurveTimeline.BEZIER_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "CurveTimeline.BEZIER_SIZE",
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

        #endregion
        
        #region Constructor
        public CurveTimeline() : base() { }

        public CurveTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CurveTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "CurveTimeline" },
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

        public decimal getFrameCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrameCount" }
                }
            );
        }

        public void setLinear(decimal frameIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinear" }, frameIndex
                }
            );
        }

        public void setStepped(decimal frameIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStepped" }, frameIndex
                }
            );
        }

        public decimal getCurveType(decimal frameIndex)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCurveType" }, frameIndex
                }
            );
        }

        public void setCurve(decimal frameIndex, decimal cx1, decimal cy1, decimal cx2, decimal cy2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCurve" }, frameIndex, cx1, cy1, cx2, cy2
                }
            );
        }

        public decimal getCurvePercent(decimal frameIndex, decimal percent)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCurvePercent" }, frameIndex, percent
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