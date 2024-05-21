using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided with " + other.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered with " + other.gameObject.name);
    }
}
