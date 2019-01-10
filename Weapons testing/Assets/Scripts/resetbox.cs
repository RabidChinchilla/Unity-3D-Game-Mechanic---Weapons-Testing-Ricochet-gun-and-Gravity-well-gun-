using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbox : MonoBehaviour
{

    public GameObject box;
    public Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        //get original positon of the box
        originalPosition = box.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            //move the box back to its original position
            box.transform.position = originalPosition;
        }
    }
}
