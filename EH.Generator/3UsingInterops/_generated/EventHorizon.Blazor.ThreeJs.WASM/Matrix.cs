/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Matrix : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MatrixCachedEntity>))]
public class MatrixCachedEntity : CachedEntityObject, Matrix
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
        
        public decimal[] elements
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "elements"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elements",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MatrixCachedEntity() : base() { }

        public MatrixCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public MatrixCachedEntity identity()
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "identity" }
                }
            );
        }

        public MatrixCachedEntity copy(Matrix m)
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, m
                }
            );
        }

        public MatrixCachedEntity multiplyScalar(decimal s)
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyScalar" }, s
                }
            );
        }

        public decimal determinant()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "determinant" }
                }
            );
        }

        public MatrixCachedEntity transpose()
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transpose" }
                }
            );
        }

        public MatrixCachedEntity invert()
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public MatrixCachedEntity clone()
        {
            return EventHorizonBlazorInterop.FuncClass<MatrixCachedEntity>(
                entity => new MatrixCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
    #endregion
}
