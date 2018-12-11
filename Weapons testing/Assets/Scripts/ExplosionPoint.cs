using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPoint : MonoBehaviour {

    public float force = -50.0f;
    public float radius = 10.0f;

    public GameObject fragment;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < 10; i++)
        {
            Instantiate(fragment, transform.position, transform.rotation);
        }

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

        Object.Destroy(gameObject, 3.0f);
    }
	
}
