/// Generated - Do Not Edit
namespace MatterJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CCompositeFactory>))]
    public class CCompositeFactory : CachedEntityObject
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
        public CCompositeFactory() : base() { }

        public CCompositeFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public CachedEntity add(CachedEntity composite, CachedEntity @object)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "add" }, composite, @object
                }
            );
        }

        public CachedEntity[] allBodies(CachedEntity composite)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "allBodies" }, composite
                }
            );
        }

        public CachedEntity[] allComposites(CachedEntity composite)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "allComposites" }, composite
                }
            );
        }

        public CachedEntity[] allConstraints(CachedEntity composite)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "allConstraints" }, composite
                }
            );
        }

        public void clear(CachedEntity composite, bool keepStatic, System.Nullable<bool> deep = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, composite, keepStatic, deep
                }
            );
        }

        public CachedEntity create(ICompositeDefinition options = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "create" }, options
                }
            );
        }

        public CachedEntity get(CachedEntity composite, decimal id, string type)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "get" }, composite, id, type
                }
            );
        }

        public CachedEntity move(CachedEntity compositeA, CachedEntity objects, CachedEntity compositeB)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "move" }, compositeA, objects, compositeB
                }
            );
        }

        public CachedEntity rebase(CachedEntity composite)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rebase" }, composite
                }
            );
        }

        public CachedEntity remove(CachedEntity composite, CachedEntity @object, System.Nullable<bool> deep = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, composite, @object, deep
                }
            );
        }

        public void setModified(CachedEntity composite, bool isModified, System.Nullable<bool> updateParents = null, System.Nullable<bool> updateChildren = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setModified" }, composite, isModified, updateParents, updateChildren
                }
            );
        }

        public void translate(CachedEntity composite, CVector translation, System.Nullable<bool> recursive = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, composite, translation, recursive
                }
            );
        }

        public void rotate(CachedEntity composite, decimal rotation, CVector point, System.Nullable<bool> recursive = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, composite, rotation, point, recursive
                }
            );
        }

        public void scale(CachedEntity composite, decimal scaleX, decimal scaleY, CVector point, System.Nullable<bool> recursive = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, composite, scaleX, scaleY, point, recursive
                }
            );
        }
        #endregion
    }
}