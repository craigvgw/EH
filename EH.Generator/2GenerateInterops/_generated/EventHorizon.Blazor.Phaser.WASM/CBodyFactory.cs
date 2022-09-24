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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CBodyFactory>))]
    public class CBodyFactory : CachedEntityObject
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
        public CBodyFactory() : base() { }

        public CBodyFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void applyForce(CachedEntity body, CVector position, CVector force)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" }, body, position, force
                }
            );
        }

        public CachedEntity create(IChamferableBodyDefinition options)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "create" }, options
                }
            );
        }

        public void rotate(CachedEntity body, decimal rotation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, body, rotation
                }
            );
        }

        public decimal nextGroup(bool isNonColliding)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "nextGroup" }, isNonColliding
                }
            );
        }

        public decimal nextCategory()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "nextCategory" }
                }
            );
        }

        public void set(CachedEntity body, object settings, object value = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "set" }, body, settings, value
                }
            );
        }

        public void setMass(CachedEntity body, decimal mass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMass" }, body, mass
                }
            );
        }

        public void setDensity(CachedEntity body, decimal density)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDensity" }, body, density
                }
            );
        }

        public void setInertia(CachedEntity body, decimal inertia)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setInertia" }, body, inertia
                }
            );
        }

        public void setVertices(CachedEntity body, CVector[] vertices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVertices" }, body, vertices
                }
            );
        }

        public void setParts(CachedEntity body, CachedEntity[] parts, System.Nullable<bool> autoHull = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setParts" }, body, parts, autoHull
                }
            );
        }

        public void setPosition(CachedEntity body, CVector position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, body, position
                }
            );
        }

        public void setAngle(CachedEntity body, decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngle" }, body, angle
                }
            );
        }

        public void setVelocity(CachedEntity body, CVector velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVelocity" }, body, velocity
                }
            );
        }

        public void setAngularVelocity(CachedEntity body, decimal velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" }, body, velocity
                }
            );
        }

        public void setStatic(CachedEntity body, bool isStatic)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStatic" }, body, isStatic
                }
            );
        }

        public void scale(CachedEntity body, decimal scaleX, decimal scaleY, CVector point = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, body, scaleX, scaleY, point
                }
            );
        }

        public void translate(CachedEntity body, CVector translation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, body, translation
                }
            );
        }

        public void update(CachedEntity body, decimal deltaTime, decimal timeScale, decimal correction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, body, deltaTime, timeScale, correction
                }
            );
        }
        #endregion
    }
}