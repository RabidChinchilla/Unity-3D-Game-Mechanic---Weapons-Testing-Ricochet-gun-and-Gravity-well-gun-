using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCams : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
	
	// Update is called once per frame
	void Update () {

        cam1.rect = new Rect(0.8f, 0, 0.2f, 0.2f);
        cam2.rect = new Rect(0.8f, 0.8f, 0.2f, 0.2f);
	}
}
