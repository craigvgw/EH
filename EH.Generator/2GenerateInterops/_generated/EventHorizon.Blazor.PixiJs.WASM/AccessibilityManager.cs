/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AccessibilityManager>))]
public class AccessibilityManager : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "AccessibilityManager",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "AccessibilityManager",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public bool isActive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isActive"
                );
            }
        }

        
        public bool isMobileAccessibility
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMobileAccessibility"
                );
            }
        }
    #endregion

    #region Properties
        
        public bool debug
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "debug"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debug",
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
    #endregion
    
    #region Constructor
        public AccessibilityManager() : base() { }

        public AccessibilityManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AccessibilityManager(
            AbstractRenderer renderer
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AccessibilityManager" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void updateDebugHTML(IAccessibleHTMLElement div)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDebugHTML" }, div
                }
            );
        }

        public void capHitArea(Rectangle hitArea)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "capHitArea" }, hitArea
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
