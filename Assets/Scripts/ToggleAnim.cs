using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetInteger("State", 2);
        }
    }
}
