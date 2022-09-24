/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimationClip>))]
public class AnimationClip : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static AnimationClip CreateFromMorphTargetSequence(string name, MorphTarget[] morphTargetSequence, decimal fps, bool noLoop)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimationClip", "CreateFromMorphTargetSequence" }, name, morphTargetSequence, fps, noLoop
                }
            );
        }

        public static AnimationClip findByName(AnimationClip[] clipArray, string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimationClip", "findByName" }, clipArray, name
                }
            );
        }

        public static AnimationClip[] CreateClipsFromMorphTargetSequences(MorphTarget[] morphTargets, decimal fps, bool noLoop)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimationClip", "CreateClipsFromMorphTargetSequences" }, morphTargets, fps, noLoop
                }
            );
        }

        public static AnimationClip parse(object json)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimationClip", "parse" }, json
                }
            );
        }

        public static AnimationClip parseAnimation(object animation, Bone[] bones)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "AnimationClip", "parseAnimation" }, animation, bones
                }
            );
        }

        public static CachedEntity toJSON(AnimationClip clip)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "AnimationClip", "toJSON" }, clip
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public KeyframeTrack[] tracks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<KeyframeTrack>(
                    this.___guid,
                    "tracks",
                    (entity) =>
                    {
                        return new KeyframeTrack() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tracks",
                    value
                );
            }
        }

        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        
        public decimal duration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "duration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "duration",
                    value
                );
            }
        }

        
        public string uuid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uuid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uuid",
                    value
                );
            }
        }

        
        public CachedEntity[] results
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "results",
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
                    "results",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AnimationClip() : base() { }

        public AnimationClip(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationClip(
            string name = null, System.Nullable<decimal> duration = null, KeyframeTrack[] tracks = null, System.Nullable<int> blendMode = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimationClip" },
                name, duration, tracks, blendMode
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public AnimationClip resetDuration()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resetDuration" }
                }
            );
        }

        public AnimationClip trim()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "trim" }
                }
            );
        }

        public bool validate()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "validate" }
                }
            );
        }

        public AnimationClip optimize()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "optimize" }
                }
            );
        }

        public AnimationClip clone()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationClip>(
                entity => new AnimationClip() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity toJSON(AnimationClip clip)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }, clip
                }
            );
        }
    #endregion
}
