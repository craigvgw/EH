/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Ticker>))]
public class Ticker : CachedEntityObject
{
    #region Static Accessors
        private static Ticker __shared;
        public static Ticker shared
        {
            get
            {
            if(__shared == null)
            {
                __shared = EventHorizonBlazorInterop.GetClass<Ticker>(
                    "Ticker",
                    "shared",
                    (entity) =>
                    {
                        return new Ticker() { ___guid = entity.___guid };
                    }
                );
            }
            return __shared;
            }
        }

        private static Ticker __system;
        public static Ticker system
        {
            get
            {
            if(__system == null)
            {
                __system = EventHorizonBlazorInterop.GetClass<Ticker>(
                    "Ticker",
                    "system",
                    (entity) =>
                    {
                        return new Ticker() { ___guid = entity.___guid };
                    }
                );
            }
            return __system;
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
        }

        
        public decimal FPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FPS"
                );
            }
        }

        
        public decimal minFPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minFPS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minFPS",
                    value
                );
            }
        }

        
        public decimal maxFPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxFPS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxFPS",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public bool autoStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoStart",
                    value
                );
            }
        }

        
        public decimal deltaTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaTime",
                    value
                );
            }
        }

        
        public decimal deltaMS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "deltaMS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deltaMS",
                    value
                );
            }
        }

        
        public decimal elapsedMS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elapsedMS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elapsedMS",
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

        
        public decimal speed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speed",
                    value
                );
            }
        }

        
        public bool started
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "started"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "started",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Ticker() : base() { }

        public Ticker(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public Ticker add<T>(ActionResultCallback<T, decimal, CachedEntity> fn, T context = null, System.Nullable<int> priority = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ticker>(
                entity => new Ticker() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, fn, context, priority
                }
            );
        }

        public Ticker addOnce<T>(ActionResultCallback<T, decimal, CachedEntity> fn, T context = null, System.Nullable<int> priority = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ticker>(
                entity => new Ticker() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addOnce" }, fn, context, priority
                }
            );
        }

        public Ticker remove<T>(ActionResultCallback<T, decimal, CachedEntity> fn, T context = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ticker>(
                entity => new Ticker() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, fn, context
                }
            );
        }

        public void start()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }
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

        public void update(System.Nullable<decimal> currentTime = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, currentTime
                }
            );
        }
    #endregion
}
