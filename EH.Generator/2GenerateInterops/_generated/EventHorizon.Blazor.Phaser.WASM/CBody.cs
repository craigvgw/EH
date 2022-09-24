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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CBody>))]
    public class CBody : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void applyForce(CachedEntity body, CVector position, CVector force)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "applyForce" }, body, position, force
                }
            );
        }

        public static CBody create(IChamferableBodyDefinition options)
        {
            return EventHorizonBlazorInterop.FuncClass<CBody>(
                entity => new CBody() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "create" }, options
                }
            );
        }

        public static void rotate(CachedEntity body, decimal rotation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "rotate" }, body, rotation
                }
            );
        }

        public static decimal nextGroup(bool isNonColliding)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "nextGroup" }, isNonColliding
                }
            );
        }

        public static decimal nextCategory()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "nextCategory" }
                }
            );
        }

        public static void set(CachedEntity body, object settings, object value = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "set" }, body, settings, value
                }
            );
        }

        public static void setMass(CachedEntity body, decimal mass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setMass" }, body, mass
                }
            );
        }

        public static void setDensity(CachedEntity body, decimal density)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setDensity" }, body, density
                }
            );
        }

        public static void setInertia(CachedEntity body, decimal inertia)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setInertia" }, body, inertia
                }
            );
        }

        public static void setVertices(CachedEntity body, CVector[] vertices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setVertices" }, body, vertices
                }
            );
        }

        public static void setParts(CachedEntity body, CachedEntity[] parts, System.Nullable<bool> autoHull = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setParts" }, body, parts, autoHull
                }
            );
        }

        public static void setPosition(CachedEntity body, CVector position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setPosition" }, body, position
                }
            );
        }

        public static void setAngle(CachedEntity body, decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setAngle" }, body, angle
                }
            );
        }

        public static void setVelocity(CachedEntity body, CVector velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setVelocity" }, body, velocity
                }
            );
        }

        public static void setAngularVelocity(CachedEntity body, decimal velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setAngularVelocity" }, body, velocity
                }
            );
        }

        public static void setStatic(CachedEntity body, bool isStatic)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "setStatic" }, body, isStatic
                }
            );
        }

        public static void scale(CachedEntity body, decimal scaleX, decimal scaleY, CVector point = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "scale" }, body, scaleX, scaleY, point
                }
            );
        }

        public static void translate(CachedEntity body, CVector translation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "translate" }, body, translation
                }
            );
        }

        public static void update(CachedEntity body, decimal deltaTime, decimal timeScale, decimal correction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "MatterJS", "CBody", "update" }, body, deltaTime, timeScale, correction
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public CBody() : base() { }

        public CBody(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}