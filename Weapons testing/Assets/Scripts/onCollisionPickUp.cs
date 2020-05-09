using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionPickUp : MonoBehaviour {

	public GameObject item;
	private GameObject player;
	private swapWeapons weaponSwap;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		weaponSwap = player.GetComponent<swapWeapons>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			//Debug.Log("Collision detected");
			item.SetActive(true);

			if (this.gameObject.tag == "gun1")
			{
				weaponSwap.gun1Obtained = true;
				Debug.Log("Weapon 1 obtained");
			}

			if (this.gameObject.tag == "gun2")
			{
				weaponSwap.gun2Obtained = true;
				Debug.Log("Weapon 2 obtained");
			}


			Destroy(this.gameObject);
		}
	}
}
