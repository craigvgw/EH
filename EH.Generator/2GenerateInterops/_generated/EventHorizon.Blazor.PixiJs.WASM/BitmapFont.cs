/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<BitmapFont>))]
public class BitmapFont : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties
        
        public static string[] ALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    "BitmapFont",
                    "ALPHA"
                );
            }
        }

// NUMERIC is not supported by the platform yet

        
        public static string[] ALPHANUMERIC
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    "BitmapFont",
                    "ALPHANUMERIC"
                );
            }
        }

// ASCII is not supported by the platform yet

        private static IBitmapFontOptionsCachedEntity __defaultOptions;
        public static IBitmapFontOptionsCachedEntity defaultOptions
        {
            get
            {
            if(__defaultOptions == null)
            {
                __defaultOptions = EventHorizonBlazorInterop.GetClass<IBitmapFontOptionsCachedEntity>(
                    "BitmapFont",
                    "defaultOptions",
                    (entity) =>
                    {
                        return new IBitmapFontOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultOptions;
            }
        }

        
        public static CachedEntity available
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    "BitmapFont",
                    "available"
                );
            }
        }
    #endregion

    #region Static Methods
        public static BitmapFont install(string data, Texture textures, System.Nullable<bool> ownsTextures = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapFont>(
                entity => new BitmapFont() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BitmapFont", "install" }, data, textures, ownsTextures
                }
            );
        }

        public static void uninstall(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BitmapFont", "uninstall" }, name
                }
            );
        }

        public static BitmapFont from(string name, TextStyle textStyle = null, IBitmapFontOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<BitmapFont>(
                entity => new BitmapFont() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BitmapFont", "from" }, name, textStyle, options
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string font
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "font"
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
        }

        
        public decimal lineHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lineHeight"
                );
            }
        }

        
        public CachedEntity chars
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "chars"
                );
            }
        }

        
        public CachedEntity pageTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "pageTextures"
                );
            }
        }

        
        public decimal distanceFieldRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distanceFieldRange"
                );
            }
        }

        
        public string distanceFieldType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "distanceFieldType"
                );
            }
        }
    #endregion
    
    #region Constructor
        public BitmapFont() : base() { }

        public BitmapFont(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BitmapFont(
            BitmapFontData data, Texture[] textures, System.Nullable<bool> ownsTextures = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BitmapFont" },
                data, textures, ownsTextures
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
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
