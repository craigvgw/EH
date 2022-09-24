namespace EventHorizon.Blazor.TypeScript.Interop.Generator.PixiJs.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime;
    using System.Threading;
    using System.Xml.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;

    using ServerGenerator = Blazor.Interop.Generator.GenerateInteropSource;
    using ServerProjectWriter = Blazor.Interop.Generator.Writers.Project.ServerProjectWriter;
    using WasmGenerator = GenerateSource;
    using WasmProjectWriter = Writers.Project.ProjectWriter;

    public class Program
    {
        static void Main(string[] args)
        {
            //Run(AstParser.Model.ASTParserType.NodeJS, true); //  75084ms/71877ms to generate.
            Run(AstParser.Model.ASTParserType.Sdcb, true, "EventHorizon.Blazor.PixiJs.WASM"); //  22027ms/19835ms/18236ms to generate.

            //    Run(AstParser.Model.ASTParserType.Sdcb, false, "EventHorizon.Blazor.BabylonJS.Server");

        }

        static void Run( AstParser.Model.ASTParserType type, bool useWasm, string projectAssembly )
        {
            var stopwatch = Stopwatch.StartNew();
            //var projectAssembly = "EventHorizon.Blazor.BabylonJS.WASM";
            var projectGenerationLocation = Path.Combine( "..", "_generated" );
            var sourceDirectory = Path.Combine( ".", "SourceFiles" );
            var textFormatter = new NoFormattingTextFormatter();

            var sourceFiles = new List<string>
            {
                @"accessibility\index.d.ts",
                @"app\index.d.ts",
                @"compressed-textures\index.d.ts",
                @"constants\index.d.ts",
                @"core\index.d.ts",
                @"display\index.d.ts",
                @"extensions\index.d.ts",
                @"extract\index.d.ts",
                @"filter-alpha\index.d.ts",
                @"filter-blur\index.d.ts",
                @"filter-color-matrix\index.d.ts",
                @"filter-displacement\index.d.ts",
                @"filter-fxaa\index.d.ts",
                @"filter-noise\index.d.ts",
                @"graphics\index.d.ts",
                @"interaction\index.d.ts",
                @"loaders\index.d.ts",
                @"math\index.d.ts",
                @"mesh\index.d.ts",
                @"mesh-extras\index.d.ts",
                @"mixin-cache-as-bitmap\index.d.ts",
                @"mixin-get-child-by-name\index.d.ts",
                @"mixin-get-global-position\index.d.ts",
                @"particle-container\index.d.ts",
                @"polyfill\index.d.ts",
                @"prepare\index.d.ts",
                @"runner\index.d.ts",
                @"settings\index.d.ts",
                @"sprite\index.d.ts",
                @"sprite-animated\index.d.ts",
                @"spritesheet\index.d.ts",
                @"sprite-tiling\index.d.ts",
                @"text\index.d.ts",
                @"text-bitmap\index.d.ts",
                @"ticker\index.d.ts",
                @"utils\index.d.ts",

            };

            var generationList = new List<string>
            {
                
                // accessibility
                // interfaces
             //   "IDisplayObject",  // probably need to include global.d.ts for this
                "IAccessibleHTMLElement",
                "IAccessibleTarget",

                // classes
                "AccessibilityManager",

/*
                // app
                // interfaces
            //    "IApplication",   // global
                "IApplicationOptions",
                "IApplicationPlugin",
                
                // classes
                "Application",    
                "ResizePlugin",


                // compressed-textures
                // interfaces
            //    "IBaseTexture",  // global
                "IBlobOptions",
                "ICompressedTextureResourceOptions",

                // type
                "CompressedLevelBuffer",
                "CompressedTextureExtensionRef",
                "CompressedTextureExtensions",
                "CompressedTextureManifest",

                // classes
                "BlobResource",
                "CompressedTextureLoader",
                "CompressedTextureResource",
                "DDSLoader",
                "KTXLoader",


                // constants
                // nothing


                // core
                // interfaces
            //    "IBaseTexture",         // global
            //    "Texture",              // global
            //    "BaseRenderTexture",    // global
            //    "IRendererOptions",     // global

                "BaseRenderTexture",
                "BaseTexture",
                "IArrayBuffer",
                "IAttributeData",
                "IBaseTextureOptions",
                "IBatchableElement",
                "IBatchFactoryOptions",
                "ICubeResourceOptions",
                "IFilterTarget",
                "IGenerateTextureOptions",
                "IImageResourceOptions",
                "IMaskTarget",
                "IRenderableContainer",
                "IRenderableObject",
                "IRendererOptions",
                "IRendererOptionsAuto",
                "IRendererPlugin",
                "IRendererPluginConstructor",
                "IRendererPlugins",
                "IRendererRenderOptions",
                "IRenderingContext",
                "IResourcePlugin",
                "IResourcePluginOptions",
                "ISpriteMaskFilter",
                "ISpriteMaskTarget",
                "ISupportDict",
                "ISVGResourceOptions",
                "ISystem",
                "ISystemConstructor",
                "ITypedArray",
                "IUniformData",
                "IUniformParser",
                "IUnloadableTexture",
                "IVideoResourceOptions",
                "IVideoResourceOptionsElement",
                "Texture",
                "UBOElement",
                "WEBGL_compressed_texture_atc",
                "WEBGL_compressed_texture_etc1_2",
                "WEBGL_compressed_texture_etc_2",
                "WEBGL_compressed_texture_pvrtc_2",
                "WebGLExtensions",

                // types
                "IAutoDetectOptions",
                "IResourcePluginOptions",
                "TextureSource",

                // classes
                "AbstractBatchRenderer",
                "AbstractMultiResource",
                "AbstractRenderer",
                "ArrayResource",
                "Attribute",
                "BaseImageResource",
                "BaseRenderTexture",
                "BaseTexture",
                "BatchDrawCall",
                "BatchGeometry",
                "BatchPluginFactory",
                "BatchShaderGenerator",
                "BatchSystem",
                "BatchTextureArray",
                "Buffer_2",
                "BufferResource",
                "BufferSystem",
                "CanvasResource",
                "ContextSystem",
                "CubeResource",
                "Filter",
                "FilterState",
                "FilterSystem",
                "Framebuffer",
                "FramebufferSystem",
                "Geometry",
                "GeometrySystem",
                "GLBuffer",
                "GLFramebuffer",
                "GLProgram",
                "GLTexture",
                "IGLUniformData",
                "ImageBitmapResource",
                "ImageResource",
                "MaskData",
                "MaskSystem",
                "ObjectRenderer",
                "Program",
                "ProjectionSystem",
                "Quad",
                "QuadUv",
                "Renderer",
                "RenderTexture",
                "RenderTexturePool",
                "RenderTextureSystem",
                "Resource",
                "ScissorSystem",
                "Shader",
                "ShaderSystem",
                "SpriteMaskFilter",
                "State",
                "StateSystem",
                "StencilSystem",
                "SVGResource",
                "System",
                "Texture",
                "TextureGCSystem",
                "TextureMatrix",
                "TextureSystem",
                "TextureUvs",
                "UniformGroup",
                "VideoResource",
                "ViewableBuffer",


                // display
                // interface
                "Container",
                "DisplayObject",
                "IDestroyOptions",

                // classes
                "Bounds",
                "Container",
                "DisplayObject",
                "TemporaryDisplayObject",


                // extensions
                // interface
                "ExtensionFormat",
                "ExtensionFormatLoose",
                "ExtensionMetadataDetails",

                // types
                "ExtensionHandler",
                "ExtensionMetadata",

                // enum
                "ExtensionType",


                // extract
                // interface
                "PixelExtractOptions",
                
                // class
                "Extract_2",


                // filter-alpha
                "AlphaFilter",


                // filter-blur
                "BlurFilter",
                "BlurFilterPass",

                // filter-color-matrix
                // type
                "ColorMatrix",
                
                // class
                "ColorMatrixFilter",


                // filter-displacement
                "DisplacementFilter",


                // filter-fxaa
                "FXAAFilter",


                // filter-noise
                "NoiseFilter",


                // graphics
                // interface 
                "Graphics",
                "IArcLikeShape",
                "IFillStyleOptions",
                "IGraphicsBatchElement",
                "IGraphicsCurvesSettings",
                "ILineStyleOptions",

                // type
                "IShape_2",

                // classes
                "ArcUtils",
                "BatchPart",
                "BezierUtils",
                "FillStyle",
                "Graphics",
                "GraphicsData",
                "GraphicsGeometry",
                "LineStyle",
                "QuadraticUtils",


                // interaction
                // interface
                "DelayedEvent",
                "IHitArea",
                "InteractionManagerOptions",
                "InteractionTrackingFlags",
                "InteractiveTarget",

                // types
                "Cursor",
                "InteractionCallback",
                "InteractivePointerEvent",

                // classes
                "InteractionData",
                "InteractionEvent",
                "InteractionManager",
                "InteractionTrackingData",
                "TreeSearch",
                "InteractionEvent",
                "InteractionEvent",



                // loaders
                // interface
                "IAddOptions",
                "ILoaderAdd",
                "ILoaderPlugin",
                "IResourceMetadata",
                "LoaderResource",

                // classes
                "AppLoaderPlugin",
                "Loader",
                "LoaderResource",
                "Signal",
                "SignalBinding",
                "TextureLoader",


                // math
                "IPoint",
                "IPointData",
                "ISize",
                "ObservablePoint",
                "Point",
                "Rectangle",
                "Transform",

                // type
                "GD8Symmetry",
                "IShape",

                // classes
                "Circle",
                "Ellipse",
                "Matrix",
                "ObservablePoint",
                "Point",
                "Polygon",
                "Rectangle",
                "RoundedRectangle",
                "Transform",


                // mesh
                // interfaces
                "IMeshMaterialOptions",
                "Mesh",
                "MeshMaterial",

                // classes
                "Mesh",
                "MeshBatchUvs",
                "MeshGeometry",
                "MeshMaterial",

                            
                // mesh-extras
                
                // classes
                "NineSlicePlane",
                "PlaneGeometry",
                "RopeGeometry",
                "SimpleMesh",
                "SimplePlane",
                "SimpleRope",

                // mixin-cache-as-bitmap
                "CacheData",

                // mixin-get-child-by-name

                // mixin-get-global-position

                // particle-container
                // interfaces
                "IParticleProperties",
                "IParticleRendererProperty",

                // classes
                "ParticleBuffer",
                "ParticleContainer",
                "ParticleRenderer",

                // polyfill

                // prepare
                // interfaces
                "IDisplayObjectExtended",
                "IFindHook",
                "IUploadHook",

                // classes
                "BasePrepare",
                "CountLimiter",
                "Prepare",
                "TimeLimiter",


                // runner
                "Runner",

                // settings
                "IAdapter",
                "IRenderOptions",
                "ISettings",

                // type
                "isMobileResult",


                // sprite
                // interface
                "Sprite",

                // type
                "SpriteSource",

                // classes
                "Sprite",


                // sprite-animated
                // interface
                "FrameObject",

                // class
                "AnimatedSprite",


                // spritesheet
                // interface
                "ISpritesheetData",
                "ISpritesheetFrameData",

                // class
                "Spritesheet",
                "SpritesheetLoader",


                // sprite-tiling
                // interface
                "TilingSprite",

                // class
                "TilingSprite",
                "TilingSpriteRenderer",


                // text
                // interface
                "IFontMetrics",
                "ITextStyle",
                "ModernContext2D",

                // type
                "TextStyleAlign",
                "TextStyleFill",
                "TextStyleFontStyle",
                "TextStyleFontVariant",
                "TextStyleFontWeight",
                "TextStyleLineJoin",
                "TextStyleTextBaseline",
                "TextStyleWhiteSpace",

                // class
                "Text_2",
                "TextMetrics_2",
                "TextStyle",


                // text-bitmap
                // interface
                "IBitmapFontCharacter",
                "IBitmapFontDataChar",
                "IBitmapFontDataCommon",
                "IBitmapFontDataDistanceField",
                "IBitmapFontDataInfo",
                "IBitmapFontDataKerning",
                "IBitmapFontDataPage",
                "IBitmapFontOptions",
                "IBitmapFontRawData",
                "IBitmapTextFontDescriptor",
                "IBitmapTextStyle",
                "PageMeshData",

                // classes
                "BitmapFont",
                "BitmapFontData",
                "BitmapFontLoader",
                "BitmapText",
                "TextFormat",
                "XMLFormat",
                "XMLStringFormat",


                // ticker
                // type
                "TickerCallback",

                // class
                "Ticker",
                "TickerPlugin",


                // utils
                // interface
                "DecomposedDataUri",
                "ParsedUrlQuery",
                "ParsedUrlQueryInput",
                "Path",
                "Url",
                "URLFormatOptions",
                "UrlObject",
                "UrlObjectCommon",
                "UrlWithParsedQuery",
                "UrlWithStringQuery",

                // types
                "ArrayFixed",
                "Dict",
                "FormatFunction",
                "PackedArray",
                "ParseFunction",

                // class
                "CanvasRenderTarget"
*/
            };

            // Remove any already Generated Source.
            if (Directory.Exists(Path.Combine(projectGenerationLocation, projectAssembly )))
            {
                Directory.Delete( Path.Combine( projectGenerationLocation, projectAssembly ), true );
            }

            GlobalLogger.Info("Removed Generation Directory");

            if (useWasm)
            {
                GlobalLogger.Info("Running Wasm Generator");
                var writer = new WasmProjectWriter(projectGenerationLocation, projectAssembly );

                new WasmGenerator().Run(
                    projectAssembly,
                    sourceDirectory,
                    sourceFiles,
                    generationList,
                    writer,
                    textFormatter,
                    new Dictionary<string, string>
                    {
                        { "PixiJs.PointerInfoBase | type", "int" }
                    },
                    type
                );
            }
            else
            {
                GlobalLogger.Info("Running Server Generator");
                var writer = new ServerProjectWriter( projectGenerationLocation, projectAssembly );

                new ServerGenerator().Run(
                    projectAssembly,
                    sourceDirectory,
                    sourceFiles,
                    generationList,
                    writer,
                    textFormatter,
                    new Dictionary<string, string>
                    {
                        { "PixiJs.PointerInfoBase | type", "int" }
                    },
                    type
                );
            }

            stopwatch.Stop();
            GlobalLogger.Info("Removed Generation Directory");
            GlobalLogger.Info($"Took {stopwatch.ElapsedMilliseconds}ms to generate.");
        }
    }
}
