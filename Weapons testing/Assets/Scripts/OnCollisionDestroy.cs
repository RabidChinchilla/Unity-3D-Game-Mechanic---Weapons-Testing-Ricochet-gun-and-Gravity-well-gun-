using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour {

    public GameObject barrier;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(barrier);
        }
    }
}
