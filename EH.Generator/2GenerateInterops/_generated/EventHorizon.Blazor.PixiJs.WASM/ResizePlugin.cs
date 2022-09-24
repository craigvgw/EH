/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ResizePlugin>))]
public class ResizePlugin : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "ResizePlugin",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "ResizePlugin",
                    "extension",
                    value
                );
            }
        }

        private static Window __resizeTo;
        public static Window resizeTo
        {
            get
            {
            if(__resizeTo == null)
            {
                __resizeTo = EventHorizonBlazorInterop.GetClass<Window>(
                    "ResizePlugin",
                    "resizeTo",
                    (entity) =>
                    {
                        return new Window() { ___guid = entity.___guid };
                    }
                );
            }
            return __resizeTo;
            }
            set
            {
__resizeTo = null;
                EventHorizonBlazorInterop.Set(
                    "ResizePlugin",
                    "resizeTo",
                    value
                );
            }
        }

        
        public static Pick<Renderer, unknown> renderer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<Pick<Renderer, unknown>>(
                    "ResizePlugin",
                    "renderer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "ResizePlugin",
                    "renderer",
                    value
                );
            }
        }
    #endregion

    #region Static Methods
        #region resize TODO: Get Comments as metadata identification
        private static bool IsResizeEnabled = false;
        private static readonly IDictionary<string, Func<Task>> resizeActionMap = new Dictionary<string, Func<Task>>();

        public static string resize(
            Func<Task> callback
        )
        {
            SetupResizeStaticLoop();

            var handle = Guid.NewGuid().ToString();
            resizeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool resize_Remove(
            string handle
        )
        {
            return resizeActionMap.Remove(
                handle
            );
        }

        private static void SetupResizeStaticLoop()
        {
            if (IsResizeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.PixiJs.WASM",
                "ResizePlugin.resize",
                "CallResizeStaticActions"
            );
            IsResizeEnabled = true;
        }

        [JSInvokable]
        public static async Task CallResizeStaticActions()
        {
            foreach (var action in resizeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region queueResize TODO: Get Comments as metadata identification
        private static bool IsQueueResizeEnabled = false;
        private static readonly IDictionary<string, Func<Task>> queueResizeActionMap = new Dictionary<string, Func<Task>>();

        public static string queueResize(
            Func<Task> callback
        )
        {
            SetupQueueResizeStaticLoop();

            var handle = Guid.NewGuid().ToString();
            queueResizeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool queueResize_Remove(
            string handle
        )
        {
            return queueResizeActionMap.Remove(
                handle
            );
        }

        private static void SetupQueueResizeStaticLoop()
        {
            if (IsQueueResizeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.PixiJs.WASM",
                "ResizePlugin.queueResize",
                "CallQueueResizeStaticActions"
            );
            IsQueueResizeEnabled = true;
        }

        [JSInvokable]
        public static async Task CallQueueResizeStaticActions()
        {
            foreach (var action in queueResizeActionMap.Values)
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
                    new string[] { "ResizePlugin", "init" }, options
                }
            );
        }

        public static void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "ResizePlugin", "destroy" }
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public ResizePlugin() : base() { }

        public ResizePlugin(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
