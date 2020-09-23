using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterMovement : MonoBehaviour
{
    public float jumpStrength = 4.0f;

    public bool grounded = true;

    private Animator anim;
    private Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                grounded = false;
                rb.AddForce(new Vector3(0, jumpStrength, 0));

                return;
            }

            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

            gameObject.transform.Translate(input * Time.deltaTime);

            anim.SetFloat("LocomotionBlend", input.magnitude);
        }
            
        anim.SetBool("isGrounded", grounded);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
