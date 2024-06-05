using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField] private Color32 noPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField]
    float destroyTime = 0.5f;
    private bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            Destroy(other.gameObject, destroyTime);
            spriteRenderer.color = noPackageColor;
        }
        else if (other.tag == "Customer" && !hasPackage)
        {
            Debug.Log("No package to deliver");
        }
        Debug.Log("Triggered with " + other.gameObject.name);
    }
}
