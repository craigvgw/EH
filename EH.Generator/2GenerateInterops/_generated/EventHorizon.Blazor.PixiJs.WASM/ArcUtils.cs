/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ArcUtils>))]
public class ArcUtils : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static IArcLikeShapeCachedEntity curveTo(decimal x1, decimal y1, decimal x2, decimal y2, decimal radius, decimal[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<IArcLikeShapeCachedEntity>(
                entity => new IArcLikeShapeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "ArcUtils", "curveTo" }, x1, y1, x2, y2, radius, points
                }
            );
        }

        public static void arc(decimal _startX, decimal _startY, decimal cx, decimal cy, decimal radius, decimal startAngle, decimal endAngle, bool _anticlockwise, decimal[] points)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "ArcUtils", "arc" }, _startX, _startY, cx, cy, radius, startAngle, endAngle, _anticlockwise, points
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public ArcUtils() : base() { }

        public ArcUtils(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
