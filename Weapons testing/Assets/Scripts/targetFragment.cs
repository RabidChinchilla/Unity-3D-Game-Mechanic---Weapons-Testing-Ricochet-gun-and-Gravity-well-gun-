using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFragment : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        Object.Destroy(gameObject, 3.0f);
    }
}
