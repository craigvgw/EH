/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Transform>))]
public class Transform : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        private static Transform __IDENTITY;
        public static Transform IDENTITY
        {
            get
            {
            if(__IDENTITY == null)
            {
                __IDENTITY = EventHorizonBlazorInterop.GetClass<Transform>(
                    "Transform",
                    "IDENTITY",
                    (entity) =>
                    {
                        return new Transform() { ___guid = entity.___guid };
                    }
                );
            }
            return __IDENTITY;
            }
        }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }
    #endregion

    #region Properties
        private Matrix __worldTransform;
        public Matrix worldTransform
        {
            get
            {
            if(__worldTransform == null)
            {
                __worldTransform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "worldTransform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldTransform;
            }
            set
            {
__worldTransform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldTransform",
                    value
                );
            }
        }

        private Matrix __localTransform;
        public Matrix localTransform
        {
            get
            {
            if(__localTransform == null)
            {
                __localTransform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "localTransform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __localTransform;
            }
            set
            {
__localTransform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localTransform",
                    value
                );
            }
        }

        private ObservablePoint __position;
        public ObservablePoint position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private ObservablePoint __scale;
        public ObservablePoint scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        private ObservablePoint __pivot;
        public ObservablePoint pivot
        {
            get
            {
            if(__pivot == null)
            {
                __pivot = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "pivot",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __pivot;
            }
            set
            {
__pivot = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pivot",
                    value
                );
            }
        }

        private ObservablePoint __skew;
        public ObservablePoint skew
        {
            get
            {
            if(__skew == null)
            {
                __skew = EventHorizonBlazorInterop.GetClass<ObservablePoint>(
                    this.___guid,
                    "skew",
                    (entity) =>
                    {
                        return new ObservablePoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __skew;
            }
            set
            {
__skew = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skew",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Transform() : base() { }

        public Transform(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public void updateLocalTransform()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateLocalTransform" }
                }
            );
        }

        public void updateTransform(Transform parentTransform)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTransform" }, parentTransform
                }
            );
        }

        public void setFromMatrix(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFromMatrix" }, matrix
                }
            );
        }
    #endregion
}
