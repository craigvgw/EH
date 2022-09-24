/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface MorphTarget : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MorphTargetCachedEntity>))]
public class MorphTargetCachedEntity : CachedEntityObject, MorphTarget
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

        
        public Vector3[] vertices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "vertices",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertices",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public MorphTargetCachedEntity() : base() { }

        public MorphTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
