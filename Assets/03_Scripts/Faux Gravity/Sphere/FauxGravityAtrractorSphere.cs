using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAtrractorSphere : MonoBehaviour
{

    [SerializeField]
    private float gravity = -10f;
    public void Attract(Transform body, Rigidbody rigidbody)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        rigidbody.AddForce(gravityUp * gravity);




        Quaternion targetRot = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;


        
        body.rotation = Quaternion.Slerp(body.rotation, targetRot, 0.1f);


    }
}
