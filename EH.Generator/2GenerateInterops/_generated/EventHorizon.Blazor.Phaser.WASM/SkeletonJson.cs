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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SkeletonJson>))]
    public class SkeletonJson : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static int blendModeFromString(string str)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { "spine", "SkeletonJson", "blendModeFromString" }, str
                }
            );
        }

        public static int positionModeFromString(string str)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { "spine", "SkeletonJson", "positionModeFromString" }, str
                }
            );
        }

        public static int spacingModeFromString(string str)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { "spine", "SkeletonJson", "spacingModeFromString" }, str
                }
            );
        }

        public static int rotateModeFromString(string str)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { "spine", "SkeletonJson", "rotateModeFromString" }, str
                }
            );
        }

        public static int transformModeFromString(string str)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { "spine", "SkeletonJson", "transformModeFromString" }, str
                }
            );
        }
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
        public SkeletonJson() : base() { }

        public SkeletonJson(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SkeletonJson(
            AttachmentLoader attachmentLoader
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SkeletonJson" },
                attachmentLoader
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public SkeletonData readSkeletonData(string json)
        {
            return EventHorizonBlazorInterop.FuncClass<SkeletonData>(
                entity => new SkeletonData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "readSkeletonData" }, json
                }
            );
        }

        public Attachment readAttachment(object map, Skin skin, decimal slotIndex, string name, SkeletonData skeletonData)
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "readAttachment" }, map, skin, slotIndex, name, skeletonData
                }
            );
        }

        public void readVertices(object map, VertexAttachment attachment, decimal verticesLength)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "readVertices" }, map, attachment, verticesLength
                }
            );
        }

        public void readAnimation(object map, string name, SkeletonData skeletonData)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "readAnimation" }, map, name, skeletonData
                }
            );
        }

        public void readCurve(object map, CurveTimeline timeline, decimal frameIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "readCurve" }, map, timeline, frameIndex
                }
            );
        }

        public CachedEntity getValue(object map, string prop, object defaultValue)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getValue" }, map, prop, defaultValue
                }
            );
        }
        #endregion
    }
}