/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BufferSystem>))]
public class BufferSystem : CachedEntityObject, ISystem
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
        
        public decimal CONTEXT_UID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "CONTEXT_UID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTEXT_UID",
                    value
                );
            }
        }

        private IRenderingContextCachedEntity __gl;
        public IRenderingContextCachedEntity gl
        {
            get
            {
            if(__gl == null)
            {
                __gl = EventHorizonBlazorInterop.GetClass<IRenderingContextCachedEntity>(
                    this.___guid,
                    "gl",
                    (entity) =>
                    {
                        return new IRenderingContextCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __gl;
            }
            set
            {
__gl = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gl",
                    value
                );
            }
        }

        
        public CachedEntity managedBuffers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "managedBuffers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity boundBufferBases
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "boundBufferBases",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
    #endregion
    
    #region Constructor
        public BufferSystem() : base() { }

        public BufferSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BufferSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BufferSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }

        public void bind(Buffer_2 buffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, buffer
                }
            );
        }

        public void bindBufferBase(Buffer_2 buffer, decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBufferBase" }, buffer, index
                }
            );
        }

        public void bindBufferRange(Buffer_2 buffer, System.Nullable<decimal> index = null, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBufferRange" }, buffer, index, offset
                }
            );
        }

        public void update(Buffer_2 buffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, buffer
                }
            );
        }

        public void dispose(Buffer_2 buffer, System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, buffer, contextLost
                }
            );
        }

        public void disposeAll(System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeAll" }, contextLost
                }
            );
        }
    #endregion
}
