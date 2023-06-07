using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void start()
    {
        Debug.Log("Collision Handler");
    }
    void update(){
        Debug.Log("Rigidbody collision detected!");
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // Check if the collision involves Rigidbody objects
    //     if (collision.gameObject.GetComponent<Rigidbody>() != null)
    //     {
    //         Debug.Log("Rigidbody collision detected!");
            
    //         // Access the collided Rigidbody if needed
    //         Rigidbody otherRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            
    //         // Perform actions based on the collided Rigidbody
    //         // ...
    //     }
    // }

    // void OnTriggerEnter(Collider other)
    // {
    //     // Check if the trigger collision involves Rigidbody objects
    //     if (other.gameObject.GetComponent<Rigidbody>() != null)
    //     {
    //         Debug.Log("Rigidbody trigger collision detected!");
            
    //         // Access the collided Rigidbody if needed
    //         Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
            
    //         // Perform actions based on the collided Rigidbody
    //         // ...
    //     }
    // }
}
