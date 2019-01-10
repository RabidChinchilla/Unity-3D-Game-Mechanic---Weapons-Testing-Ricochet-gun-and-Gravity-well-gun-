using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    Animator anim;
    bool isFiring;

	// Use this for initialization
	void Start () {
        //finds the animation attached to the object
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //if statement to manipulate bool for animation
        //gets mouse button clicks then sets a bool to true
		if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("IsFiring", true);
        }
        else
        //sets the bool to false so the animation isn't always playing
        {
            anim.SetBool("IsFiring", false);
        }
	}
}
