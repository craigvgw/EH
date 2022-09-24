/// Generated - Do Not Edit
namespace Phaser.Animations
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationManager>))]
    public class AnimationManager : EventEmitter
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
        
        public decimal globalTimeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalTimeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalTimeScale",
                    value
                );
            }
        }

// mixes is not supported by the platform yet

        
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

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationManager() : base() { }

        public AnimationManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AnimationManager(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "Animations", "AnimationManager" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void boot()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "boot" }
                }
            );
        }

        public AnimationManager addMix(string animA, string animB, decimal delay)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMix" }, animA, animB, delay
                }
            );
        }

        public AnimationManager removeMix(string animA, string animB = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeMix" }, animA, animB
                }
            );
        }

        public decimal getMix(string animA, string animB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMix" }, animA, animB
                }
            );
        }

        public AnimationManager add(string key, Animation animation)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, key, animation
                }
            );
        }

        public bool exists(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "exists" }, key
                }
            );
        }

        public Animation[] createFromAseprite(string key, string[] tags = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createFromAseprite" }, key, tags
                }
            );
        }

        public Animation create(Animation config)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, config
                }
            );
        }

        public Animation[] fromJSON(string data, System.Nullable<bool> clearCurrentAnimations = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromJSON" }, data, clearCurrentAnimations
                }
            );
        }

        public AnimationFrame[] generateFrameNames(string key, GenerateFrameNames config = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateFrameNames" }, key, config
                }
            );
        }

        public AnimationFrame[] generateFrameNumbers(string key, GenerateFrameNumbers config)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationFrame>(
                entity => new AnimationFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateFrameNumbers" }, key, config
                }
            );
        }

        public Animation get(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "get" }, key
                }
            );
        }

        public AnimationManager pauseAll()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pauseAll" }
                }
            );
        }

        public AnimationManager play(string key, GameObject children)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, key, children
                }
            );
        }

        public G staggerPlay<G>(string key, GameObject children, decimal stagger, System.Nullable<bool> staggerFirst = null) where G : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<G>(
                entity => new G() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "staggerPlay" }, key, children, stagger, staggerFirst
                }
            );
        }

        public Animation remove(string key)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, key
                }
            );
        }

        public AnimationManager resumeAll()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationManager>(
                entity => new AnimationManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resumeAll" }
                }
            );
        }

        public JSONAnimations toJSON(string key = null)
        {
            return EventHorizonBlazorInterop.FuncClass<JSONAnimations>(
                entity => new JSONAnimations() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, key
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