using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAiming : MonoBehaviour
{

    float turnSpeed = 15f;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

  
    void FixedUpdate()
    {
        float yawCamera = cam.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);

    }
}
