using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
   [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyup;
    [SerializeField]
    KeyCode keydown;

    /*public float acceleration = 1000f;
    public float currentAcceleration =0f;

    [SerializeField] WheelCollider player_wheel;
    [SerializeField] Transform playerTransform;

    public float maxTurnAngle = 15f;

    private float currentTurnAngle = 0f;*/
   
    void FixedUpdate ()
    {
        
        if (Input.GetKey(keyup))
            GetComponent<Rigidbody>().velocity += v3Force;
        
        

        if (Input.GetKey(keydown))
            GetComponent<Rigidbody>().velocity -= v3Force;
      /*   currentAcceleration = acceleration * Input.GetAxis("Vertical");
         player_wheel.motorTorque = currentAcceleration;
         currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        player_wheel.steerAngle = currentTurnAngle;
         UpdateWheel(player_wheel, playerTransform);*/
        
    }

     /*void UpdateWheel(WheelCollider col, Transform trans){

        Vector3 position = trans.position;
        Quaternion rotation = trans.rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;
    }*/

 
}
