/// Generated - Do Not Edit
namespace spine
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<MathUtils>))]
    public class MathUtils : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal PI
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.PI"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.PI",
                    value
                );
            }
        }

        
        public static decimal PI2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.PI2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.PI2",
                    value
                );
            }
        }

        
        public static decimal radiansToDegrees
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.radiansToDegrees"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.radiansToDegrees",
                    value
                );
            }
        }

        
        public static decimal radDeg
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.radDeg"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.radDeg",
                    value
                );
            }
        }

        
        public static decimal degreesToRadians
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.degreesToRadians"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.degreesToRadians",
                    value
                );
            }
        }

        
        public static decimal degRad
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "MathUtils.degRad"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "MathUtils.degRad",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static decimal clamp(decimal value, decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "clamp" }, value, min, max
                }
            );
        }

        public static decimal cosDeg(decimal degrees)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "cosDeg" }, degrees
                }
            );
        }

        public static decimal sinDeg(decimal degrees)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "sinDeg" }, degrees
                }
            );
        }

        public static decimal signum(decimal value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "signum" }, value
                }
            );
        }

        public static decimal toInt(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "toInt" }, x
                }
            );
        }

        public static decimal cbrt(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "cbrt" }, x
                }
            );
        }

        public static decimal randomTriangular(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "randomTriangular" }, min, max
                }
            );
        }

        public static decimal randomTriangularWith(decimal min, decimal max, decimal mode)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "MathUtils", "randomTriangularWith" }, min, max, mode
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public MathUtils() : base() { }

        public MathUtils(
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