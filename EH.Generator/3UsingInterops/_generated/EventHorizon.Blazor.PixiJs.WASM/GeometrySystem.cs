/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<GeometrySystem>))]
public class GeometrySystem : CachedEntityObject, ISystem
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
        
        public bool hasVao
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasVao"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasVao",
                    value
                );
            }
        }

        
        public bool hasInstance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInstance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasInstance",
                    value
                );
            }
        }

        
        public bool canUseUInt32ElementIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canUseUInt32ElementIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canUseUInt32ElementIndex",
                    value
                );
            }
        }

        
        public CachedEntity managedGeometries
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "managedGeometries",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
    #endregion
    
    #region Constructor
        public GeometrySystem() : base() { }

        public GeometrySystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GeometrySystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "GeometrySystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void bind(Geometry geometry = null, Shader shader = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, geometry, shader
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

        public void updateBuffers()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateBuffers" }
                }
            );
        }

        public void disposeGeometry(Geometry geometry, System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeGeometry" }, geometry, contextLost
                }
            );
        }

        public void disposeAll(System.Nullable<bool> contextLost = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeAll" }, contextLost
                }
            );
        }

        public GeometrySystem draw(int type, System.Nullable<decimal> size = null, System.Nullable<decimal> start = null, System.Nullable<decimal> instanceCount = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GeometrySystem>(
                entity => new GeometrySystem() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "draw" }, type, size, start, instanceCount
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
