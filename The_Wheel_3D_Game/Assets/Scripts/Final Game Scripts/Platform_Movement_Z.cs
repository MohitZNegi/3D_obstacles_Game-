using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movement_Z : MonoBehaviour
{
       [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
   
    private bool movingbackward;
    private float backwardpoint;
    private float forwardpoint;

    private void Awake()
    {
        backwardpoint = transform.position.z - movementDistance;
        forwardpoint = transform.position.z + movementDistance;
    }

    private void Update()
    {
        if (movingbackward)
        {
            if (transform.position.z > backwardpoint)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - speed * Time.deltaTime);
            }
            else
                movingbackward = false;
        }
        else
        {
            if (transform.position.z < forwardpoint)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + speed * Time.deltaTime);
            }
            else
                movingbackward = true;
        }
    }

   
}

