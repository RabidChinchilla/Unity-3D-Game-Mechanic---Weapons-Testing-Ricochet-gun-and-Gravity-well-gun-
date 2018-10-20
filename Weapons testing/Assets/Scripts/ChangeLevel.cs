using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    private int nextIndex;

    void start()
    {
        //nextIndex = SceneManager.GetActiveScene;
    }

	void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(1);
    }
}
