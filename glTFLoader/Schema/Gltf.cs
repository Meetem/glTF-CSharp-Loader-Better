//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glTFLoader.Schema {
    using System.Linq;
    using System.Runtime.Serialization;
    
    
    public class Gltf {
        
        /// <summary>
        /// Backing field for ExtensionsUsed.
        /// </summary>
        private string[] m_extensionsUsed;
        
        /// <summary>
        /// Backing field for ExtensionsRequired.
        /// </summary>
        private string[] m_extensionsRequired;
        
        /// <summary>
        /// Backing field for Accessors.
        /// </summary>
        private Accessor[] m_accessors;
        
        /// <summary>
        /// Backing field for Animations.
        /// </summary>
        private Animation[] m_animations;
        
        /// <summary>
        /// Backing field for Asset.
        /// </summary>
        private Asset m_asset;
        
        /// <summary>
        /// Backing field for Buffers.
        /// </summary>
        private Buffer[] m_buffers;
        
        /// <summary>
        /// Backing field for BufferViews.
        /// </summary>
        private BufferView[] m_bufferViews;
        
        /// <summary>
        /// Backing field for Cameras.
        /// </summary>
        private Camera[] m_cameras;
        
        /// <summary>
        /// Backing field for Images.
        /// </summary>
        private Image[] m_images;
        
        /// <summary>
        /// Backing field for Materials.
        /// </summary>
        private Material[] m_materials;
        
        /// <summary>
        /// Backing field for Meshes.
        /// </summary>
        private Mesh[] m_meshes;
        
        /// <summary>
        /// Backing field for Nodes.
        /// </summary>
        private Node[] m_nodes;
        
        /// <summary>
        /// Backing field for Samplers.
        /// </summary>
        private Sampler[] m_samplers;
        
        /// <summary>
        /// Backing field for Scene.
        /// </summary>
        private System.Nullable<int> m_scene;
        
        /// <summary>
        /// Backing field for Scenes.
        /// </summary>
        private Scene[] m_scenes;
        
        /// <summary>
        /// Backing field for Skins.
        /// </summary>
        private Skin[] m_skins;
        
        /// <summary>
        /// Backing field for Textures.
        /// </summary>
        private Texture[] m_textures;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> m_extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras m_extras;
        
        /// <summary>
        /// Names of glTF extensions used in this asset.
        /// </summary>
        [Newtonsoft.Json.JsonConverterAttribute(typeof(glTFLoader.Shared.ArrayConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute("extensionsUsed")]
        public string[] ExtensionsUsed {
            get {
                return this.m_extensionsUsed;
            }
            set {
                if ((value == null)) {
                    this.m_extensionsUsed = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_extensionsUsed = value;
            }
        }
        
        /// <summary>
        /// Names of glTF extensions required to properly load this asset.
        /// </summary>
        [Newtonsoft.Json.JsonConverterAttribute(typeof(glTFLoader.Shared.ArrayConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute("extensionsRequired")]
        public string[] ExtensionsRequired {
            get {
                return this.m_extensionsRequired;
            }
            set {
                if ((value == null)) {
                    this.m_extensionsRequired = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_extensionsRequired = value;
            }
        }
        
        /// <summary>
        /// An array of accessors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessors")]
        public Accessor[] Accessors {
            get {
                return this.m_accessors;
            }
            set {
                if ((value == null)) {
                    this.m_accessors = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_accessors = value;
            }
        }
        
        /// <summary>
        /// An array of keyframe animations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animations")]
        public Animation[] Animations {
            get {
                return this.m_animations;
            }
            set {
                if ((value == null)) {
                    this.m_animations = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_animations = value;
            }
        }
        
        /// <summary>
        /// Metadata about the glTF asset.
        /// </summary>
        [Newtonsoft.Json.JsonRequiredAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public Asset Asset {
            get {
                return this.m_asset;
            }
            set {
                this.m_asset = value;
            }
        }
        
        /// <summary>
        /// An array of buffers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buffers")]
        public Buffer[] Buffers {
            get {
                return this.m_buffers;
            }
            set {
                if ((value == null)) {
                    this.m_buffers = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_buffers = value;
            }
        }
        
        /// <summary>
        /// An array of bufferViews.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bufferViews")]
        public BufferView[] BufferViews {
            get {
                return this.m_bufferViews;
            }
            set {
                if ((value == null)) {
                    this.m_bufferViews = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_bufferViews = value;
            }
        }
        
        /// <summary>
        /// An array of cameras.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cameras")]
        public Camera[] Cameras {
            get {
                return this.m_cameras;
            }
            set {
                if ((value == null)) {
                    this.m_cameras = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_cameras = value;
            }
        }
        
        /// <summary>
        /// An array of images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public Image[] Images {
            get {
                return this.m_images;
            }
            set {
                if ((value == null)) {
                    this.m_images = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_images = value;
            }
        }
        
        /// <summary>
        /// An array of materials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public Material[] Materials {
            get {
                return this.m_materials;
            }
            set {
                if ((value == null)) {
                    this.m_materials = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_materials = value;
            }
        }
        
        /// <summary>
        /// An array of meshes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public Mesh[] Meshes {
            get {
                return this.m_meshes;
            }
            set {
                if ((value == null)) {
                    this.m_meshes = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_meshes = value;
            }
        }
        
        /// <summary>
        /// An array of nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public Node[] Nodes {
            get {
                return this.m_nodes;
            }
            set {
                if ((value == null)) {
                    this.m_nodes = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_nodes = value;
            }
        }
        
        /// <summary>
        /// An array of samplers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplers")]
        public Sampler[] Samplers {
            get {
                return this.m_samplers;
            }
            set {
                if ((value == null)) {
                    this.m_samplers = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_samplers = value;
            }
        }
        
        /// <summary>
        /// The index of the default scene.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scene")]
        public System.Nullable<int> Scene {
            get {
                return this.m_scene;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("Scene", value, "Expected value to be greater than or equal to 0");
                }
                this.m_scene = value;
            }
        }
        
        /// <summary>
        /// An array of scenes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenes")]
        public Scene[] Scenes {
            get {
                return this.m_scenes;
            }
            set {
                if ((value == null)) {
                    this.m_scenes = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_scenes = value;
            }
        }
        
        /// <summary>
        /// An array of skins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skins")]
        public Skin[] Skins {
            get {
                return this.m_skins;
            }
            set {
                if ((value == null)) {
                    this.m_skins = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_skins = value;
            }
        }
        
        /// <summary>
        /// An array of textures.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textures")]
        public Texture[] Textures {
            get {
                return this.m_textures;
            }
            set {
                if ((value == null)) {
                    this.m_textures = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_textures = value;
            }
        }
        
        /// <summary>
        /// JSON object with extension-specific objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public System.Collections.Generic.Dictionary<string, object> Extensions {
            get {
                return this.m_extensions;
            }
            set {
                this.m_extensions = value;
            }
        }
        
        /// <summary>
        /// Application-specific data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extras")]
        public Extras Extras {
            get {
                return this.m_extras;
            }
            set {
                this.m_extras = value;
            }
        }
<<<<<<< Updated upstream
        
=======

        [JsonIgnore]
        private GCHandle binaryHandle;
        [JsonIgnore]
        private byte[] binary;

        [JsonIgnore]
        public byte[] Binary
        {
            get => binary;
            set
            {
                if (binaryHandle.IsAllocated)
                    binaryHandle.Free();

                binaryHandle = new GCHandle();
                binary = value;

                if (binary != null)
                {
                    binaryHandle = GCHandle.Alloc(binary, GCHandleType.Pinned);
                    return;
                }
            }
        }

        public struct BufferCopyParams
        {
            public int startByte;
            public int elementCount;
            public int elementSize;
            public int stride;

            public int NumBytes => elementCount * elementSize;
            public int NumBytesStrided => elementCount * stride;

            public bool IsValid()
            {
                return NumBytes > 0 && stride > 0;
            }
        }

        public BufferCopyParams GetBufferCopyParams(BufferId v)
        {
            if (v == null || v.View == null)
                return new BufferCopyParams();

            var view = v.View;
            var buf = Buffers[view.Buffer];
            if (buf == null)
                return new BufferCopyParams();

            if (!string.IsNullOrEmpty(buf.Uri))
                throw new NotImplementedException("Only loads from GLB buffer are supported now");

            if (Binary == null)
                throw new InvalidOperationException("GLTF doesn't contains binary buffer");

            var start = v.Offset;
            var fullBytesSize = v.Count * v.Stride;

            if (start + fullBytesSize > Binary.Length)
                throw new IndexOutOfRangeException($"View end position would overflow source bufferoffs: {view.ByteOffset}, len: {Binary.Length}");

            return new BufferCopyParams
            {
                startByte = start,
                elementCount = v.Count,
                stride = v.Stride,
                elementSize = v.ElementSize
            };
        }

        public uint GetBuffer(BufferId v, byte[] target, int dstIndex)
        {
            var copy = GetBufferCopyParams(v);
            if (!copy.IsValid())
                return 0;

            if (copy.stride != 1)
                throw new NotImplementedException("Custom strides is not implmeneted");

            if(copy.stride == 1)
            {
                var sz = copy.elementCount * copy.elementSize;
                Array.Copy(Binary, copy.startByte, target, dstIndex, sz);
                return (uint)sz;
            }

            int currentDstPtr = dstIndex;
            var currentSrcPtr = copy.startByte;

            for(int i = 0; i < copy.elementCount; i++)
            {
                for(int j = 0; j < copy.elementSize; j++)
                    target[currentDstPtr + j] = Binary[currentSrcPtr + j];

                currentSrcPtr += copy.stride;
                currentDstPtr += copy.elementSize;
            }

            return (uint)(copy.elementCount * copy.elementSize);
        }

        public byte[] GetBuffer(BufferId v)
        {
            var copy = GetBufferCopyParams(v);
            if (!copy.IsValid())
                return Array.Empty<byte>();

            var totalSize = copy.elementCount * copy.elementSize;
            var newArray = new byte[totalSize];
            GetBuffer(v, newArray, 0);
            return newArray;
        }

#if ENABLE_UNSAFE
        public unsafe IntPtr GetBufferPointer(BufferId v, out BufferCopyParams copyParams)
        {
            copyParams = GetBufferCopyParams(v);
            if (!copyParams.IsValid())
                return IntPtr.Zero;

            return Marshal.UnsafeAddrOfPinnedArrayElement(Binary, copyParams.startByte);
        }

        /// <summary>
        /// Copies data to <paramref name="dst"/> with given stride
        /// </summary>
        /// <param name="v">BufferId</param>
        /// <param name="dst">Target buffer</param>
        /// <param name="dstSizeLimitBytes">Maximum allowed target size (in bytes)</param>
        /// <returns></returns>
        public unsafe uint CopyToPointer(BufferCopyParams copy, IntPtr dst, int dstSizeLimitBytes)
        {
            if (!copy.IsValid())
                return 0;

            if (copy.startByte + copy.NumBytesStrided > Binary.Length)
                throw new InvalidOperationException($"This copy will overflow source buffer");

            var numTotalBytes = copy.NumBytes;
            if (numTotalBytes > dstSizeLimitBytes)
                throw new InvalidOperationException($"This copy will overflow destination buffer");

            var bufPtr = (byte*)Marshal.UnsafeAddrOfPinnedArrayElement(Binary, copy.startByte);
            if(copy.stride == copy.elementSize)
            {
                System.Buffer.MemoryCopy(bufPtr, dst.ToPointer(), numTotalBytes, numTotalBytes);
                return (uint)numTotalBytes;
            }
            
            var dstPtr = (byte*)dst;
            var emSize = copy.elementSize;
            var stride = copy.stride;

            for(int i = 0; i < copy.elementCount; i++)
            {
                //There should be more performant copy.
                for(int j = 0; j < emSize; j++)
                    dstPtr[j] = bufPtr[j];

                bufPtr += stride;
                dstPtr += emSize;
            }

            return (uint)numTotalBytes;
        }

        /// <summary>
        /// Copies data to <paramref name="dst"/> with given stride
        /// </summary>
        /// <param name="v">BufferId</param>
        /// <param name="dst">Target buffer</param>
        /// <param name="dstSizeLimitBytes">Maximum allowed target size (in bytes)</param>
        /// <returns></returns>
        public unsafe uint CopyToPointer(BufferId v, IntPtr dst, int dstSizeLimitBytes)
        {
            var copy = GetBufferCopyParams(v);
            return CopyToPointer(copy, dst, dstSizeLimitBytes);
        }

        public unsafe uint GetBuffer<T>(BufferId v, T[] ptr, int dstIndex)
            where T : unmanaged
        {
            var copy = GetBufferCopyParams(v);
            if (!copy.IsValid())
                return 0;

            if(copy.elementSize == sizeof(T))
            {
                var numCopies = copy.elementCount;
                if(copy.stride == 1 || copy.stride)
            }

            if (copy.elementSize > sizeof(T))
            {

            }
                throw new InvalidOperationException($"ElementsSize {copy.elementSize} > sizeof({typeof(T)})");

            if (sizeof(T) % copy.elementSize != 0)
                throw new InvalidOperationException($"sizeof({typeof(T)}) indivisible by element size {copy.elementSize}");

            var numElementsPerCopy = sizeof(T) / copy.elementSize;
            var totalNumberOfCopies = (copy.elementSize * copy.elementCount) / sizeof(T);

            if(dstIndex + totalNumberOfCopies > ptr.Length)
                throw new ArgumentOutOfRangeException(nameof(ptr), $"Array dstIndex + totalNumberOfCopies will overflow dst array");

            if (copy.startByte + (copy.elementCount * copy.stride) > Binary.Length)
                throw new ArgumentOutOfRangeException(nameof(Binary), $"Copy will overflow source array");

            var binPtr = (byte*)Marshal.UnsafeAddrOfPinnedArrayElement(Binary, copy.startByte);
            var dstPtr = (T*)Marshal.UnsafeAddrOfPinnedArrayElement(ptr, dstIndex);

            if(copy.stride == 1 && copy.elementSize == 1)
            {
                var totalBytesCopy = totalNumberOfCopies * sizeof(T);
                System.Buffer.MemoryCopy(binPtr, dstPtr, totalBytesCopy, totalBytesCopy);
                return (uint)totalNumberOfCopies;
            }

            if(copy.NumBytes % sizeof(T) != 0)
            {
                throw new InvalidOperationException($"ByteLength {copy.NumBytes} is indivisible by element size {sizeof(T)}");
            }

            var target = new T[copy.NumBytes / sizeof(T)];
            System.Buffer.MemoryCopy(binPtr.ToPointer(), Marshal.UnsafeAddrOfPinnedArrayElement(target, 0).ToPointer(), copy.NumBytes, copy.NumBytes);
            return target;
        }

#endif

>>>>>>> Stashed changes
        public bool ShouldSerializeExtensionsUsed() {
            return ((m_extensionsUsed == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensionsRequired() {
            return ((m_extensionsRequired == null) 
                        == false);
        }
        
        public bool ShouldSerializeAccessors() {
            return ((m_accessors == null) 
                        == false);
        }
        
        public bool ShouldSerializeAnimations() {
            return ((m_animations == null) 
                        == false);
        }
        
        public bool ShouldSerializeAsset() {
            return ((m_asset == null) 
                        == false);
        }
        
        public bool ShouldSerializeBuffers() {
            return ((m_buffers == null) 
                        == false);
        }
        
        public bool ShouldSerializeBufferViews() {
            return ((m_bufferViews == null) 
                        == false);
        }
        
        public bool ShouldSerializeCameras() {
            return ((m_cameras == null) 
                        == false);
        }
        
        public bool ShouldSerializeImages() {
            return ((m_images == null) 
                        == false);
        }
        
        public bool ShouldSerializeMaterials() {
            return ((m_materials == null) 
                        == false);
        }
        
        public bool ShouldSerializeMeshes() {
            return ((m_meshes == null) 
                        == false);
        }
        
        public bool ShouldSerializeNodes() {
            return ((m_nodes == null) 
                        == false);
        }
        
        public bool ShouldSerializeSamplers() {
            return ((m_samplers == null) 
                        == false);
        }
        
        public bool ShouldSerializeScene() {
            return ((m_scene == null) 
                        == false);
        }
        
        public bool ShouldSerializeScenes() {
            return ((m_scenes == null) 
                        == false);
        }
        
        public bool ShouldSerializeSkins() {
            return ((m_skins == null) 
                        == false);
        }
        
        public bool ShouldSerializeTextures() {
            return ((m_textures == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensions() {
            return ((m_extensions == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtras() {
            return ((m_extras == null) 
                        == false);
        }
    }
}
