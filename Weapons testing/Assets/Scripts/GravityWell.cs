using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour {

    //use a negative force to create an implosion
    public float force = -100.0f;
    public float radius = 5.0f;

    void Start()
    {
        Object.Destroy(gameObject, 3.0f);
    }

	// Update is called once per frame
	void Update ()
    {
        //call in update to simulate gravity rather than just a once off implosion
        Vector3 explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody m_rigidBody = hit.GetComponent<Rigidbody>();
            
            //if the object in the radius has a rigid body apply the imposion for and pull it towards the gravity well
            if (m_rigidBody != null)
            {
                m_rigidBody.AddExplosionForce(force, explosionPosition, radius);
            }
        }
    }
}
