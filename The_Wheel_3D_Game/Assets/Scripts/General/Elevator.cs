using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
   public Rigidbody Rise;
    [SerializeField]
    string strtag;
    
    [SerializeField]
    bool on=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if( on==true){
         Rise.transform.position += new Vector3(0, 0.05f, 0);
       
          
         }
           
    }

     void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == strtag )
        {
            
             on=true;
            
          
        }
       
       
        
     }
     
}
