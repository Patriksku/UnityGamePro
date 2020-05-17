using System;
using UnityEngine;

public class PlayerMovementView : MonoBehaviour
{
    private PlayerMovementController PlayerMovementController = new PlayerMovementController();
    

    // FixedUpdate for physics.
    void FixedUpdate()
    {
        PlayerMovementEvent();
    }

    private void PlayerMovementEvent()
    {

        if (Input.GetKey("a"))
        {
            PlayerMovementController.Turn("left");
        }

        if (Input.GetKeyDown("w"))
        {
            PlayerMovementController.Accelerate();
        }

        if (Input.GetKey("d"))
        {
            PlayerMovementController.Turn("right");
        }
    }
}
