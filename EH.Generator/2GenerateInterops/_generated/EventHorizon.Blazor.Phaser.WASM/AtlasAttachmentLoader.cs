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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AtlasAttachmentLoader>))]
    public class AtlasAttachmentLoader : CachedEntityObject, AttachmentLoader
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
        private TextureAtlas __atlas;
        public TextureAtlas atlas
        {
            get
            {
            if(__atlas == null)
            {
                __atlas = EventHorizonBlazorInterop.GetClass<TextureAtlas>(
                    this.___guid,
                    "atlas",
                    (entity) =>
                    {
                        return new TextureAtlas() { ___guid = entity.___guid };
                    }
                );
            }
            return __atlas;
            }
            set
            {
__atlas = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "atlas",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AtlasAttachmentLoader() : base() { }

        public AtlasAttachmentLoader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AtlasAttachmentLoader(
            TextureAtlas atlas
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "AtlasAttachmentLoader" },
                atlas
            );
            ___guid = entity.___guid;
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