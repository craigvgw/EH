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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FacebookInstantGamesPlugin>))]
    public class FacebookInstantGamesPlugin : EventEmitter
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
        private Game __game;
        public Game game
        {
            get
            {
            if(__game == null)
            {
                __game = EventHorizonBlazorInterop.GetClass<Game>(
                    this.___guid,
                    "game",
                    (entity) =>
                    {
                        return new Game() { ___guid = entity.___guid };
                    }
                );
            }
            return __game;
            }
        }

        private DataManager __data;
        public DataManager data
        {
            get
            {
            if(__data == null)
            {
                __data = EventHorizonBlazorInterop.GetClass<DataManager>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new DataManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
            }
            set
            {
__data = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public bool hasLoaded
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasLoaded"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasLoaded",
                    value
                );
            }
        }

        
        public bool dataLocked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dataLocked"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dataLocked",
                    value
                );
            }
        }

        
        public string[] supportedAPIs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "supportedAPIs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "supportedAPIs",
                    value
                );
            }
        }

        
        public string entryPoint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "entryPoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "entryPoint",
                    value
                );
            }
        }

        
        public CachedEntity entryPointData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "entryPointData",
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
                    "entryPointData",
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

        
        public string contextType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "contextType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contextType",
                    value
                );
            }
        }

        
        public string locale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "locale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "locale",
                    value
                );
            }
        }

        
        public string platform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "platform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "platform",
                    value
                );
            }
        }

        
        public string version
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "version"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "version",
                    value
                );
            }
        }

        
        public string playerID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "playerID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playerID",
                    value
                );
            }
        }

        
        public string playerName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "playerName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playerName",
                    value
                );
            }
        }

        
        public string playerPhotoURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "playerPhotoURL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playerPhotoURL",
                    value
                );
            }
        }

        
        public bool playerCanSubscribeBot
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "playerCanSubscribeBot"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playerCanSubscribeBot",
                    value
                );
            }
        }

        
        public bool paymentsReady
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "paymentsReady"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "paymentsReady",
                    value
                );
            }
        }

        
        public CachedEntity[] catalog
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "catalog"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "catalog",
                    value
                );
            }
        }

        
        public CachedEntity[] purchases
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "purchases"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "purchases",
                    value
                );
            }
        }

        
        public FacebookInstantGamesLeaderboard[] leaderboards
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<FacebookInstantGamesLeaderboard>(
                    this.___guid,
                    "leaderboards",
                    (entity) =>
                    {
                        return new FacebookInstantGamesLeaderboard() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leaderboards",
                    value
                );
            }
        }

        
        public CachedEntity[] ads
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "ads"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ads",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FacebookInstantGamesPlugin() : base() { }

        public FacebookInstantGamesPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FacebookInstantGamesPlugin(
            Game game
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "FacebookInstantGamesPlugin" },
                game
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FacebookInstantGamesPlugin showLoadProgress(Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "showLoadProgress" }, scene
                }
            );
        }

        public void gameStarted()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "gameStarted" }
                }
            );
        }

        public bool checkAPI(string api)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "checkAPI" }, api
                }
            );
        }

        public string getID()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getID" }
                }
            );
        }

        public string getType()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getType" }
                }
            );
        }

        public string getLocale()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getLocale" }
                }
            );
        }

        public string getPlatform()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPlatform" }
                }
            );
        }

        public string getSDKVersion()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSDKVersion" }
                }
            );
        }

        public string getPlayerID()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPlayerID" }
                }
            );
        }

        public string getPlayerName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPlayerName" }
                }
            );
        }

        public string getPlayerPhotoURL()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPlayerPhotoURL" }
                }
            );
        }

        public FacebookInstantGamesPlugin loadPlayerPhoto(Scene scene, string key)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadPlayerPhoto" }, scene, key
                }
            );
        }

        public FacebookInstantGamesPlugin canSubscribeBot()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "canSubscribeBot" }
                }
            );
        }

        public FacebookInstantGamesPlugin subscribeBot()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subscribeBot" }
                }
            );
        }

        public FacebookInstantGamesPlugin getData(string keys)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getData" }, keys
                }
            );
        }

        public FacebookInstantGamesPlugin saveData(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveData" }, data
                }
            );
        }

        public FacebookInstantGamesPlugin flushData()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flushData" }
                }
            );
        }

        public FacebookInstantGamesPlugin getStats(string[] keys = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getStats" }, keys
                }
            );
        }

        public FacebookInstantGamesPlugin saveStats(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveStats" }, data
                }
            );
        }

        public FacebookInstantGamesPlugin incStats(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "incStats" }, data
                }
            );
        }

        public FacebookInstantGamesPlugin saveSession(object data)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "saveSession" }, data
                }
            );
        }

        public FacebookInstantGamesPlugin openShare(string text, string key, string frame = null, object sessionData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "openShare" }, text, key, frame, sessionData
                }
            );
        }

        public FacebookInstantGamesPlugin openInvite(string text, string key, string frame = null, object sessionData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "openInvite" }, text, key, frame, sessionData
                }
            );
        }

        public FacebookInstantGamesPlugin openRequest(string text, string key, string frame = null, object sessionData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "openRequest" }, text, key, frame, sessionData
                }
            );
        }

        public FacebookInstantGamesPlugin openChallenge(string text, string key, string frame = null, object sessionData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "openChallenge" }, text, key, frame, sessionData
                }
            );
        }

        public CachedEntity isSizeBetween(System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "isSizeBetween" }, min, max
                }
            );
        }

        public FacebookInstantGamesPlugin switchContext(string contextID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "switchContext" }, contextID
                }
            );
        }

        public FacebookInstantGamesPlugin chooseContext(CachedEntity options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "chooseContext" }, options
                }
            );
        }

        public FacebookInstantGamesPlugin createContext(string playerID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createContext" }, playerID
                }
            );
        }

        public FacebookInstantGamesPlugin getPlayers()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPlayers" }
                }
            );
        }

        public FacebookInstantGamesPlugin getCatalog()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCatalog" }
                }
            );
        }

        public CachedEntity getProduct(string productID)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getProduct" }, productID
                }
            );
        }

        public FacebookInstantGamesPlugin purchase(string productID, string developerPayload = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "purchase" }, productID, developerPayload
                }
            );
        }

        public FacebookInstantGamesPlugin getPurchases()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPurchases" }
                }
            );
        }

        public FacebookInstantGamesPlugin consumePurchase(string purchaseToken)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "consumePurchase" }, purchaseToken
                }
            );
        }

        public FacebookInstantGamesPlugin update(string cta, object text, string key, string frame, string template, object updateData)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, cta, text, key, frame, template, updateData
                }
            );
        }

        public FacebookInstantGamesPlugin updateLeaderboard(string cta, object text, string key, string frame, string template, object updateData)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateLeaderboard" }, cta, text, key, frame, template, updateData
                }
            );
        }

        public FacebookInstantGamesPlugin switchGame(string appID, object data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "switchGame" }, appID, data
                }
            );
        }

        public FacebookInstantGamesPlugin createShortcut()
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createShortcut" }
                }
            );
        }

        public void quit()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "quit" }
                }
            );
        }

        public FacebookInstantGamesPlugin log(string name, System.Nullable<decimal> value = null, object @params = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "log" }, name, value, @params
                }
            );
        }

        public FacebookInstantGamesPlugin preloadAds(string placementID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "preloadAds" }, placementID
                }
            );
        }

        public FacebookInstantGamesPlugin preloadVideoAds(string placementID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "preloadVideoAds" }, placementID
                }
            );
        }

        public FacebookInstantGamesPlugin showAd(string placementID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "showAd" }, placementID
                }
            );
        }

        public FacebookInstantGamesPlugin showVideo(string placementID)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "showVideo" }, placementID
                }
            );
        }

        public FacebookInstantGamesPlugin matchPlayer(string matchTag = null, System.Nullable<bool> switchImmediately = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "matchPlayer" }, matchTag, switchImmediately
                }
            );
        }

        public FacebookInstantGamesPlugin getLeaderboard(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<FacebookInstantGamesPlugin>(
                entity => new FacebookInstantGamesPlugin() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeaderboard" }, name
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