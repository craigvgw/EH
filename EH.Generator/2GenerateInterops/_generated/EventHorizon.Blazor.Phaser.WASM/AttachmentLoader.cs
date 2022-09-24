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

    public interface AttachmentLoader : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AttachmentLoaderCachedEntity>))]
    public class AttachmentLoaderCachedEntity : CachedEntityObject, AttachmentLoader
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

        #endregion
        
        #region Constructor
        public AttachmentLoaderCachedEntity() : base() { }

        public AttachmentLoaderCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public RegionAttachment newRegionAttachment(Skin skin, string name, string path)
        {
            return EventHorizonBlazorInterop.FuncClass<RegionAttachment>(
                entity => new RegionAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newRegionAttachment" }, skin, name, path
                }
            );
        }

        public MeshAttachment newMeshAttachment(Skin skin, string name, string path)
        {
            return EventHorizonBlazorInterop.FuncClass<MeshAttachment>(
                entity => new MeshAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newMeshAttachment" }, skin, name, path
                }
            );
        }

        public BoundingBoxAttachment newBoundingBoxAttachment(Skin skin, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBoxAttachment>(
                entity => new BoundingBoxAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newBoundingBoxAttachment" }, skin, name
                }
            );
        }

        public PathAttachment newPathAttachment(Skin skin, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<PathAttachment>(
                entity => new PathAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newPathAttachment" }, skin, name
                }
            );
        }

        public PointAttachment newPointAttachment(Skin skin, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<PointAttachment>(
                entity => new PointAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newPointAttachment" }, skin, name
                }
            );
        }

        public ClippingAttachment newClippingAttachment(Skin skin, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<ClippingAttachment>(
                entity => new ClippingAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newClippingAttachment" }, skin, name
                }
            );
        }
        #endregion
    }
}