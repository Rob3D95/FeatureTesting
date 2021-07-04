using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBodyCylinder : MonoBehaviour
{
    public FauxGravityAtrractorCylinder attractor;
    private Transform myTransform;
    public Rigidbody rigidbody;


    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        myTransform = transform;
        

        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        rigidbody.useGravity = false;
    }

    private void Update()
    {
        attractor.Attract(myTransform, rigidbody);
    }
}
