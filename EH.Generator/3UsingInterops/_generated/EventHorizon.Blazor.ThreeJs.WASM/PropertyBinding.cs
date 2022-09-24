/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<PropertyBinding>))]
public class PropertyBinding : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static PropertyBinding create(object root, object path, object parsedPath = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PropertyBinding>(
                entity => new PropertyBinding() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "PropertyBinding", "create" }, root, path, parsedPath
                }
            );
        }

        public static string sanitizeNodeName(string name)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "PropertyBinding", "sanitizeNodeName" }, name
                }
            );
        }

        public static ParseTrackNameResultsCachedEntity parseTrackName(string trackName)
        {
            return EventHorizonBlazorInterop.FuncClass<ParseTrackNameResultsCachedEntity>(
                entity => new ParseTrackNameResultsCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "PropertyBinding", "parseTrackName" }, trackName
                }
            );
        }

        public static CachedEntity findNode(object root, string nodeName)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "PropertyBinding", "findNode" }, root, nodeName
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public string path
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "path"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "path",
                    value
                );
            }
        }

        
        public CachedEntity parsedPath
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parsedPath",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parsedPath",
                    value
                );
            }
        }

        
        public CachedEntity node
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "node",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "node",
                    value
                );
            }
        }

        
        public CachedEntity rootNode
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "rootNode",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootNode",
                    value
                );
            }
        }

        
        public CachedEntity BindingType
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "BindingType",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BindingType",
                    value
                );
            }
        }

        
        public CachedEntity Versioning
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "Versioning",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Versioning",
                    value
                );
            }
        }

        
        public ActionCallback[] GetterByBindingType
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<ActionCallback>(
                    this.___guid,
                    "GetterByBindingType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GetterByBindingType",
                    value
                );
            }
        }

// SetterByBindingTypeAndVersioning is not supported by the platform yet
    #endregion
    
    #region Constructor
        public PropertyBinding() : base() { }

        public PropertyBinding(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PropertyBinding(
            object rootNode, string path, object parsedPath = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "PropertyBinding" },
                rootNode, path, parsedPath
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public CachedEntity getValue(object targetArray, decimal offset)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getValue" }, targetArray, offset
                }
            );
        }

        public void setValue(object sourceArray, decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" }, sourceArray, offset
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
