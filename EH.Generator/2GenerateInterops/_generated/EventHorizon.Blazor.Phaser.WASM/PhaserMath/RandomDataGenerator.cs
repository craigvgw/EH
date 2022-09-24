/// Generated - Do Not Edit
namespace Phaser.PhaserMath
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RandomDataGenerator>))]
    public class RandomDataGenerator : CachedEntityObject
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
        
        public decimal[] signs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "signs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "signs",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RandomDataGenerator() : base() { }

        public RandomDataGenerator(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RandomDataGenerator(
            string seeds = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "PhaserMath", "RandomDataGenerator" },
                seeds
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void init(string seeds)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }, seeds
                }
            );
        }

        public void sow(string[] seeds)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sow" }, seeds
                }
            );
        }

        public decimal integer()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "integer" }
                }
            );
        }

        public decimal frac()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "frac" }
                }
            );
        }

        public decimal real()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "real" }
                }
            );
        }

        public decimal integerInRange(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "integerInRange" }, min, max
                }
            );
        }

        public decimal between(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "between" }, min, max
                }
            );
        }

        public decimal realInRange(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "realInRange" }, min, max
                }
            );
        }

        public decimal normal()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "normal" }
                }
            );
        }

        public string uuid()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "uuid" }
                }
            );
        }

        public T pick<T>(T[] array) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pick" }, array
                }
            );
        }

        public decimal sign()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "sign" }
                }
            );
        }

        public T weightedPick<T>(T[] array) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "weightedPick" }, array
                }
            );
        }

        public decimal timestamp(decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "timestamp" }, min, max
                }
            );
        }

        public decimal angle()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "angle" }
                }
            );
        }

        public decimal rotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "rotation" }
                }
            );
        }

        public string state(string state = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "state" }, state
                }
            );
        }

        public T[] shuffle<T>(T[] array = null) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shuffle" }, array
                }
            );
        }
        #endregion
    }
}