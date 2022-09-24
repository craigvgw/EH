/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ShapePath>))]
public class ShapePath : CachedEntityObject
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
        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private Color __color;
        public Color color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public CachedEntity[] subPaths
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "subPaths",
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
                    "subPaths",
                    value
                );
            }
        }

        
        public CachedEntity currentPath
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "currentPath",
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
                    "currentPath",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ShapePath() : base() { }

        public ShapePath(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public ShapePath moveTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapePath>(
                entity => new ShapePath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveTo" }, x, y
                }
            );
        }

        public ShapePath lineTo(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapePath>(
                entity => new ShapePath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lineTo" }, x, y
                }
            );
        }

        public ShapePath quadraticCurveTo(decimal aCPx, decimal aCPy, decimal aX, decimal aY)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapePath>(
                entity => new ShapePath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quadraticCurveTo" }, aCPx, aCPy, aX, aY
                }
            );
        }

        public ShapePath bezierCurveTo(decimal aCP1x, decimal aCP1y, decimal aCP2x, decimal aCP2y, decimal aX, decimal aY)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapePath>(
                entity => new ShapePath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bezierCurveTo" }, aCP1x, aCP1y, aCP2x, aCP2y, aX, aY
                }
            );
        }

        public ShapePath splineThru(Vector2[] pts)
        {
            return EventHorizonBlazorInterop.FuncClass<ShapePath>(
                entity => new ShapePath() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "splineThru" }, pts
                }
            );
        }

        public Shape[] toShapes(bool isCCW)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Shape>(
                entity => new Shape() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toShapes" }, isCCW
                }
            );
        }
    #endregion
}
