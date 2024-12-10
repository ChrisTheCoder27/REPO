using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    float xMovement;
    float zMovement;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if (xMovement != 0 || zMovement != 0)
        {
            Vector3 movement = new Vector3(xMovement, 0, zMovement);
            rb.velocity = movement * speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
