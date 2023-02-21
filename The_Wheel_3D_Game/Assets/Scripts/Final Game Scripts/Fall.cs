using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public float fall;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time ++;
       
        if(time == 70){
            fall +=90;
             transform.Rotate(0,0,fall);
        }
        if(time==170){
              fall -=90;
             transform.Rotate(0,0,fall);
             time =0;

        }
        
         
    }
}
