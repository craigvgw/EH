/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Runner>))]
public class Runner : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public bool empty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "empty"
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
        }
    #endregion

    #region Properties
        
        public CachedEntity[] items
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "items",
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
                    "items",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Runner() : base() { }

        public Runner(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Runner(
            string name
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Runner" },
                name
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Runner emit(System.Nullable<unknown> a0 = null, System.Nullable<unknown> a1 = null, System.Nullable<unknown> a2 = null, System.Nullable<unknown> a3 = null, System.Nullable<unknown> a4 = null, System.Nullable<unknown> a5 = null, System.Nullable<unknown> a6 = null, System.Nullable<unknown> a7 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Runner>(
                entity => new Runner() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "emit" }, a0, a1, a2, a3, a4, a5, a6, a7
                }
            );
        }

        public Runner add(unknown item)
        {
            return EventHorizonBlazorInterop.FuncClass<Runner>(
                entity => new Runner() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, item
                }
            );
        }

        public Runner remove(unknown item)
        {
            return EventHorizonBlazorInterop.FuncClass<Runner>(
                entity => new Runner() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "remove" }, item
                }
            );
        }

        public bool contains(unknown item)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, item
                }
            );
        }

        public Runner removeAll()
        {
            return EventHorizonBlazorInterop.FuncClass<Runner>(
                entity => new Runner() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAll" }
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
