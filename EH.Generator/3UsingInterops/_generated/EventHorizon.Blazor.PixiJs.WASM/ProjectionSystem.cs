/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<ProjectionSystem>))]
public class ProjectionSystem : CachedEntityObject, ISystem
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
        private Rectangle __destinationFrame;
        public Rectangle destinationFrame
        {
            get
            {
            if(__destinationFrame == null)
            {
                __destinationFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "destinationFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __destinationFrame;
            }
            set
            {
__destinationFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "destinationFrame",
                    value
                );
            }
        }

        private Rectangle __sourceFrame;
        public Rectangle sourceFrame
        {
            get
            {
            if(__sourceFrame == null)
            {
                __sourceFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "sourceFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __sourceFrame;
            }
            set
            {
__sourceFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceFrame",
                    value
                );
            }
        }

        private Rectangle __defaultFrame;
        public Rectangle defaultFrame
        {
            get
            {
            if(__defaultFrame == null)
            {
                __defaultFrame = EventHorizonBlazorInterop.GetClass<Rectangle>(
                    this.___guid,
                    "defaultFrame",
                    (entity) =>
                    {
                        return new Rectangle() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultFrame;
            }
            set
            {
__defaultFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultFrame",
                    value
                );
            }
        }

        private Matrix __projectionMatrix;
        public Matrix projectionMatrix
        {
            get
            {
            if(__projectionMatrix == null)
            {
                __projectionMatrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "projectionMatrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionMatrix;
            }
            set
            {
__projectionMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionMatrix",
                    value
                );
            }
        }

        private Matrix __transform;
        public Matrix transform
        {
            get
            {
            if(__transform == null)
            {
                __transform = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "transform",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __transform;
            }
            set
            {
__transform = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transform",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public ProjectionSystem() : base() { }

        public ProjectionSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ProjectionSystem(
            Renderer renderer
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "ProjectionSystem" },
                renderer
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void update(Rectangle destinationFrame, Rectangle sourceFrame, decimal resolution, bool root)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, destinationFrame, sourceFrame, resolution, root
                }
            );
        }

        public void calculateProjection(Rectangle _destinationFrame, Rectangle sourceFrame, decimal _resolution, bool root)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "calculateProjection" }, _destinationFrame, sourceFrame, _resolution, root
                }
            );
        }

        public void setTransform(Matrix _matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransform" }, _matrix
                }
            );
        }

        public void destroy()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "destroy" }
                }
            );
        }
    #endregion
}
