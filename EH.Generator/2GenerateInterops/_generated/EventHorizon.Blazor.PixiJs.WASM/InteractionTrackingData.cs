/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InteractionTrackingData>))]
public class InteractionTrackingData : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        private static Readonly<InteractionTrackingFlagsCachedEntity> __FLAGS;
        public static Readonly<InteractionTrackingFlagsCachedEntity> FLAGS
        {
            get
            {
            if(__FLAGS == null)
            {
                __FLAGS = EventHorizonBlazorInterop.GetClass<Readonly<InteractionTrackingFlagsCachedEntity>>(
                    "InteractionTrackingData",
                    "FLAGS",
                    (entity) =>
                    {
                        return new Readonly<InteractionTrackingFlagsCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __FLAGS;
            }
            set
            {
__FLAGS = null;
                EventHorizonBlazorInterop.Set(
                    "InteractionTrackingData",
                    "FLAGS",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal pointerId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerId"
                );
            }
        }

        
        public decimal flags
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "flags"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flags",
                    value
                );
            }
        }

        
        public bool none
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "none"
                );
            }
        }

        
        public bool over
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "over"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "over",
                    value
                );
            }
        }

        
        public bool rightDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rightDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightDown",
                    value
                );
            }
        }

        
        public bool leftDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "leftDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftDown",
                    value
                );
            }
        }
    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public InteractionTrackingData() : base() { }

        public InteractionTrackingData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InteractionTrackingData(
            decimal pointerId
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InteractionTrackingData" },
                pointerId
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
