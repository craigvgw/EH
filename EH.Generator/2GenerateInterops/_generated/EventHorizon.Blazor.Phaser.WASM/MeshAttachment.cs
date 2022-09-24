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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MeshAttachment>))]
    public class MeshAttachment : VertexAttachment
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
        private TextureRegion __region;
        public TextureRegion region
        {
            get
            {
            if(__region == null)
            {
                __region = EventHorizonBlazorInterop.GetClass<TextureRegion>(
                    this.___guid,
                    "region",
                    (entity) =>
                    {
                        return new TextureRegion() { ___guid = entity.___guid };
                    }
                );
            }
            return __region;
            }
            set
            {
__region = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "region",
                    value
                );
            }
        }

        
        public string path
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "path"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "path",
                    value
                );
            }
        }

        
        public decimal[] regionUVs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "regionUVs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "regionUVs",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        
        public decimal[] triangles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "triangles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "triangles",
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

        
        public decimal hullLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "hullLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hullLength",
                    value
                );
            }
        }

        
        public decimal[] edges
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "edges"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "edges",
                    value
                );
            }
        }

        private Color __tempColor;
        public Color tempColor
        {
            get
            {
            if(__tempColor == null)
            {
                __tempColor = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "tempColor",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __tempColor;
            }
            set
            {
__tempColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tempColor",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MeshAttachment() : base() { }

        public MeshAttachment(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshAttachment(
            string name
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "MeshAttachment" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateUVs()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUVs" }
                }
            );
        }

        public MeshAttachment getParentMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<MeshAttachment>(
                entity => new MeshAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParentMesh" }
                }
            );
        }

        public void setParentMesh(MeshAttachment parentMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setParentMesh" }, parentMesh
                }
            );
        }

        public Attachment copy()
        {
            return EventHorizonBlazorInterop.FuncClass<Attachment>(
                entity => new Attachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }
                }
            );
        }

        public MeshAttachment newLinkedMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<MeshAttachment>(
                entity => new MeshAttachment() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "newLinkedMesh" }
                }
            );
        }
        #endregion
    }
}