using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionCharacter : MonoBehaviour
{

    Animator animator;
    Vector2 input;

    [Range(0,1)]
    public float sensitivity = 1;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool shiftPressed = Input.GetKey(KeyCode.LeftShift);


        if (!shiftPressed)
        {
            input.x = Input.GetAxis("Horizontal") * sensitivity;
            input.y = Input.GetAxis("Vertical") * sensitivity;

            input.x = Mathf.Clamp(input.x, -0.5f, 0.5f);
            input.y = Mathf.Clamp(input.y, -0.5f, 0.5f);


        } else if (shiftPressed)
        {
            input.x = Input.GetAxis("Horizontal") * sensitivity;
            input.y = Input.GetAxis("Vertical") * sensitivity;
        }
       


      

        animator.SetFloat("VelocityX", input.x);
        animator.SetFloat("VelocityY", input.y);

       
    }
}
