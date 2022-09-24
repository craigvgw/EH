/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface InteractionManagerOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<InteractionManagerOptionsCachedEntity>))]
public class InteractionManagerOptionsCachedEntity : CachedEntityObject, InteractionManagerOptions
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
        
        public bool autoPreventDefault
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoPreventDefault",
                    value
                );
            }
        }

        
        public decimal interactionFrequency
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "interactionFrequency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interactionFrequency",
                    value
                );
            }
        }

        
        public bool useSystemTicker
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSystemTicker"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useSystemTicker",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractionManagerOptionsCachedEntity() : base() { }

        public InteractionManagerOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
