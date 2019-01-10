using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public GameObject explosionPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            //when the bullet collides with it add to the score then destroy both objects
            Score.scoreValue += 100;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        //create the fireworks that play
        Instantiate(explosionPoint, transform.position, transform.rotation);
    }
}
