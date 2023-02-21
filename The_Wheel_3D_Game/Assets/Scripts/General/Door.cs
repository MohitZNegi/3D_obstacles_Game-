using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
   
  
   public Rigidbody door1;
   public Rigidbody door2;

   public Rigidbody no;


   public Rigidbody Cube;
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
    
    if( no.transform.position==new Vector3(0f,0f,0f)){
         door1.transform.position += new Vector3(0.2f, 0, 0);
            door2.transform.position -=new Vector3(0.2f,0,0);
           
         
    }
    if(no.transform.position == new Vector3(0.6f,107.2005f,2180.5f)){
         door1.transform.position =vec1;
       
        door2.transform.position = vec2;
    }
   
  
    }
   void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Cube" )
        {
            
              no.transform.position = new Vector3(0f,0f,0f);
          
        }
       
       
        
     }
     

}
