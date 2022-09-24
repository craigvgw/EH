/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Frustum>))]
public class Frustum : CachedEntityObject
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
        
        public Plane[] planes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Plane>(
                    this.___guid,
                    "planes",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "planes",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Frustum() : base() { }

        public Frustum(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Frustum(
            Plane p0 = null, Plane p1 = null, Plane p2 = null, Plane p3 = null, Plane p4 = null, Plane p5 = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Frustum" },
                p0, p1, p2, p3, p4, p5
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Frustum set(Plane p0, Plane p1, Plane p2, Plane p3, Plane p4, Plane p5)
        {
            return EventHorizonBlazorInterop.FuncClass<Frustum>(
                entity => new Frustum() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, p0, p1, p2, p3, p4, p5
                }
            );
        }

        public Frustum clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Frustum>(
                entity => new Frustum() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Frustum copy(Frustum frustum)
        {
            return EventHorizonBlazorInterop.FuncClass<Frustum>(
                entity => new Frustum() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, frustum
                }
            );
        }

        public Frustum setFromProjectionMatrix(Matrix4 m)
        {
            return EventHorizonBlazorInterop.FuncClass<Frustum>(
                entity => new Frustum() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromProjectionMatrix" }, m
                }
            );
        }

        public bool intersectsObject(Object3D @object)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsObject" }, @object
                }
            );
        }

        public bool intersectsSprite(Sprite sprite)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSprite" }, sprite
                }
            );
        }

        public bool intersectsSphere(Sphere sphere)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere
                }
            );
        }

        public bool intersectsBox(Box3 box)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBox" }, box
                }
            );
        }

        public bool containsPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "containsPoint" }, point
                }
            );
        }
    #endregion
}
