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

    
    
    [JsonConverter(typeof(CachedEntityConverter<JitterEffect>))]
    public class JitterEffect : CachedEntityObject, VertexEffect
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
        
        public decimal jitterX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "jitterX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "jitterX",
                    value
                );
            }
        }

        
        public decimal jitterY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "jitterY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "jitterY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public JitterEffect() : base() { }

        public JitterEffect(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public JitterEffect(
            decimal jitterX, decimal jitterY
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "JitterEffect" },
                jitterX, jitterY
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