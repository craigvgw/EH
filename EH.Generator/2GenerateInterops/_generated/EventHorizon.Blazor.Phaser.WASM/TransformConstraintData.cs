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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformConstraintData>))]
    public class TransformConstraintData : ConstraintData
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
        
        public BoneData[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BoneData>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new BoneData() { ___guid = entity.___guid };
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

        private BoneData __target;
        public BoneData target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<BoneData>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new BoneData() { ___guid = entity.___guid };
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

        
        public decimal scaleMix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleMix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMix",
                    value
                );
            }
        }

        
        public decimal shearMix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shearMix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shearMix",
                    value
                );
            }
        }

        
        public decimal offsetRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetRotation",
                    value
                );
            }
        }

        
        public decimal offsetX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetX",
                    value
                );
            }
        }

        
        public decimal offsetY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetY",
                    value
                );
            }
        }

        
        public decimal offsetScaleX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetScaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetScaleX",
                    value
                );
            }
        }

        
        public decimal offsetScaleY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetScaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetScaleY",
                    value
                );
            }
        }

        
        public decimal offsetShearY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offsetShearY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetShearY",
                    value
                );
            }
        }

        
        public bool relative
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "relative"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "relative",
                    value
                );
            }
        }

        
        public bool local
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "local"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "local",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TransformConstraintData() : base() { }

        public TransformConstraintData(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TransformConstraintData(
            string name
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "TransformConstraintData" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}