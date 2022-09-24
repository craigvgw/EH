/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ParticleBuffer>))]
public class ParticleBuffer : CachedEntityObject
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
        private Geometry __geometry;
        public Geometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<Geometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        
        public decimal staticStride
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "staticStride"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "staticStride",
                    value
                );
            }
        }

        private Buffer_2 __staticBuffer;
        public Buffer_2 staticBuffer
        {
            get
            {
            if(__staticBuffer == null)
            {
                __staticBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "staticBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __staticBuffer;
            }
            set
            {
__staticBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "staticBuffer",
                    value
                );
            }
        }

        
        public decimal[] staticData
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "staticData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "staticData",
                    value
                );
            }
        }

        private Uint32Array __staticDataUint32;
        public Uint32Array staticDataUint32
        {
            get
            {
            if(__staticDataUint32 == null)
            {
                __staticDataUint32 = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "staticDataUint32",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __staticDataUint32;
            }
            set
            {
__staticDataUint32 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "staticDataUint32",
                    value
                );
            }
        }

        
        public decimal dynamicStride
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dynamicStride"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicStride",
                    value
                );
            }
        }

        private Buffer_2 __dynamicBuffer;
        public Buffer_2 dynamicBuffer
        {
            get
            {
            if(__dynamicBuffer == null)
            {
                __dynamicBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "dynamicBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __dynamicBuffer;
            }
            set
            {
__dynamicBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicBuffer",
                    value
                );
            }
        }

        
        public decimal[] dynamicData
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "dynamicData"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicData",
                    value
                );
            }
        }

        private Uint32Array __dynamicDataUint32;
        public Uint32Array dynamicDataUint32
        {
            get
            {
            if(__dynamicDataUint32 == null)
            {
                __dynamicDataUint32 = EventHorizonBlazorInterop.GetClass<Uint32Array>(
                    this.___guid,
                    "dynamicDataUint32",
                    (entity) =>
                    {
                        return new Uint32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __dynamicDataUint32;
            }
            set
            {
__dynamicDataUint32 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicDataUint32",
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
    #endregion
    
    #region Constructor
        public ParticleBuffer() : base() { }

        public ParticleBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ParticleBuffer(
            IParticleRendererProperty[] properties, bool[] dynamicPropertyFlags, decimal size
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ParticleBuffer" },
                properties, dynamicPropertyFlags, size
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void uploadDynamic(Sprite[] children, decimal startIndex, decimal amount)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadDynamic" }, children, startIndex, amount
                }
            );
        }

        public void uploadStatic(Sprite[] children, decimal startIndex, decimal amount)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadStatic" }, children, startIndex, amount
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
