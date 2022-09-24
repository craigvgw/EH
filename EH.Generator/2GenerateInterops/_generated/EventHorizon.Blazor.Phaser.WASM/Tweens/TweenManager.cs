/// Generated - Do Not Edit
namespace Phaser.Tweens
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TweenManager>))]
    public class TweenManager : CachedEntityObject
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
        #endregion
        
        #region Constructor
        public TweenManager() : base() { }

        public TweenManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public TweenManager(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Tweens", "TweenManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Timeline createTimeline(TimelineBuilderConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTimeline" }, config
                }
            );
        }

        public Timeline timeline(TimelineBuilderConfig config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Timeline>(
                entity => new Timeline() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "timeline" }, config
                }
            );
        }

        public Tween create(TweenBuilderConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, config
                }
            );
        }

        public Tween add(TweenBuilderConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, config
                }
            );
        }

        public TweenManager existing(Tween tween)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "existing" }, tween
                }
            );
        }

        public Tween addCounter(NumberTweenBuilderConfig config)
        {
            return EventHorizonBlazorInterop.FuncClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addCounter" }, config
                }
            );
        }

        public void stagger(decimal value, StaggerConfig config)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stagger" }, value, config
                }
            );
        }

        public void preUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preUpdate" }
                }
            );
        }

        public void update(decimal timestamp, decimal delta)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, timestamp, delta
                }
            );
        }

        public TweenManager remove(Tween tween)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, tween
                }
            );
        }

        public TweenManager makeActive(Tween tween)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeActive" }, tween
                }
            );
        }

        public Tween[] getAllTweens()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAllTweens" }
                }
            );
        }

        public decimal getGlobalTimeScale()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getGlobalTimeScale" }
                }
            );
        }

        public Tween[] getTweensOf(object target, System.Nullable<bool> includePending = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Tween>(
                entity => new Tween() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTweensOf" }, target, includePending
                }
            );
        }

        public bool isTweening(object target)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isTweening" }, target
                }
            );
        }

        public TweenManager killAll()
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "killAll" }
                }
            );
        }

        public TweenManager killTweensOf(object target)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "killTweensOf" }, target
                }
            );
        }

        public TweenManager pauseAll()
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pauseAll" }
                }
            );
        }

        public TweenManager resumeAll()
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resumeAll" }
                }
            );
        }

        public TweenManager setGlobalTimeScale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<TweenManager>(
                entity => new TweenManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setGlobalTimeScale" }, value
                }
            );
        }

        public void shutdown()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shutdown" }
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