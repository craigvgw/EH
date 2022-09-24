/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<AbstractBatchRenderer>))]
public class AbstractBatchRenderer : ObjectRenderer
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

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }

        
        public decimal MAX_TEXTURES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_TEXTURES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAX_TEXTURES",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public AbstractBatchRenderer() : base() { }

        public AbstractBatchRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AbstractBatchRenderer(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "AbstractBatchRenderer" },
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

        public void initFlushBuffers()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initFlushBuffers" }
                }
            );
        }

        public void onPrerender()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onPrerender" }
                }
            );
        }

        public void render(IBatchableElement element)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, element
                }
            );
        }

        public void buildTexturesAndDrawCalls()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "buildTexturesAndDrawCalls" }
                }
            );
        }

        public void buildDrawCalls(BatchTextureArray texArray, decimal start, decimal finish)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "buildDrawCalls" }, texArray, start, finish
                }
            );
        }

        public void bindAndClearTexArray(BatchTextureArray texArray)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAndClearTexArray" }, texArray
                }
            );
        }

        public void updateGeometry()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateGeometry" }
                }
            );
        }

        public void drawBatches()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawBatches" }
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

        public void start()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }
                }
            );
        }

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
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

        public ViewableBuffer getAttributeBuffer(decimal size)
        {
            return EventHorizonBlazorInterop.FuncClass<ViewableBuffer>(
                entity => new ViewableBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttributeBuffer" }, size
                }
            );
        }

        public Uint16Array getIndexBuffer(decimal size)
        {
            return EventHorizonBlazorInterop.FuncClass<Uint16Array>(
                entity => new Uint16Array() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getIndexBuffer" }, size
                }
            );
        }

        public void packInterleavedGeometry(IBatchableElement element, ViewableBuffer attributeBuffer, Uint16Array indexBuffer, decimal aIndex, decimal iIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "packInterleavedGeometry" }, element, attributeBuffer, indexBuffer, aIndex, iIndex
                }
            );
        }
    #endregion
}
