/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BufferAttribute>))]
public class BufferAttribute : CachedEntityObject
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

        
        public unknown isBufferAttribute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isBufferAttribute"
                );
            }
        }
    #endregion
    
    #region Constructor
        public BufferAttribute() : base() { }

        public BufferAttribute(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BufferAttribute(
            decimal[] array, decimal itemSize, System.Nullable<bool> normalized = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BufferAttribute" },
                array, itemSize, normalized
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region onUploadCallback TODO: Get Comments as metadata identification
        private bool _isOnUploadCallbackEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onUploadCallbackActionMap = new Dictionary<string, Func<Task>>();

        public string onUploadCallback(
            Func<Task> callback
        )
        {
            SetupOnUploadCallbackLoop();

            var handle = Guid.NewGuid().ToString();
            _onUploadCallbackActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onUploadCallback_Remove(
            string handle
        )
        {
            return _onUploadCallbackActionMap.Remove(
                handle
            );
        }

        private void SetupOnUploadCallbackLoop()
        {
            if (_isOnUploadCallbackEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onUploadCallback",
                "CallOnUploadCallbackActions",
                _invokableReference
            );
            _isOnUploadCallbackEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnUploadCallbackActions()
        {
            foreach (var action in _onUploadCallbackActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onUpload TODO: Get Comments as metadata identification
        private bool _isOnUploadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onUploadActionMap = new Dictionary<string, Func<Task>>();

        public string onUpload(
            Func<Task> callback
        )
        {
            SetupOnUploadLoop();

            var handle = Guid.NewGuid().ToString();
            _onUploadActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onUpload_Remove(
            string handle
        )
        {
            return _onUploadActionMap.Remove(
                handle
            );
        }

        private void SetupOnUploadLoop()
        {
            if (_isOnUploadEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onUpload",
                "CallOnUploadActions",
                _invokableReference
            );
            _isOnUploadEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnUploadActions()
        {
            foreach (var action in _onUploadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public BufferAttribute setUsage(int usage)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUsage" }, usage
                }
            );
        }

        public BufferAttribute clone()
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public BufferAttribute copy(BufferAttribute source)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
                }
            );
        }

        public BufferAttribute copyAt(decimal index1, BufferAttribute attribute, decimal index2)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyAt" }, index1, attribute, index2
                }
            );
        }

        public BufferAttribute copyArray(decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyArray" }, array
                }
            );
        }

        public BufferAttribute applyMatrix3(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix3" }, m
                }
            );
        }

        public BufferAttribute applyMatrix4(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, m
                }
            );
        }

        public BufferAttribute applyNormalMatrix(Matrix3 m)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyNormalMatrix" }, m
                }
            );
        }

        public BufferAttribute transformDirection(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transformDirection" }, m
                }
            );
        }

        public BufferAttribute set(decimal[] value, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, value, offset
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

        public BufferAttribute setX(decimal index, decimal x)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
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

        public BufferAttribute setY(decimal index, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
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

        public BufferAttribute setZ(decimal index, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
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

        public BufferAttribute setW(decimal index, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, index, z
                }
            );
        }

        public BufferAttribute setXY(decimal index, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXY" }, index, x, y
                }
            );
        }

        public BufferAttribute setXYZ(decimal index, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXYZ" }, index, x, y, z
                }
            );
        }

        public BufferAttribute setXYZW(decimal index, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setXYZW" }, index, x, y, z, w
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
    #endregion
}
