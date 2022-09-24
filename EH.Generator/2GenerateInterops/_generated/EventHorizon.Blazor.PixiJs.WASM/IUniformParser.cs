/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface IUniformParser : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IUniformParserCachedEntity>))]
public class IUniformParserCachedEntity : CachedEntityObject, IUniformParser
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
        public IUniformParserCachedEntity() : base() { }

        public IUniformParserCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public bool test(unknown data, object uniform)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "test" }, data, uniform
                }
            );
        }

        public string code(string name, object uniform)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "code" }, name, uniform
                }
            );
        }

        public string codeUbo(string name, object uniform)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "codeUbo" }, name, uniform
                }
            );
        }
    #endregion
}
