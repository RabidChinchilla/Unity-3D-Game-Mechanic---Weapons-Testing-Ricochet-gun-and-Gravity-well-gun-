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

        m_bulletRigid = GetComponent<Rigidbody>();

        m_bulletRigid.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        //Invoke("Destroy", 100.0f);
        Object.Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Object.Destroy(gameObject, 3.0f);
    }


    void OnCollisionEnter(Collision collision)
    {
        Instantiate(gravityWell, transform.position, transform.rotation);
        Object.Destroy(gameObject);
    }
}
