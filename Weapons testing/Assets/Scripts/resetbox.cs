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
        originalPosition = box.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            box.transform.position = originalPosition;
        }
    }
}
