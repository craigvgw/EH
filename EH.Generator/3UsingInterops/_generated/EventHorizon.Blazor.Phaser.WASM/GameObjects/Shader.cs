/// Generated - Do Not Edit
namespace Phaser.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Shader>))]
    public class Shader : GameObject, IComputedSize, IDepth, IGetBounds, IMask, IOrigin, IScrollFactor, ITransform, IVisible
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
        private BaseShader __shader;
        public BaseShader shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<BaseShader>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new BaseShader() { ___guid = entity.___guid };
                    }
                );
            }
            return __shader;
            }
            set
            {
__shader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shader",
                    value
                );
            }
        }

        private CanvasRenderer __renderer;
        public CanvasRenderer renderer
        {
            get
            {
            if(__renderer == null)
            {
                __renderer = EventHorizonBlazorInterop.GetClass<CanvasRenderer>(
                    this.___guid,
                    "renderer",
                    (entity) =>
                    {
                        return new CanvasRenderer() { ___guid = entity.___guid };
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

        private WebGLRenderingContext __gl;
        public WebGLRenderingContext gl
        {
            get
            {
            if(__gl == null)
            {
                __gl = EventHorizonBlazorInterop.GetClass<WebGLRenderingContext>(
                    this.___guid,
                    "gl",
                    (entity) =>
                    {
                        return new WebGLRenderingContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __gl;
            }
            set
            {
__gl = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gl",
                    value
                );
            }
        }

        private ArrayBuffer __vertexData;
        public ArrayBuffer vertexData
        {
            get
            {
            if(__vertexData == null)
            {
                __vertexData = EventHorizonBlazorInterop.GetClass<ArrayBuffer>(
                    this.___guid,
                    "vertexData",
                    (entity) =>
                    {
                        return new ArrayBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexData;
            }
            set
            {
__vertexData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexData",
                    value
                );
            }
        }

        private WebGLBuffer __vertexBuffer;
        public WebGLBuffer vertexBuffer
        {
            get
            {
            if(__vertexBuffer == null)
            {
                __vertexBuffer = EventHorizonBlazorInterop.GetClass<WebGLBuffer>(
                    this.___guid,
                    "vertexBuffer",
                    (entity) =>
                    {
                        return new WebGLBuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __vertexBuffer;
            }
            set
            {
__vertexBuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexBuffer",
                    value
                );
            }
        }

        private WebGLProgram __program;
        public WebGLProgram program
        {
            get
            {
            if(__program == null)
            {
                __program = EventHorizonBlazorInterop.GetClass<WebGLProgram>(
                    this.___guid,
                    "program",
                    (entity) =>
                    {
                        return new WebGLProgram() { ___guid = entity.___guid };
                    }
                );
            }
            return __program;
            }
            set
            {
__program = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "program",
                    value
                );
            }
        }

        
        public decimal[] bytes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "bytes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bytes",
                    value
                );
            }
        }

        
        public decimal[] vertexViewF32
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "vertexViewF32"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexViewF32",
                    value
                );
            }
        }

        
        public decimal[] viewMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "viewMatrix"
                );
            }
        }

        
        public decimal[] projectionMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "projectionMatrix"
                );
            }
        }

        
        public CachedEntity uniforms
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "uniforms",
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
                    "uniforms",
                    value
                );
            }
        }

        private Pointer __pointer;
        public Pointer pointer
        {
            get
            {
            if(__pointer == null)
            {
                __pointer = EventHorizonBlazorInterop.GetClass<Pointer>(
                    this.___guid,
                    "pointer",
                    (entity) =>
                    {
                        return new Pointer() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointer;
            }
            set
            {
__pointer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointer",
                    value
                );
            }
        }

        private WebGLFramebuffer __framebuffer;
        public WebGLFramebuffer framebuffer
        {
            get
            {
            if(__framebuffer == null)
            {
                __framebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "framebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __framebuffer;
            }
            set
            {
__framebuffer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framebuffer",
                    value
                );
            }
        }

        private WebGLTexture __glTexture;
        public WebGLTexture glTexture
        {
            get
            {
            if(__glTexture == null)
            {
                __glTexture = EventHorizonBlazorInterop.GetClass<WebGLTexture>(
                    this.___guid,
                    "glTexture",
                    (entity) =>
                    {
                        return new WebGLTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __glTexture;
            }
            set
            {
__glTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "glTexture",
                    value
                );
            }
        }

        
        public bool renderToTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderToTexture"
                );
            }
        }

        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal displayWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayWidth",
                    value
                );
            }
        }

        
        public decimal displayHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayHeight",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        private BitmapMask __mask;
        public BitmapMask mask
        {
            get
            {
            if(__mask == null)
            {
                __mask = EventHorizonBlazorInterop.GetClass<BitmapMask>(
                    this.___guid,
                    "mask",
                    (entity) =>
                    {
                        return new BitmapMask() { ___guid = entity.___guid };
                    }
                );
            }
            return __mask;
            }
            set
            {
__mask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
            }
        }

        
        public decimal originX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originX",
                    value
                );
            }
        }

        
        public decimal originY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "originY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originY",
                    value
                );
            }
        }

        
        public decimal displayOriginX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginX",
                    value
                );
            }
        }

        
        public decimal displayOriginY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "displayOriginY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayOriginY",
                    value
                );
            }
        }

        
        public decimal scrollFactorX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorX",
                    value
                );
            }
        }

        
        public decimal scrollFactorY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scrollFactorY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scrollFactorY",
                    value
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
            }
        }

        
        public decimal scale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal scaleX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        
        public decimal scaleY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleY",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public bool visible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Shader() : base() { }

        public Shader(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Shader(
            Scene scene, string key, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, string[] textures = null, object textureData = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Phaser", "GameObjects", "Shader" },
                scene, key, x, y, width, height, textures, textureData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool willRender(Camera camera)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "willRender" }, camera
                }
            );
        }

        public Shader setRenderToTexture(string key = null, System.Nullable<bool> flipY = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRenderToTexture" }, key, flipY
                }
            );
        }

        public Shader setShader(string key, string[] textures = null, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShader" }, key, textures, textureData
                }
            );
        }

        public Shader setPointer(Pointer pointer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPointer" }, pointer
                }
            );
        }

        public void projOrtho(decimal left, decimal right, decimal bottom, decimal top)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "projOrtho" }, left, right, bottom, top
                }
            );
        }

        public Shader setSampler2DBuffer(string uniformKey, WebGLTexture texture, decimal width, decimal height, System.Nullable<decimal> textureIndex = null, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSampler2DBuffer" }, uniformKey, texture, width, height, textureIndex, textureData
                }
            );
        }

        public Shader setSampler2D(string uniformKey, string textureKey, System.Nullable<decimal> textureIndex = null, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSampler2D" }, uniformKey, textureKey, textureIndex, textureData
                }
            );
        }

        public Shader setUniform(string key, object value)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setUniform" }, key, value
                }
            );
        }

        public CachedEntity getUniform(string key)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getUniform" }, key
                }
            );
        }

        public Shader setChannel0(string textureKey, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setChannel0" }, textureKey, textureData
                }
            );
        }

        public Shader setChannel1(string textureKey, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setChannel1" }, textureKey, textureData
                }
            );
        }

        public Shader setChannel2(string textureKey, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setChannel2" }, textureKey, textureData
                }
            );
        }

        public Shader setChannel3(string textureKey, object textureData = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setChannel3" }, textureKey, textureData
                }
            );
        }

        public void load(TransformMatrix matrix2D = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, matrix2D
                }
            );
        }

        public void flush()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flush" }
                }
            );
        }

        public Shader setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public Shader setDisplaySize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplaySize" }, width, height
                }
            );
        }

        public Shader setDepth(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDepth" }, value
                }
            );
        }

        public O getCenter<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, output
                }
            );
        }

        public O getTopLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopLeft" }, output, includeParent
                }
            );
        }

        public O getTopCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopCenter" }, output, includeParent
                }
            );
        }

        public O getTopRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopRight" }, output, includeParent
                }
            );
        }

        public O getLeftCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftCenter" }, output, includeParent
                }
            );
        }

        public O getRightCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightCenter" }, output, includeParent
                }
            );
        }

        public O getBottomLeft<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomLeft" }, output, includeParent
                }
            );
        }

        public O getBottomCenter<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomCenter" }, output, includeParent
                }
            );
        }

        public O getBottomRight<O>(O output = null, System.Nullable<bool> includeParent = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomRight" }, output, includeParent
                }
            );
        }

        public O getBounds<O>(O output = null) where O : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, output
                }
            );
        }

        public Shader setMask(BitmapMask mask)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMask" }, mask
                }
            );
        }

        public Shader clearMask(System.Nullable<bool> destroyMask = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clearMask" }, destroyMask
                }
            );
        }

        public BitmapMask createBitmapMask(GameObject renderable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapMask>(
                entity => new BitmapMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBitmapMask" }, renderable
                }
            );
        }

        public GeometryMask createGeometryMask(Graphics graphics = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometryMask>(
                entity => new GeometryMask() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createGeometryMask" }, graphics
                }
            );
        }

        public Shader setOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOrigin" }, x, y
                }
            );
        }

        public Shader setOriginFromFrame()
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setOriginFromFrame" }
                }
            );
        }

        public Shader setDisplayOrigin(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDisplayOrigin" }, x, y
                }
            );
        }

        public Shader updateDisplayOrigin()
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateDisplayOrigin" }
                }
            );
        }

        public Shader setScrollFactor(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScrollFactor" }, x, y
                }
            );
        }

        public Shader setPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, x, y, z, w
                }
            );
        }

        public Shader copyPosition(Vector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyPosition" }, source
                }
            );
        }

        public Shader setRandomPosition(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRandomPosition" }, x, y, width, height
                }
            );
        }

        public Shader setRotation(System.Nullable<decimal> radians = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, radians
                }
            );
        }

        public Shader setAngle(System.Nullable<decimal> degrees = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, degrees
                }
            );
        }

        public Shader setScale(decimal x, System.Nullable<decimal> y = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, x, y
                }
            );
        }

        public Shader setX(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setX" }, value
                }
            );
        }

        public Shader setY(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setY" }, value
                }
            );
        }

        public Shader setZ(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setZ" }, value
                }
            );
        }

        public Shader setW(System.Nullable<decimal> value = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setW" }, value
                }
            );
        }

        public TransformMatrix getLocalTransformMatrix(TransformMatrix tempMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalTransformMatrix" }, tempMatrix
                }
            );
        }

        public TransformMatrix getWorldTransformMatrix(TransformMatrix tempMatrix = null, TransformMatrix parentMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformMatrix>(
                entity => new TransformMatrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldTransformMatrix" }, tempMatrix, parentMatrix
                }
            );
        }

        public Vector2 getLocalPoint(decimal x, decimal y, Vector2 point = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPoint" }, x, y, point, camera
                }
            );
        }

        public decimal getParentRotation()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getParentRotation" }
                }
            );
        }

        public Shader setVisible(bool value)
        {
            return EventHorizonBlazorInterop.FuncClass<Shader>(
                entity => new Shader() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVisible" }, value
                }
            );
        }
        #endregion
    }
}