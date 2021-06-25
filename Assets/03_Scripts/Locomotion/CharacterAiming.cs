using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class CharacterAiming : MonoBehaviour
{

    float turnSpeed = 15f;
    Camera cam;
    public Rig aimLayer;
    public float aimDuration = 0.3f;

    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

  
    void FixedUpdate()
    {
        float yawCamera = cam.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);

    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            aimLayer.weight += Time.deltaTime / aimDuration;
        } else
        {
            aimLayer.weight -= Time.deltaTime / aimDuration;
        }
    }
}
