using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPad : MonoBehaviour {

    public int nextIndex;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            //if the player collides with it change the scene
            SceneManager.LoadScene(nextIndex);
        }
    }
}
