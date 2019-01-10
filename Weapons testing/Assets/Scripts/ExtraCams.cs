using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCams : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    private bool cameraOn = false;

    private void Start()
    {
        //turns off the extra cameras when the game starts
        cam1.enabled = false;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update () {

        //when key is pressed
        if (Input.GetKeyDown("c"))
        {
            if (cameraOn == false)
            { //if the cameras aren't on then turn them on
                cam1.enabled = true;
                cam2.enabled = true;
                cameraOn = true;
            }
            else if (cameraOn == true)
            { //if the cameras are on turn them off
                cam1.enabled = false;
                cam2.enabled = false;
                cameraOn = false;
            }
        }
	}
}
