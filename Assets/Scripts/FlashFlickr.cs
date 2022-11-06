using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashFlickr : MonoBehaviour
{
    private GameObject Flashlight;
    private bool on = false;
    private GameObject Rod;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi there");
        Flashlight = GameObject.Find("Directional Light");

        Rod = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Flashlight);
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (on == false)
            {
                Rod.transform.localScale = new Vector3(0, 0, 7);
                Flashlight.SetActive(true);
            }
            else
            {
                Rod.transform.localScale = new Vector3(0, 0, 2);
                Flashlight.SetActive(false);
            }
            on = !on;

        }
    }

}
