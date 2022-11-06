using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashFlickr : MonoBehaviour
{
    private GameObject Flashlight;
    private Light lightcomp;
    private bool on = false;
    private GameObject Rod;
    private bool dead = false;
    public float battery = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi there");
        Flashlight = GameObject.Find("Directional Light");
        lightcomp = Flashlight.GetComponentInChildren<Light>();

        Rod = GameObject.Find("Cube");
        Flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Flashlight);
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (on == false && !dead)
            {
                Rod.transform.localScale = new Vector3(0, 0, 7);
                Flashlight.SetActive(true);
                //Debug.Log("Flashlight On");
            }
            else
            {
                Rod.transform.localScale = new Vector3(0, 0, 2);
                Flashlight.SetActive(false);
                //Debug.Log("Flashlight Off");
            }
            on = !on;

        }
        if (on && !dead)
        {
            Debug.Log(battery);
            battery -= Time.deltaTime;
            lightcomp.intensity = 15-15/battery;
            if(battery <= 0)
            {
                dead = true;
                Rod.transform.localScale = new Vector3(0, 0, 2);
                Flashlight.SetActive(false);
            }
        }
    }
}
