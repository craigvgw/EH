/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Filter>))]
public class Filter : Shader
{
    #region Static Accessors
        
        public static string defaultVertexSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "Filter",
                    "defaultVertexSrc"
                );
            }
        }

        
        public static string defaultFragmentSrc
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "Filter",
                    "defaultFragmentSrc"
                );
            }
        }
    #endregion

    #region Static Properties
// SOURCE_KEY_MAP is not supported by the platform yet
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public int blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
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

    #region Properties
        
        public decimal padding
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "padding"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "padding",
                    value
                );
            }
        }

        
        public int multisample
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "multisample"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multisample",
                    value
                );
            }
        }

        
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

        
        public bool autoFit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoFit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoFit",
                    value
                );
            }
        }

        
        public bool legacy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "legacy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "legacy",
                    value
                );
            }
        }

        private State __state;
        public State state
        {
            get
            {
            if(__state == null)
            {
                __state = EventHorizonBlazorInterop.GetClass<State>(
                    this.___guid,
                    "state",
                    (entity) =>
                    {
                        return new State() { ___guid = entity.___guid };
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
    #endregion
    
    #region Constructor
        public Filter() : base() { }

        public Filter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Filter(
            string vertexSrc = null, string fragmentSrc = null, CachedEntity uniforms = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Filter" },
                vertexSrc, fragmentSrc, uniforms
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void apply(FilterSystem filterManager, RenderTexture input, RenderTexture output, System.Nullable<int> clearMode = null, FilterState _currentState = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "apply" }, filterManager, input, output, clearMode, _currentState
                }
            );
        }
    #endregion
}
