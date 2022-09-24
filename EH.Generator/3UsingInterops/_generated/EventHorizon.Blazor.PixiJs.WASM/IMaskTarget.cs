/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IMaskTarget : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IMaskTargetCachedEntity>))]
public class IMaskTargetCachedEntity : CachedEntityObject, IMaskTarget
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
        
        public bool renderable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderable",
                    value
                );
            }
        }

        
        public bool isSprite
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSprite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isSprite",
                    value
                );
            }
        }

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
    #endregion
    
    #region Constructor
        public IMaskTargetCachedEntity() : base() { }

        public IMaskTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public bool isFastRect()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isFastRect" }
                }
            );
        }

        public Rectangle getBounds(System.Nullable<bool> skipUpdate = null, Rectangle rect = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Rectangle>(
                entity => new Rectangle() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBounds" }, skipUpdate, rect
                }
            );
        }

        public void render(Renderer renderer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, renderer
                }
            );
        }
    #endregion
}
