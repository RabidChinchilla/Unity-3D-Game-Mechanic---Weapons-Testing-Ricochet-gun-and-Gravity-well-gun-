using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    public int nextIndex;
    public GameObject box;
    public Vector3 originalPosition;

    void Start()
    {
        originalPosition = box.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene(nextIndex);
        }
        else if (other.name == "Box")
        {
            box.transform.position = originalPosition;
        }
    }
}
