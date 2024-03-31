using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardsSetup: MonoBehaviour
{
    public float force = 10f; 

    void Start()
    {
        Movement(); 
    }

    private void Movement()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
