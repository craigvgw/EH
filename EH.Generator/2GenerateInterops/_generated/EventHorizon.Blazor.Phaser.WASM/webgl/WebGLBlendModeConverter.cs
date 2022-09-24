/// Generated - Do Not Edit
namespace spine.webgl
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebGLBlendModeConverter>))]
    public class WebGLBlendModeConverter : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal ZERO
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ZERO"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ZERO",
                    value
                );
            }
        }

        
        public static decimal ONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE",
                    value
                );
            }
        }

        
        public static decimal SRC_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.SRC_COLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.SRC_COLOR",
                    value
                );
            }
        }

        
        public static decimal ONE_MINUS_SRC_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_SRC_COLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_SRC_COLOR",
                    value
                );
            }
        }

        
        public static decimal SRC_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.SRC_ALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.SRC_ALPHA",
                    value
                );
            }
        }

        
        public static decimal ONE_MINUS_SRC_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_SRC_ALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_SRC_ALPHA",
                    value
                );
            }
        }

        
        public static decimal DST_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.DST_ALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.DST_ALPHA",
                    value
                );
            }
        }

        
        public static decimal ONE_MINUS_DST_ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_DST_ALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.ONE_MINUS_DST_ALPHA",
                    value
                );
            }
        }

        
        public static decimal DST_COLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "spine",
                    "webgl.WebGLBlendModeConverter.DST_COLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "spine",
                    "webgl.WebGLBlendModeConverter.DST_COLOR",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static decimal getDestGLBlendMode(int blendMode)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "webgl", "WebGLBlendModeConverter", "getDestGLBlendMode" }, blendMode
                }
            );
        }

        public static decimal getSourceGLBlendMode(int blendMode, System.Nullable<bool> premultipliedAlpha = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "spine", "webgl", "WebGLBlendModeConverter", "getSourceGLBlendMode" }, blendMode, premultipliedAlpha
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public WebGLBlendModeConverter() : base() { }

        public WebGLBlendModeConverter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}