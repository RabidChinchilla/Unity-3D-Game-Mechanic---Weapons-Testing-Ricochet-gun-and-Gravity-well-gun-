﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    public void LoadLevel()
    {
        //Load a specific level by name
        SceneManager.LoadScene("updated demo level");
    }
}
