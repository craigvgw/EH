/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GLBufferAttribute>))]
public class GLBufferAttribute : CachedEntityObject
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

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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

        
        public decimal itemSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "itemSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "itemSize",
                    value
                );
            }
        }

        
        public unknown elementSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "elementSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elementSize",
                    value
                );
            }
        }

        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "count",
                    value
                );
            }
        }

        
        public decimal version
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "version"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "version",
                    value
                );
            }
        }

        
        public unknown isGLBufferAttribute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isGLBufferAttribute"
                );
            }
        }
    #endregion
    
    #region Constructor
        public GLBufferAttribute() : base() { }

        public GLBufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public GLBufferAttribute(
            WebGLBuffer buffer, decimal type, decimal itemSize, unknown elementSize, decimal count
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GLBufferAttribute" },
                buffer, type, itemSize, elementSize, count
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public GLBufferAttribute setBuffer(WebGLBuffer buffer)
        {
            return EventHorizonBlazorInterop.FuncClass<GLBufferAttribute>(
                entity => new GLBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBuffer" }, buffer
                }
            );
        }

        public GLBufferAttribute setType(decimal type, unknown elementSize)
        {
            return EventHorizonBlazorInterop.FuncClass<GLBufferAttribute>(
                entity => new GLBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setType" }, type, elementSize
                }
            );
        }

        public GLBufferAttribute setItemSize(decimal itemSize)
        {
            return EventHorizonBlazorInterop.FuncClass<GLBufferAttribute>(
                entity => new GLBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setItemSize" }, itemSize
                }
            );
        }

        public GLBufferAttribute setCount(decimal count)
        {
            return EventHorizonBlazorInterop.FuncClass<GLBufferAttribute>(
                entity => new GLBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setCount" }, count
                }
            );
        }
    #endregion
}
