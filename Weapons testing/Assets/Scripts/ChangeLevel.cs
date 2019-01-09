using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    public int nextIndex;
    public GameObject box;
    public GameObject Player;
    public Vector3 PlayerPosition;
    public Vector3 originalPosition;

    void Start()
    {
        originalPosition = box.transform.position;
        PlayerPosition = Player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.transform.position = PlayerPosition;
        }
        else if (other.tag == "Box")
        {
            box.transform.position = originalPosition;
        }
    }
}
