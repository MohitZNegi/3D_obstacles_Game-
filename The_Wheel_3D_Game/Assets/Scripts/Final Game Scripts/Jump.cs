using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody rb;
    public bool landed = false;

    public float jumpforce = 250;
  
    void Start()
    { 

        rb= GetComponent<Rigidbody>();
    }
    void FixedUpdate ()
    {
        if (Input.GetButtonDown("Jump") && landed)   {
           rb.AddForce(new Vector3(0, jumpforce, 0), ForceMode.Impulse);

            landed = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Ground")
        {
          landed = true;
        }
    }

}
