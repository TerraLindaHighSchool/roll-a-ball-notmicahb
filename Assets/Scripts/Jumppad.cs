using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{


    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Jumppad"))
        {
            rb.AddForce(Vector3.up * 700);
        }
    }
}
