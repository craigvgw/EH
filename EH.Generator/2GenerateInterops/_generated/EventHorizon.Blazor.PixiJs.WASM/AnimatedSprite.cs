/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimatedSprite>))]
public class AnimatedSprite : Sprite
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static AnimatedSprite fromFrames(string[] frames)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimatedSprite>(
                entity => new AnimatedSprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimatedSprite", "fromFrames" }, frames
                }
            );
        }

        public static AnimatedSprite fromImages(string[] images)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimatedSprite>(
                entity => new AnimatedSprite() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimatedSprite", "fromImages" }, images
                }
            );
        }
    #endregion

    #region Accessors
        
        public decimal totalFrames
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "totalFrames"
                );
            }
        }

        
        public Texture[] textures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Texture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textures",
                    value
                );
            }
        }

        
        public decimal currentFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentFrame"
                );
            }
        }

        
        public bool playing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "playing"
                );
            }
        }

        
        public bool autoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoUpdate",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public decimal animationSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationSpeed",
                    value
                );
            }
        }

        
        public bool loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        
        public bool updateAnchor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "updateAnchor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateAnchor",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AnimatedSprite() : base() { }

        public AnimatedSprite(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AnimatedSprite(
            Texture[] textures, System.Nullable<bool> autoUpdate = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimatedSprite" },
                textures, autoUpdate
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region onComplete TODO: Get Comments as metadata identification
        private bool _isOnCompleteEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onCompleteActionMap = new Dictionary<string, Func<Task>>();

        public string onComplete(
            Func<Task> callback
        )
        {
            SetupOnCompleteLoop();

            var handle = Guid.NewGuid().ToString();
            _onCompleteActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onComplete_Remove(
            string handle
        )
        {
            return _onCompleteActionMap.Remove(
                handle
            );
        }

        private void SetupOnCompleteLoop()
        {
            if (_isOnCompleteEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onComplete",
                "CallOnCompleteActions",
                _invokableReference
            );
            _isOnCompleteEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnCompleteActions()
        {
            foreach (var action in _onCompleteActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onFrameChange TODO: Get Comments as metadata identification
        private bool _isOnFrameChangeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onFrameChangeActionMap = new Dictionary<string, Func<Task>>();

        public string onFrameChange(
            Func<Task> callback
        )
        {
            SetupOnFrameChangeLoop();

            var handle = Guid.NewGuid().ToString();
            _onFrameChangeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onFrameChange_Remove(
            string handle
        )
        {
            return _onFrameChangeActionMap.Remove(
                handle
            );
        }

        private void SetupOnFrameChangeLoop()
        {
            if (_isOnFrameChangeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onFrameChange",
                "CallOnFrameChangeActions",
                _invokableReference
            );
            _isOnFrameChangeEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnFrameChangeActions()
        {
            foreach (var action in _onFrameChangeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onLoop TODO: Get Comments as metadata identification
        private bool _isOnLoopEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onLoopActionMap = new Dictionary<string, Func<Task>>();

        public string onLoop(
            Func<Task> callback
        )
        {
            SetupOnLoopLoop();

            var handle = Guid.NewGuid().ToString();
            _onLoopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onLoop_Remove(
            string handle
        )
        {
            return _onLoopActionMap.Remove(
                handle
            );
        }

        private void SetupOnLoopLoop()
        {
            if (_isOnLoopEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onLoop",
                "CallOnLoopActions",
                _invokableReference
            );
            _isOnLoopEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnLoopActions()
        {
            foreach (var action in _onLoopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public void play()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "play" }
                }
            );
        }

        public void gotoAndStop(decimal frameNumber)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "gotoAndStop" }, frameNumber
                }
            );
        }

        public void gotoAndPlay(decimal frameNumber)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "gotoAndPlay" }, frameNumber
                }
            );
        }

        public void update(decimal deltaTime)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, deltaTime
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
