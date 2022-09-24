/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Interpolant>))]
public class Interpolant : CachedEntityObject
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
        
        public CachedEntity parameterPositions
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parameterPositions",
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
                    "parameterPositions",
                    value
                );
            }
        }

        
        public CachedEntity sampleValues
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "sampleValues",
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
                    "sampleValues",
                    value
                );
            }
        }

        
        public decimal valueSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "valueSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueSize",
                    value
                );
            }
        }

        
        public CachedEntity resultBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "resultBuffer",
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
                    "resultBuffer",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Interpolant() : base() { }

        public Interpolant(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Interpolant(
            object parameterPositions, object sampleValues, decimal sampleSize, object resultBuffer = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Interpolant" },
                parameterPositions, sampleValues, sampleSize, resultBuffer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity evaluate(decimal time)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "evaluate" }, time
                }
            );
        }
    #endregion
}
