/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface InteractionTrackingFlags : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<InteractionTrackingFlagsCachedEntity>))]
public class InteractionTrackingFlagsCachedEntity : CachedEntityObject, InteractionTrackingFlags
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
        
        public decimal OVER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "OVER"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OVER",
                    value
                );
            }
        }

        
        public decimal LEFT_DOWN
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LEFT_DOWN"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LEFT_DOWN",
                    value
                );
            }
        }

        
        public decimal RIGHT_DOWN
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RIGHT_DOWN"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RIGHT_DOWN",
                    value
                );
            }
        }

        
        public decimal NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NONE",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractionTrackingFlagsCachedEntity() : base() { }

        public InteractionTrackingFlagsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
