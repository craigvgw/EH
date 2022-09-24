/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface UVGenerator : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<UVGeneratorCachedEntity>))]
public class UVGeneratorCachedEntity : CachedEntityObject, UVGenerator
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
        public UVGeneratorCachedEntity() : base() { }

        public UVGeneratorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public Vector2[] generateTopUV(ExtrudeGeometry geometry, decimal[] vertices, decimal indexA, decimal indexB, decimal indexC)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateTopUV" }, geometry, vertices, indexA, indexB, indexC
                }
            );
        }

        public Vector2[] generateSideWallUV(ExtrudeGeometry geometry, decimal[] vertices, decimal indexA, decimal indexB, decimal indexC, decimal indexD)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "generateSideWallUV" }, geometry, vertices, indexA, indexB, indexC, indexD
                }
            );
        }
    #endregion
}
