/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ViewableBuffer>))]
public class ViewableBuffer : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static decimal sizeOf(string type)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "ViewableBuffer", "sizeOf" }, type
                }
            );
        }
    #endregion

    #region Accessors
        private Int8Array __int8View;
        public Int8Array int8View
        {
            get
            {
            if(__int8View == null)
            {
                __int8View = EventHorizonBlazorInterop.GetClass<Int8Array>(
                    this.___guid,
                    "int8View",
                    (entity) =>
                    {
                        return new Int8Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __int8View;
            }
        }

        
        public decimal[] uint8View
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uint8View"
                );
            }
        }

        private Int16Array __int16View;
        public Int16Array int16View
        {
            get
            {
            if(__int16View == null)
            {
                __int16View = EventHorizonBlazorInterop.GetClass<Int16Array>(
                    this.___guid,
                    "int16View",
                    (entity) =>
                    {
                        return new Int16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __int16View;
            }
        }

        private Uint16Array __uint16View;
        public Uint16Array uint16View
        {
            get
            {
            if(__uint16View == null)
            {
                __uint16View = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "uint16View",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __uint16View;
            }
        }

        private Int32Array __int32View;
        public Int32Array int32View
        {
            get
            {
            if(__int32View == null)
            {
                __int32View = EventHorizonBlazorInterop.GetClass<Int32Array>(
                    this.___guid,
                    "int32View",
                    (entity) =>
                    {
                        return new Int32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __int32View;
            }
        }
    #endregion

    #region Properties
        
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

        private ArrayBuffer __rawBinaryData;
        public ArrayBuffer rawBinaryData
        {
            get
            {
            if(__rawBinaryData == null)
            {
                __rawBinaryData = EventHorizonBlazorInterop.GetClass<ArrayBuffer>(
                    this.___guid,
                    "rawBinaryData",
                    (entity) =>
                    {
                        return new ArrayBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __rawBinaryData;
            }
            set
            {
__rawBinaryData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rawBinaryData",
                    value
                );
            }
        }

        private Uint32Array __uint32View;
        public Uint32Array uint32View
        {
            get
            {
            if(__uint32View == null)
            {
                __uint32View = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "uint32View",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __uint32View;
            }
            set
            {
__uint32View = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uint32View",
                    value
                );
            }
        }

        
        public decimal[] float32View
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "float32View"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "float32View",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ViewableBuffer() : base() { }

        public ViewableBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ViewableBuffer(
            decimal length
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ViewableBuffer" },
                length
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public ITypedArrayCachedEntity view(string type)
        {
            return EventHorizonBlazorInterop.FuncClass<ITypedArrayCachedEntity>(
                entity => new ITypedArrayCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "view" }, type
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
