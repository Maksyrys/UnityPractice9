using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperManMoving : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        SupermanMovement(); 
    }

    private void SupermanMovement()
    {
        Vector3 movement = transform.right * moveSpeed * Time.fixedDeltaTime;
        _rb.MovePosition(_rb.position + movement);
    }

}
