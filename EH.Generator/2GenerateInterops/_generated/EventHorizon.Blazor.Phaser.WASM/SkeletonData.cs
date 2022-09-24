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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonData>))]
    public class SkeletonData : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
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

        
        public SlotData[] slots
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<SlotData>(
                    this.___guid,
                    "slots",
                    (entity) =>
                    {
                        return new SlotData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slots",
                    value
                );
            }
        }

        
        public Skin[] skins
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Skin>(
                    this.___guid,
                    "skins",
                    (entity) =>
                    {
                        return new Skin() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skins",
                    value
                );
            }
        }

        private Skin __defaultSkin;
        public Skin defaultSkin
        {
            get
            {
            if(__defaultSkin == null)
            {
                __defaultSkin = EventHorizonBlazorInterop.GetClass<Skin>(
                    this.___guid,
                    "defaultSkin",
                    (entity) =>
                    {
                        return new Skin() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultSkin;
            }
            set
            {
__defaultSkin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultSkin",
                    value
                );
            }
        }

        
        public CachedEntity[] events
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "events"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "events",
                    value
                );
            }
        }

        
        public string[] animations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "animations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public IkConstraintData[] ikConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IkConstraintData>(
                    this.___guid,
                    "ikConstraints",
                    (entity) =>
                    {
                        return new IkConstraintData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ikConstraints",
                    value
                );
            }
        }

        
        public TransformConstraintData[] transformConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TransformConstraintData>(
                    this.___guid,
                    "transformConstraints",
                    (entity) =>
                    {
                        return new TransformConstraintData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformConstraints",
                    value
                );
            }
        }

        
        public PathConstraintData[] pathConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PathConstraintData>(
                    this.___guid,
                    "pathConstraints",
                    (entity) =>
                    {
                        return new PathConstraintData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pathConstraints",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public string version
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "version"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "version",
                    value
                );
            }
        }

        
        public string hash
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hash"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hash",
                    value
                );
            }
        }

        
        public decimal fps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fps",
                    value
                );
            }
        }

        
        public string imagesPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "imagesPath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imagesPath",
                    value
                );
            }
        }

        
        public string audioPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "audioPath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audioPath",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SkeletonData() : base() { }

        public SkeletonData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public BoneData findBone(string boneName)
        {
            return EventHorizonBlazorInterop.FuncClass<BoneData>(
                entity => new BoneData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findBone" }, boneName
                }
            );
        }

        public decimal findBoneIndex(string boneName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "findBoneIndex" }, boneName
                }
            );
        }

        public SlotData findSlot(string slotName)
        {
            return EventHorizonBlazorInterop.FuncClass<SlotData>(
                entity => new SlotData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findSlot" }, slotName
                }
            );
        }

        public decimal findSlotIndex(string slotName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "findSlotIndex" }, slotName
                }
            );
        }

        public Skin findSkin(string skinName)
        {
            return EventHorizonBlazorInterop.FuncClass<Skin>(
                entity => new Skin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findSkin" }, skinName
                }
            );
        }

        public CachedEntity findEvent(string eventDataName)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "findEvent" }, eventDataName
                }
            );
        }

        public string findAnimation(string animationName)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "findAnimation" }, animationName
                }
            );
        }

        public IkConstraintData findIkConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<IkConstraintData>(
                entity => new IkConstraintData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findIkConstraint" }, constraintName
                }
            );
        }

        public TransformConstraintData findTransformConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformConstraintData>(
                entity => new TransformConstraintData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findTransformConstraint" }, constraintName
                }
            );
        }

        public PathConstraintData findPathConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<PathConstraintData>(
                entity => new PathConstraintData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findPathConstraint" }, constraintName
                }
            );
        }

        public decimal findPathConstraintIndex(string pathConstraintName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "findPathConstraintIndex" }, pathConstraintName
                }
            );
        }
        #endregion
    }
}