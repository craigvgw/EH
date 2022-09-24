/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CountLimiter>))]
public class CountLimiter : CachedEntityObject
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
        
        public decimal maxItemsPerFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxItemsPerFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxItemsPerFrame",
                    value
                );
            }
        }

        
        public decimal itemsLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "itemsLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "itemsLeft",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CountLimiter() : base() { }

        public CountLimiter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public CountLimiter(
            decimal maxItemsPerFrame
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "CountLimiter" },
                maxItemsPerFrame
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
