/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TickerPlugin>))]
public class TickerPlugin : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "TickerPlugin",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TickerPlugin",
                    "extension",
                    value
                );
            }
        }

        private static Ticker __ticker;
        public static Ticker ticker
        {
            get
            {
            if(__ticker == null)
            {
                __ticker = EventHorizonBlazorInterop.GetClass<Ticker>(
                    "TickerPlugin",
                    "ticker",
                    (entity) =>
                    {
                        return new Ticker() { ___guid = entity.___guid };
                    }
                );
            }
            return __ticker;
            }
            set
            {
__ticker = null;
                EventHorizonBlazorInterop.Set(
                    "TickerPlugin",
                    "ticker",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        #region start TODO: Get Comments as metadata identification
        private static bool IsStartEnabled = false;
        private static readonly IDictionary<string, Func<Task>> startActionMap = new Dictionary<string, Func<Task>>();

        public static string start(
            Func<Task> callback
        )
        {
            SetupStartStaticLoop();

            var handle = Guid.NewGuid().ToString();
            startActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool start_Remove(
            string handle
        )
        {
            return startActionMap.Remove(
                handle
            );
        }

        private static void SetupStartStaticLoop()
        {
            if (IsStartEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.PixiJs.WASM",
                "TickerPlugin.start",
                "CallStartStaticActions"
            );
            IsStartEnabled = true;
        }

        [JSInvokable]
        public static async Task CallStartStaticActions()
        {
            foreach (var action in startActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region stop TODO: Get Comments as metadata identification
        private static bool IsStopEnabled = false;
        private static readonly IDictionary<string, Func<Task>> stopActionMap = new Dictionary<string, Func<Task>>();

        public static string stop(
            Func<Task> callback
        )
        {
            SetupStopStaticLoop();

            var handle = Guid.NewGuid().ToString();
            stopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool stop_Remove(
            string handle
        )
        {
            return stopActionMap.Remove(
                handle
            );
        }

        private static void SetupStopStaticLoop()
        {
            if (IsStopEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.PixiJs.WASM",
                "TickerPlugin.stop",
                "CallStopStaticActions"
            );
            IsStopEnabled = true;
        }

        [JSInvokable]
        public static async Task CallStopStaticActions()
        {
            foreach (var action in stopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static void init(IApplicationOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "TickerPlugin", "init" }, options
                }
            );
        }

        public static void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "TickerPlugin", "destroy" }
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public TickerPlugin() : base() { }

        public TickerPlugin(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
