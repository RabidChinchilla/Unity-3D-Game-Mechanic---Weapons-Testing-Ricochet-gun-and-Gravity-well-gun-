using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    public int nextIndex;

    void start()
    {
        
    }

	void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(nextIndex);
    }
}
