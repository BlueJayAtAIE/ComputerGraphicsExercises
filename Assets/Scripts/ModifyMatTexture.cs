using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyMatTexture : MonoBehaviour
{
    [Tooltip("Time in seconds until the texture changes to the next in the array.")]
    public float switchInterval = 5f;
    private float accumulatedtime = 0f;

    public Texture[] textures;
    private int texIndex = 0;

    private MeshRenderer meshRend;

    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        accumulatedtime += Time.deltaTime;

        if (accumulatedtime > switchInterval)
        {
            accumulatedtime -= switchInterval;

            meshRend.sharedMaterial.SetTexture("_MainTex", textures[texIndex]);

            texIndex++;

            if (texIndex >= textures.Length)
            {
                texIndex = 0;
            }
        }
    }
}
