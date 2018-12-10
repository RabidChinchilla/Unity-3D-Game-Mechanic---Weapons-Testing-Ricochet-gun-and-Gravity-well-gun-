using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    public void LoadLevel()
    {
        //Load a specific level by name
        SceneManager.LoadScene("Menu");
    }
}
