/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Bob>))]
    public class Bob : CachedEntityObject
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
        private Blitter __parent;
        public Blitter parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInterop.GetClass<Blitter>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Blitter() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public CachedEntity data
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "data"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public bool flipX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipX",
                    value
                );
            }
        }

        
        public bool flipY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "flipY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "flipY",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Bob() : base() { }

        public Bob(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Bob(
            Blitter blitter, decimal x, decimal y, string frame, bool visible
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Bob" },
                blitter, x, y, frame, visible
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Bob setFrame(string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFrame" }, frame
                }
            );
        }

        public Bob resetFlip()
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetFlip" }
                }
            );
        }

        public Bob reset(decimal x, decimal y, string frame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }, x, y, frame
                }
            );
        }

        public Bob setPosition(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y
                }
            );
        }

        public Bob setFlipX(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipX" }, value
                }
            );
        }

        public Bob setFlipY(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlipY" }, value
                }
            );
        }

        public Bob setFlip(bool x, bool y)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFlip" }, x, y
                }
            );
        }

        public Bob setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }

        public Bob setAlpha(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAlpha" }, value
                }
            );
        }

        public Bob setTint(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Bob>(
                entity => new Bob() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTint" }, value
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
        #endregion
    }
}