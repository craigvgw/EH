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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformConstraint>))]
    public class TransformConstraint : CachedEntityObject, Updatable
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
        private TransformConstraintData __data;
        public TransformConstraintData data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<TransformConstraintData>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new TransformConstraintData() { ___guid = entity.___guid };
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

        private Bone __target;
        public Bone target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<Bone>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
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

        private Vector2 __temp;
        public Vector2 temp
        {
            get
            {
            if(__temp == null)
            {
                __temp = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "temp",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __temp;
            }
            set
            {
__temp = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "temp",
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
        public TransformConstraint() : base() { }

        public TransformConstraint(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TransformConstraint(
            TransformConstraintData data, Skeleton skeleton
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "TransformConstraint" },
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

        public void applyAbsoluteWorld()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAbsoluteWorld" }
                }
            );
        }

        public void applyRelativeWorld()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyRelativeWorld" }
                }
            );
        }

        public void applyAbsoluteLocal()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAbsoluteLocal" }
                }
            );
        }

        public void applyRelativeLocal()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyRelativeLocal" }
                }
            );
        }
        #endregion
    }
}