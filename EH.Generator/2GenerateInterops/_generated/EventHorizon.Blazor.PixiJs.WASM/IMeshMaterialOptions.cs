/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IMeshMaterialOptions : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IMeshMaterialOptionsCachedEntity>))]
public class IMeshMaterialOptionsCachedEntity : CachedEntityObject, IMeshMaterialOptions
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
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal tint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tint",
                    value
                );
            }
        }

        
        public string pluginName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "pluginName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pluginName",
                    value
                );
            }
        }

        private Program __program;
        public Program program
        {
            get
            {
            if(__program == null)
            {
                __program = EventHorizonBlazorInterop.GetClass<Program>(
                    this.___guid,
                    "program",
                    (entity) =>
                    {
                        return new Program() { ___guid = entity.___guid };
                    }
                );
            }
            return __program;
            }
            set
            {
__program = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "program",
                    value
                );
            }
        }

        
        public CachedEntity uniforms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "uniforms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniforms",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IMeshMaterialOptionsCachedEntity() : base() { }

        public IMeshMaterialOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
