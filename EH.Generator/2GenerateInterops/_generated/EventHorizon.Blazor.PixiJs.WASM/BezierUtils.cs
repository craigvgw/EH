/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BezierUtils>))]
public class BezierUtils : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static decimal curveLength(decimal fromX, decimal fromY, decimal cpX, decimal cpY, decimal cpX2, decimal cpY2, decimal toX, decimal toY)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BezierUtils", "curveLength" }, fromX, fromY, cpX, cpY, cpX2, cpY2, toX, toY
                }
            );
        }

        public static void curveTo(decimal cpX, decimal cpY, decimal cpX2, decimal cpY2, decimal toX, decimal toY, decimal[] points)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BezierUtils", "curveTo" }, cpX, cpY, cpX2, cpY2, toX, toY, points
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public BezierUtils() : base() { }

        public BezierUtils(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
