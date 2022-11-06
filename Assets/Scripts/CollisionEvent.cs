using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{

    void OnCollisionEnter (Collision collision)
    {
        if (!collision.gameObject.GetComponent<isReal>().isRealProp)
        {
            Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            renderer.enabled = false;
            Collider collider = collision.gameObject.GetComponent<BoxCollider>();
            collider.enabled = false;
            Debug.Log(collider.isTrigger);
           
        }        
    }

    void OnCollisionExit(Collision collision)
    {
        Renderer renderer = collision.gameObject.GetComponent<Renderer>();
        renderer.enabled = true;
        Collider collider = collision.gameObject.GetComponent<BoxCollider>();
        collider.enabled = true;
    }
}
