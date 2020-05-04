using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapWeapons : MonoBehaviour {

	public GameObject gun1;
	public GameObject gun2;

	public bool gun1Obtained;
	public bool gun2Obtained;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			print("1 key was pressed");
			if (gun1Obtained == true)
			{
				gun2.SetActive(false);
				gun1.SetActive(true);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			if (gun2Obtained == true)
			{
				print("1 key was pressed");
				gun1.SetActive(false);
				gun2.SetActive(true);
			}
		}
	}
}
