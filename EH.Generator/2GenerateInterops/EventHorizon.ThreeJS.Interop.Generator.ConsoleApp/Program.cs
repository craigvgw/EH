namespace EventHorizon.Blazor.TypeScript.Interop.Generator.ThreeJs.ConsoleApp
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection.Emit;
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
            Run( AstParser.Model.ASTParserType.Sdcb, true, "EventHorizon.Blazor.ThreeJs.WASM" ); //  22027ms/19835ms/18236ms to generate.

            //    Run( AstParser.Model.ASTParserType.Sdcb, false, "EventHorizon.Blazor.BabylonJS.Server" );

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
                // root source folder
                "Three.d.ts",
                "Three.Legacy.d.ts",
                "utils.d.ts",
                "constants.d.ts",

                // animation folder
                @"animation\AnimationAction.d.ts",
                @"animation\AnimationClip.d.ts",
                @"animation\AnimationMixer.d.ts",
                @"animation\AnimationObjectGroup.d.ts",
                @"animation\AnimationUtils.d.ts",
                @"animation\KeyframeTrack.d.ts",
                @"animation\PropertyBinding.d.ts",
                @"animation\PropertyMixer.d.ts",

                @"animation\tracks\BooleanKeyframeTrack.d.ts",
                @"animation\tracks\ColorKeyframeTrack.d.ts",
                @"animation\tracks\NumberKeyframeTrack.d.ts",
                @"animation\tracks\QuaternionKeyframeTrack.d.ts",
                @"animation\tracks\StringKeyframeTrack.d.ts",
                @"animation\tracks\VectorKeyframeTrack.d.ts",

                // audio folder
                @"audio\Audio.d.ts",
                @"audio\AudioAnalyser.d.ts",
                @"audio\AudioContext.d.ts",
                @"audio\AudioListener.d.ts",
                @"audio\PositionalAudio.d.ts",
                
                // cameras folder
                @"cameras\ArrayCamera.d.ts",
                @"cameras\Camera.d.ts",
                @"cameras\CubeCamera.d.ts",
                @"cameras\OrthographicCamera.d.ts",
                @"cameras\PerspectiveCamera.d.ts",
                @"cameras\StereoCamera.d.ts",

                // core folder
                @"core\BufferAttribute.d.ts",
                @"core\BufferGeometry.d.ts",
                @"core\Clock.d.ts",
                @"core\EventDispatcher.d.ts",
                @"core\GLBufferAttribute.d.ts",
                @"core\InstancedBufferAttribute.d.ts",
                @"core\InstancedBufferGeometry.d.ts",
                @"core\InstancedInterleavedBuffer.d.ts",
                @"core\InterleavedBuffer.d.ts",
                @"core\InterleavedBufferAttribute.d.ts",
                @"core\Layers.d.ts",
                @"core\Object3D.d.ts",
                @"core\Raycaster.d.ts",
                @"core\Uniform.d.ts",
                @"core\UniformsGroup.d.ts",

                // extras folder
                @"extras\DataUtils.d.ts",
                @"extras\Earcut.d.ts",
                @"extras\ImageUtils.d.ts",
                @"extras\PMREMGenerator.d.ts",
                @"extras\ShapeUtils.d.ts",
                @"extras\core\Curve.d.ts",
                @"extras\core\CurvePath.d.ts",
                @"extras\core\Path.d.ts",
                @"extras\core\Shape.d.ts",
                @"extras\core\ShapePath.d.ts",
                @"extras\curves\ArcCurve.d.ts",
                @"extras\curves\CatmullRomCurve3.d.ts",
                @"extras\curves\CubicBezierCurve.d.ts",
                @"extras\curves\CubicBezierCurve3.d.ts",
                @"extras\curves\Curves.d.ts",
                @"extras\curves\EllipseCurve.d.ts",
                @"extras\curves\LineCurve.d.ts",
                @"extras\curves\LineCurve3.d.ts",
                @"extras\curves\QuadraticBezierCurve.d.ts",
                @"extras\curves\QuadraticBezierCurve3.d.ts",
                @"extras\curves\SplineCurve.d.ts",

                // geometries folder
                @"geometries\BoxGeometry.d.ts",
                @"geometries\CapsuleGeometry.d.ts",
                @"geometries\CircleGeometry.d.ts",
                @"geometries\ConeGeometry.d.ts",
                @"geometries\CylinderGeometry.d.ts",
                @"geometries\DodecahedronGeometry.d.ts",
                @"geometries\EdgesGeometry.d.ts",
                @"geometries\ExtrudeGeometry.d.ts",
                @"geometries\Geometries.d.ts",
                @"geometries\IcosahedronGeometry.d.ts",
                @"geometries\LatheGeometry.d.ts",
                @"geometries\OctahedronGeometry.d.ts",
                @"geometries\PlaneGeometry.d.ts",
                @"geometries\PolyhedronGeometry.d.ts",
                @"geometries\RingGeometry.d.ts",
                @"geometries\ShapeGeometry.d.ts",
                @"geometries\SphereGeometry.d.ts",
                @"geometries\TetrahedronGeometry.d.ts",
                @"geometries\TorusGeometry.d.ts",
                @"geometries\TorusKnotGeometry.d.ts",
                @"geometries\TubeGeometry.d.ts",
                @"geometries\WireframeGeometry.d.ts",

                // helpers
                @"helpers\ArrowHelper.d.ts",
                @"helpers\AxesHelper.d.ts",
                @"helpers\Box3Helper.d.ts",
                @"helpers\BoxHelper.d.ts",
                @"helpers\CameraHelper.d.ts",
                @"helpers\DirectionalLightHelper.d.ts",
                @"helpers\GridHelper.d.ts",
                @"helpers\HemisphereLightHelper.d.ts",
                @"helpers\PlaneHelper.d.ts",
                @"helpers\PointLightHelper.d.ts",
                @"helpers\PolarGridHelper.d.ts",
                @"helpers\SkeletonHelper.d.ts",
                @"helpers\SpotLightHelper.d.ts",

                // lights folder
                @"lights\AmbientLight.d.ts",
                @"lights\AmbientLightProbe.d.ts",
                @"lights\DirectionalLight.d.ts",
                @"lights\DirectionalLightShadow.d.ts",
                @"lights\HemisphereLight.d.ts",
                @"lights\HemisphereLightProbe.d.ts",
                @"lights\Light.d.ts",
                @"lights\LightProbe.d.ts",
                @"lights\LightShadow.d.ts",
                @"lights\PointLight.d.ts",
                @"lights\PointLightShadow.d.ts",
                @"lights\RectAreaLight.d.ts",
                @"lights\SpotLight.d.ts",
                @"lights\SpotLightShadow.d.ts",

                // loaders folder
                @"loaders\AnimationLoader.d.ts",
                @"loaders\AudioLoader.d.ts",
                @"loaders\BufferGeometryLoader.d.ts",
                @"loaders\Cache.d.ts",
                @"loaders\CompressedTextureLoader.d.ts",
                @"loaders\CubeTextureLoader.d.ts",
                @"loaders\DataTextureLoader.d.ts",
                @"loaders\FileLoader.d.ts",
                @"loaders\ImageBitmapLoader.d.ts",
                @"loaders\ImageLoader.d.ts",
                @"loaders\Loader.d.ts",
                @"loaders\LoaderUtils.d.ts",
                @"loaders\LoadingManager.d.ts",
                @"loaders\MaterialLoader.d.ts",
                @"loaders\ObjectLoader.d.ts",
                @"loaders\TextureLoader.d.ts",

                // materials folder
                @"materials\LineBasicMaterial.d.ts",
                @"materials\LineDashedMaterial.d.ts",
                @"materials\Material.d.ts",
                @"materials\Materials.d.ts",
                @"materials\MeshBasicMaterial.d.ts",
                @"materials\MeshDepthMaterial.d.ts",
                @"materials\MeshDistanceMaterial.d.ts",
                @"materials\MeshLambertMaterial.d.ts",
                @"materials\MeshMatcapMaterial.d.ts",
                @"materials\MeshNormalMaterial.d.ts",
                @"materials\MeshPhongMaterial.d.ts",
                @"materials\MeshPhysicalMaterial.d.ts",
                @"materials\MeshStandardMaterial.d.ts",
                @"materials\MeshToonMaterial.d.ts",
                @"materials\PointsMaterial.d.ts",
                @"materials\RawShaderMaterial.d.ts",
                @"materials\ShaderMaterial.d.ts",
                @"materials\ShadowMaterial.d.ts",
                @"materials\SpriteMaterial.d.ts",

                // math folder
                @"math\Box2.d.ts",
                @"math\Box3.d.ts",
                @"math\Color.d.ts",
                @"math\ColorManagement.d.ts",
                @"math\Cylindrical.d.ts",
                @"math\Euler.d.ts",
                @"math\Frustum.d.ts",
                @"math\Interpolant.d.ts",
                @"math\Line3.d.ts",
                @"math\MathUtils.d.ts",
                @"math\Matrix3.d.ts",
                @"math\Matrix4.d.ts",
                @"math\Plane.d.ts",
                @"math\Quaternion.d.ts",
                @"math\Ray.d.ts",
                @"math\Sphere.d.ts",
                @"math\Spherical.d.ts",
                @"math\SphericalHarmonics3.d.ts",
                @"math\Triangle.d.ts",
                @"math\Vector2.d.ts",
                @"math\Vector3.d.ts",
                @"math\Vector4.d.ts",
                @"math\interpolants\CubicInterpolant.d.ts",
                @"math\interpolants\DiscreteInterpolant.d.ts",
                @"math\interpolants\LinearInterpolant.d.ts",
                @"math\interpolants\QuaternionLinearInterpolant.d.ts",

                // objects folder
                @"objects\Bone.d.ts",
                @"objects\Group.d.ts",
                @"objects\InstancedMesh.d.ts",
                @"objects\Line.d.ts",
                @"objects\LineLoop.d.ts",
                @"objects\LineSegments.d.ts",
                @"objects\LOD.d.ts",
                @"objects\Mesh.d.ts",
                @"objects\Points.d.ts",
                @"objects\Skeleton.d.ts",
                @"objects\SkinnedMesh.d.ts",
                @"objects\Sprite.d.ts",

                // renderers folder
                @"renderers\WebGL1Renderer.d.ts",
                @"renderers\WebGL3DRenderTarget.d.ts",
                @"renderers\WebGLArrayRenderTarget.d.ts",
                @"renderers\WebGLCubeRenderTarget.d.ts",
                @"renderers\WebGLMultipleRenderTargets.d.ts",
                @"renderers\WebGLMultisampleRenderTarget.d.ts",
                @"renderers\WebGLRenderer.d.ts",
                @"renderers\WebGLRenderTarget.d.ts",

                @"renderers\shaders\ShaderChunk.d.ts",
                @"renderers\shaders\ShaderLib.d.ts",
                @"renderers\shaders\UniformsLib.d.ts",
                @"renderers\shaders\UniformsUtils.d.ts",

                @"renderers\webgl\WebGLAttributes.d.ts",
                @"renderers\webgl\WebGLBindingStates.d.ts",
                @"renderers\webgl\WebGLBufferRenderer.d.ts",
                @"renderers\webgl\WebGLCapabilities.d.ts",
                @"renderers\webgl\WebGLClipping.d.ts",
                @"renderers\webgl\WebGLCubeMaps.d.ts",
                @"renderers\webgl\WebGLCubeUVMaps.d.ts",
                @"renderers\webgl\WebGLExtensions.d.ts",
                @"renderers\webgl\WebGLGeometries.d.ts",
                @"renderers\webgl\WebGLIndexedBufferRenderer.d.ts",
                @"renderers\webgl\WebGLInfo.d.ts",
                @"renderers\webgl\WebGLLights.d.ts",
                @"renderers\webgl\WebGLObjects.d.ts",
                @"renderers\webgl\WebGLProgram.d.ts",
                @"renderers\webgl\WebGLPrograms.d.ts",
                @"renderers\webgl\WebGLProperties.d.ts",
                @"renderers\webgl\WebGLRenderLists.d.ts",
                @"renderers\webgl\WebGLShader.d.ts",
                @"renderers\webgl\WebGLShadowMap.d.ts",
                @"renderers\webgl\WebGLState.d.ts",
                @"renderers\webgl\WebGLTextures.d.ts",
                @"renderers\webgl\WebGLUniforms.d.ts",
                @"renderers\webgl\WebGLUniformsGroups.d.ts",
                @"renderers\webgl\WebGLUtils.d.ts",

                @"renderers\webxr\WebXRController.d.ts",
                @"renderers\webxr\WebXRManager.d.ts",

                // scenes folder
                @"scenes\Fog.d.ts",
                @"scenes\FogExp2.d.ts",
                @"scenes\Scene.d.ts",

                // textures folder
                @"textures\CanvasTexture.d.ts",
                @"textures\CompressedTexture.d.ts",
                @"textures\CubeTexture.d.ts",
                @"textures\Data3DTexture.d.ts",
                @"textures\DataArrayTexture.d.ts",
                @"textures\DataTexture.d.ts",
                @"textures\DataTexture2DArray.d.ts",
                @"textures\DataTexture3D.d.ts",
                @"textures\DepthTexture.d.ts",
                @"textures\FramebufferTexture.d.ts",
                @"textures\Source.d.ts",
                @"textures\Texture.d.ts",
                @"textures\VideoTexture.d.ts",

            };

            var generationList = new List<string>
            {
                // animation folder
                // interface
                "MorphTarget",
                "ParseTrackNameResults",

                "AnimationAction",
                "AnimationClip",
                "AnimationMixer",
                "AnimationObjectGroup",
                "KeyframeTrack",
                "PropertyBinding",
                "Composite",
                "PropertyMixer",
                "BooleanKeyframeTrack",
                "ColorKeyframeTrack",
                "NumberKeyframeTrack",
                "QuaternionKeyframeTrack",
                "StringKeyframeTrack",
                "VectorKeyframeTrack",


                // audio folder
                "Audio",
                "AudioAnalyser",
                "AudioListener",
                "PositionalAudio",


                // cameras folder
                "ArrayCamera",
                "Camera",
                "CubeCamera",
                "OrthographicCamera",
                "PerspectiveCamera",
                "StereoCamera",


                // core folder
                // interface
                "BaseEvent",
                "Event",
                "Face",
                "Intersection",
                "RaycasterParameters",

                // class
                "BufferAttribute",
                "Int8Attribute",
                "Uint8Attribute",
                "Uint8ClampedAttribute",
                "Int16Attribute",
                "Uint16Attribute",
                "Int32Attribute",
                "Uint32Attribute",
                "Float32Attribute",
                "Float64Attribute",
                "Int8BufferAttribute",
                "Uint8BufferAttribute",
                "Uint8ClampedBufferAttribute",
                "Int16BufferAttribute",
                "Uint16BufferAttribute",
                "Int32BufferAttribute",
                "Uint32BufferAttribute",
                "Float16BufferAttribute",
                "Float32BufferAttribute",
                "Float64BufferAttribute",
                "BufferGeometry",
                "Clock",
                "EventDispatcher",
                "GLBufferAttribute",
                "InstancedBufferAttribute",
                "InstancedBufferGeometry",
                "InstancedInterleavedBuffer",
                "InterleavedBuffer",
                "InterleavedBufferAttribute",
                "Layers",
                "Object3D",
                "Raycaster",
                "Uniform",
                "UniformsGroup",


                // extras folder
                // interface
                "Vec2",

                // classes
                "PMREMGenerator",
                "Curve",
                "CurvePath",
                "Path",
                "Shape",
                "ShapePath",
                "ArcCurve",
                "CatmullRomCurve3",
                "CubicBezierCurve",
                "CubicBezierCurve3",
                "EllipseCurve",
                "LineCurve",
                "LineCurve3",
                "QuadraticBezierCurve",
                "QuadraticBezierCurve3",
                "SplineCurve",


                // geometries folder
                // interfaces
                "ExtrudeGeometryOptions",
                "UVGenerator",

                // classes
                "BoxGeometry",
                "CapsuleGeometry",
                "CircleGeometry",
                "ConeGeometry",
                "CylinderGeometry",
                "DodecahedronGeometry",
                "EdgesGeometry",
                "ExtrudeGeometry",
                "IcosahedronGeometry",
                "LatheGeometry",
                "OctahedronGeometry",
                "PlaneGeometry",
                "PolyhedronGeometry",
                "RingGeometry",
                "ShapeGeometry",
                "SphereGeometry",
                "TetrahedronGeometry",
                "TorusGeometry",
                "TorusKnotGeometry",
                "TubeGeometry",
                "WireframeGeometry",


                // helpers folder
                "ArrowHelper",
                "AxesHelper",
                "Box3Helper",
                "BoxHelper",
                "CameraHelper",
                "DirectionalLightHelper",
                "GridHelper",
                "HemisphereLightHelper",
                "PlaneHelper",
                "PointLightHelper",
                "PolarGridHelper",
                "SkeletonHelper",
                "SpotLightHelper",


                // lights folder
                "AmbientLight",
                "AmbientLightProbe",
                "DirectionalLight",
                "DirectionalLightShadow",
                "HemisphereLight",
                "HemisphereLightProbe",
                "Light",
                "LightProbe",
                "LightShadow",
                "PointLight",
                "PointLightShadow",
                "RectAreaLight",
                "SpotLight",
                "SpotLightShadow",


                // loaders folder
                // interface
                "LoaderUtils",

                // classes
                "AnimationLoader",
                "AudioLoader",
                "BufferGeometryLoader",
                "CompressedTextureLoader",
                "CubeTextureLoader",
                "DataTextureLoader",
                "FileLoader",
                "ImageBitmapLoader",
                "ImageLoader",
                "Loader",
                "LoadingManager",
                "MaterialLoader",
                "ObjectLoader",
                "TextureLoader",
                

                // materials folder
                // interfaces
                "LineBasicMaterialParameters",
                "LineDashedMaterialParameters",
                "MaterialParameters",
                "MeshBasicMaterialParameters",
                "MeshDepthMaterialParameters",
                "MeshDistanceMaterialParameters",
                "MeshLambertMaterialParameters",
                "MeshMatcapMaterialParameters",
                "MeshNormalMaterialParameters",
                "MeshPhongMaterialParameters",
                "MeshPhysicalMaterialParameters",
                "MeshStandardMaterialParameters",
                "MeshToonMaterialParameters",
                "PointsMaterialParameters",
                "ShaderMaterialParameters",
                "ShadowMaterialParameters",
                "SpriteMaterialParameters",

                // classes
                "LineBasicMaterial",
                "LineDashedMaterial",
                "Material",
                "MeshBasicMaterial",
                "MeshDepthMaterial",
                "MeshDistanceMaterial",
                "MeshLambertMaterial",
                "MeshMatcapMaterial",
                "MeshNormalMaterial",
                "MeshPhongMaterial",
                "MeshPhysicalMaterial",
                "MeshStandardMaterial",
                "MeshToonMaterial",
                "PointsMaterial",
                "RawShaderMaterial",
                "ShaderMaterial",
                "ShadowMaterial",
                "SpriteMaterial",
                

                // math folder
                // interfaces
                "HSL",
                "RGB",
                "Matrix",
                "Vector",

                // types
                "Matrix3Tuple",
                "Matrix4Tuple",
                "Vector2Tuple",
                "Vector3Tuple",
                "Vector4Tuple",

                // classes
                "Box2",
                "Box3",
                "Color",
                "Cylindrical",
                "Euler",
                "Frustum",
                "Interpolant",
                "Line3",
                "Matrix3",
                "Matrix4",
                "Plane",
                "Quaternion",
                "Ray",
                "Sphere",
                "Spherical",
                "SphericalHarmonics3",
                "Triangle",
                "Vector2",
                "Vector3",
                "Vector4",


                // objects folder
                "Bone",
                "Group",
                "InstancedMesh",
                "Line",
                "LineLoop",
                "LineSegments",
                "LOD",
                "Mesh",
                "Points",
                "Skeleton",
                "SkinnedMesh",
                "Sprite",


                // renderers folder
                // interfaces
                "Shader",
                "IUniform",
                "WebGLCapabilitiesParameters",
                "RenderItem",
                "Renderer",
                "WebGLRenderTargetOptions",
                "XRHandInputState",

                // types
                "XRControllerEventType",
                "XRHandJoints",
                "WebXRCamera",
                "WebXRArrayCamera",

                // classes
                "WebGL1Renderer",
                "WebGL3DRenderTarget",
                "WebGLArrayRenderTarget",
                "WebGLCubeRenderTarget",
                "WebGLMultipleRenderTargets",
                "WebGLMultisampleRenderTarget",
                "WebGLRenderer",
                "WebGLRenderTarget",
                "WebGLAttributes",
                "WebGLBindingStates",
                "WebGLBufferRenderer",
                "WebGLCapabilities",
                "WebGLClipping",
                "WebGLCubeMaps",
                "WebGLCubeUVMaps",
                "WebGLExtensions",
                "WebGLGeometries",
                "WebGLIndexedBufferRenderer",
                "WebGLInfo",
                "WebGLLights",
                "WebGLObjects",
                "WebGLProgram",
                "WebGLPrograms",
                "WebGLProperties",
                "WebGLRenderList",
                "WebGLRenderLists",
                "WebGLShadowMap",
                "WebGLColorBuffer",
                "WebGLDepthBuffer",
                "WebGLStencilBuffer",
                "WebGLState",
                "WebGLTextures",
                "WebGLUniforms",
                "WebGLUtils",
                "XRHandSpace",
                "XRTargetRaySpace",
                "XRGripSpace",
                "WebXRController",
                "WebXRManager",
                
                // scenes folder
                // interface
                "FogBase",

                // classes
                "Fog",
                "FogExp2",
                "Scene",


                // textures folder
                "CanvasTexture",
                "CompressedTexture",
                "CubeTexture",
                "Data3DTexture",
                "DataArrayTexture",
                "DataTexture",
                "DataTexture2DArray",
                "DataTexture3D",
                "DepthTexture",
                "FramebufferTexture",
                "Source",
                "Texture",
                "VideoTexture",

                // constants file
                "PixelFormatGPU",
                "ColorSpace",
                "NoColorSpace",
                "SRGBColorSpace",
                "LinearSRGBColorSpace",
                "BuiltinShaderAttributeName",

                // utils file
                "ColorRepresentation",
            };

            // Remove any already Generated Source.
            if (Directory.Exists(Path.Combine( projectGenerationLocation, projectAssembly )))
            {
                Directory.Delete( Path.Combine( projectGenerationLocation, projectAssembly ), true );
            }
            
            GlobalLogger.Info("Removed Generation Directory");

            if (useWasm)
            {
                GlobalLogger.Info("Running Wasm Generator");
                var writer = new WasmProjectWriter( projectGenerationLocation, projectAssembly );
                
                new WasmGenerator().Run(
                    projectAssembly,
                    sourceDirectory,
                    sourceFiles,
                    generationList,
                    writer,
                    textFormatter,
                    new Dictionary<string, string>
                    {
                        { "ThreeJs.PointerInfoBase | type", "int" }
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
                        { "ThreeJs.PointerInfoBase | type", "int" }
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
