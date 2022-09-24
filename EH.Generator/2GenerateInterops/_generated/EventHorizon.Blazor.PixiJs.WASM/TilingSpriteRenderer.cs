/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<TilingSpriteRenderer>))]
public class TilingSpriteRenderer : ObjectRenderer
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "TilingSpriteRenderer",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "TilingSpriteRenderer",
                    "extension",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        private Shader __shader;
        public Shader shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<Shader>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new Shader() { ___guid = entity.___guid };
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

        private Shader __simpleShader;
        public Shader simpleShader
        {
            get
            {
            if(__simpleShader == null)
            {
                __simpleShader = EventHorizonBlazorInterop.GetClass<Shader>(
                    this.___guid,
                    "simpleShader",
                    (entity) =>
                    {
                        return new Shader() { ___guid = entity.___guid };
                    }
                );
            }
            return __simpleShader;
            }
            set
            {
__simpleShader = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "simpleShader",
                    value
                );
            }
        }

        private QuadUv __quad;
        public QuadUv quad
        {
            get
            {
            if(__quad == null)
            {
                __quad = EventHorizonBlazorInterop.GetClass<QuadUv>(
                    this.___guid,
                    "quad",
                    (entity) =>
                    {
                        return new QuadUv() { ___guid = entity.___guid };
                    }
                );
            }
            return __quad;
            }
            set
            {
__quad = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "quad",
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
        }
    #endregion
    
    #region Constructor
        public TilingSpriteRenderer() : base() { }

        public TilingSpriteRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TilingSpriteRenderer(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "TilingSpriteRenderer" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void contextChange()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "contextChange" }
                }
            );
        }

        public void render(TilingSprite ts)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, ts
                }
            );
        }
    #endregion
}
