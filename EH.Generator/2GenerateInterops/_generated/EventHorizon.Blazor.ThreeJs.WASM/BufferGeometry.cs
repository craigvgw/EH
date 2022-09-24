/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BufferGeometry>))]
public class BufferGeometry : EventDispatcher
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
        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public string uuid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uuid"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uuid",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public string type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private BufferAttribute __index;
        public BufferAttribute index
        {
            get
            {
            if(__index == null)
            {
                __index = EventHorizonBlazorInterop.GetClass<BufferAttribute>(
                    this.___guid,
                    "index",
                    (entity) =>
                    {
                        return new BufferAttribute() { ___guid = entity.___guid };
                    }
                );
            }
            return __index;
            }
            set
            {
__index = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        private BufferAttribute __attributes;
        public BufferAttribute attributes
        {
            get
            {
            if(__attributes == null)
            {
                __attributes = EventHorizonBlazorInterop.GetClass<BufferAttribute>(
                    this.___guid,
                    "attributes",
                    (entity) =>
                    {
                        return new BufferAttribute() { ___guid = entity.___guid };
                    }
                );
            }
            return __attributes;
            }
            set
            {
__attributes = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributes",
                    value
                );
            }
        }

        private BufferAttribute __morphAttributes;
        public BufferAttribute morphAttributes
        {
            get
            {
            if(__morphAttributes == null)
            {
                __morphAttributes = EventHorizonBlazorInterop.GetClass<BufferAttribute>(
                    this.___guid,
                    "morphAttributes",
                    (entity) =>
                    {
                        return new BufferAttribute() { ___guid = entity.___guid };
                    }
                );
            }
            return __morphAttributes;
            }
            set
            {
__morphAttributes = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphAttributes",
                    value
                );
            }
        }

        
        public bool morphTargetsRelative
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "morphTargetsRelative"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphTargetsRelative",
                    value
                );
            }
        }

        
        public decimal[] groups
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "groups"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groups",
                    value
                );
            }
        }

        private Box3 __boundingBox;
        public Box3 boundingBox
        {
            get
            {
            if(__boundingBox == null)
            {
                __boundingBox = EventHorizonBlazorInterop.GetClass<Box3>(
                    this.___guid,
                    "boundingBox",
                    (entity) =>
                    {
                        return new Box3() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingBox;
            }
            set
            {
__boundingBox = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBox",
                    value
                );
            }
        }

        private Sphere __boundingSphere;
        public Sphere boundingSphere
        {
            get
            {
            if(__boundingSphere == null)
            {
                __boundingSphere = EventHorizonBlazorInterop.GetClass<Sphere>(
                    this.___guid,
                    "boundingSphere",
                    (entity) =>
                    {
                        return new Sphere() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingSphere;
            }
            set
            {
__boundingSphere = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingSphere",
                    value
                );
            }
        }

        
        public CachedEntity drawRange
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "drawRange",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawRange",
                    value
                );
            }
        }

        
        public CachedEntity userData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "userData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "userData",
                    value
                );
            }
        }

        
        public unknown isBufferGeometry
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isBufferGeometry"
                );
            }
        }

        
        public CachedEntity drawcalls
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "drawcalls",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawcalls",
                    value
                );
            }
        }

        
        public CachedEntity offsets
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "offsets",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsets",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public BufferGeometry() : base() { }

        public BufferGeometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public BufferAttribute getIndex()
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }
                }
            );
        }

        public BufferGeometry setIndex(BufferAttribute index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIndex" }, index
                }
            );
        }

        public BufferGeometry setAttribute(unknown name, BufferAttribute attribute)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAttribute" }, name, attribute
                }
            );
        }

        public BufferAttribute getAttribute(unknown name)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferAttribute>(
                entity => new BufferAttribute() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAttribute" }, name
                }
            );
        }

        public BufferGeometry deleteAttribute(unknown name)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "deleteAttribute" }, name
                }
            );
        }

        public bool hasAttribute(unknown name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasAttribute" }, name
                }
            );
        }

        public void addGroup(decimal start, decimal count, System.Nullable<decimal> materialIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addGroup" }, start, count, materialIndex
                }
            );
        }

        public void clearGroups()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearGroups" }
                }
            );
        }

        public void setDrawRange(decimal start, decimal count)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDrawRange" }, start, count
                }
            );
        }

        public BufferGeometry applyMatrix4(Matrix4 matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyMatrix4" }, matrix
                }
            );
        }

        public BufferGeometry applyQuaternion(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyQuaternion" }, q
                }
            );
        }

        public BufferGeometry rotateX(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateX" }, angle
                }
            );
        }

        public BufferGeometry rotateY(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateY" }, angle
                }
            );
        }

        public BufferGeometry rotateZ(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateZ" }, angle
                }
            );
        }

        public BufferGeometry translate(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, x, y, z
                }
            );
        }

        public BufferGeometry scale(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, x, y, z
                }
            );
        }

        public void lookAt(Vector3 v)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, v
                }
            );
        }

        public BufferGeometry center()
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "center" }
                }
            );
        }

        public BufferGeometry setFromPoints(Vector3[] points)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFromPoints" }, points
                }
            );
        }

        public void computeBoundingBox()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeBoundingBox" }
                }
            );
        }

        public void computeBoundingSphere()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeBoundingSphere" }
                }
            );
        }

        public void computeTangents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeTangents" }
                }
            );
        }

        public void computeVertexNormals()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeVertexNormals" }
                }
            );
        }

        public void normalizeNormals()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "normalizeNormals" }
                }
            );
        }

        public BufferGeometry toNonIndexed()
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toNonIndexed" }
                }
            );
        }

        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }

        public BufferGeometry clone()
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public BufferGeometry copy(BufferGeometry source)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, source
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

        public void addIndex(object index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addIndex" }, index
                }
            );
        }

        public void addDrawCall(object start, object count, object indexOffset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addDrawCall" }, start, count, indexOffset
                }
            );
        }

        public void clearDrawCalls()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearDrawCalls" }
                }
            );
        }

        public BufferGeometry addAttribute(string name, BufferAttribute attribute)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAttribute" }, name, attribute
                }
            );
        }

        public BufferGeometry removeAttribute(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<BufferGeometry>(
                entity => new BufferGeometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeAttribute" }, name
                }
            );
        }
    #endregion
}
