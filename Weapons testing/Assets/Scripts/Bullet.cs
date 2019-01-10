using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Rigidbody m_bulletRigid;
    public float bulletSpeed = 20.0f;

	// Use this for initialization
	void Start () {
        //gets the attached rigid body
        m_bulletRigid = GetComponent<Rigidbody>();
        //adds force to the rigid body 
        m_bulletRigid.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        //destroys the object after a set time
        Object.Destroy(gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        //Object.Destroy(gameObject, 5.0f);
	}
}
