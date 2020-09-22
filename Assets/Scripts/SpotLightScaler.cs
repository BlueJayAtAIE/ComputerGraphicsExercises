using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
[ExecuteInEditMode]
public class SpotLightScaler : MonoBehaviour
{
    public float scaleStrength = 2f;

    private Light lit;

    void Start()
    {
        lit = GetComponent<Light>();

        if (lit.type != LightType.Spot)
        {
            lit.type = LightType.Spot;
        }
    }

    void Update()
    {
        lit.intensity = ((179 - lit.spotAngle) / scaleStrength);
    }
}
