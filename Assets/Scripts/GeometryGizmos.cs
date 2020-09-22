using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class GeometryGizmos : MonoBehaviour
{
    public enum gizmoDisplayType { ALWAYS, SELECTED, NEVER };

    [Tooltip("Denotates whether the gizmos should be during editor and runtime, or runtime only.")]
    public bool runInEditor = false;

    [Tooltip("Toggles when the gizmos are visable.\nAlways: Always visable in scene view.\nSelected: Only visable when the object is selected.\nNever: Gizmos are not visable.")]
    public gizmoDisplayType displayGizmos = gizmoDisplayType.ALWAYS;

    public MeshFilter meshFilter;

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void GizmoDrawing()
    {
        Gizmos.color = Color.blue;

        List<Vector3> verts = new List<Vector3>();
        meshFilter.sharedMesh.GetVertices(verts);

        foreach (var vert in verts)
        {
            Vector3 vertPos = new Vector3(vert.x, vert.y, vert.z) + gameObject.transform.position;

            Gizmos.DrawSphere(vertPos, 0.02f);
        }
    }

    private void OnDrawGizmos()
    {
        if (displayGizmos == gizmoDisplayType.ALWAYS && ((runInEditor == !EditorApplication.isPlaying) || runInEditor))
        {
            GizmoDrawing();
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (displayGizmos == gizmoDisplayType.SELECTED && (runInEditor == !EditorApplication.isPlaying))
        {
            GizmoDrawing();
        }
    }
}
