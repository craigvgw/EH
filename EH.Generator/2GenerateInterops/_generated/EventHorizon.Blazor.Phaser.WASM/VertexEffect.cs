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

    public interface VertexEffect : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<VertexEffectCachedEntity>))]
    public class VertexEffectCachedEntity : CachedEntityObject, VertexEffect
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
        public VertexEffectCachedEntity() : base() { }

        public VertexEffectCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
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