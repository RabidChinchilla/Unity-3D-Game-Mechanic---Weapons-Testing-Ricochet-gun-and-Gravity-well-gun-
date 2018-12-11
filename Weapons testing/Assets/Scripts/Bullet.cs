using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Rigidbody m_bulletRigid;
    public float bulletSpeed = 20.0f;

	// Use this for initialization
	void Start () {

        m_bulletRigid = GetComponent<Rigidbody>();

        m_bulletRigid.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        //Invoke("Destroy", 200.0f);
        Object.Destroy(gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        //Object.Destroy(gameObject, 5.0f);
	}
}
