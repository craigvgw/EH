/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<MeshMaterial>))]
public class MeshMaterial : Shader
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors
        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
            }
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
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
    #endregion

    #region Properties
        private TextureMatrix __uvMatrix;
        public TextureMatrix uvMatrix
        {
            get
            {
            if(__uvMatrix == null)
            {
                __uvMatrix = EventHorizonBlazorInterop.GetClass<TextureMatrix>(
                    this.___guid,
                    "uvMatrix",
                    (entity) =>
                    {
                        return new TextureMatrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __uvMatrix;
            }
        }

        
        public bool batchable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "batchable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "batchable",
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
    #endregion
    
    #region Constructor
        public MeshMaterial() : base() { }

        public MeshMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MeshMaterial(
            Texture uSampler, IMeshMaterialOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "MeshMaterial" },
                uSampler, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
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
