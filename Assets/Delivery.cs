using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package") {
            Debug.Log("Package picked up");
            hasPackage = true;
        }
        if (collision.tag == "Customer" && hasPackage) {
            hasPackage = false;
            Debug.Log("Package delivered!");
        }

    }
}
