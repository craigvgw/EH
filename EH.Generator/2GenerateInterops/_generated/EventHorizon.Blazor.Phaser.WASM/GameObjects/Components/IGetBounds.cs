/// Generated - Do Not Edit
namespace Phaser.GameObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IGetBounds : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IGetBoundsCachedEntity>))]
    public class IGetBoundsCachedEntity : CachedEntityObject, IGetBounds
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

        #endregion
        
        #region Constructor
        public IGetBoundsCachedEntity() : base() { }

        public IGetBoundsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public O getCenter(O output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCenter" }, output
                }
            );
        }

        public O getTopLeft(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopLeft" }, output, includeParent
                }
            );
        }

        public O getTopCenter(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopCenter" }, output, includeParent
                }
            );
        }

        public O getTopRight(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTopRight" }, output, includeParent
                }
            );
        }

        public O getLeftCenter(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftCenter" }, output, includeParent
                }
            );
        }

        public O getRightCenter(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightCenter" }, output, includeParent
                }
            );
        }

        public O getBottomLeft(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomLeft" }, output, includeParent
                }
            );
        }

        public O getBottomCenter(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomCenter" }, output, includeParent
                }
            );
        }

        public O getBottomRight(O output = null, System.Nullable<bool> includeParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBottomRight" }, output, includeParent
                }
            );
        }

        public O getBounds(O output = null)
        {
            return EventHorizonBlazorInterop.FuncClass<O>(
                entity => new O() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, output
                }
            );
        }
        #endregion
    }
}