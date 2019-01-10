using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlatformPoint")
        {
            //when the platform collides with the point make it kinematic to stop it moving
            rb.isKinematic = true;
        }
        
    }
}
