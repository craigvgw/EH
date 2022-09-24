/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GLBuffer>))]
public class GLBuffer : CachedEntityObject
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
        private WebGLBuffer __buffer;
        public WebGLBuffer buffer
        {
            get
            {
            if(__buffer == null)
            {
                __buffer = EventHorizonBlazorInterop.GetClass<WebGLBuffer>(
                    this.___guid,
                    "buffer",
                    (entity) =>
                    {
                        return new WebGLBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __buffer;
            }
            set
            {
__buffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffer",
                    value
                );
            }
        }

        
        public decimal updateID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateID",
                    value
                );
            }
        }

        
        public decimal byteLength
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "byteLength"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "byteLength",
                    value
                );
            }
        }

        
        public decimal refCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refCount",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public GLBuffer() : base() { }

        public GLBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GLBuffer(
            WebGLBuffer buffer = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GLBuffer" },
                buffer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
