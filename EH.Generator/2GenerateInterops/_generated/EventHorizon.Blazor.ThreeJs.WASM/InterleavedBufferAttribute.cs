/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InterleavedBufferAttribute>))]
public class InterleavedBufferAttribute : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
        }

        
        public decimal[] array
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "array"
                );
            }
        }
    #endregion

    #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private InterleavedBuffer __data;
        public InterleavedBuffer data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<InterleavedBuffer>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new InterleavedBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
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

        
        public bool normalized
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "normalized"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalized",
                    value
                );
            }
        }

        
        public unknown isInterleavedBufferAttribute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isInterleavedBufferAttribute"
                );
            }
        }
    #endregion
    
    #region Constructor
        public InterleavedBufferAttribute() : base() { }

        public InterleavedBufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InterleavedBufferAttribute(
            InterleavedBuffer interleavedBuffer, decimal itemSize, decimal offset, System.Nullable<bool> normalized = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InterleavedBufferAttribute" },
                interleavedBuffer, itemSize, offset, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public InterleavedBufferAttribute applyMatrix4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, m
                }
            );
        }

        public BufferAttribute clone(object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, data
                }
            );
        }

        public decimal getX(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getX" }, index
                }
            );
        }

        public InterleavedBufferAttribute setX(decimal index, decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, index, x
                }
            );
        }

        public decimal getY(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getY" }, index
                }
            );
        }

        public InterleavedBufferAttribute setY(decimal index, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, index, y
                }
            );
        }

        public decimal getZ(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getZ" }, index
                }
            );
        }

        public InterleavedBufferAttribute setZ(decimal index, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, index, z
                }
            );
        }

        public decimal getW(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getW" }, index
                }
            );
        }

        public InterleavedBufferAttribute setW(decimal index, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, index, z
                }
            );
        }

        public InterleavedBufferAttribute setXY(decimal index, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXY" }, index, x, y
                }
            );
        }

        public InterleavedBufferAttribute setXYZ(decimal index, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXYZ" }, index, x, y, z
                }
            );
        }

        public InterleavedBufferAttribute setXYZW(decimal index, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXYZW" }, index, x, y, z, w
                }
            );
        }

        public CachedEntity toJSON(object data = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, data
                }
            );
        }

        public InterleavedBufferAttribute applyNormalMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyNormalMatrix" }, matrix
                }
            );
        }

        public InterleavedBufferAttribute transformDirection(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<InterleavedBufferAttribute>(
                entity => new InterleavedBufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformDirection" }, matrix
                }
            );
        }
    #endregion
}
