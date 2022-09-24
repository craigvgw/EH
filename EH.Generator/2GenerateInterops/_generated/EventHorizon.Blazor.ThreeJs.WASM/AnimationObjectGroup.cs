/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AnimationObjectGroup>))]
public class AnimationObjectGroup : CachedEntityObject
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

        
        public CachedEntity stats
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "stats",
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
                    "stats",
                    value
                );
            }
        }

        
        public unknown isAnimationObjectGroup
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isAnimationObjectGroup"
                );
            }
        }
    #endregion
    
    #region Constructor
        public AnimationObjectGroup() : base() { }

        public AnimationObjectGroup(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationObjectGroup(
            CachedEntity[] args
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AnimationObjectGroup" },
                args
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void add(CachedEntity[] args)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "add" }, args
                }
            );
        }

        public void remove(CachedEntity[] args)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, args
                }
            );
        }

        public void uncache(CachedEntity[] args)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uncache" }, args
                }
            );
        }
    #endregion
}
