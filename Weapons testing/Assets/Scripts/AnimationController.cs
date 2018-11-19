﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    Animator anim;
    bool isFiring;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("IsFiring", true);
        }
        else
        {
            anim.SetBool("IsFiring", false);
        }
	}
}