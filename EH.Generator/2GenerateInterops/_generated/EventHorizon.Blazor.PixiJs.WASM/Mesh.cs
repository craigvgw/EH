/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Mesh<CachedEntity>>))]
public class Mesh<T> : Container where T : CachedEntity, new()
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static decimal BATCHABLE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "Mesh",
                    "BATCHABLE_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "Mesh",
                    "BATCHABLE_SIZE",
                    value
                );
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private Geometry __geometry;
        public Geometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInterop.GetClass<Geometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
            }
            return __geometry;
            }
            set
            {
__geometry = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometry",
                    value
                );
            }
        }

        private Buffer_2 __uvBuffer;
        public Buffer_2 uvBuffer
        {
            get
            {
            if(__uvBuffer == null)
            {
                __uvBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "uvBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvBuffer;
            }
        }

        private Buffer_2 __verticesBuffer;
        public Buffer_2 verticesBuffer
        {
            get
            {
            if(__verticesBuffer == null)
            {
                __verticesBuffer = EventHorizonBlazorInterop.GetClass<Buffer_2>(
                    this.___guid,
                    "verticesBuffer",
                    (entity) =>
                    {
                        return new Buffer_2() { ___guid = entity.___guid };
                    }
                );
            }
            return __verticesBuffer;
            }
        }

        private T __material;
        public T material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
            }
        }

        
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

        
        public bool roundPixels
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "roundPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roundPixels",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
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
    #endregion

    #region Properties
        private T __shader;
        public T shader
        {
            get
            {
            if(__shader == null)
            {
                __shader = EventHorizonBlazorInterop.GetClass<T>(
                    this.___guid,
                    "shader",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
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

        
        public int drawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "drawMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawMode",
                    value
                );
            }
        }

        
        public decimal start
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "start"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "start",
                    value
                );
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

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        private Uint16Array __indices;
        public Uint16Array indices
        {
            get
            {
            if(__indices == null)
            {
                __indices = EventHorizonBlazorInterop.GetClass<Uint16Array>(
                    this.___guid,
                    "indices",
                    (entity) =>
                    {
                        return new Uint16Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __indices;
            }
            set
            {
__indices = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Mesh() : base() { }

        public Mesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Mesh(
            Geometry geometry, T shader, State state = null, System.Nullable<int> drawMode = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Mesh" },
                geometry, shader, state, drawMode
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void calculateVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateVertices" }
                }
            );
        }

        public void calculateUvs()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateUvs" }
                }
            );
        }

        public bool containsPoint(IPointData point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }

        public void destroy(IDestroyOptions options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }, options
                }
            );
        }
    #endregion
}
