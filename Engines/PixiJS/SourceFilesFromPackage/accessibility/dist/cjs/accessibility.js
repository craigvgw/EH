/*!
 * @pixi/accessibility - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/accessibility is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var display = require('@pixi/display');
var utils = require('@pixi/utils');
var core = require('@pixi/core');

/**
 * Default property values of accessible objects
 * used by {@link PIXI.AccessibilityManager}.
 * @private
 * @function accessibleTarget
 * @memberof PIXI
 * @type {object}
 * @example
 *      function MyObject() {}
 *
 *      Object.assign(
 *          MyObject.prototype,
 *          PIXI.accessibleTarget
 *      );
 */
var accessibleTarget = {
    /**
     *  Flag for if the object is accessible. If true AccessibilityManager will overlay a
     *   shadow div with attributes set
     * @member {boolean}
     * @memberof PIXI.DisplayObject#
     */
    accessible: false,
    /**
     * Sets the title attribute of the shadow div
     * If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
     * @member {?string}
     * @memberof PIXI.DisplayObject#
     */
    accessibleTitle: null,
    /**
     * Sets the aria-label attribute of the shadow div
     * @member {string}
     * @memberof PIXI.DisplayObject#
     */
    accessibleHint: null,
    /**
     * @member {number}
     * @memberof PIXI.DisplayObject#
     * @private
     * @todo Needs docs.
     */
    tabIndex: 0,
    /**
     * @member {boolean}
     * @memberof PIXI.DisplayObject#
     * @todo Needs docs.
     */
    _accessibleActive: false,
    /**
     * @member {boolean}
     * @memberof PIXI.DisplayObject#
     * @todo Needs docs.
     */
    _accessibleDiv: null,
    /**
     * Specify the type of div the accessible layer is. Screen readers treat the element differently
     * depending on this type. Defaults to button.
     * @member {string}
     * @memberof PIXI.DisplayObject#
     * @default 'button'
     */
    accessibleType: 'button',
    /**
     * Specify the pointer-events the accessible div will use
     * Defaults to auto.
     * @member {string}
     * @memberof PIXI.DisplayObject#
     * @default 'auto'
     */
    accessiblePointerEvents: 'auto',
    /**
     * Setting to false will prevent any children inside this container to
     * be accessible. Defaults to true.
     * @member {boolean}
     * @memberof PIXI.DisplayObject#
     * @default true
     */
    accessibleChildren: true,
    renderId: -1,
};

// add some extra variables to the container..
display.DisplayObject.mixin(accessibleTarget);
var KEY_CODE_TAB = 9;
var DIV_TOUCH_SIZE = 100;
var DIV_TOUCH_POS_X = 0;
var DIV_TOUCH_POS_Y = 0;
var DIV_TOUCH_ZINDEX = 2;
var DIV_HOOK_SIZE = 1;
var DIV_HOOK_POS_X = -1000;
var DIV_HOOK_POS_Y = -1000;
var DIV_HOOK_ZINDEX = 2;
/**
 * The Accessibility manager recreates the ability to tab and have content read by screen readers.
 * This is very important as it can possibly help people with disabilities access PixiJS content.
 *
 * A DisplayObject can be made accessible just like it can be made interactive. This manager will map the
 * events as if the mouse was being used, minimizing the effort required to implement.
 *
 * An instance of this class is automatically created by default, and can be found at `renderer.plugins.accessibility`
 * @class
 * @memberof PIXI
 */
