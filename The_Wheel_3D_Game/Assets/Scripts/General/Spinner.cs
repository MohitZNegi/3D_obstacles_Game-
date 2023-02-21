using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
  //  public Rigidbody PL;
   
   public float speedy=0;
  // public bool hit=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {     speedy= 4f;
          transform.Rotate(speedy,0,0);
         /* if(hit==true){
             PL.transform.position = new Vector3(8,2.5f,7);
             hit=false;
          }*/

    }

    /* private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player")
        {
          hit = true;
        }
    }*/

}
