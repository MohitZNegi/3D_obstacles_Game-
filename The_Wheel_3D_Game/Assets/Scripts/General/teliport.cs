using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teliport : MonoBehaviour
{
   public Rigidbody PL;
    [SerializeField]
    Vector3 vec3;

    bool In=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(In==true){
             PL.transform.position = vec3;
             In=false;
          }
    }

      private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player")
        {
          In = true;
        }
    }
}
