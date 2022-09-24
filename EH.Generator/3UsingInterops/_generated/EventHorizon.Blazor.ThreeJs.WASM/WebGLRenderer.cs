/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLRenderer>))]
public class WebGLRenderer : CachedEntityObject, Renderer
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
        private HTMLCanvasElement __domElement;
        public HTMLCanvasElement domElement
        {
            get
            {
            if(__domElement == null)
            {
                __domElement = EventHorizonBlazorInterop.GetClass<HTMLCanvasElement>(
                    this.___guid,
                    "domElement",
                    (entity) =>
                    {
                        return new HTMLCanvasElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __domElement;
            }
            set
            {
__domElement = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "domElement",
                    value
                );
            }
        }

        
        public bool autoClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
            }
        }

        
        public bool autoClearColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClearColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClearColor",
                    value
                );
            }
        }

        
        public bool autoClearDepth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClearDepth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClearDepth",
                    value
                );
            }
        }

        
        public bool autoClearStencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClearStencil"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClearStencil",
                    value
                );
            }
        }

        private WebGLDebugCachedEntity __debug;
        public WebGLDebugCachedEntity debug
        {
            get
            {
            if(__debug == null)
            {
                __debug = EventHorizonBlazorInterop.GetClass<WebGLDebugCachedEntity>(
                    this.___guid,
                    "debug",
                    (entity) =>
                    {
                        return new WebGLDebugCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __debug;
            }
            set
            {
__debug = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "debug",
                    value
                );
            }
        }

        
        public bool sortObjects
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sortObjects"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sortObjects",
                    value
                );
            }
        }

        
        public CachedEntity[] clippingPlanes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    this.___guid,
                    "clippingPlanes",
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
                    "clippingPlanes",
                    value
                );
            }
        }

        
        public bool localClippingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "localClippingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localClippingEnabled",
                    value
                );
            }
        }

        private WebGLExtensions __extensions;
        public WebGLExtensions extensions
        {
            get
            {
            if(__extensions == null)
            {
                __extensions = EventHorizonBlazorInterop.GetClass<WebGLExtensions>(
                    this.___guid,
                    "extensions",
                    (entity) =>
                    {
                        return new WebGLExtensions() { ___guid = entity.___guid };
                    }
                );
            }
            return __extensions;
            }
            set
            {
__extensions = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extensions",
                    value
                );
            }
        }

        
        public int outputEncoding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "outputEncoding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outputEncoding",
                    value
                );
            }
        }

        
        public bool physicallyCorrectLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "physicallyCorrectLights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physicallyCorrectLights",
                    value
                );
            }
        }

        
        public int toneMapping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "toneMapping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMapping",
                    value
                );
            }
        }

        
        public decimal toneMappingExposure
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toneMappingExposure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingExposure",
                    value
                );
            }
        }

        private WebGLInfo __info;
        public WebGLInfo info
        {
            get
            {
            if(__info == null)
            {
                __info = EventHorizonBlazorInterop.GetClass<WebGLInfo>(
                    this.___guid,
                    "info",
                    (entity) =>
                    {
                        return new WebGLInfo() { ___guid = entity.___guid };
                    }
                );
            }
            return __info;
            }
            set
            {
__info = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "info",
                    value
                );
            }
        }

        private WebGLShadowMap __shadowMap;
        public WebGLShadowMap shadowMap
        {
            get
            {
            if(__shadowMap == null)
            {
                __shadowMap = EventHorizonBlazorInterop.GetClass<WebGLShadowMap>(
                    this.___guid,
                    "shadowMap",
                    (entity) =>
                    {
                        return new WebGLShadowMap() { ___guid = entity.___guid };
                    }
                );
            }
            return __shadowMap;
            }
            set
            {
__shadowMap = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMap",
                    value
                );
            }
        }

        
        public decimal pixelRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pixelRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pixelRatio",
                    value
                );
            }
        }

        private WebGLCapabilities __capabilities;
        public WebGLCapabilities capabilities
        {
            get
            {
            if(__capabilities == null)
            {
                __capabilities = EventHorizonBlazorInterop.GetClass<WebGLCapabilities>(
                    this.___guid,
                    "capabilities",
                    (entity) =>
                    {
                        return new WebGLCapabilities() { ___guid = entity.___guid };
                    }
                );
            }
            return __capabilities;
            }
            set
            {
__capabilities = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "capabilities",
                    value
                );
            }
        }

        private WebGLProperties __properties;
        public WebGLProperties properties
        {
            get
            {
            if(__properties == null)
            {
                __properties = EventHorizonBlazorInterop.GetClass<WebGLProperties>(
                    this.___guid,
                    "properties",
                    (entity) =>
                    {
                        return new WebGLProperties() { ___guid = entity.___guid };
                    }
                );
            }
            return __properties;
            }
            set
            {
__properties = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "properties",
                    value
                );
            }
        }

        private WebGLRenderLists __renderLists;
        public WebGLRenderLists renderLists
        {
            get
            {
            if(__renderLists == null)
            {
                __renderLists = EventHorizonBlazorInterop.GetClass<WebGLRenderLists>(
                    this.___guid,
                    "renderLists",
                    (entity) =>
                    {
                        return new WebGLRenderLists() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderLists;
            }
            set
            {
__renderLists = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderLists",
                    value
                );
            }
        }

        private WebGLState __state;
        public WebGLState state
        {
            get
            {
            if(__state == null)
            {
                __state = EventHorizonBlazorInterop.GetClass<WebGLState>(
                    this.___guid,
                    "state",
                    (entity) =>
                    {
                        return new WebGLState() { ___guid = entity.___guid };
                    }
                );
            }
            return __state;
            }
            set
            {
__state = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        private WebXRManager __xr;
        public WebXRManager xr
        {
            get
            {
            if(__xr == null)
            {
                __xr = EventHorizonBlazorInterop.GetClass<WebXRManager>(
                    this.___guid,
                    "xr",
                    (entity) =>
                    {
                        return new WebXRManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __xr;
            }
            set
            {
__xr = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xr",
                    value
                );
            }
        }

        
        public bool vr
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vr"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vr",
                    value
                );
            }
        }

        
        public bool shadowMapEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowMapEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMapEnabled",
                    value
                );
            }
        }

        
        public int shadowMapType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "shadowMapType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMapType",
                    value
                );
            }
        }

        
        public int shadowMapCullFace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "shadowMapCullFace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMapCullFace",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLRenderer() : base() { }

        public WebGLRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebGLRenderer(
            WebGLRendererParameters parameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLRenderer" },
                parameters
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public WebGLRenderingContext getContext()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderingContext>(
                entity => new WebGLRenderingContext() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" }
                }
            );
        }

        public CachedEntity getContextAttributes()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getContextAttributes" }
                }
            );
        }

        public void forceContextLoss()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceContextLoss" }
                }
            );
        }

        public void forceContextRestore()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceContextRestore" }
                }
            );
        }

        public decimal getMaxAnisotropy()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getMaxAnisotropy" }
                }
            );
        }

        public string getPrecision()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getPrecision" }
                }
            );
        }

        public decimal getPixelRatio()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPixelRatio" }
                }
            );
        }

        public void setPixelRatio(decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPixelRatio" }, value
                }
            );
        }

        public Vector2 getDrawingBufferSize(Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDrawingBufferSize" }, target
                }
            );
        }

        public void setDrawingBufferSize(decimal width, decimal height, decimal pixelRatio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDrawingBufferSize" }, width, height, pixelRatio
                }
            );
        }

        public Vector2 getSize(Vector2 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSize" }, target
                }
            );
        }

        public void setSize(decimal width, decimal height, System.Nullable<bool> updateStyle = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height, updateStyle
                }
            );
        }

        public Vector4 getCurrentViewport(Vector4 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCurrentViewport" }, target
                }
            );
        }

        public Vector4 getViewport(Vector4 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getViewport" }, target
                }
            );
        }

        public void setViewport(Vector4 x, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" }, x, y, width, height
                }
            );
        }

        public Vector4 getScissor(Vector4 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScissor" }, target
                }
            );
        }

        public void setScissor(Vector4 x, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScissor" }, x, y, width, height
                }
            );
        }

        public bool getScissorTest()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getScissorTest" }
                }
            );
        }

        public void setScissorTest(bool enable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScissorTest" }, enable
                }
            );
        }

        public void setOpaqueSort(ActionResultCallback<object, object, decimal> method)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setOpaqueSort" }, method
                }
            );
        }

        public void setTransparentSort(ActionResultCallback<object, object, decimal> method)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransparentSort" }, method
                }
            );
        }

        public Color getClearColor(Color target)
        {
            return EventHorizonBlazorInterop.FuncClass<Color>(
                entity => new Color() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getClearColor" }, target
                }
            );
        }

        public void setClearColor(Color color, System.Nullable<decimal> alpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setClearColor" }, color, alpha
                }
            );
        }

        public decimal getClearAlpha()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getClearAlpha" }
                }
            );
        }

        public void setClearAlpha(decimal alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setClearAlpha" }, alpha
                }
            );
        }

        public void clear(System.Nullable<bool> color = null, System.Nullable<bool> depth = null, System.Nullable<bool> stencil = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, color, depth, stencil
                }
            );
        }

        public void clearColor()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearColor" }
                }
            );
        }

        public void clearDepth()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearDepth" }
                }
            );
        }

        public void clearStencil()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearStencil" }
                }
            );
        }

        public void clearTarget(WebGLRenderTarget renderTarget, bool color, bool depth, bool stencil)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearTarget" }, renderTarget, color, depth, stencil
                }
            );
        }

        public void resetGLState()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetGLState" }
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

        public void renderBufferDirect(Camera camera, Scene scene, BufferGeometry geometry, Material material, Object3D @object, object geometryGroup)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "renderBufferDirect" }, camera, scene, geometry, material, @object, geometryGroup
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

        #region animate TODO: Get Comments as metadata identification
        private bool _isAnimateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _animateActionMap = new Dictionary<string, Func<Task>>();

        public string animate(
            Func<Task> callback
        )
        {
            SetupAnimateLoop();

            var handle = Guid.NewGuid().ToString();
            _animateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool animate_Remove(
            string handle
        )
        {
            return _animateActionMap.Remove(
                handle
            );
        }

        private void SetupAnimateLoop()
        {
            if (_isAnimateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "animate",
                "CallAnimateActions",
                _invokableReference
            );
            _isAnimateEnabled = true;
        }

        [JSInvokable]
        public async Task CallAnimateActions()
        {
            foreach (var action in _animateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void compile(Object3D scene, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compile" }, scene, camera
                }
            );
        }

        public void render(Object3D scene, Camera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, scene, camera
                }
            );
        }

        public decimal getActiveCubeFace()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveCubeFace" }
                }
            );
        }

        public decimal getActiveMipmapLevel()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveMipmapLevel" }
                }
            );
        }

        public WebGLRenderTarget getRenderTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRenderTarget" }
                }
            );
        }

        public WebGLRenderTarget getCurrentRenderTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLRenderTarget>(
                entity => new WebGLRenderTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCurrentRenderTarget" }
                }
            );
        }

        public void setRenderTarget(WebGLRenderTarget renderTarget = null, System.Nullable<decimal> activeCubeFace = null, System.Nullable<decimal> activeMipmapLevel = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderTarget" }, renderTarget, activeCubeFace, activeMipmapLevel
                }
            );
        }

        public void readRenderTargetPixels(WebGLRenderTarget renderTarget, decimal x, decimal y, decimal width, decimal height, object buffer, System.Nullable<decimal> activeCubeFaceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "readRenderTargetPixels" }, renderTarget, x, y, width, height, buffer, activeCubeFaceIndex
                }
            );
        }

        public void copyFramebufferToTexture(Vector2 position, Texture texture, System.Nullable<decimal> level = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyFramebufferToTexture" }, position, texture, level
                }
            );
        }

        public void copyTextureToTexture(Vector2 position, Texture srcTexture, Texture dstTexture, System.Nullable<decimal> level = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTextureToTexture" }, position, srcTexture, dstTexture, level
                }
            );
        }

        public void copyTextureToTexture3D(Box3 sourceBox, Vector3 position, Texture srcTexture, Data3DTexture dstTexture, System.Nullable<decimal> level = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTextureToTexture3D" }, sourceBox, position, srcTexture, dstTexture, level
                }
            );
        }

        public void initTexture(Texture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initTexture" }, texture
                }
            );
        }

        public void resetState()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetState" }
                }
            );
        }

        public CachedEntity supportsFloatTextures()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsFloatTextures" }
                }
            );
        }

        public CachedEntity supportsHalfFloatTextures()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsHalfFloatTextures" }
                }
            );
        }

        public CachedEntity supportsStandardDerivatives()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsStandardDerivatives" }
                }
            );
        }

        public CachedEntity supportsCompressedTextureS3TC()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsCompressedTextureS3TC" }
                }
            );
        }

        public CachedEntity supportsCompressedTexturePVRTC()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsCompressedTexturePVRTC" }
                }
            );
        }

        public CachedEntity supportsBlendMinMax()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsBlendMinMax" }
                }
            );
        }

        public CachedEntity supportsVertexTextures()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsVertexTextures" }
                }
            );
        }

        public CachedEntity supportsInstancedArrays()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "supportsInstancedArrays" }
                }
            );
        }

        public CachedEntity enableScissorTest(object boolean)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableScissorTest" }, boolean
                }
            );
        }
    #endregion
}
