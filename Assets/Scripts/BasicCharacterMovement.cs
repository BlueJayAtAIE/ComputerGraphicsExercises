using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterMovement : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        gameObject.transform.Translate(input * Time.deltaTime);

        anim.SetFloat("LocomotionBlend", input.magnitude);
    }
}
