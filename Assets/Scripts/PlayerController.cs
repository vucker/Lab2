using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float inputVertical;
    public float inputHorizontal;

    private Rigidbody playerRb;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        inputVertical = Input.GetAxis("Vertical");
        inputHorizontal = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(inputHorizontal, 0, inputVertical);
        if (direction.magnitude > 1)
        {
            direction.Normalize();
        }
        Vector3 newVelocity = direction * speed;
        newVelocity.y = playerRb.velocity.y;
        playerRb.velocity = newVelocity;
    }
}

