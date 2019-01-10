using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFragment : MonoBehaviour {

	
	// Update is called once per frame
	void Start () {
        //destroy the object after a set time
        Object.Destroy(gameObject, 3.0f);
    }
}
