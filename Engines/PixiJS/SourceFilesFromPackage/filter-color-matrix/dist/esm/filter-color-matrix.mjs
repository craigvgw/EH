/*!
 * @pixi/filter-color-matrix - v6.5.2
 * Compiled Wed, 24 Aug 2022 13:51:19 UTC
 *
 * @pixi/filter-color-matrix is licensed under the MIT License.
 * http://www.opensource.org/licenses/mit-license
 */
import { defaultFilterVertex, Filter } from '@pixi/core';

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
/* global Reflect, Promise */

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) { if (b.hasOwnProperty(p)) { d[p] = b[p]; } } };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

var fragment = "varying vec2 vTextureCoord;\nuniform sampler2D uSampler;\nuniform float m[20];\nuniform float uAlpha;\n\nvoid main(void)\n{\n    vec4 c = texture2D(uSampler, vTextureCoord);\n\n    if (uAlpha == 0.0) {\n        gl_FragColor = c;\n        return;\n    }\n\n    // Un-premultiply alpha before applying the color matrix. See issue #3539.\n    if (c.a > 0.0) {\n      c.rgb /= c.a;\n    }\n\n    vec4 result;\n\n    result.r = (m[0] * c.r);\n        result.r += (m[1] * c.g);\n        result.r += (m[2] * c.b);\n        result.r += (m[3] * c.a);\n        result.r += m[4];\n\n    result.g = (m[5] * c.r);\n        result.g += (m[6] * c.g);\n        result.g += (m[7] * c.b);\n        result.g += (m[8] * c.a);\n        result.g += m[9];\n\n    result.b = (m[10] * c.r);\n       result.b += (m[11] * c.g);\n       result.b += (m[12] * c.b);\n       result.b += (m[13] * c.a);\n       result.b += m[14];\n\n    result.a = (m[15] * c.r);\n       result.a += (m[16] * c.g);\n       result.a += (m[17] * c.b);\n       result.a += (m[18] * c.a);\n       result.a += m[19];\n\n    vec3 rgb = mix(c.rgb, result.rgb, uAlpha);\n\n    // Premultiply alpha again.\n    rgb *= result.a;\n\n    gl_FragColor = vec4(rgb, result.a);\n}\n";

/**
 * The ColorMatrixFilter class lets you apply a 5x4 matrix transformation on the RGBA
 * color and alpha values of every pixel on your displayObject to produce a result
 * with a new set of RGBA color and alpha values. It's pretty powerful!
 *
 * ```js
 *  let colorMatrix = new PIXI.filters.ColorMatrixFilter();
 *  container.filters = [colorMatrix];
 *  colorMatrix.contrast(2);
 * ```
 * @author Cl??ment Chenebault <clement@goodboydigital.com>
 * @memberof PIXI.filters
 */
