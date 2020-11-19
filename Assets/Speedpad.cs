using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedpad : MonoBehaviour
{


    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Speedpad"))
        {
            rb.AddForce(Vector3.forward * 1000);
        }
    }
}
