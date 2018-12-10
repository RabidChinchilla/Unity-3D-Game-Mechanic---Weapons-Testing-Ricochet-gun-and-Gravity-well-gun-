using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCams : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    private bool cameraOn = false;

    private void Start()
    {
        cam1.enabled = false;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update () {


        if (Input.GetKeyDown("c"))
        {
            if (cameraOn == false)
            {
                cam1.enabled = true;
                cam2.enabled = true;
                cameraOn = true;
            }
            else if (cameraOn == true)
            {
                cam1.enabled = false;
                cam2.enabled = false;
                cameraOn = false;
            }
        }
	}
}
