/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TemporaryDisplayObject>))]
public class TemporaryDisplayObject : DisplayObject
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
        
        public bool sortDirty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortDirty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortDirty",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public TemporaryDisplayObject() : base() { }

        public TemporaryDisplayObject(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region calculateBounds TODO: Get Comments as metadata identification
        private bool _isCalculateBoundsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _calculateBoundsActionMap = new Dictionary<string, Func<Task>>();

        public string calculateBounds(
            Func<Task> callback
        )
        {
            SetupCalculateBoundsLoop();

            var handle = Guid.NewGuid().ToString();
            _calculateBoundsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool calculateBounds_Remove(
            string handle
        )
        {
            return _calculateBoundsActionMap.Remove(
                handle
            );
        }

        private void SetupCalculateBoundsLoop()
        {
            if (_isCalculateBoundsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "calculateBounds",
                "CallCalculateBoundsActions",
                _invokableReference
            );
            _isCalculateBoundsEnabled = true;
        }

        [JSInvokable]
        public async Task CallCalculateBoundsActions()
        {
            foreach (var action in _calculateBoundsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region removeChild TODO: Get Comments as metadata identification
        private bool _isRemoveChildEnabled = false;
        private readonly IDictionary<string, Func<Task>> _removeChildActionMap = new Dictionary<string, Func<Task>>();

        public string removeChild(
            Func<Task> callback
        )
        {
            SetupRemoveChildLoop();

            var handle = Guid.NewGuid().ToString();
            _removeChildActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool removeChild_Remove(
            string handle
        )
        {
            return _removeChildActionMap.Remove(
                handle
            );
        }

        private void SetupRemoveChildLoop()
        {
            if (_isRemoveChildEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "removeChild",
                "CallRemoveChildActions",
                _invokableReference
            );
            _isRemoveChildEnabled = true;
        }

        [JSInvokable]
        public async Task CallRemoveChildActions()
        {
            foreach (var action in _removeChildActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region render TODO: Get Comments as metadata identification
        private bool _isRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _renderActionMap = new Dictionary<string, Func<Task>>();

        public string render(
            Func<Task> callback
        )
        {
            SetupRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _renderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool render_Remove(
            string handle
        )
        {
            return _renderActionMap.Remove(
                handle
            );
        }

        private void SetupRenderLoop()
        {
            if (_isRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "render",
                "CallRenderActions",
                _invokableReference
            );
            _isRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallRenderActions()
        {
            foreach (var action in _renderActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
