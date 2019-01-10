using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySpawn : MonoBehaviour {

    public GameObject gravityWell;
    public float bulletSpeed = 20.0f;
    private Rigidbody m_bulletRigid;

    // Use this for initialization
    void Start()
    {
        //gets rigid body
        m_bulletRigid = GetComponent<Rigidbody>();
        //applies force
        m_bulletRigid.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        //destroys the object after time
        Object.Destroy(gameObject, 3.0f);
    }



    void OnCollisionEnter(Collision collision)
    {
        //when it colliders with an object create the gravity well and destroy the bullet
        Instantiate(gravityWell, transform.position, transform.rotation);
        Object.Destroy(gameObject);
    }
}
