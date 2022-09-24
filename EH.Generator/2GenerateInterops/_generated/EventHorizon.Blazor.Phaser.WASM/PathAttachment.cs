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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PathAttachment>))]
    public class PathAttachment : VertexAttachment
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
        
        public decimal[] lengths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "lengths"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lengths",
                    value
                );
            }
        }

        
        public bool closed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "closed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "closed",
                    value
                );
            }
        }

        
        public bool constantSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "constantSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantSpeed",
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
        #endregion
        
        #region Constructor
        public PathAttachment() : base() { }

        public PathAttachment(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PathAttachment(
            string name
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "PathAttachment" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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
        #endregion
    }
}