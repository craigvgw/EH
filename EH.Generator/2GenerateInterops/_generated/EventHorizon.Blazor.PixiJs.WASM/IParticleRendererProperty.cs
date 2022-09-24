/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IParticleRendererProperty : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IParticleRendererPropertyCachedEntity>))]
public class IParticleRendererPropertyCachedEntity : CachedEntityObject, IParticleRendererProperty
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
        
        public string attributeName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "attributeName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributeName",
                    value
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
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

        
        public decimal offset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IParticleRendererPropertyCachedEntity() : base() { }

        public IParticleRendererPropertyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        #region uploadFunction TODO: Get Comments as metadata identification
        private bool _isUploadFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _uploadFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string uploadFunction(
            Func<Task> callback
        )
        {
            SetupUploadFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _uploadFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool uploadFunction_Remove(
            string handle
        )
        {
            return _uploadFunctionActionMap.Remove(
                handle
            );
        }

        private void SetupUploadFunctionLoop()
        {
            if (_isUploadFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "uploadFunction",
                "CallUploadFunctionActions",
                _invokableReference
            );
            _isUploadFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallUploadFunctionActions()
        {
            foreach (var action in _uploadFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
