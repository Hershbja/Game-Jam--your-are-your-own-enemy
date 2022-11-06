using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowGameOver : MonoBehaviour
{
    public GameObject Player;
    public GameObject Shadow;

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.GetComponent<CharacterController>().enabled = false;
        }
    }
}
