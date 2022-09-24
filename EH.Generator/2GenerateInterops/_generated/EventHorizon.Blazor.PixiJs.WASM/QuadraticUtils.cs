/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<QuadraticUtils>))]
public class QuadraticUtils : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static decimal curveLength(decimal fromX, decimal fromY, decimal cpX, decimal cpY, decimal toX, decimal toY)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "QuadraticUtils", "curveLength" }, fromX, fromY, cpX, cpY, toX, toY
                }
            );
        }

        public static void curveTo(decimal cpX, decimal cpY, decimal toX, decimal toY, decimal[] points)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "QuadraticUtils", "curveTo" }, cpX, cpY, toX, toY, points
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public QuadraticUtils() : base() { }

        public QuadraticUtils(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
