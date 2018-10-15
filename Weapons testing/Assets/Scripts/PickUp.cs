using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public Transform weaponSpawn;
    public GameObject pickUp;

    private bool pickUpAllowed = false;

	// Use this for initialization
	void Start () {
        //weaponSpawn = spawnPosition.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (pickUpAllowed = true && Input.GetKeyDown(KeyCode.E))
        {
            PickUP();
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pick Up")
        {
            pickUpAllowed = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Pick Up")
        {
            pickUpAllowed = false;
        }
    }

    private void PickUP()
    {
        
    }
}
