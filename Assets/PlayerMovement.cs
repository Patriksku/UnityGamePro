using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float playerForwardSpeed = 1000f;
    public float playerSidewaySpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FixedUpdate for physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, playerForwardSpeed * Time.deltaTime); // Preliminary - Constant force forward to move the player.

        if (Input.GetKey("a"))
        {
            rb.AddForce(-playerSidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(playerSidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
