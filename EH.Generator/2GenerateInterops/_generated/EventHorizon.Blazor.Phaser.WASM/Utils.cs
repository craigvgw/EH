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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Utils>))]
    public class Utils : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool SUPPORTS_TYPED_ARRAYS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "spine",
                    "Utils.SUPPORTS_TYPED_ARRAYS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "Utils.SUPPORTS_TYPED_ARRAYS",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static void arrayCopy<T>(T[] source, decimal sourceStart, T[] dest, decimal destStart, decimal numElements)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "spine", "Utils", "arrayCopy" }, source, sourceStart, dest, destStart, numElements
                }
            );
        }

        public static T[] setArraySize<T>(T[] array, decimal size, object value = null) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "spine", "Utils", "setArraySize" }, array, size, value
                }
            );
        }

        public static T[] ensureArrayCapacity<T>(T[] array, decimal size, object value = null) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "spine", "Utils", "ensureArrayCapacity" }, array, size, value
                }
            );
        }

        public static T[] newArray<T>(decimal size, T defaultValue) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "spine", "Utils", "newArray" }, size, defaultValue
                }
            );
        }

        public static decimal[] newFloatArray(decimal size)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "spine", "Utils", "newFloatArray" }, size
                }
            );
        }

        public static decimal[] newShortArray(decimal size)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "spine", "Utils", "newShortArray" }, size
                }
            );
        }

        public static decimal[] toFloatArray(decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "spine", "Utils", "toFloatArray" }, array
                }
            );
        }

        public static decimal toSinglePrecision(decimal value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "Utils", "toSinglePrecision" }, value
                }
            );
        }

        public static void webkit602BugfixHelper(decimal alpha, int blend)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "spine", "Utils", "webkit602BugfixHelper" }, alpha, blend
                }
            );
        }

        public static bool contains<T>(T[] array, T element, System.Nullable<bool> identity = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "spine", "Utils", "contains" }, array, element, identity
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Utils() : base() { }

        public Utils(
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