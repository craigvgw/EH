/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Program>))]
public class Program : CachedEntityObject
{
    #region Static Accessors
        
        public static string defaultVertexSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "Program",
                    "defaultVertexSrc"
                );
            }
        }

        
        public static string defaultFragmentSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "Program",
                    "defaultFragmentSrc"
                );
            }
        }
    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static Program from(string vertexSrc = null, string fragmentSrc = null, string name = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Program>(
                entity => new Program() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "Program", "from" }, vertexSrc, fragmentSrc, name
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
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

        
        public string vertexSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexSrc"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexSrc",
                    value
                );
            }
        }

        
        public string fragmentSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fragmentSrc"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fragmentSrc",
                    value
                );
            }
        }

        
        public CachedEntity nameCache
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "nameCache",
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
                    "nameCache",
                    value
                );
            }
        }

        
        public CachedEntity glPrograms
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "glPrograms",
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
                    "glPrograms",
                    value
                );
            }
        }

        
        public CachedEntity syncUniforms
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "syncUniforms",
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
                    "syncUniforms",
                    value
                );
            }
        }

        
        public CachedEntity attributeData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "attributeData",
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
                    "attributeData",
                    value
                );
            }
        }

        
        public CachedEntity uniformData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "uniformData",
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
                    "uniformData",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Program() : base() { }

        public Program(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Program(
            string vertexSrc = null, string fragmentSrc = null, string name = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Program" },
                vertexSrc, fragmentSrc, name
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
