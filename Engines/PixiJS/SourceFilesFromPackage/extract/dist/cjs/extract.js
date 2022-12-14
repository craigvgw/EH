/*!
 * @pixi/extract - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/extract is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

var utils = require('@pixi/utils');
var math = require('@pixi/math');
var core = require('@pixi/core');

var TEMP_RECT = new math.Rectangle();
var BYTES_PER_PIXEL = 4;
/**
 * This class provides renderer-specific plugins for exporting content from a renderer.
 * For instance, these plugins can be used for saving an Image, Canvas element or for exporting the raw image data (pixels).
 *
 * Do not instantiate these plugins directly. It is available from the `renderer.plugins` property.
 * See {@link PIXI.CanvasRenderer#plugins} or {@link PIXI.Renderer#plugins}.
 * @example
 * // Create a new app (will auto-add extract plugin to renderer)
 * const app = new PIXI.Application();
 *
 * // Draw a red circle
 * const graphics = new PIXI.Graphics()
 *     .beginFill(0xFF0000)
 *     .drawCircle(0, 0, 50);
 *
 * // Render the graphics as an HTMLImageElement
 * const image = app.renderer.plugins.extract.image(graphics);
 * document.body.appendChild(image);
 * @memberof PIXI
 */
var Extract = /** @class */ (function () {
    /**
     * @param renderer - A reference to the current renderer
     */
    function Extract(renderer) {
        this.renderer = renderer;
    }
    /**
     * Will return a HTML Image of the target
     * @param target - A displayObject or renderTexture
     *  to convert. If left empty will use the main renderer
     * @param format - Image format, e.g. "image/jpeg" or "image/webp".
     * @param quality - JPEG or Webp compression from 0 to 1. Default is 0.92.
     * @returns - HTML Image of the target
     */
    Extract.prototype.image = function (target, format, quality) {
        var image = new Image();
        image.src = this.base64(target, format, quality);
        return image;
    };
    /**
     * Will return a base64 encoded string of this target. It works by calling
     *  `Extract.getCanvas` and then running toDataURL on that.
     * @param target - A displayObject or renderTexture
     *  to convert. If left empty will use the main renderer
     * @param format - Image format, e.g. "image/jpeg" or "image/webp".
     * @param quality - JPEG or Webp compression from 0 to 1. Default is 0.92.
     * @returns - A base64 encoded string of the texture.
     */
    Extract.prototype.base64 = function (target, format, quality) {
        return this.canvas(target).toDataURL(format, quality);
    };
    /**
     * Creates a Canvas element, renders this target to it and then returns it.
     * @param target - A displayObject or renderTexture
     *  to convert. If left empty will use the main renderer
     * @param frame - The frame the extraction is restricted to.
     * @returns - A Canvas element with the texture rendered on.
     */
    Extract.prototype.canvas = function (target, frame) {
        var renderer = this.renderer;
        var resolution;
        var flipY = false;
        var renderTexture;
        var generated = false;
        if (target) {
            if (target instanceof core.RenderTexture) {
                renderTexture = target;
            }
            else {
                renderTexture = this.renderer.generateTexture(target);
                generated = true;
            }
        }
        if (renderTexture) {
            resolution = renderTexture.baseTexture.resolution;
            frame = frame !== null && frame !== void 0 ? frame : renderTexture.frame;
            flipY = false;
            renderer.renderTexture.bind(renderTexture);
        }
        else {
            resolution = renderer.resolution;
            if (!frame) {
                frame = TEMP_RECT;
                frame.width = renderer.width;
                frame.height = renderer.height;
            }
            flipY = true;
            renderer.renderTexture.bind(null);
        }
        var width = Math.round(frame.width * resolution);
        var height = Math.round(frame.height * resolution);
        var canvasBuffer = new utils.CanvasRenderTarget(width, height, 1);
        var webglPixels = new Uint8Array(BYTES_PER_PIXEL * width * height);
        // read pixels to the array
        var gl = renderer.gl;
        gl.readPixels(Math.round(frame.x * resolution), Math.round(frame.y * resolution), width, height, gl.RGBA, gl.UNSIGNED_BYTE, webglPixels);
        // add the pixels to the canvas
        var canvasData = canvasBuffer.context.getImageData(0, 0, width, height);
        Extract.arrayPostDivide(webglPixels, canvasData.data);
        canvasBuffer.context.putImageData(canvasData, 0, 0);
        // pulling pixels
        if (flipY) {
            var target_1 = new utils.CanvasRenderTarget(canvasBuffer.width, canvasBuffer.height, 1);
            target_1.context.scale(1, -1);
            // we can't render to itself because we should be empty before render.
            target_1.context.drawImage(canvasBuffer.canvas, 0, -height);
            canvasBuffer.destroy();
            canvasBuffer = target_1;
        }
        if (generated) {
            renderTexture.destroy(true);
        }
        // send the canvas back..
        return canvasBuffer.canvas;
    };
    /**
     * Will return a one-dimensional array containing the pixel data of the entire texture in RGBA
     * order, with integer values between 0 and 255 (included).
     * @param target - A displayObject or renderTexture
     *  to convert. If left empty will use the main renderer
     * @param frame - The frame the extraction is restricted to.
     * @returns - One-dimensional array containing the pixel data of the entire texture
     */
    Extract.prototype.pixels = function (target, frame) {
        var renderer = this.renderer;
        var resolution;
        var renderTexture;
        var generated = false;
        if (target) {
            if (target instanceof core.RenderTexture) {
                renderTexture = target;
            }
            else {
                renderTexture = this.renderer.generateTexture(target);
                generated = true;
            }
        }
        if (renderTexture) {
            resolution = renderTexture.baseTexture.resolution;
            frame = frame !== null && frame !== void 0 ? frame : renderTexture.frame;
            renderer.renderTexture.bind(renderTexture);
        }
        else {
            resolution = renderer.resolution;
            if (!frame) {
                frame = TEMP_RECT;
                frame.width = renderer.width;
                frame.height = renderer.height;
            }
            renderer.renderTexture.bind(null);
        }
        var width = Math.round(frame.width * resolution);
        var height = Math.round(frame.height * resolution);
        var webglPixels = new Uint8Array(BYTES_PER_PIXEL * width * height);
        // read pixels to the array
        var gl = renderer.gl;
        gl.readPixels(Math.round(frame.x * resolution), Math.round(frame.y * resolution), width, height, gl.RGBA, gl.UNSIGNED_BYTE, webglPixels);
        if (generated) {
            renderTexture.destroy(true);
        }
        Extract.arrayPostDivide(webglPixels, webglPixels);
        return webglPixels;
    };
    /** Destroys the extract. */
    Extract.prototype.destroy = function () {
        this.renderer = null;
    };
    /**
     * Takes premultiplied pixel data and produces regular pixel data
     * @private
     * @param pixels - array of pixel data
     * @param out - output array
     */
    Extract.arrayPostDivide = function (pixels, out) {
        for (var i = 0; i < pixels.length; i += 4) {
            var alpha = out[i + 3] = pixels[i + 3];
            if (alpha !== 0) {
                out[i] = Math.round(Math.min(pixels[i] * 255.0 / alpha, 255.0));
                out[i + 1] = Math.round(Math.min(pixels[i + 1] * 255.0 / alpha, 255.0));
                out[i + 2] = Math.round(Math.min(pixels[i + 2] * 255.0 / alpha, 255.0));
            }
            else {
                out[i] = pixels[i];
                out[i + 1] = pixels[i + 1];
                out[i + 2] = pixels[i + 2];
            }
        }
    };
    /** @ignore */
    Extract.extension = {
        name: 'extract',
        type: core.ExtensionType.RendererPlugin,
    };
    return Extract;
}());

exports.Extract = Extract;
//# sourceMappingURL=extract.js.map
