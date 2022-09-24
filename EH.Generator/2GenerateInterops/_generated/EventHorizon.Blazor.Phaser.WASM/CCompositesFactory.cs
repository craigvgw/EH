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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CCompositesFactory>))]
    public class CCompositesFactory : CachedEntityObject
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
        public CCompositesFactory() : base() { }

        public CCompositesFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CachedEntity car(decimal xx, decimal yy, decimal width, decimal height, decimal wheelSize)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "car" }, xx, yy, width, height, wheelSize
                }
            );
        }

        public CachedEntity chain(CachedEntity composite, decimal xOffsetA, decimal yOffsetA, decimal xOffsetB, decimal yOffsetB, object options)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "chain" }, composite, xOffsetA, yOffsetA, xOffsetB, yOffsetB, options
                }
            );
        }

        public CachedEntity mesh(CachedEntity composite, decimal columns, decimal rows, bool crossBrace, object options)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "mesh" }, composite, columns, rows, crossBrace, options
                }
            );
        }

        public CachedEntity newtonsCradle(decimal xx, decimal yy, decimal number, decimal size, decimal length)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "newtonsCradle" }, xx, yy, number, size, length
                }
            );
        }

        public CachedEntity softBody(decimal xx, decimal yy, decimal columns, decimal rows, decimal columnGap, decimal rowGap, bool crossBrace, decimal particleRadius, object particleOptions, object constraintOptions)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "softBody" }, xx, yy, columns, rows, columnGap, rowGap, crossBrace, particleRadius, particleOptions, constraintOptions
                }
            );
        }


        #endregion
    }
}