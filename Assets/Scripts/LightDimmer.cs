using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightDimmer : MonoBehaviour
{
    public bool on = true;
    public float onIntensity = 1f;
    public float transitionTime = 3f;

    private Light lit;

    void Start()
    {
        lit = GetComponent<Light>();
    }

    void Update()
    {
        if (on && lit.intensity < onIntensity)
        {
            lit.intensity = Mathf.Clamp(Mathf.Lerp(lit.intensity, onIntensity, Time.deltaTime / transitionTime), 0, onIntensity);
        }
        else
        {
            lit.intensity = Mathf.Clamp(Mathf.Lerp(lit.intensity, 0, Time.deltaTime / transitionTime), 0, onIntensity);
        }
    }
}
