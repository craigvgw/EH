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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformConstraintTimeline>))]
    public class TransformConstraintTimeline : CurveTimeline
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
                    "TransformConstraintTimeline.ENTRIES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.ENTRIES",
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
                    "TransformConstraintTimeline.PREV_TIME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.PREV_TIME",
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
                    "TransformConstraintTimeline.PREV_ROTATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.PREV_ROTATE",
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
                    "TransformConstraintTimeline.PREV_TRANSLATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.PREV_TRANSLATE",
                    value
                );
            }
        }

        
        public static decimal PREV_SCALE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "TransformConstraintTimeline.PREV_SCALE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.PREV_SCALE",
                    value
                );
            }
        }

        
        public static decimal PREV_SHEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "TransformConstraintTimeline.PREV_SHEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.PREV_SHEAR",
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
                    "TransformConstraintTimeline.ROTATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.ROTATE",
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
                    "TransformConstraintTimeline.TRANSLATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.TRANSLATE",
                    value
                );
            }
        }

        
        public static decimal SCALE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "TransformConstraintTimeline.SCALE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.SCALE",
                    value
                );
            }
        }

        
        public static decimal SHEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "TransformConstraintTimeline.SHEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "TransformConstraintTimeline.SHEAR",
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
        
        public decimal transformConstraintIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transformConstraintIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformConstraintIndex",
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
        public TransformConstraintTimeline() : base() { }

        public TransformConstraintTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TransformConstraintTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "TransformConstraintTimeline" },
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

        public void setFrame(decimal frameIndex, decimal time, decimal rotateMix, decimal translateMix, decimal scaleMix, decimal shearMix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, rotateMix, translateMix, scaleMix, shearMix
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