using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    
   
  
   public Rigidbody door1;
   public Rigidbody door2;


   public Rigidbody Cube;
   public Rigidbody no;
   [SerializeField]
    Vector3 vec1;
 [SerializeField]
    Vector3 vec2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
 
  
    }
   void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Cube" )
        {
          
              no.transform.position = new Vector3(0.6f,107.2005f,2180.5f);
        }
     
       
        
     }
     

}
