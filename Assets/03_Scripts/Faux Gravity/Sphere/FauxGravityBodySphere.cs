using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBodySphere : MonoBehaviour
{
    public FauxGravityAtrractorSphere attractor;
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
