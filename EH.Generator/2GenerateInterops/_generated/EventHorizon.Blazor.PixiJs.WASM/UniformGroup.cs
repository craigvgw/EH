/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<UniformGroup<CachedEntity>>))]
public class UniformGroup<LAYOUT> : CachedEntityObject where LAYOUT : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static UniformGroup from(CachedEntity uniforms, System.Nullable<bool> _static = null, System.Nullable<bool> _ubo = null)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformGroup>(
                entity => new UniformGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "UniformGroup", "from" }, uniforms, _static, _ubo
                }
            );
        }

        public static UniformGroup uboFrom(CachedEntity uniforms, System.Nullable<bool> _static = null)
        {
            return EventHorizonBlazorInterop.FuncClass<UniformGroup>(
                entity => new UniformGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "UniformGroup", "uboFrom" }, uniforms, _static
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        private LAYOUT __uniforms;
        public LAYOUT uniforms
        {
            get
            {
            if(__uniforms == null)
            {
                __uniforms = EventHorizonBlazorInterop.GetClass<LAYOUT>(
                    this.___guid,
                    "uniforms",
                    (entity) =>
                    {
                        return new LAYOUT() { ___guid = entity.___guid };
                    }
                );
            }
            return __uniforms;
            }
        }

        
        public bool group
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "group"
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

        
        public CachedEntity syncUniforms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "syncUniforms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "syncUniforms",
                    value
                );
            }
        }

        
        public decimal dirtyId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dirtyId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dirtyId",
                    value
                );
            }
        }

        
        public bool static
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "static"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "static",
                    value
                );
            }
        }

        
        public bool ubo
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ubo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ubo",
                    value
                );
            }
        }

        private Buffer_2 __buffer;
        public Buffer_2 buffer
        {
            get
            {
            if(__buffer == null)
            {
                __buffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "buffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
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

        
        public bool autoManage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoManage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoManage",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public UniformGroup() : base() { }

        public UniformGroup(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public UniformGroup(
            LAYOUT uniforms, System.Nullable<bool> isStatic = null, System.Nullable<bool> isUbo = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "UniformGroup" },
                uniforms, isStatic, isUbo
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void add(string name, CachedEntity uniforms, System.Nullable<bool> _static = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "add" }, name, uniforms, _static
                }
            );
        }
    #endregion
}
