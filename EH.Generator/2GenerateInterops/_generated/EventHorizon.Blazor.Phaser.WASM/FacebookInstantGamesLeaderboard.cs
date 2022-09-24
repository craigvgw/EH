/// Generated - Do Not Edit
namespace Phaser
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<FacebookInstantGamesLeaderboard>))]
    public class FacebookInstantGamesLeaderboard : EventEmitter
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
        private FacebookInstantGamesPlugin __plugin;
        public FacebookInstantGamesPlugin plugin
        {
            get
            {
            if(__plugin == null)
            {
                __plugin = EventHorizonBlazorInterop.GetClass<FacebookInstantGamesPlugin>(
                    this.___guid,
                    "plugin",
                    (entity) =>
                    {
                        return new FacebookInstantGamesPlugin() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugin;
            }
            set
            {
__plugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
            }
        }

        
        public CachedEntity @ref
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "ref",
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
                    "ref",
                    value
                );
            }
        }

        
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

        
        public string contextID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "contextID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contextID",
                    value
                );
            }
        }

        
        public decimal entryCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "entryCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "entryCount",
                    value
                );
            }
        }

        
        public CachedEntity playerScore
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "playerScore"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playerScore",
                    value
                );
            }
        }

        
        public CachedEntity[] scores
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "scores"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scores",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FacebookInstantGamesLeaderboard() : base() { }

        public FacebookInstantGamesLeaderboard(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FacebookInstantGamesLeaderboard(
            FacebookInstantGamesPlugin plugin, object data
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "FacebookInstantGamesLeaderboard" },
                plugin, data
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FacebookInstantGamesLeaderboard getEntryCount()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesLeaderboard>(
                entity => new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEntryCount" }
                }
            );
        }

        public FacebookInstantGamesLeaderboard setScore(decimal score, string data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesLeaderboard>(
                entity => new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScore" }, score, data
                }
            );
        }

        public FacebookInstantGamesLeaderboard getPlayerScore()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesLeaderboard>(
                entity => new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPlayerScore" }
                }
            );
        }

        public FacebookInstantGamesLeaderboard getScores(System.Nullable<decimal> count = null, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesLeaderboard>(
                entity => new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScores" }, count, offset
                }
            );
        }

        public FacebookInstantGamesLeaderboard getConnectedScores()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesLeaderboard>(
                entity => new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getConnectedScores" }
                }
            );
        }
        #endregion
    }
}