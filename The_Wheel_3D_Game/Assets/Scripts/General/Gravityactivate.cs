using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravityactivate : MonoBehaviour
{

    public Rigidbody Pillar1;
  /*  public Rigidbody Pillar2;
    public Rigidbody Pillar3;
    public Rigidbody Pillar4;
    public Rigidbody Pillar5;
    public Rigidbody Pillar6;
    public Rigidbody Pillar7;
    public Rigidbody Pillar8;
    public Rigidbody Pillar9;
    public Rigidbody Pillar10;
    public Rigidbody Pillar11;
    public Rigidbody Pillar12;*/
 

 

    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
     void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Player")
        {
          
           
           Pillar1.GetComponent<Rigidbody>().useGravity = true;
         /*   Pillar2.GetComponent<Rigidbody>().useGravity = true;
            Pillar3.GetComponent<Rigidbody>().useGravity = true;
            Pillar4.GetComponent<Rigidbody>().useGravity = true;
            Pillar5.GetComponent<Rigidbody>().useGravity = true;
            Pillar6.GetComponent<Rigidbody>().useGravity = true;
            Pillar7.GetComponent<Rigidbody>().useGravity = true;
            Pillar8.GetComponent<Rigidbody>().useGravity = true;
            Pillar9.GetComponent<Rigidbody>().useGravity = true;
            Pillar10.GetComponent<Rigidbody>().useGravity = true;
            Pillar11.GetComponent<Rigidbody>().useGravity = true;
            Pillar12.GetComponent<Rigidbody>().useGravity = true;*/
        }
    }
}
