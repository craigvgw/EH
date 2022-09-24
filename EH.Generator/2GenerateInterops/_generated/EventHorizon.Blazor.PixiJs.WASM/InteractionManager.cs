/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<InteractionManager>))]
public class InteractionManager : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "InteractionManager",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "InteractionManager",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public bool useSystemTicker
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSystemTicker"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useSystemTicker",
                    value
                );
            }
        }

        private DisplayObject __lastObjectRendered;
        public DisplayObject lastObjectRendered
        {
            get
            {
            if(__lastObjectRendered == null)
            {
                __lastObjectRendered = EventHorizonBlazorInterop.GetClass<DisplayObject>(
                    this.___guid,
                    "lastObjectRendered",
                    (entity) =>
                    {
                        return new DisplayObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __lastObjectRendered;
            }
        }
    #endregion

    #region Properties
        
        public CachedEntity activeInteractionData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "activeInteractionData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool supportsTouchEvents
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "supportsTouchEvents"
                );
            }
        }

        
        public bool supportsPointerEvents
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "supportsPointerEvents"
                );
            }
        }

        
        public InteractionData[] interactionDataPool
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<InteractionData>(
                    this.___guid,
                    "interactionDataPool",
                    (entity) =>
                    {
                        return new InteractionData() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interactionDataPool",
                    value
                );
            }
        }

        
        public string cursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cursor",
                    value
                );
            }
        }

        
        public DelayedEventCachedEntity[] delayedEvents
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<DelayedEventCachedEntity>(
                    this.___guid,
                    "delayedEvents",
                    (entity) =>
                    {
                        return new DelayedEventCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayedEvents",
                    value
                );
            }
        }

        private TreeSearch __search;
        public TreeSearch search
        {
            get
            {
            if(__search == null)
            {
                __search = EventHorizonBlazorInterop.GetClass<TreeSearch>(
                    this.___guid,
                    "search",
                    (entity) =>
                    {
                        return new TreeSearch() { ___guid = entity.___guid };
                    }
                );
            }
            return __search;
            }
            set
            {
__search = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "search",
                    value
                );
            }
        }

        private AbstractRenderer __renderer;
        public AbstractRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<AbstractRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new AbstractRenderer() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderer;
            }
            set
            {
__renderer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderer",
                    value
                );
            }
        }

        
        public bool autoPreventDefault
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoPreventDefault",
                    value
                );
            }
        }

        
        public decimal interactionFrequency
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "interactionFrequency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interactionFrequency",
                    value
                );
            }
        }

        private InteractionData __mouse;
        public InteractionData mouse
        {
            get
            {
            if(__mouse == null)
            {
                __mouse = EventHorizonBlazorInterop.GetClass<InteractionData>(
                    this.___guid,
                    "mouse",
                    (entity) =>
                    {
                        return new InteractionData() { ___guid = entity.___guid };
                    }
                );
            }
            return __mouse;
            }
            set
            {
__mouse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mouse",
                    value
                );
            }
        }

        private InteractionEvent __eventData;
        public InteractionEvent eventData
        {
            get
            {
            if(__eventData == null)
            {
                __eventData = EventHorizonBlazorInterop.GetClass<InteractionEvent>(
                    this.___guid,
                    "eventData",
                    (entity) =>
                    {
                        return new InteractionEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __eventData;
            }
            set
            {
__eventData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "eventData",
                    value
                );
            }
        }

        
        public bool moveWhenInside
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "moveWhenInside"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "moveWhenInside",
                    value
                );
            }
        }

// cursorStyles is not supported by the platform yet

        
        public string currentCursorMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "currentCursorMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentCursorMode",
                    value
                );
            }
        }

        
        public decimal resolution
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "resolution"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resolution",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public InteractionManager() : base() { }

        public InteractionManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InteractionManager(
            AbstractRenderer renderer, InteractionManagerOptions options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "InteractionManager" },
                renderer, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public DisplayObject hitTest(Point globalPoint, DisplayObject root = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DisplayObject>(
                entity => new DisplayObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "hitTest" }, globalPoint, root
                }
            );
        }

        public void setTargetElement(object element, System.Nullable<decimal> resolution = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTargetElement" }, element, resolution
                }
            );
        }

        public void tickerUpdate(decimal deltaTime)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "tickerUpdate" }, deltaTime
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void setCursorMode(string mode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCursorMode" }, mode
                }
            );
        }

        public void mapPositionToPoint(IPointData point, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "mapPositionToPoint" }, point, x, y
                }
            );
        }

        public void processInteractive(InteractionEvent interactionEvent, DisplayObject displayObject, ActionCallback<InteractionEvent, DisplayObject, bool> func = null, System.Nullable<bool> hitTest = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processInteractive" }, interactionEvent, displayObject, func, hitTest
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
