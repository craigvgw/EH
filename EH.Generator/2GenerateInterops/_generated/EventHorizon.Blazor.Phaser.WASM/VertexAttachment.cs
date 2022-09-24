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

    
    
    [JsonConverter(typeof(CachedEntityConverter<VertexAttachment>))]
    public class VertexAttachment : Attachment
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
        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public decimal[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "bones"
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

        
        public decimal[] vertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }

        
        public decimal worldVerticesLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "worldVerticesLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldVerticesLength",
                    value
                );
            }
        }

        private VertexAttachment __deformAttachment;
        public VertexAttachment deformAttachment
        {
            get
            {
            if(__deformAttachment == null)
            {
                __deformAttachment = EventHorizonBlazorInterop.GetClass<VertexAttachment>(
                    this.___guid,
                    "deformAttachment",
                    (entity) =>
                    {
                        return new VertexAttachment() { ___guid = entity.___guid };
                    }
                );
            }
            return __deformAttachment;
            }
            set
            {
__deformAttachment = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deformAttachment",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public VertexAttachment() : base() { }

        public VertexAttachment(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public VertexAttachment(
            string name
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "VertexAttachment" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void computeWorldVertices(Slot slot, decimal start, decimal count, decimal[] worldVertices, decimal offset, decimal stride)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeWorldVertices" }, slot, start, count, worldVertices, offset, stride
                }
            );
        }

        public void copyTo(VertexAttachment attachment)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, attachment
                }
            );
        }
        #endregion
    }
}