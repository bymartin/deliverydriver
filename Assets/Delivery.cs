using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage) {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }
        if (collision.tag == "Customer" && hasPackage) {
            hasPackage = false;
            Debug.Log("Package delivered!");
        }

    }
}
