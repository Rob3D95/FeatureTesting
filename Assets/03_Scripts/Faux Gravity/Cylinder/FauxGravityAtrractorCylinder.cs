using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAtrractorCylinder : MonoBehaviour
{

    [SerializeField]
    private float gravity = -10f;

    public GameObject target;
    float targetX;

    private void Start()
    {
        targetX = target.transform.position.x;
    }
    public void Attract(Transform body, Rigidbody rigidbody)
    {

       



        Vector3 gravityUp = (body.position - target.transform.position).normalized;


        Vector3 bodyUp = body.up;

        rigidbody.AddForce(gravityUp * gravity);

        

        


        Quaternion targetRot = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;


        
        body.rotation = Quaternion.Slerp(body.rotation, targetRot, 0.1f);

        targetX = body.position.x;

    }
}
