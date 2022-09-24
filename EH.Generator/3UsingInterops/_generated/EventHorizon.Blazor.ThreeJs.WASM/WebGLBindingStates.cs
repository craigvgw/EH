/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<WebGLBindingStates>))]
public class WebGLBindingStates : CachedEntityObject
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
        public WebGLBindingStates() : base() { }

        public WebGLBindingStates(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public WebGLBindingStates(
            WebGLRenderingContext gl, WebGLExtensions extensions, WebGLAttributes attributes, WebGLCapabilities capabilities
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "WebGLBindingStates" },
                gl, extensions, attributes, capabilities
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void setup(Object3D @object, Material material, WebGLProgram program, BufferGeometry geometry, BufferAttribute index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setup" }, @object, material, program, geometry, index
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

        public void resetDefaultState()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetDefaultState" }
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

        public void releaseStatesOfGeometry()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseStatesOfGeometry" }
                }
            );
        }

        public void releaseStatesOfProgram()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseStatesOfProgram" }
                }
            );
        }

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

        public void disableUnusedAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableUnusedAttributes" }
                }
            );
        }
    #endregion
}
