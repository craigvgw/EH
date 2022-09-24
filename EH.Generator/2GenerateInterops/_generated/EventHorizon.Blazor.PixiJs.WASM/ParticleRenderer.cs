/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ParticleRenderer>))]
public class ParticleRenderer : ObjectRenderer
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static int extension
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    "ParticleRenderer",
                    "extension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "ParticleRenderer",
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

        private Matrix __tempMatrix;
        public Matrix tempMatrix
        {
            get
            {
            if(__tempMatrix == null)
            {
                __tempMatrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "tempMatrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __tempMatrix;
            }
            set
            {
__tempMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tempMatrix",
                    value
                );
            }
        }

        
        public IParticleRendererPropertyCachedEntity[] properties
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IParticleRendererPropertyCachedEntity>(
                    this.___guid,
                    "properties",
                    (entity) =>
                    {
                        return new IParticleRendererPropertyCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "properties",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ParticleRenderer() : base() { }

        public ParticleRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ParticleRenderer(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ParticleRenderer" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void render(ParticleContainer container)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, container
                }
            );
        }

        public void uploadVertices(Sprite[] children, decimal startIndex, decimal amount, decimal[] array, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadVertices" }, children, startIndex, amount, array, stride, offset
                }
            );
        }

        public void uploadPosition(Sprite[] children, decimal startIndex, decimal amount, decimal[] array, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadPosition" }, children, startIndex, amount, array, stride, offset
                }
            );
        }

        public void uploadRotation(Sprite[] children, decimal startIndex, decimal amount, decimal[] array, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadRotation" }, children, startIndex, amount, array, stride, offset
                }
            );
        }

        public void uploadUvs(Sprite[] children, decimal startIndex, decimal amount, decimal[] array, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadUvs" }, children, startIndex, amount, array, stride, offset
                }
            );
        }

        public void uploadTint(Sprite[] children, decimal startIndex, decimal amount, decimal[] array, decimal stride, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "uploadTint" }, children, startIndex, amount, array, stride, offset
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
