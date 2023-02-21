using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
      public float x_rotation_speed=0;
       public float y_rotation_speed=0;
        public float z_rotation_speed=0;
      
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {    
          transform.Rotate(x_rotation_speed, y_rotation_speed, z_rotation_speed);
         

    }

}
