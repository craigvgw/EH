/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Skeleton>))]
public class Skeleton : CachedEntityObject
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

        
        public Bone[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bones",
                    value
                );
            }
        }

        
        public Matrix4[] boneInverses
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Matrix4>(
                    this.___guid,
                    "boneInverses",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneInverses",
                    value
                );
            }
        }

        
        public decimal[] boneMatrices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "boneMatrices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneMatrices",
                    value
                );
            }
        }

        private DataTexture __boneTexture;
        public DataTexture boneTexture
        {
            get
            {
            if(__boneTexture == null)
            {
                __boneTexture = EventHorizonBlazorInterop.GetClass<DataTexture>(
                    this.___guid,
                    "boneTexture",
                    (entity) =>
                    {
                        return new DataTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __boneTexture;
            }
            set
            {
__boneTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneTexture",
                    value
                );
            }
        }

        
        public decimal boneTextureSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "boneTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boneTextureSize",
                    value
                );
            }
        }

        
        public decimal frame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool useVertexTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useVertexTexture",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Skeleton() : base() { }

        public Skeleton(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Skeleton(
            Bone[] bones, Matrix4[] boneInverses = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "Skeleton" },
                bones, boneInverses
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void init()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public void calculateInverses()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateInverses" }
                }
            );
        }

        public Skeleton computeBoneTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeBoneTexture" }
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

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public Skeleton clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Bone getBoneByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoneByName" }, name
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
    #endregion
}
