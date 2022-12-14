/// <reference path="./global.d.ts" />

import type { AbstractRenderer } from "./../core/index";
import type { DisplayObject } from "./../display/index";
import type { ExtensionMetadata } from "./../extensions/index";
import type { Rectangle } from "./../math/index";
import type { Renderer } from "./../core/index";

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
export declare class AccessibilityManager {
    /** @ignore */
    static extension: ExtensionMetadata;
    /** Setting this to true will visually show the divs. */
    debug: boolean;
    /**
     * The renderer this accessibility manager works for.
     * @type {PIXI.CanvasRenderer|PIXI.Renderer}
     */
    renderer: AbstractRenderer | Renderer;
    /** Internal variable, see isActive getter. */
    private _isActive;
    /** Internal variable, see isMobileAccessibility getter. */
    private _isMobileAccessibility;
    /** Button element for handling touch hooks. */
    private _hookDiv;
    /** This is the dom element that will sit over the PixiJS element. This is where the div overlays will go. */
    private div;
    /** A simple pool for storing divs. */
    private pool;
    /** This is a tick used to check if an object is no longer being rendered. */
    private renderId;
    /** The array of currently active accessible items. */
    private children;
    /** Count to throttle div updates on android devices. */
    private androidUpdateCount;
    /**  The frequency to update the div elements. */
    private androidUpdateFrequency;
    /**
     * @param {PIXI.CanvasRenderer|PIXI.Renderer} renderer - A reference to the current renderer
     */
    constructor(renderer: AbstractRenderer | Renderer);
    /**
     * Value of `true` if accessibility is currently active and accessibility layers are showing.
     * @member {boolean}
     * @readonly
     */
    get isActive(): boolean;
    /**
     * Value of `true` if accessibility is enabled for touch devices.
     * @member {boolean}
     * @readonly
     */
    get isMobileAccessibility(): boolean;
    /**
     * Creates the touch hooks.
     * @private
     */
    private createTouchHook;
    /**
     * Destroys the touch hooks.
     * @private
     */
    private destroyTouchHook;
    /**
     * Activating will cause the Accessibility layer to be shown.
     * This is called when a user presses the tab key.
     * @private
     */
    private activate;
    /**
     * Deactivating will cause the Accessibility layer to be hidden.
     * This is called when a user moves the mouse.
     * @private
     */
    private deactivate;
    /**
     * This recursive function will run through the scene graph and add any new accessible objects to the DOM layer.
     * @private
     * @param {PIXI.Container} displayObject - The DisplayObject to check.
     */
    private updateAccessibleObjects;
    /**
     * Before each render this function will ensure that all divs are mapped correctly to their DisplayObjects.
     * @private
     */
    private update;
    /**
     * private function that will visually add the information to the
     * accessability div
     * @param {HTMLElement} div -
     */
    updateDebugHTML(div: IAccessibleHTMLElement): void;
    /**
     * Adjust the hit area based on the bounds of a display object
     * @param {PIXI.Rectangle} hitArea - Bounds of the child
     */
    capHitArea(hitArea: Rectangle): void;
    /**
     * Adds a DisplayObject to the accessibility manager
     * @private
     * @param {PIXI.DisplayObject} displayObject - The child to make accessible.
     */
    private addChild;
    /**
     * Maps the div button press to pixi's InteractionManager (click)
     * @private
     * @param {MouseEvent} e - The click event.
     */
    private _onClick;
    /**
     * Maps the div focus events to pixi's InteractionManager (mouseover)
     * @private
     * @param {FocusEvent} e - The focus event.
     */
    private _onFocus;
    /**
     * Maps the div focus events to pixi's InteractionManager (mouseout)
     * @private
     * @param {FocusEvent} e - The focusout event.
     */
    private _onFocusOut;
    /**
     * Is called when a key is pressed
     * @private
     * @param {KeyboardEvent} e - The keydown event.
     */
    private _onKeyDown;
    /**
     * Is called when the mouse moves across the renderer element
     * @private
     * @param {MouseEvent} e - The mouse event.
     */
    private _onMouseMove;
    /** Destroys the accessibility manager */
    destroy(): void;
}

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
export declare const accessibleTarget: IAccessibleTarget;

export declare interface IAccessibleHTMLElement extends HTMLElement {
    type?: string;
    displayObject?: DisplayObject;
}

export declare interface IAccessibleTarget {
    accessible: boolean;
    accessibleTitle: string;
    accessibleHint: string;
    tabIndex: number;
    _accessibleActive: boolean;
    _accessibleDiv: IAccessibleHTMLElement;
    accessibleType: string;
    accessiblePointerEvents: PointerEvents;
    accessibleChildren: boolean;
    renderId: number;
}

export declare type PointerEvents = 'auto' | 'none' | 'visiblePainted' | 'visibleFill' | 'visibleStroke' | 'visible' | 'painted' | 'fill' | 'stroke' | 'all' | 'inherit';

export { }
