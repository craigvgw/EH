/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IAdapter : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IAdapterCachedEntity>))]
public class IAdapterCachedEntity : CachedEntityObject, IAdapter
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
        public IAdapterCachedEntity() : base() { }

        public IAdapterCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region createCanvas TODO: Get Comments as metadata identification
        private bool _isCreateCanvasEnabled = false;
        private readonly IDictionary<string, Func<Task>> _createCanvasActionMap = new Dictionary<string, Func<Task>>();

        public string createCanvas(
            Func<Task> callback
        )
        {
            SetupCreateCanvasLoop();

            var handle = Guid.NewGuid().ToString();
            _createCanvasActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool createCanvas_Remove(
            string handle
        )
        {
            return _createCanvasActionMap.Remove(
                handle
            );
        }

        private void SetupCreateCanvasLoop()
        {
            if (_isCreateCanvasEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "createCanvas",
                "CallCreateCanvasActions",
                _invokableReference
            );
            _isCreateCanvasEnabled = true;
        }

        [JSInvokable]
        public async Task CallCreateCanvasActions()
        {
            foreach (var action in _createCanvasActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getWebGLRenderingContext TODO: Get Comments as metadata identification
        private bool _isGetWebGLRenderingContextEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getWebGLRenderingContextActionMap = new Dictionary<string, Func<Task>>();

        public string getWebGLRenderingContext(
            Func<Task> callback
        )
        {
            SetupGetWebGLRenderingContextLoop();

            var handle = Guid.NewGuid().ToString();
            _getWebGLRenderingContextActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getWebGLRenderingContext_Remove(
            string handle
        )
        {
            return _getWebGLRenderingContextActionMap.Remove(
                handle
            );
        }

        private void SetupGetWebGLRenderingContextLoop()
        {
            if (_isGetWebGLRenderingContextEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getWebGLRenderingContext",
                "CallGetWebGLRenderingContextActions",
                _invokableReference
            );
            _isGetWebGLRenderingContextEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetWebGLRenderingContextActions()
        {
            foreach (var action in _getWebGLRenderingContextActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getNavigator TODO: Get Comments as metadata identification
        private bool _isGetNavigatorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getNavigatorActionMap = new Dictionary<string, Func<Task>>();

        public string getNavigator(
            Func<Task> callback
        )
        {
            SetupGetNavigatorLoop();

            var handle = Guid.NewGuid().ToString();
            _getNavigatorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getNavigator_Remove(
            string handle
        )
        {
            return _getNavigatorActionMap.Remove(
                handle
            );
        }

        private void SetupGetNavigatorLoop()
        {
            if (_isGetNavigatorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getNavigator",
                "CallGetNavigatorActions",
                _invokableReference
            );
            _isGetNavigatorEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetNavigatorActions()
        {
            foreach (var action in _getNavigatorActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getBaseUrl TODO: Get Comments as metadata identification
        private bool _isGetBaseUrlEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getBaseUrlActionMap = new Dictionary<string, Func<Task>>();

        public string getBaseUrl(
            Func<Task> callback
        )
        {
            SetupGetBaseUrlLoop();

            var handle = Guid.NewGuid().ToString();
            _getBaseUrlActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getBaseUrl_Remove(
            string handle
        )
        {
            return _getBaseUrlActionMap.Remove(
                handle
            );
        }

        private void SetupGetBaseUrlLoop()
        {
            if (_isGetBaseUrlEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getBaseUrl",
                "CallGetBaseUrlActions",
                _invokableReference
            );
            _isGetBaseUrlEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetBaseUrlActions()
        {
            foreach (var action in _getBaseUrlActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region fetch TODO: Get Comments as metadata identification
        private bool _isFetchEnabled = false;
        private readonly IDictionary<string, Func<Task>> _fetchActionMap = new Dictionary<string, Func<Task>>();

        public string fetch(
            Func<Task> callback
        )
        {
            SetupFetchLoop();

            var handle = Guid.NewGuid().ToString();
            _fetchActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool fetch_Remove(
            string handle
        )
        {
            return _fetchActionMap.Remove(
                handle
            );
        }

        private void SetupFetchLoop()
        {
            if (_isFetchEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "fetch",
                "CallFetchActions",
                _invokableReference
            );
            _isFetchEnabled = true;
        }

        [JSInvokable]
        public async Task CallFetchActions()
        {
            foreach (var action in _fetchActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
