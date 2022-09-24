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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationStateData>))]
    public class AnimationStateData : CachedEntityObject
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
        private SkeletonData __skeletonData;
        public SkeletonData skeletonData
        {
            get
            {
            if(__skeletonData == null)
            {
                __skeletonData = EventHorizonBlazorInterop.GetClass<SkeletonData>(
                    this.___guid,
                    "skeletonData",
                    (entity) =>
                    {
                        return new SkeletonData() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeletonData;
            }
            set
            {
__skeletonData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonData",
                    value
                );
            }
        }

// animationToMixTime is not supported by the platform yet

        
        public decimal defaultMix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultMix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultMix",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationStateData() : base() { }

        public AnimationStateData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationStateData(
            SkeletonData skeletonData
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "spine", "AnimationStateData" },
                skeletonData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setMix(string fromName, string toName, decimal duration)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMix" }, fromName, toName, duration
                }
            );
        }

        public void setMixWith(string from, string to, decimal duration)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMixWith" }, from, to, duration
                }
            );
        }

        public decimal getMix(string from, string to)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMix" }, from, to
                }
            );
        }
        #endregion
    }
}