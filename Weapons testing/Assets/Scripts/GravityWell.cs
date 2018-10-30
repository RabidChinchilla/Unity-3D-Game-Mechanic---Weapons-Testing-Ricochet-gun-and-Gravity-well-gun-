﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour {

    public float force = -100.0f;
    public float radius = 5.0f;

    void Start()
    {
        
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

        Object.Destroy(gameObject, 3.0f);
    }
}
