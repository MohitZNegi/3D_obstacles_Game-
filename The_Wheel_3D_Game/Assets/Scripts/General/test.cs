using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
     public Rigidbody ab;
     [SerializeField]
     Vector3 vec;
    public bool dead = false;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void Update() {


     if(dead==true)
     {
         ab.position= vec;
         dead=false;
     }
    }

   private void OnCollisionEnter(Collision collision)
{
     if(collision.gameObject.tag == "Ground")
     {
         dead= true;
       
     }

 }
}
