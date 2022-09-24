/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XMLFormat>))]
public class XMLFormat : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static bool test(unknown data)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "XMLFormat", "test" }, data
                }
            );
        }

        public static BitmapFontData parse(XMLDocument xml)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapFontData>(
                entity => new BitmapFontData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "XMLFormat", "parse" }, xml
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion
    
    #region Constructor
        public XMLFormat() : base() { }

        public XMLFormat(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods

    #endregion
}
