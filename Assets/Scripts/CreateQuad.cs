using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class CreateQuad : MonoBehaviour
{
    [Tooltip("X and Y dimentions that the quad should spawn as. Bottom corner will always be (0, 0).")]
    public Vector2 dimentions = new Vector2(1, 1);

    private Mesh customMesh;

    void Start()
    {
        // Create a new mesh.
        Mesh mesh = new Mesh();

        // Verices
        // The location of the verticies.
        var verts = new Vector3[6];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, dimentions.y, 0);
        verts[2] = new Vector3(dimentions.x, 0, 0);
        verts[3] = new Vector3(0, dimentions.y, 0);
        verts[4] = new Vector3(dimentions.x, dimentions.y, 0);
        verts[5] = new Vector3(dimentions.x, 0, 0);

        mesh.vertices = verts;

        // Indices
        // Determines which vertices make up an individual triangle.
        // This should always stay in a multiple of three!
        // Each triandle should be specified in [CLOCK-WISE] order.
        var indices = new int[6];

        for (int i = 0; i < indices.Length; i++)
        {
            indices[i] = i;
        }

        mesh.triangles = indices;

        // Normals
        // Describes how light bounces off at the surface (at the vertex level).
        // Note that these points are interpolated across the surface of the triangle.
        var normals = new Vector3[6];

        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -Vector3.forward;
        }

        mesh.normals = normals;

        // UVs, STs
        // Defines how textures are mapped onto the surface.
        var UVs = new Vector2[6];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0, 1);
        UVs[2] = new Vector2(1, 0);
        UVs[3] = new Vector2(0, 1);
        UVs[4] = new Vector2(1, 1);
        UVs[5] = new Vector2(1, 0);

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