/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CVertices>))]
    public class CVertices : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static CVector[] mean(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "mean" }, vertices
                }
            );
        }

        public static CVector[] clockwiseSort(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "clockwiseSort" }, vertices
                }
            );
        }

        public static bool isConvex(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "isConvex" }, vertices
                }
            );
        }

        public static CVector[] hull(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "hull" }, vertices
                }
            );
        }

        public static decimal area(CVector[] vertices, bool signed)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "area" }, vertices, signed
                }
            );
        }

        public static CVector centre(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "centre" }, vertices
                }
            );
        }

        public static void chamfer(CVector[] vertices, decimal radius, decimal quality, decimal qualityMin, decimal qualityMax)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "chamfer" }, vertices, radius, quality, qualityMin, qualityMax
                }
            );
        }

        public static bool contains(CVector[] vertices, CVector point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "contains" }, vertices, point
                }
            );
        }

        public static CVector[] create(CVector[] points, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "create" }, points, body
                }
            );
        }

        public static CVector[] fromPath(string path, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "fromPath" }, path, body
                }
            );
        }

        public static decimal inertia(CVector[] vertices, decimal mass)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "inertia" }, vertices, mass
                }
            );
        }

        public static void rotate(CVector[] vertices, decimal angle, CVector point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "rotate" }, vertices, angle, point
                }
            );
        }

        public static void scale(CVector[] vertices, decimal scaleX, decimal scaleY, CVector point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "scale" }, vertices, scaleX, scaleY, point
                }
            );
        }

        public static void translate(CVector[] vertices, CVector vector, decimal scalar)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CVertices", "translate" }, vertices, vector, scalar
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public CVertices() : base() { }

        public CVertices(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}