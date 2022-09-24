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

    public interface AnimationStateListener2 : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationStateListener2CachedEntity>))]
    public class AnimationStateListener2CachedEntity : CachedEntityObject, AnimationStateListener2
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
        public AnimationStateListener2CachedEntity() : base() { }

        public AnimationStateListener2CachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void start(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, entry
                }
            );
        }

        public void interrupt(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "interrupt" }, entry
                }
            );
        }

        public void end(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }, entry
                }
            );
        }

        public void dispose(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, entry
                }
            );
        }

        public void complete(TrackEntry entry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "complete" }, entry
                }
            );
        }

        public void @event(TrackEntry entry, string @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "@event" }, entry, @event
                }
            );
        }
        #endregion
    }
}