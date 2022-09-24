/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InterleavedBuffer>))]
public class InterleavedBuffer : CachedEntityObject
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
        
        public decimal[] array
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "array"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "array",
                    value
                );
            }
        }

        
        public decimal stride
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stride"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stride",
                    value
                );
            }
        }

        
        public int usage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "usage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usage",
                    value
                );
            }
        }

        
        public CachedEntity updateRange
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "updateRange",
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
                    "updateRange",
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

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
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

        
        public bool needsUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needsUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needsUpdate",
                    value
                );
            }
        }

        
        public string uuid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uuid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uuid",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InterleavedBuffer() : base() { }

        public InterleavedBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InterleavedBuffer(
            decimal[] array, decimal stride
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InterleavedBuffer" },
                array, stride
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public InterleavedBuffer setUsage(int usage)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBuffer>(
                entity => new InterleavedBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUsage" }, usage
                }
            );
        }

        public InterleavedBuffer clone(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBuffer>(
                entity => new InterleavedBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, data
                }
            );
        }

        public InterleavedBuffer copy(InterleavedBuffer source)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBuffer>(
                entity => new InterleavedBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public InterleavedBuffer copyAt(decimal index1, InterleavedBufferAttribute attribute, decimal index2)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBuffer>(
                entity => new InterleavedBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyAt" }, index1, attribute, index2
                }
            );
        }

        public InterleavedBuffer set(decimal[] value, decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBuffer>(
                entity => new InterleavedBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, value, index
                }
            );
        }

        public CachedEntity toJSON(object data)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, data
                }
            );
        }
    #endregion
}
