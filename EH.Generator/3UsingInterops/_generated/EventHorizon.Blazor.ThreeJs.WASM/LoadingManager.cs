/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<LoadingManager>))]
public class LoadingManager : CachedEntityObject
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

    #endregion
    
    #region Constructor
        public LoadingManager() : base() { }

        public LoadingManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public LoadingManager(
            ActionCallback onLoad = null, ActionCallback<string, decimal, decimal> onProgress = null, ActionCallback<string> onError = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "LoadingManager" },
                onLoad, onProgress, onError
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region onStart TODO: Get Comments as metadata identification
        private bool _isOnStartEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onStartActionMap = new Dictionary<string, Func<Task>>();

        public string onStart(
            Func<Task> callback
        )
        {
            SetupOnStartLoop();

            var handle = Guid.NewGuid().ToString();
            _onStartActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onStart_Remove(
            string handle
        )
        {
            return _onStartActionMap.Remove(
                handle
            );
        }

        private void SetupOnStartLoop()
        {
            if (_isOnStartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onStart",
                "CallOnStartActions",
                _invokableReference
            );
            _isOnStartEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnStartActions()
        {
            foreach (var action in _onStartActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onLoad TODO: Get Comments as metadata identification
        private bool _isOnLoadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onLoadActionMap = new Dictionary<string, Func<Task>>();

        public string onLoad(
            Func<Task> callback
        )
        {
            SetupOnLoadLoop();

            var handle = Guid.NewGuid().ToString();
            _onLoadActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onLoad_Remove(
            string handle
        )
        {
            return _onLoadActionMap.Remove(
                handle
            );
        }

        private void SetupOnLoadLoop()
        {
            if (_isOnLoadEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onLoad",
                "CallOnLoadActions",
                _invokableReference
            );
            _isOnLoadEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnLoadActions()
        {
            foreach (var action in _onLoadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onProgress TODO: Get Comments as metadata identification
        private bool _isOnProgressEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onProgressActionMap = new Dictionary<string, Func<Task>>();

        public string onProgress(
            Func<Task> callback
        )
        {
            SetupOnProgressLoop();

            var handle = Guid.NewGuid().ToString();
            _onProgressActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onProgress_Remove(
            string handle
        )
        {
            return _onProgressActionMap.Remove(
                handle
            );
        }

        private void SetupOnProgressLoop()
        {
            if (_isOnProgressEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onProgress",
                "CallOnProgressActions",
                _invokableReference
            );
            _isOnProgressEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnProgressActions()
        {
            foreach (var action in _onProgressActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onError TODO: Get Comments as metadata identification
        private bool _isOnErrorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onErrorActionMap = new Dictionary<string, Func<Task>>();

        public string onError(
            Func<Task> callback
        )
        {
            SetupOnErrorLoop();

            var handle = Guid.NewGuid().ToString();
            _onErrorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onError_Remove(
            string handle
        )
        {
            return _onErrorActionMap.Remove(
                handle
            );
        }

        private void SetupOnErrorLoop()
        {
            if (_isOnErrorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onError",
                "CallOnErrorActions",
                _invokableReference
            );
            _isOnErrorEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnErrorActions()
        {
            foreach (var action in _onErrorActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region setURLModifier TODO: Get Comments as metadata identification
        private bool _isSetURLModifierEnabled = false;
        private readonly IDictionary<string, Func<string, Task>> _setURLModifierActionMap = new Dictionary<string, Func<string, Task>>();

        public string setURLModifier(
            Func<string, Task> callback
        )
        {
            SetupSetURLModifierLoop();

            var handle = Guid.NewGuid().ToString();
            _setURLModifierActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool setURLModifier_Remove(
            string handle
        )
        {
            return _setURLModifierActionMap.Remove(
                handle
            );
        }

        private void SetupSetURLModifierLoop()
        {
            if (_isSetURLModifierEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "setURLModifier",
                "CallSetURLModifierActions",
                _invokableReference
            );
            _isSetURLModifierEnabled = true;
        }

        [JSInvokable]
        public async Task CallSetURLModifierActions(string url)
        {
            foreach (var action in _setURLModifierActionMap.Values)
            {
                await action(url);
            }
        }
        #endregion

        public string resolveURL(string url)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "resolveURL" }, url
                }
            );
        }

        public void itemStart(string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "itemStart" }, url
                }
            );
        }

        public void itemEnd(string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "itemEnd" }, url
                }
            );
        }

        public void itemError(string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "itemError" }, url
                }
            );
        }

        public LoadingManager addHandler(RegExp regex, Loader loader)
        {
            return EventHorizonBlazorInterop.FuncClass<LoadingManager>(
                entity => new LoadingManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addHandler" }, regex, loader
                }
            );
        }

        public LoadingManager removeHandler(RegExp regex)
        {
            return EventHorizonBlazorInterop.FuncClass<LoadingManager>(
                entity => new LoadingManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeHandler" }, regex
                }
            );
        }

        public Loader getHandler(string file)
        {
            return EventHorizonBlazorInterop.FuncClass<Loader>(
                entity => new Loader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHandler" }, file
                }
            );
        }
    #endregion
}
