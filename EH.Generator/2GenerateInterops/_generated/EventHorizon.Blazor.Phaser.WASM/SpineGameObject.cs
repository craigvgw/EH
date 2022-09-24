/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SpineGameObject>))]
public class SpineGameObject : GameObject
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
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
            }
        }

        
        public decimal blue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blue",
                    value
                );
            }
        }

        
        public CachedEntity bounds
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "bounds",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bounds",
                    value
                );
            }
        }

        
        public decimal displayOriginX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginX",
                    value
                );
            }
        }

        
        public decimal displayOriginY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginY",
                    value
                );
            }
        }

        
        public bool drawDebug
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawDebug"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawDebug",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public decimal displayWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayWidth",
                    value
                );
            }
        }

        
        public decimal displayHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayHeight",
                    value
                );
            }
        }

        
        public bool flipX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipX",
                    value
                );
            }
        }

        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }

        
        public decimal green
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "green"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "green",
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

        private SpinePlugin __plugin;
        public SpinePlugin plugin
        {
            get
            {
            if(__plugin == null)
            {
                __plugin = EventHorizonBlazorInterop.GetClass<SpinePlugin>(
                    this.___guid,
                    "plugin",
                    (entity) =>
                    {
                        return new SpinePlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugin;
            }
            set
            {
__plugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
            }
        }

        
        public bool preMultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preMultipliedAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preMultipliedAlpha",
                    value
                );
            }
        }

        
        public decimal red
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "red"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "red",
                    value
                );
            }
        }

        private Bone __root;
        public Bone root
        {
            get
            {
            if(__root == null)
            {
                __root = EventHorizonBlazorInterop.GetClass<Bone>(
                    this.___guid,
                    "root",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            return __root;
            }
            set
            {
__root = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "root",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
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

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
                    value
                );
            }
        }

        private Skeleton __skeleton;
        public Skeleton skeleton
        {
            get
            {
            if(__skeleton == null)
            {
                __skeleton = EventHorizonBlazorInterop.GetClass<Skeleton>(
                    this.___guid,
                    "skeleton",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeleton;
            }
            set
            {
__skeleton = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeleton",
                    value
                );
            }
        }

        private SkeletonData __skeletonData;
        public SkeletonData skeletonData
        {
            get
            {
            if(__skeletonData == null)
            {
                __skeletonData = EventHorizonBlazorInterop.GetClass<SkeletonData>(
                    this.___guid,
                    "skeletonData",
                    (entity) =>
                    {
                        return new SkeletonData() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeletonData;
            }
            set
            {
__skeletonData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonData",
                    value
                );
            }
        }

        private AnimationState __state;
        public AnimationState state
        {
            get
            {
            if(__state == null)
            {
                __state = EventHorizonBlazorInterop.GetClass<AnimationState>(
                    this.___guid,
                    "state",
                    (entity) =>
                    {
                        return new AnimationState() { ___guid = entity.___guid };
                    }
                );
            }
            return __state;
            }
            set
            {
__state = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        private AnimationStateData __stateData;
        public AnimationStateData stateData
        {
            get
            {
            if(__stateData == null)
            {
                __stateData = EventHorizonBlazorInterop.GetClass<AnimationStateData>(
                    this.___guid,
                    "stateData",
                    (entity) =>
                    {
                        return new AnimationStateData() { ___guid = entity.___guid };
                    }
                );
            }
            return __stateData;
            }
            set
            {
__stateData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stateData",
                    value
                );
            }
        }

        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
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

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
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
    #endregion
    
    #region Constructor
        public SpineGameObject() : base() { }

        public SpineGameObject(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpineGameObject(
            Scene scene, SpinePlugin pluginManager, decimal x, decimal y, string key = null, string animationName = null, System.Nullable<bool> loop = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SpineGameObject" },
                scene, pluginManager, x, y, key, animationName, loop
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public TrackEntry addAnimation(decimal trackIndex, string animationName, System.Nullable<bool> loop = null, System.Nullable<decimal> delay = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TrackEntry>(
                entity => new TrackEntry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAnimation" }, trackIndex, animationName, loop, delay
                }
            );
        }

        public SpineGameObject angleBoneToXY(Bone bone, decimal worldX, decimal worldY, System.Nullable<decimal> offset = null, System.Nullable<decimal> minAngle = null, System.Nullable<decimal> maxAngle = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "angleBoneToXY" }, bone, worldX, worldY, offset, minAngle, maxAngle
                }
            );
        }

        public SpineGameObject clearTrack(decimal trackIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTrack" }, trackIndex
                }
            );
        }

        public SpineGameObject clearTracks()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearTracks" }
                }
            );
        }

        public Animation findAnimation(string animationName)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findAnimation" }, animationName
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

        public EventData findEvent(string eventDataName)
        {
            return EventHorizonBlazorInterop.FuncClass<EventData>(
                entity => new EventData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "findEvent" }, eventDataName
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

        public decimal findPathConstraintIndex(string constraintName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "findPathConstraintIndex" }, constraintName
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

        public string[] getAnimationList()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAnimationList" }
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

        public string[] getBoneList()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getBoneList" }
                }
            );
        }

        public CachedEntity getBounds()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }
                }
            );
        }

        public Animation getCurrentAnimation(System.Nullable<decimal> trackIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCurrentAnimation" }, trackIndex
                }
            );
        }

        public TransformMatrix getLocalTransformMatrix(TransformMatrix tempMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalTransformMatrix" }, tempMatrix
                }
            );
        }

        public decimal getParentRotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParentRotation" }
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

        public string[] getSkinList()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSkinList" }
                }
            );
        }

        public string[] getSlotList()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSlotList" }
                }
            );
        }

        public TransformMatrix getWorldTransformMatrix(TransformMatrix tempMatrix = null, TransformMatrix parentMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldTransformMatrix" }, tempMatrix, parentMatrix
                }
            );
        }

        public SpineGameObject play(string animationName, System.Nullable<bool> loop = null, System.Nullable<bool> ignoreIfPlaying = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, animationName, loop, ignoreIfPlaying
                }
            );
        }

        public SpineGameObject refresh()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refresh" }
                }
            );
        }

        public SpineGameObject resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public SpineGameObject setAlpha(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public SpineGameObject setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public TrackEntry setAnimation(decimal trackIndex, string animationName, System.Nullable<bool> loop = null, System.Nullable<bool> ignoreIfPlaying = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TrackEntry>(
                entity => new TrackEntry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAnimation" }, trackIndex, animationName, loop, ignoreIfPlaying
                }
            );
        }

        public SpineGameObject setAttachment(string slotName, string attachmentName)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAttachment" }, slotName, attachmentName
                }
            );
        }

        public SpineGameObject setBonesToSetupPose()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBonesToSetupPose" }
                }
            );
        }

        public SpineGameObject setColor(System.Nullable<decimal> color = null, string slotName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor" }, color, slotName
                }
            );
        }

        public SpineGameObject setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public SpineGameObject setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public TrackEntry setEmptyAnimation(decimal trackIndex, System.Nullable<decimal> mixDuration = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TrackEntry>(
                entity => new TrackEntry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setEmptyAnimation" }, trackIndex, mixDuration
                }
            );
        }

        public SpineGameObject setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public SpineGameObject setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public SpineGameObject setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public SpineGameObject setMix(string fromName, string toName, System.Nullable<decimal> duration = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMix" }, fromName, toName, duration
                }
            );
        }

        public SpineGameObject setOffset(System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOffset" }, offsetX, offsetY
                }
            );
        }

        public SpineGameObject setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public SpineGameObject setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public SpineGameObject setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public SpineGameObject setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public SpineGameObject setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public SpineGameObject setSize(System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<decimal> offsetX = null, System.Nullable<decimal> offsetY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, offsetX, offsetY
                }
            );
        }

        public SpineGameObject setSkeleton(string atlasDataKey, object skeletonJSON, string animationName = null, System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkeleton" }, atlasDataKey, skeletonJSON, animationName, loop
                }
            );
        }

        public SpineGameObject setSkeletonFromJSON(string atlasDataKey, object skeletonJSON, string animationName = null, System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkeletonFromJSON" }, atlasDataKey, skeletonJSON, animationName, loop
                }
            );
        }

        public SpineGameObject setSkin(Skin newSkin)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkin" }, newSkin
                }
            );
        }

        public SpineGameObject setSkinByName(string skinName)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSkinByName" }, skinName
                }
            );
        }

        public SpineGameObject setSlotsToSetupPose()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSlotsToSetupPose" }
                }
            );
        }

        public SpineGameObject setToSetupPose()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setToSetupPose" }
                }
            );
        }

        public SpineGameObject setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }

        public SpineGameObject setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public SpineGameObject setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public SpineGameObject setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public SpineGameObject setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, value
                }
            );
        }

        public SpineGameObject toggleFlipX()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipX" }
                }
            );
        }

        public SpineGameObject toggleFlipY()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toggleFlipY" }
                }
            );
        }

        public SpineGameObject updateSize()
        {
            return EventHorizonBlazorInterop.FuncClass<SpineGameObject>(
                entity => new SpineGameObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateSize" }
                }
            );
        }

        public bool willRender()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willRender" }
                }
            );
        }
    #endregion
}
