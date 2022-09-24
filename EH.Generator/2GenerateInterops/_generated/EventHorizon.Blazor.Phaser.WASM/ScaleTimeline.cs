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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ScaleTimeline>))]
    public class ScaleTimeline : TranslateTimeline
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
        public ScaleTimeline() : base() { }

        public ScaleTimeline(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ScaleTimeline(
            decimal frameCount
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "ScaleTimeline" },
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