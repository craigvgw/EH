/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SkinnedMesh<CachedEntity>>))]
public class SkinnedMesh<TGeometry, Material> : Mesh<TGeometry, TMaterial> where TGeometry : CachedEntity, new() where Material : CachedEntity, new()
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
        
        public string bindMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "bindMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindMode",
                    value
                );
            }
        }

        private Matrix4 __bindMatrix;
        public Matrix4 bindMatrix
        {
            get
            {
            if(__bindMatrix == null)
            {
                __bindMatrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "bindMatrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __bindMatrix;
            }
            set
            {
__bindMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindMatrix",
                    value
                );
            }
        }

        private Matrix4 __bindMatrixInverse;
        public Matrix4 bindMatrixInverse
        {
            get
            {
            if(__bindMatrixInverse == null)
            {
                __bindMatrixInverse = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "bindMatrixInverse",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __bindMatrixInverse;
            }
            set
            {
__bindMatrixInverse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindMatrixInverse",
                    value
                );
            }
        }

        private Skeleton __skeleton;
        public Skeleton skeleton
        {
            get
            {
            if(__skeleton == null)
            {
                __skeleton = EventHorizonBlazorInterop.GetClass<Skeleton>(
                    this.___guid,
                    "skeleton",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeleton;
            }
            set
            {
__skeleton = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeleton",
                    value
                );
            }
        }

        
        public unknown isSkinnedMesh
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSkinnedMesh"
                );
            }
        }
    #endregion
    
    #region Constructor
        public SkinnedMesh() : base() { }

        public SkinnedMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SkinnedMesh(
            TGeometry geometry = null, TMaterial material = null, System.Nullable<bool> useVertexTexture = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SkinnedMesh" },
                geometry, material, useVertexTexture
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void bind(Skeleton skeleton, Matrix4 bindMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, skeleton, bindMatrix
                }
            );
        }

        public void pose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pose" }
                }
            );
        }

        public void normalizeSkinWeights()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "normalizeSkinWeights" }
                }
            );
        }

        public void updateMatrixWorld(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrixWorld" }, force
                }
            );
        }

        public Vector3 boneTransform(decimal index, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "boneTransform" }, index, target
                }
            );
        }
    #endregion
}
