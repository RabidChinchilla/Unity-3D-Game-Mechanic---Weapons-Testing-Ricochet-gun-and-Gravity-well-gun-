using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour {

    public float force = -100.0f;
    public float radius = 5.0f;
    //public float upwardsModifier = 0.0f;
    //public ForceMode m_forceMode;

    void Start()
    {
        //Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        //Vector3 explosionPosition = transform.position;
    }

	// Update is called once per frame
	void Update ()
    {
        Vector3 explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody m_rigidBody = hit.GetComponent<Rigidbody>();

            if (m_rigidBody != null)
            {
                m_rigidBody.AddExplosionForce(force, explosionPosition, radius);
            }
        }
	}
}
