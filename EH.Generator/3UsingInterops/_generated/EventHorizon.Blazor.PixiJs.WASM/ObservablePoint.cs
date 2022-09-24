/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ObservablePoint<CachedEntity>>))]
public class ObservablePoint<T> : CachedEntityObject, IPoint where T : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }
    #endregion

    #region Properties
        
        public CachedEntity scope
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "scope",
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
                    "scope",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ObservablePoint() : base() { }

        public ObservablePoint(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ObservablePoint(
            ActionResultCallback<T, CachedEntity> cb, T scope, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ObservablePoint" },
                cb, scope, x, y
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region cb TODO: Get Comments as metadata identification
        private bool _isCbEnabled = false;
        private readonly IDictionary<string, Func<Task>> _cbActionMap = new Dictionary<string, Func<Task>>();

        public string cb(
            Func<Task> callback
        )
        {
            SetupCbLoop();

            var handle = Guid.NewGuid().ToString();
            _cbActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool cb_Remove(
            string handle
        )
        {
            return _cbActionMap.Remove(
                handle
            );
        }

        private void SetupCbLoop()
        {
            if (_isCbEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "cb",
                "CallCbActions",
                _invokableReference
            );
            _isCbEnabled = true;
        }

        [JSInvokable]
        public async Task CallCbActions()
        {
            foreach (var action in _cbActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public ObservablePoint clone(ActionResultCallback<T, CachedEntity> cb = null, object scope = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ObservablePoint>(
                entity => new ObservablePoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, cb, scope
                }
            );
        }

        public ObservablePoint set(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ObservablePoint>(
                entity => new ObservablePoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y
                }
            );
        }

        public ObservablePoint copyFrom(IPointData p)
        {
            return EventHorizonBlazorInterop.FuncClass<ObservablePoint>(
                entity => new ObservablePoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, p
                }
            );
        }

        public T copyTo<T>(T p) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, p
                }
            );
        }

        public bool equals(IPointData p)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, p
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
    #endregion
}
