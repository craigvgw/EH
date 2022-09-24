/// Generated - Do Not Edit
namespace Phaser.Time
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Clock>))]
    public class Clock : CachedEntityObject
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private Systems __systems;
        public Systems systems
        {
            get
            {
            if(__systems == null)
            {
                __systems = EventHorizonBlazorInterop.GetClass<Systems>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new Systems() { ___guid = entity.___guid };
                    }
                );
            }
            return __systems;
            }
            set
            {
__systems = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
        }

        
        public decimal now
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "now"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "now",
                    value
                );
            }
        }

        
        public decimal timeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeScale",
                    value
                );
            }
        }

        
        public bool paused
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "paused"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "paused",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Clock() : base() { }

        public Clock(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Clock(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Time", "Clock" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TimerEvent addEvent(TimerEvent config)
        {
            return EventHorizonBlazorInterop.FuncClass<TimerEvent>(
                entity => new TimerEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addEvent" }, config
                }
            );
        }

        public Clock clearPendingEvents()
        {
            return EventHorizonBlazorInterop.FuncClass<Clock>(
                entity => new Clock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearPendingEvents" }
                }
            );
        }

        public Clock removeEvent(TimerEvent events)
        {
            return EventHorizonBlazorInterop.FuncClass<Clock>(
                entity => new Clock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeEvent" }, events
                }
            );
        }

        public Clock removeAllEvents()
        {
            return EventHorizonBlazorInterop.FuncClass<Clock>(
                entity => new Clock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAllEvents" }
                }
            );
        }

        public void preUpdate(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preUpdate" }, time, delta
                }
            );
        }

        public void update(decimal time, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, time, delta
                }
            );
        }


        #endregion
    }
}