var ColorMatrixFilter = /** @class */ (function (_super) {
    __extends(ColorMatrixFilter, _super);
    function ColorMatrixFilter() {
        var _this = this;
        var uniforms = {
            m: new Float32Array([1, 0, 0, 0, 0,
                0, 1, 0, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 0, 1, 0]),
            uAlpha: 1,
        };
        _this = _super.call(this, defaultFilterVertex, fragment, uniforms) || this;
        _this.alpha = 1;
        return _this;
    }
    /**
     * Transforms current matrix and set the new one
     * @param {number[]} matrix - 5x4 matrix
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype._loadMatrix = function (matrix, multiply) {
        if (multiply === void 0) { multiply = false; }
        var newMatrix = matrix;
        if (multiply) {
            this._multiply(newMatrix, this.uniforms.m, matrix);
            newMatrix = this._colorMatrix(newMatrix);
        }
        // set the new matrix
        this.uniforms.m = newMatrix;
    };
    /**
     * Multiplies two mat5's
     * @private
     * @param out - 5x4 matrix the receiving matrix
     * @param a - 5x4 matrix the first operand
     * @param b - 5x4 matrix the second operand
     * @returns {number[]} 5x4 matrix
     */
    ColorMatrixFilter.prototype._multiply = function (out, a, b) {
        // Red Channel
        out[0] = (a[0] * b[0]) + (a[1] * b[5]) + (a[2] * b[10]) + (a[3] * b[15]);
        out[1] = (a[0] * b[1]) + (a[1] * b[6]) + (a[2] * b[11]) + (a[3] * b[16]);
        out[2] = (a[0] * b[2]) + (a[1] * b[7]) + (a[2] * b[12]) + (a[3] * b[17]);
        out[3] = (a[0] * b[3]) + (a[1] * b[8]) + (a[2] * b[13]) + (a[3] * b[18]);
        out[4] = (a[0] * b[4]) + (a[1] * b[9]) + (a[2] * b[14]) + (a[3] * b[19]) + a[4];
        // Green Channel
        out[5] = (a[5] * b[0]) + (a[6] * b[5]) + (a[7] * b[10]) + (a[8] * b[15]);
        out[6] = (a[5] * b[1]) + (a[6] * b[6]) + (a[7] * b[11]) + (a[8] * b[16]);
        out[7] = (a[5] * b[2]) + (a[6] * b[7]) + (a[7] * b[12]) + (a[8] * b[17]);
        out[8] = (a[5] * b[3]) + (a[6] * b[8]) + (a[7] * b[13]) + (a[8] * b[18]);
        out[9] = (a[5] * b[4]) + (a[6] * b[9]) + (a[7] * b[14]) + (a[8] * b[19]) + a[9];
        // Blue Channel
        out[10] = (a[10] * b[0]) + (a[11] * b[5]) + (a[12] * b[10]) + (a[13] * b[15]);
        out[11] = (a[10] * b[1]) + (a[11] * b[6]) + (a[12] * b[11]) + (a[13] * b[16]);
        out[12] = (a[10] * b[2]) + (a[11] * b[7]) + (a[12] * b[12]) + (a[13] * b[17]);
        out[13] = (a[10] * b[3]) + (a[11] * b[8]) + (a[12] * b[13]) + (a[13] * b[18]);
        out[14] = (a[10] * b[4]) + (a[11] * b[9]) + (a[12] * b[14]) + (a[13] * b[19]) + a[14];
        // Alpha Channel
        out[15] = (a[15] * b[0]) + (a[16] * b[5]) + (a[17] * b[10]) + (a[18] * b[15]);
        out[16] = (a[15] * b[1]) + (a[16] * b[6]) + (a[17] * b[11]) + (a[18] * b[16]);
        out[17] = (a[15] * b[2]) + (a[16] * b[7]) + (a[17] * b[12]) + (a[18] * b[17]);
        out[18] = (a[15] * b[3]) + (a[16] * b[8]) + (a[17] * b[13]) + (a[18] * b[18]);
        out[19] = (a[15] * b[4]) + (a[16] * b[9]) + (a[17] * b[14]) + (a[18] * b[19]) + a[19];
        return out;
    };
    /**
     * Create a Float32 Array and normalize the offset component to 0-1
     * @param {number[]} matrix - 5x4 matrix
     * @returns {number[]} 5x4 matrix with all values between 0-1
     */
    ColorMatrixFilter.prototype._colorMatrix = function (matrix) {
        // Create a Float32 Array and normalize the offset component to 0-1
        var m = new Float32Array(matrix);
        m[4] /= 255;
        m[9] /= 255;
        m[14] /= 255;
        m[19] /= 255;
        return m;
    };
    /**
     * Adjusts brightness
     * @param b - value of the brigthness (0-1, where 0 is black)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.brightness = function (b, multiply) {
        var matrix = [
            b, 0, 0, 0, 0,
            0, b, 0, 0, 0,
            0, 0, b, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Sets each channel on the diagonal of the color matrix.
     * This can be used to achieve a tinting effect on Containers similar to the tint field of some
     * display objects like Sprite, Text, Graphics, and Mesh.
     * @param color - Color of the tint. This is a hex value.
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.tint = function (color, multiply) {
        var r = (color >> 16) & 0xff;
        var g = (color >> 8) & 0xff;
        var b = color & 0xff;
        var matrix = [
            r / 255, 0, 0, 0, 0,
            0, g / 255, 0, 0, 0,
            0, 0, b / 255, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Set the matrices in grey scales
     * @param scale - value of the grey (0-1, where 0 is black)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.greyscale = function (scale, multiply) {
        var matrix = [
            scale, scale, scale, 0, 0,
            scale, scale, scale, 0, 0,
            scale, scale, scale, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Set the black and white matrice.
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.blackAndWhite = function (multiply) {
        var matrix = [
            0.3, 0.6, 0.1, 0, 0,
            0.3, 0.6, 0.1, 0, 0,
            0.3, 0.6, 0.1, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Set the hue property of the color
     * @param rotation - in degrees
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.hue = function (rotation, multiply) {
        rotation = (rotation || 0) / 180 * Math.PI;
        var cosR = Math.cos(rotation);
        var sinR = Math.sin(rotation);
        var sqrt = Math.sqrt;
        /* a good approximation for hue rotation
         This matrix is far better than the versions with magic luminance constants
         formerly used here, but also used in the starling framework (flash) and known from this
         old part of the internet: quasimondo.com/archives/000565.php

         This new matrix is based on rgb cube rotation in space. Look here for a more descriptive
         implementation as a shader not a general matrix:
         https://github.com/evanw/glfx.js/blob/58841c23919bd59787effc0333a4897b43835412/src/filters/adjust/huesaturation.js

         This is the source for the code:
         see http://stackoverflow.com/questions/8507885/shift-hue-of-an-rgb-color/8510751#8510751
         */
        var w = 1 / 3;
        var sqrW = sqrt(w); // weight is
        var a00 = cosR + ((1.0 - cosR) * w);
        var a01 = (w * (1.0 - cosR)) - (sqrW * sinR);
        var a02 = (w * (1.0 - cosR)) + (sqrW * sinR);
        var a10 = (w * (1.0 - cosR)) + (sqrW * sinR);
        var a11 = cosR + (w * (1.0 - cosR));
        var a12 = (w * (1.0 - cosR)) - (sqrW * sinR);
        var a20 = (w * (1.0 - cosR)) - (sqrW * sinR);
        var a21 = (w * (1.0 - cosR)) + (sqrW * sinR);
        var a22 = cosR + (w * (1.0 - cosR));
        var matrix = [
            a00, a01, a02, 0, 0,
            a10, a11, a12, 0, 0,
            a20, a21, a22, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Set the contrast matrix, increase the separation between dark and bright
     * Increase contrast : shadows darker and highlights brighter
     * Decrease contrast : bring the shadows up and the highlights down
     * @param amount - value of the contrast (0-1)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.contrast = function (amount, multiply) {
        var v = (amount || 0) + 1;
        var o = -0.5 * (v - 1);
        var matrix = [
            v, 0, 0, 0, o,
            0, v, 0, 0, o,
            0, 0, v, 0, o,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Set the saturation matrix, increase the separation between colors
     * Increase saturation : increase contrast, brightness, and sharpness
     * @param amount - The saturation amount (0-1)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.saturate = function (amount, multiply) {
        if (amount === void 0) { amount = 0; }
        var x = (amount * 2 / 3) + 1;
        var y = ((x - 1) * -0.5);
        var matrix = [
            x, y, y, 0, 0,
            y, x, y, 0, 0,
            y, y, x, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /** Desaturate image (remove color) Call the saturate function */
    ColorMatrixFilter.prototype.desaturate = function () {
        this.saturate(-1);
    };
    /**
     * Negative image (inverse of classic rgb matrix)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.negative = function (multiply) {
        var matrix = [
            -1, 0, 0, 1, 0,
            0, -1, 0, 1, 0,
            0, 0, -1, 1, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Sepia image
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.sepia = function (multiply) {
        var matrix = [
            0.393, 0.7689999, 0.18899999, 0, 0,
            0.349, 0.6859999, 0.16799999, 0, 0,
            0.272, 0.5339999, 0.13099999, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Color motion picture process invented in 1916 (thanks Dominic Szablewski)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.technicolor = function (multiply) {
        var matrix = [
            1.9125277891456083, -0.8545344976951645, -0.09155508482755585, 0, 11.793603434377337,
            -0.3087833385928097, 1.7658908555458428, -0.10601743074722245, 0, -70.35205161461398,
            -0.231103377548616, -0.7501899197440212, 1.847597816108189, 0, 30.950940869491138,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Polaroid filter
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.polaroid = function (multiply) {
        var matrix = [
            1.438, -0.062, -0.062, 0, 0,
            -0.122, 1.378, -0.122, 0, 0,
            -0.016, -0.016, 1.483, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Filter who transforms : Red -> Blue and Blue -> Red
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.toBGR = function (multiply) {
        var matrix = [
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Color reversal film introduced by Eastman Kodak in 1935. (thanks Dominic Szablewski)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.kodachrome = function (multiply) {
        var matrix = [
            1.1285582396593525, -0.3967382283601348, -0.03992559172921793, 0, 63.72958762196502,
            -0.16404339962244616, 1.0835251566291304, -0.05498805115633132, 0, 24.732407896706203,
            -0.16786010706155763, -0.5603416277695248, 1.6014850761964943, 0, 35.62982807460946,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Brown delicious browni filter (thanks Dominic Szablewski)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.browni = function (multiply) {
        var matrix = [
            0.5997023498159715, 0.34553243048391263, -0.2708298674538042, 0, 47.43192855600873,
            -0.037703249837783157, 0.8609577587992641, 0.15059552388459913, 0, -36.96841498319127,
            0.24113635128153335, -0.07441037908422492, 0.44972182064877153, 0, -7.562075277591283,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Vintage filter (thanks Dominic Szablewski)
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.vintage = function (multiply) {
        var matrix = [
            0.6279345635605994, 0.3202183420819367, -0.03965408211312453, 0, 9.651285835294123,
            0.02578397704808868, 0.6441188644374771, 0.03259127616149294, 0, 7.462829176470591,
            0.0466055556782719, -0.0851232987247891, 0.5241648018700465, 0, 5.159190588235296,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * We don't know exactly what it does, kind of gradient map, but funny to play with!
     * @param desaturation - Tone values.
     * @param toned - Tone values.
     * @param lightColor - Tone values, example: `0xFFE580`
     * @param darkColor - Tone values, example: `0xFFE580`
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.colorTone = function (desaturation, toned, lightColor, darkColor, multiply) {
        desaturation = desaturation || 0.2;
        toned = toned || 0.15;
        lightColor = lightColor || 0xFFE580;
        darkColor = darkColor || 0x338000;
        var lR = ((lightColor >> 16) & 0xFF) / 255;
        var lG = ((lightColor >> 8) & 0xFF) / 255;
        var lB = (lightColor & 0xFF) / 255;
        var dR = ((darkColor >> 16) & 0xFF) / 255;
        var dG = ((darkColor >> 8) & 0xFF) / 255;
        var dB = (darkColor & 0xFF) / 255;
        var matrix = [
            0.3, 0.59, 0.11, 0, 0,
            lR, lG, lB, desaturation, 0,
            dR, dG, dB, toned, 0,
            lR - dR, lG - dG, lB - dB, 0, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Night effect
     * @param intensity - The intensity of the night effect.
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.night = function (intensity, multiply) {
        intensity = intensity || 0.1;
        var matrix = [
            intensity * (-2.0), -intensity, 0, 0, 0,
            -intensity, 0, intensity, 0, 0,
            0, intensity, intensity * 2.0, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * Predator effect
     *
     * Erase the current matrix by setting a new indepent one
     * @param amount - how much the predator feels his future victim
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.predator = function (amount, multiply) {
        var matrix = [
            // row 1
            11.224130630493164 * amount,
            -4.794486999511719 * amount,
            -2.8746118545532227 * amount,
            0 * amount,
            0.40342438220977783 * amount,
            // row 2
            -3.6330697536468506 * amount,
            9.193157196044922 * amount,
            -2.951810836791992 * amount,
            0 * amount,
            -1.316135048866272 * amount,
            // row 3
            -3.2184197902679443 * amount,
            -4.2375030517578125 * amount,
            7.476448059082031 * amount,
            0 * amount,
            0.8044459223747253 * amount,
            // row 4
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /**
     * LSD effect
     *
     * Multiply the current matrix
     * @param multiply - if true, current matrix and matrix are multiplied. If false,
     *  just set the current matrix with @param matrix
     */
    ColorMatrixFilter.prototype.lsd = function (multiply) {
        var matrix = [
            2, -0.4, 0.5, 0, 0,
            -0.5, 2, -0.4, 0, 0,
            -0.4, -0.5, 3, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, multiply);
    };
    /** Erase the current matrix by setting the default one. */
    ColorMatrixFilter.prototype.reset = function () {
        var matrix = [
            1, 0, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 1, 0 ];
        this._loadMatrix(matrix, false);
    };
    Object.defineProperty(ColorMatrixFilter.prototype, "matrix", {
        /**
         * The matrix of the color matrix filter
         * @member {number[]}
         * @default [1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0]
         */
        get: function () {
            return this.uniforms.m;
        },
        set: function (value) {
            this.uniforms.m = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(ColorMatrixFilter.prototype, "alpha", {
        /**
         * The opacity value to use when mixing the original and resultant colors.
         *
         * When the value is 0, the original color is used without modification.
         * When the value is 1, the result color is used.
         * When in the range (0, 1) the color is interpolated between the original and result by this amount.
         * @default 1
         */
        get: function () {
            return this.uniforms.uAlpha;
        },
        set: function (value) {
            this.uniforms.uAlpha = value;
        },
        enumerable: false,
        configurable: true
    });
    return ColorMatrixFilter;
}(Filter));
// Americanized alias
ColorMatrixFilter.prototype.grayscale = ColorMatrixFilter.prototype.greyscale;

export { ColorMatrixFilter };
//# sourceMappingURL=filter-color-matrix.mjs.map
