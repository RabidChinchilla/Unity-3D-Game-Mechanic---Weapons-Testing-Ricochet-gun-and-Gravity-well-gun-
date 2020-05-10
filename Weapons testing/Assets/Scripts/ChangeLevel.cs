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
        //gets the original position of the objects and stores it
        originalPosition = box.transform.position;
        //PlayerPosition = Player.transform.position;
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        //if an object enters the trigger
        if (other.name == "Player")
        {
            //moves player back to their original location
            SceneManager.LoadScene(nextIndex);
        }
        else if (other.tag == "Box")
        {
            //moves box back to its original location
            box.transform.position = originalPosition;
        }
    }
}
