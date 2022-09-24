/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IPoint : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IPointCachedEntity>))]
public class IPointCachedEntity : CachedEntityObject, IPoint
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

    #endregion
    
    #region Constructor
        public IPointCachedEntity() : base() { }

        public IPointCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public IPointCachedEntity copyFrom(IPointData p)
        {
            return EventHorizonBlazorInterop.FuncClass<IPointCachedEntity>(
                entity => new IPointCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, p
                }
            );
        }

        public T copyTo(T p)
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, p
                }
            );
        }

        public bool equals(IPointData p)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, p
                }
            );
        }

        public void set(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y
                }
            );
        }
    #endregion
}
