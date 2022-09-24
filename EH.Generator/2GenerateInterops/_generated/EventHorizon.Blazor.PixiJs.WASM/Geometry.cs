/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Geometry>))]
public class Geometry : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Geometry merge(Geometry[] geometries)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Geometry", "merge" }, geometries
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public Buffer_2[] buffers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Buffer_2>(
                    this.___guid,
                    "buffers",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buffers",
                    value
                );
            }
        }

        private Buffer_2 __indexBuffer;
        public Buffer_2 indexBuffer
        {
            get
            {
            if(__indexBuffer == null)
            {
                __indexBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "indexBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __indexBuffer;
            }
            set
            {
__indexBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexBuffer",
                    value
                );
            }
        }

        
        public CachedEntity attributes
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "attributes",
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
                    "attributes",
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

        
        public bool instanced
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "instanced"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanced",
                    value
                );
            }
        }

        
        public decimal instanceCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instanceCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanceCount",
                    value
                );
            }
        }

        
        public CachedEntity glVertexArrayObjects
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "glVertexArrayObjects",
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
                    "glVertexArrayObjects",
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
        public Geometry() : base() { }

        public Geometry(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Geometry(
            Buffer_2[] buffers = null, object attributes = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Geometry" },
                buffers, attributes
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Geometry addAttribute(string id, Buffer_2 buffer, System.Nullable<decimal> size = null, System.Nullable<bool> normalized = null, System.Nullable<int> type = null, System.Nullable<decimal> stride = null, System.Nullable<decimal> start = null, System.Nullable<bool> instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAttribute" }, id, buffer, size, normalized, type, stride, start, instance
                }
            );
        }

        public Attribute getAttribute(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Attribute>(
                entity => new Attribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttribute" }, id
                }
            );
        }

        public Buffer_2 getBuffer(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Buffer_2>(
                entity => new Buffer_2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBuffer" }, id
                }
            );
        }

        public Geometry addIndex(Buffer_2 buffer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addIndex" }, buffer
                }
            );
        }

        public Buffer_2 getIndex()
        {
            return EventHorizonBlazorInterop.FuncClass<Buffer_2>(
                entity => new Buffer_2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }
                }
            );
        }

        public Geometry interleave()
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "interleave" }
                }
            );
        }

        public decimal getSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getSize" }
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

        public Geometry clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
    #endregion
}
