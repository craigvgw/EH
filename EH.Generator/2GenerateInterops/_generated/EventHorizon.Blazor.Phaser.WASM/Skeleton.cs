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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Skeleton>))]
    public class Skeleton : CachedEntityObject
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
        private SkeletonData __data;
        public SkeletonData data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<SkeletonData>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new SkeletonData() { ___guid = entity.___guid };
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

        
        public Slot[] slots
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Slot>(
                    this.___guid,
                    "slots",
                    (entity) =>
                    {
                        return new Slot() { ___guid = entity.___guid };
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

        
        public Slot[] drawOrder
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Slot>(
                    this.___guid,
                    "drawOrder",
                    (entity) =>
                    {
                        return new Slot() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawOrder",
                    value
                );
            }
        }

        
        public IkConstraint[] ikConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IkConstraint>(
                    this.___guid,
                    "ikConstraints",
                    (entity) =>
                    {
                        return new IkConstraint() { ___guid = entity.___guid };
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

        
        public TransformConstraint[] transformConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TransformConstraint>(
                    this.___guid,
                    "transformConstraints",
                    (entity) =>
                    {
                        return new TransformConstraint() { ___guid = entity.___guid };
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

        
        public PathConstraint[] pathConstraints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PathConstraint>(
                    this.___guid,
                    "pathConstraints",
                    (entity) =>
                    {
                        return new PathConstraint() { ___guid = entity.___guid };
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

        
        public UpdatableCachedEntity[] updateCacheReset
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<UpdatableCachedEntity>(
                    this.___guid,
                    "updateCacheReset",
                    (entity) =>
                    {
                        return new UpdatableCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateCacheReset",
                    value
                );
            }
        }

        private Skin __skin;
        public Skin skin
        {
            get
            {
            if(__skin == null)
            {
                __skin = EventHorizonBlazorInterop.GetClass<Skin>(
                    this.___guid,
                    "skin",
                    (entity) =>
                    {
                        return new Skin() { ___guid = entity.___guid };
                    }
                );
            }
            return __skin;
            }
            set
            {
__skin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skin",
                    value
                );
            }
        }

        private Color __color;
        public Color color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal time
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "time"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "time",
                    value
                );
            }
        }

        
        public decimal scaleX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        
        public decimal scaleY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleY",
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
        #endregion
        
        #region Constructor
        public Skeleton() : base() { }

        public Skeleton(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Skeleton(
            SkeletonData data
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "Skeleton" },
                data
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCache" }
                }
            );
        }

        public void sortIkConstraint(IkConstraint constraint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortIkConstraint" }, constraint
                }
            );
        }

        public void sortPathConstraint(PathConstraint constraint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortPathConstraint" }, constraint
                }
            );
        }

        public void sortTransformConstraint(TransformConstraint constraint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortTransformConstraint" }, constraint
                }
            );
        }

        public void sortPathConstraintAttachment(Skin skin, decimal slotIndex, Bone slotBone)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortPathConstraintAttachment" }, skin, slotIndex, slotBone
                }
            );
        }

        public void sortPathConstraintAttachmentWith(Attachment attachment, Bone slotBone)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortPathConstraintAttachmentWith" }, attachment, slotBone
                }
            );
        }

        public void sortBone(Bone bone)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortBone" }, bone
                }
            );
        }

        public void sortReset(Bone[] bones)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortReset" }, bones
                }
            );
        }

        public void updateWorldTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateWorldTransform" }
                }
            );
        }

        public void setToSetupPose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToSetupPose" }
                }
            );
        }

        public void setBonesToSetupPose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBonesToSetupPose" }
                }
            );
        }

        public void setSlotsToSetupPose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSlotsToSetupPose" }
                }
            );
        }

        public Bone getRootBone()
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRootBone" }
                }
            );
        }

        public Bone findBone(string boneName)
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
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

        public Slot findSlot(string slotName)
        {
            return EventHorizonBlazorInterop.FuncClass<Slot>(
                entity => new Slot() { ___guid = entity.___guid },
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

        public void setSkinByName(string skinName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSkinByName" }, skinName
                }
            );
        }

        public void setSkin(Skin newSkin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSkin" }, newSkin
                }
            );
        }

        public Attachment getAttachmentByName(string slotName, string attachmentName)
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachmentByName" }, slotName, attachmentName
                }
            );
        }

        public Attachment getAttachment(decimal slotIndex, string attachmentName)
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttachment" }, slotIndex, attachmentName
                }
            );
        }

        public void setAttachment(string slotName, string attachmentName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAttachment" }, slotName, attachmentName
                }
            );
        }

        public IkConstraint findIkConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<IkConstraint>(
                entity => new IkConstraint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findIkConstraint" }, constraintName
                }
            );
        }

        public TransformConstraint findTransformConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformConstraint>(
                entity => new TransformConstraint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findTransformConstraint" }, constraintName
                }
            );
        }

        public PathConstraint findPathConstraint(string constraintName)
        {
            return EventHorizonBlazorInterop.FuncClass<PathConstraint>(
                entity => new PathConstraint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findPathConstraint" }, constraintName
                }
            );
        }

        public void getBounds(Vector2 offset, Vector2 size, decimal[] temp = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, offset, size, temp
                }
            );
        }

        public void update(decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, delta
                }
            );
        }
        #endregion
    }
}