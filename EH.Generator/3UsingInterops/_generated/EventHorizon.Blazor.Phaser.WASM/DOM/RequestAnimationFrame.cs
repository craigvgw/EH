/// Generated - Do Not Edit
namespace Phaser.DOM
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RequestAnimationFrame>))]
    public class RequestAnimationFrame : CachedEntityObject
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
        
        public bool isRunning
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRunning"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRunning",
                    value
                );
            }
        }

        private FrameRequestCallback __callback;
        public FrameRequestCallback callback
        {
            get
            {
            if(__callback == null)
            {
                __callback = EventHorizonBlazorInterop.GetClass<FrameRequestCallback>(
                    this.___guid,
                    "callback",
                    (entity) =>
                    {
                        return new FrameRequestCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __callback;
            }
            set
            {
__callback = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "callback",
                    value
                );
            }
        }

        
        public decimal tick
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tick"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tick",
                    value
                );
            }
        }

        
        public bool isSetTimeOut
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSetTimeOut"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSetTimeOut",
                    value
                );
            }
        }

        
        public decimal timeOutID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeOutID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeOutID",
                    value
                );
            }
        }

        
        public decimal lastTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lastTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lastTime",
                    value
                );
            }
        }

        
        public decimal target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "target"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        private FrameRequestCallback __step;
        public FrameRequestCallback step
        {
            get
            {
            if(__step == null)
            {
                __step = EventHorizonBlazorInterop.GetClass<FrameRequestCallback>(
                    this.___guid,
                    "step",
                    (entity) =>
                    {
                        return new FrameRequestCallback() { ___guid = entity.___guid };
                    }
                );
            }
            return __step;
            }
            set
            {
__step = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "step",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RequestAnimationFrame() : base() { }

        public RequestAnimationFrame(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void stepTimeout()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stepTimeout" }
                }
            );
        }

        public void start(FrameRequestCallback callback, bool forceSetTimeOut, decimal targetFPS)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, callback, forceSetTimeOut, targetFPS
                }
            );
        }

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}