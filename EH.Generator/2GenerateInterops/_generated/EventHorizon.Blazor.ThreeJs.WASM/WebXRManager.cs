/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebXRManager>))]
public class WebXRManager : EventDispatcher
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
        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
            }
        }

        
        public bool isPresenting
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPresenting"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPresenting",
                    value
                );
            }
        }

        
        public bool cameraAutoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraAutoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraAutoUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebXRManager() : base() { }

        public WebXRManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebXRManager(
            object renderer, WebGLRenderingContext gl
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebXRManager" },
                renderer, gl
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public XRTargetRaySpace getController(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<XRTargetRaySpace>(
                entity => new XRTargetRaySpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getController" }, index
                }
            );
        }

        public XRGripSpace getControllerGrip(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<XRGripSpace>(
                entity => new XRGripSpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getControllerGrip" }, index
                }
            );
        }

        public XRHandSpace getHand(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<XRHandSpace>(
                entity => new XRHandSpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHand" }, index
                }
            );
        }

        public void setFramebufferScaleFactor(decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFramebufferScaleFactor" }, value
                }
            );
        }

        public void setReferenceSpaceType(XRReferenceSpaceType value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setReferenceSpaceType" }, value
                }
            );
        }

        public XRReferenceSpace getReferenceSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<XRReferenceSpace>(
                entity => new XRReferenceSpace() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getReferenceSpace" }
                }
            );
        }

        public void setReferenceSpace(XRReferenceSpace value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setReferenceSpace" }, value
                }
            );
        }

        public XRWebGLLayer getBaseLayer()
        {
            return EventHorizonBlazorInterop.FuncClass<XRWebGLLayer>(
                entity => new XRWebGLLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBaseLayer" }
                }
            );
        }

        public XRWebGLBinding getBinding()
        {
            return EventHorizonBlazorInterop.FuncClass<XRWebGLBinding>(
                entity => new XRWebGLBinding() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBinding" }
                }
            );
        }

        public XRFrame getFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<XRFrame>(
                entity => new XRFrame() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrame" }
                }
            );
        }

        public XRSession getSession()
        {
            return EventHorizonBlazorInterop.FuncClass<XRSession>(
                entity => new XRSession() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSession" }
                }
            );
        }

        public async ValueTask setSession(XRSession value)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSession" }, value
                }
            );
        }

        public WebXRCamera getCamera()
        {
            return EventHorizonBlazorInterop.Func<WebXRCamera>(
                new object[]
                {
                    new string[] { this.___guid, "getCamera" }
                }
            );
        }

        public void updateCamera(PerspectiveCamera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCamera" }, camera
                }
            );
        }

        public void setAnimationLoop(XRFrameRequestCallback callback = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAnimationLoop" }, callback
                }
            );
        }

        public decimal getFoveation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFoveation" }
                }
            );
        }

        public void setFoveation(decimal foveation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFoveation" }, foveation
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
    #endregion
}
