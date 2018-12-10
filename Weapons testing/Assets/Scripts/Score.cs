﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject door;
    public static int scoreValue = 0;
    Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + scoreValue;

        if (scoreValue == 1100)
        {
            Destroy(door);
        }
	}
}
