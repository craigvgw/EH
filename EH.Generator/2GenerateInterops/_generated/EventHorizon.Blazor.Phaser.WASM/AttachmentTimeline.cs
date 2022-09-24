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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AttachmentTimeline>))]
    public class AttachmentTimeline : CachedEntityObject, ITimeline
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
        
        public decimal slotIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "slotIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "slotIndex",
                    value
                );
            }
        }

        
        public decimal[] frames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "frames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frames",
                    value
                );
            }
        }

        
        public string[] attachmentNames
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "attachmentNames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachmentNames",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AttachmentTimeline() : base() { }

        public AttachmentTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AttachmentTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "AttachmentTimeline" },
                frameCount
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getPropertyId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPropertyId" }
                }
            );
        }

        public decimal getFrameCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrameCount" }
                }
            );
        }

        public void setFrame(decimal frameIndex, decimal time, string attachmentName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frameIndex, time, attachmentName
                }
            );
        }

        public void apply(Skeleton skeleton, decimal lastTime, decimal time, string[] events, decimal alpha, int blend, int direction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }, skeleton, lastTime, time, events, alpha, blend, direction
                }
            );
        }
        #endregion
    }
}