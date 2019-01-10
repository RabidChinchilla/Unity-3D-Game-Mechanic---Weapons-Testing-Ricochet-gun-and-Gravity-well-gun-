using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformReset : MonoBehaviour {

    public int nextIndex;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            //when the player falls out of the level reload it
            SceneManager.LoadScene(nextIndex);
        }
    }
}
