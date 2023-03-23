using System;
using System.Collections.Generic;
using System.Text;

namespace glTFLoader.Schema
{
    public class BufferId
    {
        public BufferView View { get; protected set; }
        public int Offset { get; protected set; }
        public int Size { get; protected set; }
        public int Stride { get; protected set; }

        public BufferId(BufferView view)
        {
            View = view;
        }

        public BufferId(Texture v, Gltf gltf)
        {
            if (v == null || v.Source == null)
                return;

            var img = gltf.Images[v.Source.Value];
            if (img == null || img.BufferView == null)
                return;

            View = gltf.BufferViews[img.BufferView.Value];
        }

        public BufferId(Image v, Gltf gltf)
        {
            if (v == null || v.BufferView == null)
                return;

            View = gltf.BufferViews[v.BufferView.Value];
        }

        public BufferId(MeshPrimitive v, string attribute, Gltf gltf, out Accessor accessor)
        {
            int? id;
            accessor = null;

            if (string.IsNullOrEmpty(attribute))
            {
                id = v.Indices;
            }
            else
            {
                if (!v.Attributes.TryGetValue(attribute, out var i))
                    return;

                id = i;
            }

            if (id == null)
                return;

            accessor = gltf.Accessors[id.Value];
            if (accessor == null || accessor.BufferView == null)
                return;

            if (accessor.Sparse != null)
                throw new NotImplementedException("Sparse access is not supported");

            var view = gltf.BufferViews[accessor.BufferView.Value];
            if (view == null)
                return;

            View = view;
            Offset = accessor.ByteOffset;
            Size = accessor.Count * accessor.GetElementSize();
            Stride = View.ByteStride ?? 0;
        }

        public static explicit operator BufferId(BufferView v) => new BufferId(v);
    }
}
