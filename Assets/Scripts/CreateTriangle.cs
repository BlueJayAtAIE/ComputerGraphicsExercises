using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The following script was made by following-along with the Example
// Code from the AIE Sharepoint page on Game Engine Geometry.

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class CreateTriangle : MonoBehaviour
{
    private Mesh customMesh;

    void Start()
    {
        // Create a new mesh.
        Mesh mesh = new Mesh();

        // Verices
        // The location of the verticies.
        var verts = new Vector3[3];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, 1, 0);
        verts[2] = new Vector3(1, 0, 0);

        mesh.vertices = verts;

        // Indices
        // Determines which vertices make up an individual triangle.
        // This should always stay in a multiple of three!
        // Each triandle should be specified in [CLOCK-WISE] order.
        var indices = new int[3];

        for (int i = 0; i < indices.Length; i++)
        {
            indices[i] = i;
        }

        mesh.triangles = indices;

        // Normals
        // Describes how light bounces off at the surface (at the vertex level).
        // Note that these points are interpolated across the surface of the triangle.
        var normals = new Vector3[3];

        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -Vector3.forward;
        }

        mesh.normals = normals;

        // UVs, STs
        // Defines how textures are mapped onto the surface.
        var UVs = new Vector2[3];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0, 1);
        UVs[2] = new Vector2(1, 0);

        mesh.uv = UVs;

        // Assignment
        // End step!
        customMesh = mesh;
        GetComponent<MeshFilter>().mesh = customMesh;
    }

    private void OnDestroy()
    {
        if (customMesh != null)
        {
            Destroy(customMesh);
        }
    }
}