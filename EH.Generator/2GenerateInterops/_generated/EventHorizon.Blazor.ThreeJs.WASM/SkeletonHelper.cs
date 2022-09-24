/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<SkeletonHelper>))]
public class SkeletonHelper : LineSegments
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

        private Object3D __root;
        public Object3D root
        {
            get
            {
            if(__root == null)
            {
                __root = EventHorizonBlazorInterop.GetClass<Object3D>(
                    this.___guid,
                    "root",
                    (entity) =>
                    {
                        return new Object3D() { ___guid = entity.___guid };
                    }
                );
            }
            return __root;
            }
            set
            {
__root = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "root",
                    value
                );
            }
        }

        
        public unknown isSkeletonHelper
        {
            get
            {
            return EventHorizonBlazorInterop.Get<unknown>(
                    this.___guid,
                    "isSkeletonHelper"
                );
            }
        }

        private Matrix4 __matrix;
        public Matrix4 matrix
        {
            get
            {
            if(__matrix == null)
            {
                __matrix = EventHorizonBlazorInterop.GetClass<Matrix4>(
                    this.___guid,
                    "matrix",
                    (entity) =>
                    {
                        return new Matrix4() { ___guid = entity.___guid };
                    }
                );
            }
            return __matrix;
            }
            set
            {
__matrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }

        
        public bool matrixAutoUpdate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "matrixAutoUpdate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixAutoUpdate",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public SkeletonHelper() : base() { }

        public SkeletonHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SkeletonHelper(
            Object3D @object
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "SkeletonHelper" },
                @object
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public Bone[] getBoneList(Object3D @object)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoneList" }, @object
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
    #endregion
}
