using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
   
   
     [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private bool present = false;
  

    private void Start()
    {
        door1.GetComponent<GameObject>();
        door2.GetComponent<GameObject>();
        
    }

    private void Update()
    {
        if (present == true)
        {
           door1.transform.position = new Vector3(door1.transform.position.x - speed * Time.deltaTime, door1.transform.position.y, door1.transform.position.z);
          door2.transform.position = new Vector3(door2.transform.position.x + speed * Time.deltaTime, door2.transform.position.y, door2.transform.position.z);
        }
      
                
    }
    void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Cube" )
        {
            
             present = true;
          
        }
       
       
        
     
     
       
        
     }

   
}


