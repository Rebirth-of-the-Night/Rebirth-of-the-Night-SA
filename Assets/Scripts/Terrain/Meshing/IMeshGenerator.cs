using System.Collections.Generic;
using Rebirth.Terrain.Chunk;
using UnityEngine;

namespace Rebirth.Terrain.Meshing
{
    /// <summary>
    /// Provides Unity mesh objects for voxel-based terrain chunks.
    /// </summary>
    public interface IMeshGenerator
    {
        /// <summary>
        /// Generates a mesh from the data in an <seealso cref="IChunk"/>.
        /// </summary>
        /// <param name="chunkLocation">The location of the chunk to mesh.</param>
        /// <param name="chunks">The loaded chunks to use in mesh generation.</param>
        /// <param name="computeShader">The compute shader to use when generating the mesh.</param>
        /// <returns>A Unity mesh which can be added to a scene.</returns>
        void GenerateMesh(Vector3Int chunkLocation, IDictionary<Vector3Int, IChunk> chunks, ComputeShader computeShader, ref Mesh mesh);
    }
}
