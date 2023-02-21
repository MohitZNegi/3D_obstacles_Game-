using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
   public float speed = 5.0f;
   public float horizontal;
   public float vertical;
	
	void Update ()
    {
       horizontal = Input.GetAxis("Horizontal");
       vertical = Input.GetAxis("Vertical");

       transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
       transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
	}
}
