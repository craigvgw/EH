/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Buffer_2>))]
public class Buffer_2 : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Buffer_2 from(IArrayBuffer data)
        {
            return EventHorizonBlazorInterop.FuncClass<Buffer_2>(
                entity => new Buffer_2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Buffer_2", "from" }, data
                }
            );
        }
    #endregion

    #region Accessors
        
        public bool index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private ITypedArrayCachedEntity __data;
        public ITypedArrayCachedEntity data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<ITypedArrayCachedEntity>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new ITypedArrayCachedEntity() { ___guid = entity.___guid };
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

        
        public int typePixi
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "typePixi"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "typePixi",
                    value
                );
            }
        }

        
        public bool staticPixi
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "staticPixi"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "staticPixi",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        private Runner __disposeRunner;
        public Runner disposeRunner
        {
            get
            {
            if(__disposeRunner == null)
            {
                __disposeRunner = EventHorizonBlazorInterop.GetClass<Runner>(
                    this.___guid,
                    "disposeRunner",
                    (entity) =>
                    {
                        return new Runner() { ___guid = entity.___guid };
                    }
                );
            }
            return __disposeRunner;
            }
            set
            {
__disposeRunner = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeRunner",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Buffer_2() : base() { }

        public Buffer_2(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Buffer_2(
            IArrayBuffer data = null, System.Nullable<bool> _static = null, System.Nullable<bool> index = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Buffer_2" },
                data, _static, index
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(IArrayBuffer data = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, data
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
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
