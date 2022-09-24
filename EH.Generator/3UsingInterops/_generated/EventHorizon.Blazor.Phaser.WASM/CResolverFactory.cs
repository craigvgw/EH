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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CResolverFactory>))]
    public class CResolverFactory : CachedEntityObject
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
        public CResolverFactory() : base() { }

        public CResolverFactory(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void preSolvePosition(IPair[] pairs)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preSolvePosition" }, pairs
                }
            );
        }

        public void solvePosition(IPair[] pairs, CachedEntity[] bodies, decimal timeScale)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "solvePosition" }, pairs, bodies, timeScale
                }
            );
        }

        public void postSolvePosition(CachedEntity[] bodies)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "postSolvePosition" }, bodies
                }
            );
        }

        public void preSolveVelocity(IPair[] pairs)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "preSolveVelocity" }, pairs
                }
            );
        }

        public void solveVelocity(IPair[] pairs, decimal timeScale)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "solveVelocity" }, pairs, timeScale
                }
            );
        }
        #endregion
    }
}