/// Generated - Do Not Edit
namespace Phaser.GameObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IPathFollower : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IPathFollowerCachedEntity>))]
    public class IPathFollowerCachedEntity : CachedEntityObject, IPathFollower
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
        private Path __path;
        public Path path
        {
            get
            {
            if(__path == null)
            {
                __path = EventHorizonBlazorInterop.GetClass<Path>(
                    this.___guid,
                    "path",
                    (entity) =>
                    {
                        return new Path() { ___guid = entity.___guid };
                    }
                );
            }
            return __path;
            }
            set
            {
__path = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "path",
                    value
                );
            }
        }

        
        public bool rotateToPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotateToPath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotateToPath",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IPathFollowerCachedEntity() : base() { }

        public IPathFollowerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public IPathFollowerCachedEntity setPath(Path path, System.Nullable<decimal> config = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPath" }, path, config
                }
            );
        }

        public IPathFollowerCachedEntity setRotateToPath(bool value, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotateToPath" }, value, offset
                }
            );
        }

        public bool isFollowing()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFollowing" }
                }
            );
        }

        public IPathFollowerCachedEntity startFollow(System.Nullable<decimal> config = null, System.Nullable<decimal> startAt = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "startFollow" }, config, startAt
                }
            );
        }

        public IPathFollowerCachedEntity pauseFollow()
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pauseFollow" }
                }
            );
        }

        public IPathFollowerCachedEntity resumeFollow()
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "resumeFollow" }
                }
            );
        }

        public IPathFollowerCachedEntity stopFollow()
        {
            return EventHorizonBlazorInterop.FuncClass<IPathFollowerCachedEntity>(
                entity => new IPathFollowerCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stopFollow" }
                }
            );
        }

        public void pathUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pathUpdate" }
                }
            );
        }
        #endregion
    }
}