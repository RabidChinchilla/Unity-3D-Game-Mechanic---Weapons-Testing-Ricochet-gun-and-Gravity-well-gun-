using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public GameObject explosionPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Score.scoreValue += 100;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        Instantiate(explosionPoint, transform.position, transform.rotation);
    }
}
