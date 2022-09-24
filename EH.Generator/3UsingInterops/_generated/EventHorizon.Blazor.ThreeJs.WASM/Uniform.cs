/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Uniform>))]
public class Uniform : CachedEntityObject
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public CachedEntity value
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "value",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }

        
        public bool dynamic
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dynamic"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamic",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Uniform() : base() { }

        public Uniform(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Uniform(
            object value
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Uniform" },
                value
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region onUpdate TODO: Get Comments as metadata identification
        private bool _isOnUpdateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onUpdateActionMap = new Dictionary<string, Func<Task>>();

        public string onUpdate(
            Func<Task> callback
        )
        {
            SetupOnUpdateLoop();

            var handle = Guid.NewGuid().ToString();
            _onUpdateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onUpdate_Remove(
            string handle
        )
        {
            return _onUpdateActionMap.Remove(
                handle
            );
        }

        private void SetupOnUpdateLoop()
        {
            if (_isOnUpdateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onUpdate",
                "CallOnUpdateActions",
                _invokableReference
            );
            _isOnUpdateEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnUpdateActions()
        {
            foreach (var action in _onUpdateActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
