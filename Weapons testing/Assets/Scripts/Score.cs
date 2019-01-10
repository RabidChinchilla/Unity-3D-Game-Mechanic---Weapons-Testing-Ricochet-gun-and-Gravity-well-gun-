using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject door;
    public static int scoreValue = 0;
    Text scoreText;

	// Use this for initialization
	void Start () {
        //set the text box
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //set the contents of the textbox to a string and a int variable that can be changed
        scoreText.text = "Score: " + scoreValue;

        if (scoreValue == 1200)
        {
            //when a minimum score is reached remove the door
            Destroy(door);
        }
	}
}
