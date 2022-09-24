/// Generated - Do Not Edit
namespace PropertyBinding
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Composite>))]
    public class Composite : CachedEntityObject
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
        public Composite() : base() { }

        public Composite(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Composite(
            object targetGroup, object path, object parsedPath = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PropertyBinding", "Composite" },
                targetGroup, path, parsedPath
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity getValue(object array, decimal offset)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getValue" }, array, offset
                }
            );
        }

        public void setValue(object array, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" }, array, offset
                }
            );
        }

        public void bind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }
        #endregion
    }
}