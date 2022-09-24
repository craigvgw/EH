/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TimeLimiter>))]
public class TimeLimiter : CachedEntityObject
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
        
        public decimal maxMilliseconds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxMilliseconds"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxMilliseconds",
                    value
                );
            }
        }

        
        public decimal frameStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frameStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frameStart",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TimeLimiter() : base() { }

        public TimeLimiter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TimeLimiter(
            decimal maxMilliseconds
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TimeLimiter" },
                maxMilliseconds
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void beginFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public bool allowedToUpload()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "allowedToUpload" }
                }
            );
        }
    #endregion
}
