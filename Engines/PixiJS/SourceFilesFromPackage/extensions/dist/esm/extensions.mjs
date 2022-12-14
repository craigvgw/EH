/*!
 * @pixi/extensions - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/extensions is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
/*! *****************************************************************************
Copyright (c) Microsoft Corporation.

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
PERFORMANCE OF THIS SOFTWARE.
***************************************************************************** */

var __assign = function() {
    __assign = Object.assign || function __assign(t) {
        var arguments$1 = arguments;

        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments$1[i];
            for (var p in s) { if (Object.prototype.hasOwnProperty.call(s, p)) { t[p] = s[p]; } }
        }
        return t;
    };
    return __assign.apply(this, arguments);
};

/**
 * Collection of valid extension types.
 * @memberof PIXI
 * @property {string} Application - Application plugins
 * @property {string} RendererPlugin - Plugins for Renderer
 * @property {string} CanvasRendererPlugin - Plugins for CanvasRenderer
 * @property {string} Loader - Plugins to use with Loader
 * @property {string} LoadParser - Parsers for Assets loader.
 * @property {string} ResolveParser - Parsers for Assets resolvers.
 * @property {string} CacheParser - Parsers for Assets cache.
 */
var ExtensionType;
(function (ExtensionType) {
    ExtensionType["Application"] = "application";
    ExtensionType["RendererPlugin"] = "renderer-webgl-plugin";
    ExtensionType["CanvasRendererPlugin"] = "renderer-canvas-plugin";
    ExtensionType["Loader"] = "loader";
    ExtensionType["LoadParser"] = "load-parser";
    ExtensionType["ResolveParser"] = "resolve-parser";
    ExtensionType["CacheParser"] = "cache-parser";
    ExtensionType["DetectionParser"] = "detection-parser";
})(ExtensionType || (ExtensionType = {}));
/**
 * Convert input into extension format data.
 * @ignore
 */
var normalizeExtension = function (ext) {
    // Class/Object submission, use extension object
    if (typeof ext === 'function' || (typeof ext === 'object' && ext.extension)) {
        if (!ext.extension) {
            throw new Error('Extension class must have an extension object');
        }
        var metadata = (typeof ext.extension !== 'object')
            ? { type: ext.extension }
            : ext.extension;
        ext = __assign(__assign({}, metadata), { ref: ext });
    }
    if (typeof ext === 'object') {
        ext = __assign({}, ext);
    }
    else {
        throw new Error('Invalid extension type');
    }
    if (typeof ext.type === 'string') {
        ext.type = [ext.type];
    }
    return ext;
};
/**
 * Global registration of all PixiJS extensions. One-stop-shop for extensibility.
 * @memberof PIXI
 * @namespace extensions
 */
var extensions = {
    /** @ignore */
    _addHandlers: null,
    /** @ignore */
    _removeHandlers: null,
    /** @ignore */
    _queue: {},
    /**
     * Remove extensions from PixiJS.
     * @param extensions - Extensions to be removed.
     * @returns {PIXI.extensions} For chaining.
     */
    remove: function () {
        var arguments$1 = arguments;

        var _this = this;
        var extensions = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            extensions[_i] = arguments$1[_i];
        }
        extensions.map(normalizeExtension).forEach(function (ext) {
            ext.type.forEach(function (type) { var _a, _b; return (_b = (_a = _this._removeHandlers)[type]) === null || _b === void 0 ? void 0 : _b.call(_a, ext); });
        });
        return this;
    },
    /**
     * Register new extensions with PixiJS.
     * @param extensions - The spread of extensions to add to PixiJS.
     * @returns {PIXI.extensions} For chaining.
     */
    add: function () {
        var arguments$1 = arguments;

        var _this = this;
        var extensions = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            extensions[_i] = arguments$1[_i];
        }
        // Handle any extensions either passed as class w/ data or as data
        extensions.map(normalizeExtension).forEach(function (ext) {
            ext.type.forEach(function (type) {
                var handlers = _this._addHandlers;
                var queue = _this._queue;
                if (!handlers[type]) {
                    queue[type] = queue[type] || [];
                    queue[type].push(ext);
                }
                else {
                    handlers[type](ext);
                }
            });
        });
        return this;
    },
    /**
     * Internal method to handle extensions by name.
     * @param type - The extension type.
     * @param onAdd  - Function for handling when extensions are added/registered passes {@link PIXI.ExtensionFormat}.
     * @param onRemove  - Function for handling when extensions are removed/unregistered passes {@link PIXI.ExtensionFormat}.
     * @returns {PIXI.extensions} For chaining.
     */
    handle: function (type, onAdd, onRemove) {
        var addHandlers = this._addHandlers = this._addHandlers || {};
        var removeHandlers = this._removeHandlers = this._removeHandlers || {};
        if (addHandlers[type] || removeHandlers[type]) {
            throw new Error("Extension type " + type + " already has a handler");
        }
        addHandlers[type] = onAdd;
        removeHandlers[type] = onRemove;
        // Process the queue
        var queue = this._queue;
        // Process any plugins that have been registered before the handler
        if (queue[type]) {
            queue[type].forEach(function (ext) { return onAdd(ext); });
            delete queue[type];
        }
        return this;
    },
    /**
     * Handle a type, but using a map by `name` property.
     * @param type - Type of extension to handle.
     * @param map - The object map of named extensions.
     * @returns {PIXI.extensions} For chaining.
     */
    handleByMap: function (type, map) {
        return this.handle(type, function (extension) {
            map[extension.name] = extension.ref;
        }, function (extension) {
            delete map[extension.name];
        });
    },
    /**
     * Handle a type, but using a list of extensions.
     * @param type - Type of extension to handle.
     * @param list - The list of extensions.
     * @returns {PIXI.extensions} For chaining.
     */
    handleByList: function (type, list) {
        return this.handle(type, function (extension) {
            var _a, _b;
            list.push(extension.ref);
            // TODO: remove me later, only added for @pixi/loaders
            if (type === ExtensionType.Loader) {
                (_b = (_a = extension.ref).add) === null || _b === void 0 ? void 0 : _b.call(_a);
            }
        }, function (extension) {
            var index = list.indexOf(extension.ref);
            if (index !== -1) {
                list.splice(index, 1);
            }
        });
    },
};

export { ExtensionType, extensions };
//# sourceMappingURL=extensions.mjs.map