var AccessibilityManager = /** @class */ (function () {
    /**
     * @param {PIXI.CanvasRenderer|PIXI.Renderer} renderer - A reference to the current renderer
     */
    function AccessibilityManager(renderer) {
        /** Setting this to true will visually show the divs. */
        this.debug = false;
        /** Internal variable, see isActive getter. */
        this._isActive = false;
        /** Internal variable, see isMobileAccessibility getter. */
        this._isMobileAccessibility = false;
        /** A simple pool for storing divs. */
        this.pool = [];
        /** This is a tick used to check if an object is no longer being rendered. */
        this.renderId = 0;
        /** The array of currently active accessible items. */
        this.children = [];
        /** Count to throttle div updates on android devices. */
        this.androidUpdateCount = 0;
        /**  The frequency to update the div elements. */
        this.androidUpdateFrequency = 500; // 2fps
        this._hookDiv = null;
        if (utils.isMobile.tablet || utils.isMobile.phone) {
            this.createTouchHook();
        }
        // first we create a div that will sit over the PixiJS element. This is where the div overlays will go.
        var div = document.createElement('div');
        div.style.width = DIV_TOUCH_SIZE + "px";
        div.style.height = DIV_TOUCH_SIZE + "px";
        div.style.position = 'absolute';
        div.style.top = DIV_TOUCH_POS_X + "px";
        div.style.left = DIV_TOUCH_POS_Y + "px";
        div.style.zIndex = DIV_TOUCH_ZINDEX.toString();
        this.div = div;
        this.renderer = renderer;
        /**
         * pre-bind the functions
         * @type {Function}
         * @private
         */
        this._onKeyDown = this._onKeyDown.bind(this);
        /**
         * pre-bind the functions
         * @type {Function}
         * @private
         */
        this._onMouseMove = this._onMouseMove.bind(this);
        // let listen for tab.. once pressed we can fire up and show the accessibility layer
        globalThis.addEventListener('keydown', this._onKeyDown, false);
    }
    Object.defineProperty(AccessibilityManager.prototype, "isActive", {
        /**
         * Value of `true` if accessibility is currently active and accessibility layers are showing.
         * @member {boolean}
         * @readonly
         */
        get: function () {
            return this._isActive;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AccessibilityManager.prototype, "isMobileAccessibility", {
        /**
         * Value of `true` if accessibility is enabled for touch devices.
         * @member {boolean}
         * @readonly
         */
        get: function () {
            return this._isMobileAccessibility;
        },
        enumerable: false,
        configurable: true
    });
    /**
     * Creates the touch hooks.
     * @private
     */
    AccessibilityManager.prototype.createTouchHook = function () {
        var _this = this;
        var hookDiv = document.createElement('button');
        hookDiv.style.width = DIV_HOOK_SIZE + "px";
        hookDiv.style.height = DIV_HOOK_SIZE + "px";
        hookDiv.style.position = 'absolute';
        hookDiv.style.top = DIV_HOOK_POS_X + "px";
        hookDiv.style.left = DIV_HOOK_POS_Y + "px";
        hookDiv.style.zIndex = DIV_HOOK_ZINDEX.toString();
        hookDiv.style.backgroundColor = '#FF0000';
        hookDiv.title = 'select to enable accessibility for this content';
        hookDiv.addEventListener('focus', function () {
            _this._isMobileAccessibility = true;
            _this.activate();
            _this.destroyTouchHook();
        });
        document.body.appendChild(hookDiv);
        this._hookDiv = hookDiv;
    };
    /**
     * Destroys the touch hooks.
     * @private
     */
    AccessibilityManager.prototype.destroyTouchHook = function () {
        if (!this._hookDiv) {
            return;
        }
        document.body.removeChild(this._hookDiv);
        this._hookDiv = null;
    };
    /**
     * Activating will cause the Accessibility layer to be shown.
     * This is called when a user presses the tab key.
     * @private
     */
    AccessibilityManager.prototype.activate = function () {
        var _a;
        if (this._isActive) {
            return;
        }
        this._isActive = true;
        globalThis.document.addEventListener('mousemove', this._onMouseMove, true);
        globalThis.removeEventListener('keydown', this._onKeyDown, false);
        this.renderer.on('postrender', this.update, this);
        (_a = this.renderer.view.parentNode) === null || _a === void 0 ? void 0 : _a.appendChild(this.div);
    };
    /**
     * Deactivating will cause the Accessibility layer to be hidden.
     * This is called when a user moves the mouse.
     * @private
     */
    AccessibilityManager.prototype.deactivate = function () {
        var _a;
        if (!this._isActive || this._isMobileAccessibility) {
            return;
        }
        this._isActive = false;
        globalThis.document.removeEventListener('mousemove', this._onMouseMove, true);
        globalThis.addEventListener('keydown', this._onKeyDown, false);
        this.renderer.off('postrender', this.update);
        (_a = this.div.parentNode) === null || _a === void 0 ? void 0 : _a.removeChild(this.div);
    };
    /**
     * This recursive function will run through the scene graph and add any new accessible objects to the DOM layer.
     * @private
     * @param {PIXI.Container} displayObject - The DisplayObject to check.
     */
    AccessibilityManager.prototype.updateAccessibleObjects = function (displayObject) {
        if (!displayObject.visible || !displayObject.accessibleChildren) {
            return;
        }
        if (displayObject.accessible && displayObject.interactive) {
            if (!displayObject._accessibleActive) {
                this.addChild(displayObject);
            }
            displayObject.renderId = this.renderId;
        }
        var children = displayObject.children;
        if (children) {
            for (var i = 0; i < children.length; i++) {
                this.updateAccessibleObjects(children[i]);
            }
        }
    };
    /**
     * Before each render this function will ensure that all divs are mapped correctly to their DisplayObjects.
     * @private
     */
    AccessibilityManager.prototype.update = function () {
        /* On Android default web browser, tab order seems to be calculated by position rather than tabIndex,
        *  moving buttons can cause focus to flicker between two buttons making it hard/impossible to navigate,
        *  so I am just running update every half a second, seems to fix it.
        */
        var now = performance.now();
        if (utils.isMobile.android.device && now < this.androidUpdateCount) {
            return;
        }
        this.androidUpdateCount = now + this.androidUpdateFrequency;
        if (!this.renderer.renderingToScreen) {
            return;
        }
        // update children...
        if (this.renderer._lastObjectRendered) {
            this.updateAccessibleObjects(this.renderer._lastObjectRendered);
        }
        var _a = this.renderer.view.getBoundingClientRect(), left = _a.left, top = _a.top, width = _a.width, height = _a.height;
        var _b = this.renderer, viewWidth = _b.width, viewHeight = _b.height, resolution = _b.resolution;
        var sx = (width / viewWidth) * resolution;
        var sy = (height / viewHeight) * resolution;
        var div = this.div;
        div.style.left = left + "px";
        div.style.top = top + "px";
        div.style.width = viewWidth + "px";
        div.style.height = viewHeight + "px";
        for (var i = 0; i < this.children.length; i++) {
            var child = this.children[i];
            if (child.renderId !== this.renderId) {
                child._accessibleActive = false;
                utils.removeItems(this.children, i, 1);
                this.div.removeChild(child._accessibleDiv);
                this.pool.push(child._accessibleDiv);
                child._accessibleDiv = null;
                i--;
            }
            else {
                // map div to display..
                div = child._accessibleDiv;
                var hitArea = child.hitArea;
                var wt = child.worldTransform;
                if (child.hitArea) {
                    div.style.left = (wt.tx + (hitArea.x * wt.a)) * sx + "px";
                    div.style.top = (wt.ty + (hitArea.y * wt.d)) * sy + "px";
                    div.style.width = hitArea.width * wt.a * sx + "px";
                    div.style.height = hitArea.height * wt.d * sy + "px";
                }
                else {
                    hitArea = child.getBounds();
                    this.capHitArea(hitArea);
                    div.style.left = hitArea.x * sx + "px";
                    div.style.top = hitArea.y * sy + "px";
                    div.style.width = hitArea.width * sx + "px";
                    div.style.height = hitArea.height * sy + "px";
                    // update button titles and hints if they exist and they've changed
                    if (div.title !== child.accessibleTitle && child.accessibleTitle !== null) {
                        div.title = child.accessibleTitle;
                    }
                    if (div.getAttribute('aria-label') !== child.accessibleHint
                        && child.accessibleHint !== null) {
                        div.setAttribute('aria-label', child.accessibleHint);
                    }
                }
                // the title or index may have changed, if so lets update it!
                if (child.accessibleTitle !== div.title || child.tabIndex !== div.tabIndex) {
                    div.title = child.accessibleTitle;
                    div.tabIndex = child.tabIndex;
                    if (this.debug)
                        { this.updateDebugHTML(div); }
                }
            }
        }
        // increment the render id..
        this.renderId++;
    };
    /**
     * private function that will visually add the information to the
     * accessability div
     * @param {HTMLElement} div -
     */
    AccessibilityManager.prototype.updateDebugHTML = function (div) {
        div.innerHTML = "type: " + div.type + "</br> title : " + div.title + "</br> tabIndex: " + div.tabIndex;
    };
    /**
     * Adjust the hit area based on the bounds of a display object
     * @param {PIXI.Rectangle} hitArea - Bounds of the child
     */
    AccessibilityManager.prototype.capHitArea = function (hitArea) {
        if (hitArea.x < 0) {
            hitArea.width += hitArea.x;
            hitArea.x = 0;
        }
        if (hitArea.y < 0) {
            hitArea.height += hitArea.y;
            hitArea.y = 0;
        }
        var _a = this.renderer, viewWidth = _a.width, viewHeight = _a.height;
        if (hitArea.x + hitArea.width > viewWidth) {
            hitArea.width = viewWidth - hitArea.x;
        }
        if (hitArea.y + hitArea.height > viewHeight) {
            hitArea.height = viewHeight - hitArea.y;
        }
    };
    /**
     * Adds a DisplayObject to the accessibility manager
     * @private
     * @param {PIXI.DisplayObject} displayObject - The child to make accessible.
     */
    AccessibilityManager.prototype.addChild = function (displayObject) {
        //    this.activate();
        var div = this.pool.pop();
        if (!div) {
            div = document.createElement('button');
            div.style.width = DIV_TOUCH_SIZE + "px";
            div.style.height = DIV_TOUCH_SIZE + "px";
            div.style.backgroundColor = this.debug ? 'rgba(255,255,255,0.5)' : 'transparent';
            div.style.position = 'absolute';
            div.style.zIndex = DIV_TOUCH_ZINDEX.toString();
            div.style.borderStyle = 'none';
            // ARIA attributes ensure that button title and hint updates are announced properly
            if (navigator.userAgent.toLowerCase().indexOf('chrome') > -1) {
                // Chrome doesn't need aria-live to work as intended; in fact it just gets more confused.
                div.setAttribute('aria-live', 'off');
            }
            else {
                div.setAttribute('aria-live', 'polite');
            }
            if (navigator.userAgent.match(/rv:.*Gecko\//)) {
                // FireFox needs this to announce only the new button name
                div.setAttribute('aria-relevant', 'additions');
            }
            else {
                // required by IE, other browsers don't much care
                div.setAttribute('aria-relevant', 'text');
            }
            div.addEventListener('click', this._onClick.bind(this));
            div.addEventListener('focus', this._onFocus.bind(this));
            div.addEventListener('focusout', this._onFocusOut.bind(this));
        }
        // set pointer events
        div.style.pointerEvents = displayObject.accessiblePointerEvents;
        // set the type, this defaults to button!
        div.type = displayObject.accessibleType;
        if (displayObject.accessibleTitle && displayObject.accessibleTitle !== null) {
            div.title = displayObject.accessibleTitle;
        }
        else if (!displayObject.accessibleHint
            || displayObject.accessibleHint === null) {
            div.title = "displayObject " + displayObject.tabIndex;
        }
        if (displayObject.accessibleHint
            && displayObject.accessibleHint !== null) {
            div.setAttribute('aria-label', displayObject.accessibleHint);
        }
        if (this.debug)
            { this.updateDebugHTML(div); }
        displayObject._accessibleActive = true;
        displayObject._accessibleDiv = div;
        div.displayObject = displayObject;
        this.children.push(displayObject);
        this.div.appendChild(displayObject._accessibleDiv);
        displayObject._accessibleDiv.tabIndex = displayObject.tabIndex;
    };
    /**
     * Maps the div button press to pixi's InteractionManager (click)
     * @private
     * @param {MouseEvent} e - The click event.
     */
    AccessibilityManager.prototype._onClick = function (e) {
        var interactionManager = this.renderer.plugins.interaction;
        var displayObject = e.target.displayObject;
        var eventData = interactionManager.eventData;
        interactionManager.dispatchEvent(displayObject, 'click', eventData);
        interactionManager.dispatchEvent(displayObject, 'pointertap', eventData);
        interactionManager.dispatchEvent(displayObject, 'tap', eventData);
    };
    /**
     * Maps the div focus events to pixi's InteractionManager (mouseover)
     * @private
     * @param {FocusEvent} e - The focus event.
     */
    AccessibilityManager.prototype._onFocus = function (e) {
        if (!e.target.getAttribute('aria-live')) {
            e.target.setAttribute('aria-live', 'assertive');
        }
        var interactionManager = this.renderer.plugins.interaction;
        var displayObject = e.target.displayObject;
        var eventData = interactionManager.eventData;
        interactionManager.dispatchEvent(displayObject, 'mouseover', eventData);
    };
    /**
     * Maps the div focus events to pixi's InteractionManager (mouseout)
     * @private
     * @param {FocusEvent} e - The focusout event.
     */
    AccessibilityManager.prototype._onFocusOut = function (e) {
        if (!e.target.getAttribute('aria-live')) {
            e.target.setAttribute('aria-live', 'polite');
        }
        var interactionManager = this.renderer.plugins.interaction;
        var displayObject = e.target.displayObject;
        var eventData = interactionManager.eventData;
        interactionManager.dispatchEvent(displayObject, 'mouseout', eventData);
    };
    /**
     * Is called when a key is pressed
     * @private
     * @param {KeyboardEvent} e - The keydown event.
     */
    AccessibilityManager.prototype._onKeyDown = function (e) {
        if (e.keyCode !== KEY_CODE_TAB) {
            return;
        }
        this.activate();
    };
    /**
     * Is called when the mouse moves across the renderer element
     * @private
     * @param {MouseEvent} e - The mouse event.
     */
    AccessibilityManager.prototype._onMouseMove = function (e) {
        if (e.movementX === 0 && e.movementY === 0) {
            return;
        }
        this.deactivate();
    };
    /** Destroys the accessibility manager */
    AccessibilityManager.prototype.destroy = function () {
        this.destroyTouchHook();
        this.div = null;
        globalThis.document.removeEventListener('mousemove', this._onMouseMove, true);
        globalThis.removeEventListener('keydown', this._onKeyDown);
        this.pool = null;
        this.children = null;
        this.renderer = null;
    };
    /** @ignore */
    AccessibilityManager.extension = {
        name: 'accessibility',
        type: [
            core.ExtensionType.RendererPlugin,
            core.ExtensionType.CanvasRendererPlugin ],
    };
    return AccessibilityManager;
}());

exports.AccessibilityManager = AccessibilityManager;
exports.accessibleTarget = accessibleTarget;
//# sourceMappingURL=accessibility.js.map
