using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{/*
        public Transform PlayerTransform;
    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor= 0.5f;
    public bool LookAtPlayer= false;
    public bool RotateAroundPlayer= true;

    public float RotationsSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* RotationsSpeed, Vector3.up);
            _cameraOffset = camTurnAngle * _cameraOffset;
        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if(LookAtPlayer || RotateAroundPlayer)
        {
            transform.LookAt(PlayerTransform);
        }
        
    }*/

      public float speed;
    public Camera cam;
    public Collider planeCollider;
    RaycastHit hit;
    Ray ray;    
   
 void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            if (hit.collider == planeCollider)
            {
                transform.position = Vector3.MoveTowards(transform.position,hit.point,Time.deltaTime * speed);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));

            }
        }
    }

}
