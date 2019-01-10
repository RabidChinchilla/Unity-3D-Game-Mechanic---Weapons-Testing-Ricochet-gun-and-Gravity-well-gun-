using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPoint : MonoBehaviour {

    void Start () {

        //makes sure particle system is destroyed after a set time
        Object.Destroy(gameObject, 3.0f);
    }
	
}
