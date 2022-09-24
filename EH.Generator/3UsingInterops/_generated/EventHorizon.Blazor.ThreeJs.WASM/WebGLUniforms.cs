/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLUniforms>))]
public class WebGLUniforms : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static void upload(WebGLRenderingContext gl, object seq, CachedEntity[] values, WebGLTextures textures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "WebGLUniforms", "upload" }, gl, seq, values, textures
                }
            );
        }

        public static CachedEntity[] seqWithValue(object seq, CachedEntity[] values)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { "WebGLUniforms", "seqWithValue" }, seq, values
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public WebGLUniforms() : base() { }

        public WebGLUniforms(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLUniforms(
            WebGLRenderingContext gl, WebGLProgram program
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLUniforms" },
                gl, program
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setValue(WebGLRenderingContext gl, string name, object value, WebGLTextures textures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" }, gl, name, value, textures
                }
            );
        }

        public void setOptional(WebGLRenderingContext gl, object @object, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setOptional" }, gl, @object, name
                }
            );
        }
    #endregion
}
