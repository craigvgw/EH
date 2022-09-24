/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<CacheData>))]
public class CacheData : CachedEntityObject
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
        
        public string textureCacheId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "textureCacheId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureCacheId",
                    value
                );
            }
        }

        private Container __originalMask;
        public Container originalMask
        {
            get
            {
            if(__originalMask == null)
            {
                __originalMask = EventHorizonBlazorInterop.GetClass<Container>(
                    this.___guid,
                    "originalMask",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
                    }
                );
            }
            return __originalMask;
            }
            set
            {
__originalMask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originalMask",
                    value
                );
            }
        }

        private Rectangle __originalFilterArea;
        public Rectangle originalFilterArea
        {
            get
            {
            if(__originalFilterArea == null)
            {
                __originalFilterArea = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "originalFilterArea",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __originalFilterArea;
            }
            set
            {
__originalFilterArea = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originalFilterArea",
                    value
                );
            }
        }

        private Sprite __sprite;
        public Sprite sprite
        {
            get
            {
            if(__sprite == null)
            {
                __sprite = EventHorizonBlazorInterop.GetClass<Sprite>(
                    this.___guid,
                    "sprite",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
            }
            return __sprite;
            }
            set
            {
__sprite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sprite",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CacheData() : base() { }

        public CacheData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        #region originalRender TODO: Get Comments as metadata identification
        private bool _isOriginalRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalRenderActionMap = new Dictionary<string, Func<Task>>();

        public string originalRender(
            Func<Task> callback
        )
        {
            SetupOriginalRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _originalRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalRender_Remove(
            string handle
        )
        {
            return _originalRenderActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalRenderLoop()
        {
            if (_isOriginalRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalRender",
                "CallOriginalRenderActions",
                _invokableReference
            );
            _isOriginalRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalRenderActions()
        {
            foreach (var action in _originalRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalRenderCanvas TODO: Get Comments as metadata identification
        private bool _isOriginalRenderCanvasEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalRenderCanvasActionMap = new Dictionary<string, Func<Task>>();

        public string originalRenderCanvas(
            Func<Task> callback
        )
        {
            SetupOriginalRenderCanvasLoop();

            var handle = Guid.NewGuid().ToString();
            _originalRenderCanvasActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalRenderCanvas_Remove(
            string handle
        )
        {
            return _originalRenderCanvasActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalRenderCanvasLoop()
        {
            if (_isOriginalRenderCanvasEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalRenderCanvas",
                "CallOriginalRenderCanvasActions",
                _invokableReference
            );
            _isOriginalRenderCanvasEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalRenderCanvasActions()
        {
            foreach (var action in _originalRenderCanvasActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalCalculateBounds TODO: Get Comments as metadata identification
        private bool _isOriginalCalculateBoundsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalCalculateBoundsActionMap = new Dictionary<string, Func<Task>>();

        public string originalCalculateBounds(
            Func<Task> callback
        )
        {
            SetupOriginalCalculateBoundsLoop();

            var handle = Guid.NewGuid().ToString();
            _originalCalculateBoundsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalCalculateBounds_Remove(
            string handle
        )
        {
            return _originalCalculateBoundsActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalCalculateBoundsLoop()
        {
            if (_isOriginalCalculateBoundsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalCalculateBounds",
                "CallOriginalCalculateBoundsActions",
                _invokableReference
            );
            _isOriginalCalculateBoundsEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalCalculateBoundsActions()
        {
            foreach (var action in _originalCalculateBoundsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalGetLocalBounds TODO: Get Comments as metadata identification
        private bool _isOriginalGetLocalBoundsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalGetLocalBoundsActionMap = new Dictionary<string, Func<Task>>();

        public string originalGetLocalBounds(
            Func<Task> callback
        )
        {
            SetupOriginalGetLocalBoundsLoop();

            var handle = Guid.NewGuid().ToString();
            _originalGetLocalBoundsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalGetLocalBounds_Remove(
            string handle
        )
        {
            return _originalGetLocalBoundsActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalGetLocalBoundsLoop()
        {
            if (_isOriginalGetLocalBoundsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalGetLocalBounds",
                "CallOriginalGetLocalBoundsActions",
                _invokableReference
            );
            _isOriginalGetLocalBoundsEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalGetLocalBoundsActions()
        {
            foreach (var action in _originalGetLocalBoundsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalUpdateTransform TODO: Get Comments as metadata identification
        private bool _isOriginalUpdateTransformEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalUpdateTransformActionMap = new Dictionary<string, Func<Task>>();

        public string originalUpdateTransform(
            Func<Task> callback
        )
        {
            SetupOriginalUpdateTransformLoop();

            var handle = Guid.NewGuid().ToString();
            _originalUpdateTransformActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalUpdateTransform_Remove(
            string handle
        )
        {
            return _originalUpdateTransformActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalUpdateTransformLoop()
        {
            if (_isOriginalUpdateTransformEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalUpdateTransform",
                "CallOriginalUpdateTransformActions",
                _invokableReference
            );
            _isOriginalUpdateTransformEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalUpdateTransformActions()
        {
            foreach (var action in _originalUpdateTransformActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalDestroy TODO: Get Comments as metadata identification
        private bool _isOriginalDestroyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalDestroyActionMap = new Dictionary<string, Func<Task>>();

        public string originalDestroy(
            Func<Task> callback
        )
        {
            SetupOriginalDestroyLoop();

            var handle = Guid.NewGuid().ToString();
            _originalDestroyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalDestroy_Remove(
            string handle
        )
        {
            return _originalDestroyActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalDestroyLoop()
        {
            if (_isOriginalDestroyEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalDestroy",
                "CallOriginalDestroyActions",
                _invokableReference
            );
            _isOriginalDestroyEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalDestroyActions()
        {
            foreach (var action in _originalDestroyActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region originalContainsPoint TODO: Get Comments as metadata identification
        private bool _isOriginalContainsPointEnabled = false;
        private readonly IDictionary<string, Func<Task>> _originalContainsPointActionMap = new Dictionary<string, Func<Task>>();

        public string originalContainsPoint(
            Func<Task> callback
        )
        {
            SetupOriginalContainsPointLoop();

            var handle = Guid.NewGuid().ToString();
            _originalContainsPointActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool originalContainsPoint_Remove(
            string handle
        )
        {
            return _originalContainsPointActionMap.Remove(
                handle
            );
        }

        private void SetupOriginalContainsPointLoop()
        {
            if (_isOriginalContainsPointEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "originalContainsPoint",
                "CallOriginalContainsPointActions",
                _invokableReference
            );
            _isOriginalContainsPointEnabled = true;
        }

        [JSInvokable]
        public async Task CallOriginalContainsPointActions()
        {
            foreach (var action in _originalContainsPointActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
