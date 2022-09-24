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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CVerticesFactory>))]
    public class CVerticesFactory : CachedEntityObject
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
        public CVerticesFactory() : base() { }

        public CVerticesFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CVector[] mean(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mean" }, vertices
                }
            );
        }

        public CVector[] clockwiseSort(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clockwiseSort" }, vertices
                }
            );
        }

        public bool isConvex(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isConvex" }, vertices
                }
            );
        }

        public CVector[] hull(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "hull" }, vertices
                }
            );
        }

        public decimal area(CVector[] vertices, bool signed)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "area" }, vertices, signed
                }
            );
        }

        public CVector centre(CVector[] vertices)
        {
            return EventHorizonBlazorInterop.FuncClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "centre" }, vertices
                }
            );
        }

        public void chamfer(CVector[] vertices, decimal radius, decimal quality, decimal qualityMin, decimal qualityMax)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "chamfer" }, vertices, radius, quality, qualityMin, qualityMax
                }
            );
        }

        public bool contains(CVector[] vertices, CVector point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, vertices, point
                }
            );
        }

        public CVector[] create(CVector[] points, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "create" }, points, body
                }
            );
        }

        public CVector[] fromPath(string path, CachedEntity body)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<CVector>(
                entity => new CVector() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromPath" }, path, body
                }
            );
        }

        public decimal inertia(CVector[] vertices, decimal mass)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "inertia" }, vertices, mass
                }
            );
        }

        public void rotate(CVector[] vertices, decimal angle, CVector point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, vertices, angle, point
                }
            );
        }

        public void scale(CVector[] vertices, decimal scaleX, decimal scaleY, CVector point)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, vertices, scaleX, scaleY, point
                }
            );
        }

        public void translate(CVector[] vertices, CVector vector, decimal scalar)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, vertices, vector, scalar
                }
            );
        }
        #endregion
    }
}