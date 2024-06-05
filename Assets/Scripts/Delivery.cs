using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    float destroyTime = 0.5f;
    private bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided with " + other.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            Destroy(other.gameObject, destroyTime);
        }
        else if (other.tag == "Customer" && !hasPackage)
        {
            Debug.Log("No package to deliver");
        }
        Debug.Log("Triggered with " + other.gameObject.name);
    }
}
