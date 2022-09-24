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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonBinary>))]
    public class SkeletonBinary : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal[] AttachmentTypeValues
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    "spine",
                    "SkeletonBinary.AttachmentTypeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.AttachmentTypeValues",
                    value
                );
            }
        }

        
        public static int[] TransformModeValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    "spine",
                    "SkeletonBinary.TransformModeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.TransformModeValues",
                    value
                );
            }
        }

        
        public static int[] PositionModeValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    "spine",
                    "SkeletonBinary.PositionModeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.PositionModeValues",
                    value
                );
            }
        }

        
        public static int[] SpacingModeValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    "spine",
                    "SkeletonBinary.SpacingModeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.SpacingModeValues",
                    value
                );
            }
        }

        
        public static int[] RotateModeValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    "spine",
                    "SkeletonBinary.RotateModeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.RotateModeValues",
                    value
                );
            }
        }

        
        public static int[] BlendModeValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    "spine",
                    "SkeletonBinary.BlendModeValues"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.BlendModeValues",
                    value
                );
            }
        }

        
        public static decimal BONE_ROTATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.BONE_ROTATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.BONE_ROTATE",
                    value
                );
            }
        }

        
        public static decimal BONE_TRANSLATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.BONE_TRANSLATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.BONE_TRANSLATE",
                    value
                );
            }
        }

        
        public static decimal BONE_SCALE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.BONE_SCALE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.BONE_SCALE",
                    value
                );
            }
        }

        
        public static decimal BONE_SHEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.BONE_SHEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.BONE_SHEAR",
                    value
                );
            }
        }

        
        public static decimal SLOT_ATTACHMENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.SLOT_ATTACHMENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.SLOT_ATTACHMENT",
                    value
                );
            }
        }

        
        public static decimal SLOT_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.SLOT_COLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.SLOT_COLOR",
                    value
                );
            }
        }

        
        public static decimal SLOT_TWO_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.SLOT_TWO_COLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.SLOT_TWO_COLOR",
                    value
                );
            }
        }

        
        public static decimal PATH_POSITION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.PATH_POSITION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.PATH_POSITION",
                    value
                );
            }
        }

        
        public static decimal PATH_SPACING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.PATH_SPACING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.PATH_SPACING",
                    value
                );
            }
        }

        
        public static decimal PATH_MIX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.PATH_MIX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.PATH_MIX",
                    value
                );
            }
        }

        
        public static decimal CURVE_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.CURVE_LINEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.CURVE_LINEAR",
                    value
                );
            }
        }

        
        public static decimal CURVE_STEPPED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.CURVE_STEPPED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.CURVE_STEPPED",
                    value
                );
            }
        }

        
        public static decimal CURVE_BEZIER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "SkeletonBinary.CURVE_BEZIER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SkeletonBinary.CURVE_BEZIER",
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
        private AttachmentLoaderCachedEntity __attachmentLoader;
        public AttachmentLoaderCachedEntity attachmentLoader
        {
            get
            {
            if(__attachmentLoader == null)
            {
                __attachmentLoader = EventHorizonBlazorInterop.GetClass<AttachmentLoaderCachedEntity>(
                    this.___guid,
                    "attachmentLoader",
                    (entity) =>
                    {
                        return new AttachmentLoaderCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __attachmentLoader;
            }
            set
            {
__attachmentLoader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachmentLoader",
                    value
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkeletonBinary() : base() { }

        public SkeletonBinary(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SkeletonBinary(
            AttachmentLoader attachmentLoader
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SkeletonBinary" },
                attachmentLoader
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public SkeletonData readSkeletonData(decimal[] binary)
        {
            return EventHorizonBlazorInterop.FuncClass<SkeletonData>(
                entity => new SkeletonData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "readSkeletonData" }, binary
                }
            );
        }

        public void setCurve(CurveTimeline timeline, decimal frameIndex, decimal cx1, decimal cy1, decimal cx2, decimal cy2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCurve" }, timeline, frameIndex, cx1, cy1, cx2, cy2
                }
            );
        }
        #endregion
    }
}