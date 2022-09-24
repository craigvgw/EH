/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebXRController>))]
public class WebXRController : CachedEntityObject
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

    #endregion
    
    #region Constructor
        public WebXRController() : base() { }

        public WebXRController(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public XRHandSpace getHandSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<XRHandSpace>(
                entity => new XRHandSpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHandSpace" }
                }
            );
        }

        public XRTargetRaySpace getTargetRaySpace()
        {
            return EventHorizonBlazorInterop.FuncClass<XRTargetRaySpace>(
                entity => new XRTargetRaySpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTargetRaySpace" }
                }
            );
        }

        public XRGripSpace getGripSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<XRGripSpace>(
                entity => new XRGripSpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getGripSpace" }
                }
            );
        }

        public WebXRController dispatchEvent(object @event)
        {
            return EventHorizonBlazorInterop.FuncClass<WebXRController>(
                entity => new WebXRController() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "dispatchEvent" }, @event
                }
            );
        }

        public WebXRController disconnect(XRInputSource inputSource)
        {
            return EventHorizonBlazorInterop.FuncClass<WebXRController>(
                entity => new WebXRController() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disconnect" }, inputSource
                }
            );
        }

        public WebXRController update(XRInputSource inputSource, XRFrame frame, XRReferenceSpace referenceSpace)
        {
            return EventHorizonBlazorInterop.FuncClass<WebXRController>(
                entity => new WebXRController() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, inputSource, frame, referenceSpace
                }
            );
        }
    #endregion
}
