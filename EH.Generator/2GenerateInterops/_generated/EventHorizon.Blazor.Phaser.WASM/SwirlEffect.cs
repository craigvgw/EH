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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SwirlEffect>))]
    public class SwirlEffect : CachedEntityObject, VertexEffect
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static PowOut __interpolation;
        public static PowOut interpolation
        {
            get
            {
            if(__interpolation == null)
            {
                __interpolation = EventHorizonBlazorInterop.GetClass<PowOut>(
                    "spine",
                    "SwirlEffect.interpolation",
                    (entity) =>
                    {
                        return new PowOut() { ___guid = entity.___guid };
                    }
                );
            }
            return __interpolation;
            }
            set
            {
__interpolation = null;
                EventHorizonBlazorInterop.Set(
                    "spine",
                    "SwirlEffect.interpolation",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal centerX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerX",
                    value
                );
            }
        }

        
        public decimal centerY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "centerY",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SwirlEffect() : base() { }

        public SwirlEffect(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SwirlEffect(
            decimal radius
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "SwirlEffect" },
                radius
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void begin(Skeleton skeleton)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "begin" }, skeleton
                }
            );
        }

        public void transform(Vector2 position, Vector2 uv, Color light, Color dark)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "transform" }, position, uv, light, dark
                }
            );
        }

        public void end()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }
                }
            );
        }
        #endregion
    }
}