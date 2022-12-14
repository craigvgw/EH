/// <reference path="./global.d.ts" />

import type { AbstractRenderer } from "./../core/index";
import { Container } from "./../display/index";
import type { ExtensionMetadata } from "./../extensions/index";
import type { IDestroyOptions } from "./../display/index";
import type { IRendererOptionsAuto } from "./../core/index";
import type { Rectangle } from "./../math/index";
import type { Renderer } from "./../core/index";

export declare interface IApplication extends GlobalMixins.IApplication {
}

/**
 * Convenience class to create a new PIXI application.
 *
 * This class automatically creates the renderer, ticker and root container.
 * @example
 * // Create the application
 * const app = new PIXI.Application();
 *
 * // Add the view to the DOM
 * document.body.appendChild(app.view);
 *
 * // ex, add display objects
 * app.stage.addChild(PIXI.Sprite.from('something.png'));
 * @class
 * @memberof PIXI
 */
export declare class Application {
    /** Collection of installed plugins. */
    static _plugins: IApplicationPlugin[];
    /**
     * The root display container that's rendered.
     * @member {PIXI.Container}
     */
    stage: Container;
    /**
     * WebGL renderer if available, otherwise CanvasRenderer.
     * @member {PIXI.Renderer|PIXI.CanvasRenderer}
     */
    renderer: Renderer | AbstractRenderer;
    /**
     * @param {object} [options] - The optional renderer parameters.
     * @param {boolean} [options.autoStart=true] - Automatically starts the rendering after the construction.
     *     **Note**: Setting this parameter to false does NOT stop the shared ticker even if you set
     *     options.sharedTicker to true in case that it is already started. Stop it by your own.
     * @param {number} [options.width=800] - The width of the renderers view.
     * @param {number} [options.height=600] - The height of the renderers view.
     * @param {HTMLCanvasElement} [options.view] - The canvas to use as a view, optional.
     * @param {boolean} [options.useContextAlpha=true] - Pass-through value for canvas' context `alpha` property.
     *   If you want to set transparency, please use `backgroundAlpha`. This option is for cases where the
     *   canvas needs to be opaque, possibly for performance reasons on some older devices.
     * @param {boolean} [options.autoDensity=false] - Resizes renderer view in CSS pixels to allow for
     *   resolutions other than 1.
     * @param {boolean} [options.antialias=false] - Sets antialias
     * @param {boolean} [options.preserveDrawingBuffer=false] - Enables drawing buffer preservation, enable this if you
     *  need to call toDataUrl on the WebGL context.
     * @param {number} [options.resolution=PIXI.settings.RESOLUTION] - The resolution / device pixel ratio of the renderer.
     * @param {boolean} [options.forceCanvas=false] - prevents selection of WebGL renderer, even if such is present, this
     *   option only is available when using **pixi.js-legacy** or **@pixi/canvas-renderer** modules, otherwise
     *   it is ignored.
     * @param {number} [options.backgroundColor=0x000000] - The background color of the rendered area
     *  (shown if not transparent).
     * @param {number} [options.backgroundAlpha=1] - Value from 0 (fully transparent) to 1 (fully opaque).
     * @param {boolean} [options.clearBeforeRender=true] - This sets if the renderer will clear the canvas or
     *   not before the new render pass.
     * @param {string} [options.powerPreference] - Parameter passed to webgl context, set to "high-performance"
     *  for devices with dual graphics card. **(WebGL only)**.
     * @param {boolean} [options.sharedTicker=false] - `true` to use PIXI.Ticker.shared, `false` to create new ticker.
     *  If set to false, you cannot register a handler to occur before anything that runs on the shared ticker.
     *  The system ticker will always run before both the shared ticker and the app ticker.
     * @param {boolean} [options.sharedLoader=false] - `true` to use PIXI.Loader.shared, `false` to create new Loader.
     * @param {Window|HTMLElement} [options.resizeTo] - Element to automatically resize stage to.
     */
    constructor(options?: IApplicationOptions);
    /**
     * Use the {@link PIXI.extensions.add} API to register plugins.
     * @deprecated since 6.5.0
     * @static
     * @param {PIXI.IApplicationPlugin} plugin - Plugin being installed
     */
    static registerPlugin(plugin: IApplicationPlugin): void;
    /** Render the current stage. */
    render(): void;
    /**
     * Reference to the renderer's canvas element.
     * @member {HTMLCanvasElement}
     * @readonly
     */
    get view(): HTMLCanvasElement;
    /**
     * Reference to the renderer's screen rectangle. Its safe to use as `filterArea` or `hitArea` for the whole screen.
     * @member {PIXI.Rectangle}
     * @readonly
     */
    get screen(): Rectangle;
    /**
     * Destroy and don't use after this.
     * @param {boolean} [removeView=false] - Automatically remove canvas from DOM.
     * @param {object|boolean} [stageOptions] - Options parameter. A boolean will act as if all options
     *  have been set to that value
     * @param {boolean} [stageOptions.children=false] - if set to true, all the children will have their destroy
     *  method called as well. 'stageOptions' will be passed on to those calls.
     * @param {boolean} [stageOptions.texture=false] - Only used for child Sprites if stageOptions.children is set
     *  to true. Should it destroy the texture of the child sprite
     * @param {boolean} [stageOptions.baseTexture=false] - Only used for child Sprites if stageOptions.children is set
     *  to true. Should it destroy the base texture of the child sprite
     */
    destroy(removeView?: boolean, stageOptions?: IDestroyOptions | boolean): void;
}

export declare interface IApplicationOptions extends IRendererOptionsAuto, GlobalMixins.IApplicationOptions {
}

/**
 * Any plugin that's usable for Application should contain these methods.
 * @memberof PIXI
 */
export declare interface IApplicationPlugin {
    /**
     * Called when Application is constructed, scoped to Application instance.
     * Passes in `options` as the only argument, which are Application constructor options.
     * @param {object} options - Application options.
     */
    init(options: IApplicationOptions): void;
    /** Called when destroying Application, scoped to Application instance. */
    destroy(): void;
}

declare type ResizeableRenderer = Pick<Renderer, 'resize'>;

/**
 * Middleware for for Application's resize functionality
 * @private
 * @class
 */
export declare class ResizePlugin {
    /** @ignore */
    static extension: ExtensionMetadata;
    static resizeTo: Window | HTMLElement;
    static resize: () => void;
    static renderer: ResizeableRenderer;
    static queueResize: () => void;
    private static _resizeId;
    private static _resizeTo;
    private static cancelResize;
    /**
     * Initialize the plugin with scope of application instance
     * @static
     * @private
     * @param {object} [options] - See application options
     */
    static init(options?: IApplicationOptions): void;
    /**
     * Clean up the ticker, scoped to application
     * @static
     * @private
     */
    static destroy(): void;
}

export { }
