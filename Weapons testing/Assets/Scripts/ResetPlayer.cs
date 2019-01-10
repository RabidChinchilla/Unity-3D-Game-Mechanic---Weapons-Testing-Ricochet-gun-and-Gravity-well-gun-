using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            //move the player to a specific position when they enter a trigger
            other.transform.position = new Vector3(0, 4, 7);
        }
    }
}
