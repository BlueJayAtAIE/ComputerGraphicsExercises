using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ModifyMatColor : MonoBehaviour
{
    public Color newMatColor = new Color(0, 0, 0);

    private MeshRenderer meshRend;

    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRend.sharedMaterial.color = newMatColor;
    }
}
