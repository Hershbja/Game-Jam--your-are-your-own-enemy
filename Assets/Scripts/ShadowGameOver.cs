using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowGameOver : MonoBehaviour
{
    public GameObject Player;
    public GameObject Shadow;
    private GameObject Flashlight;

    void Start()
    {
        Flashlight = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.GetComponent<CharacterController>().enabled = false;
            AudioSource audioData = Player.GetComponent<AudioSource>();
            audioData.Play(0);

            
            Flashlight.SetActive(true);
            Light deathlight = Player.GetComponentInChildren<Light>();
            deathlight.color = Color.red;
            deathlight.intensity = 40;
            
        }
    }
}
