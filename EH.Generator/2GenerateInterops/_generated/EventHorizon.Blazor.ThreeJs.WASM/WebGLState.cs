/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLState>))]
public class WebGLState : CachedEntityObject
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
        
        public CachedEntity buffers
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "buffers",
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
                    "buffers",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public WebGLState() : base() { }

        public WebGLState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLState(
            WebGLRenderingContext gl, WebGLExtensions extensions, WebGLCapabilities capabilities
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLState" },
                gl, extensions, capabilities
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void initAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initAttributes" }
                }
            );
        }

        public void enableAttribute(decimal attribute)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableAttribute" }, attribute
                }
            );
        }

        public void enableAttributeAndDivisor(decimal attribute, decimal meshPerAttribute)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableAttributeAndDivisor" }, attribute, meshPerAttribute
                }
            );
        }

        public void disableUnusedAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableUnusedAttributes" }
                }
            );
        }

        public void vertexAttribPointer(decimal index, decimal size, decimal type, bool normalized, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "vertexAttribPointer" }, index, size, type, normalized, stride, offset
                }
            );
        }

        public void enable(decimal id)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enable" }, id
                }
            );
        }

        public void disable(decimal id)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disable" }, id
                }
            );
        }

        public void bindFramebuffer(decimal target, WebGLFramebuffer framebuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindFramebuffer" }, target, framebuffer
                }
            );
        }

        public void bindXRFramebuffer(WebGLFramebuffer framebuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindXRFramebuffer" }, framebuffer
                }
            );
        }

        public bool useProgram(object program)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "useProgram" }, program
                }
            );
        }

        public void setBlending(int blending, System.Nullable<int> blendEquation = null, System.Nullable<int> blendSrc = null, System.Nullable<int> blendDst = null, System.Nullable<int> blendEquationAlpha = null, System.Nullable<int> blendSrcAlpha = null, System.Nullable<int> blendDstAlpha = null, System.Nullable<bool> premultiplyAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBlending" }, blending, blendEquation, blendSrc, blendDst, blendEquationAlpha, blendSrcAlpha, blendDstAlpha, premultiplyAlpha
                }
            );
        }

        public void setMaterial(Material material, bool frontFaceCW)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMaterial" }, material, frontFaceCW
                }
            );
        }

        public void setFlipSided(bool flipSided)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFlipSided" }, flipSided
                }
            );
        }

        public void setCullFace(int cullFace)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCullFace" }, cullFace
                }
            );
        }

        public void setLineWidth(decimal width)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLineWidth" }, width
                }
            );
        }

        public void setPolygonOffset(bool polygonoffset, System.Nullable<decimal> factor = null, System.Nullable<decimal> units = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPolygonOffset" }, polygonoffset, factor, units
                }
            );
        }

        public void setScissorTest(bool scissorTest)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScissorTest" }, scissorTest
                }
            );
        }

        public void activeTexture(decimal webglSlot)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "activeTexture" }, webglSlot
                }
            );
        }

        public void bindTexture(decimal webglType, object webglTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindTexture" }, webglType, webglTexture
                }
            );
        }

        public void unbindTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbindTexture" }
                }
            );
        }

        public void compressedTexImage2D(decimal target, decimal level, decimal internalformat, decimal width, decimal height, decimal border, ArrayBufferView data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "compressedTexImage2D" }, target, level, internalformat, width, height, border, data
                }
            );
        }

        public void texImage2D(decimal target, decimal level, decimal internalformat, decimal width, decimal height, decimal border, decimal format, decimal type, ArrayBufferView pixels = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texImage2D" }, target, level, internalformat, width, height, border, format, type, pixels
                }
            );
        }

        public void texImage3D(decimal target, decimal level, decimal internalformat, decimal width, decimal height, decimal depth, decimal border, decimal format, decimal type, object pixels)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "texImage3D" }, target, level, internalformat, width, height, depth, border, format, type, pixels
                }
            );
        }

        public void scissor(Vector4 scissor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scissor" }, scissor
                }
            );
        }

        public void viewport(Vector4 viewport)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "viewport" }, viewport
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
    #endregion
}
