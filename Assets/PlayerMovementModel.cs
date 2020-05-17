using UnityEngine;

public class PlayerMovementModel : MonoBehaviour
{
    public Rigidbody rb;
    public float playerTurnForce = 15000f;
    public float playerAccelerationForce = 30f;

    internal void TurnLeft()
    {
        rb.AddForce(playerTurnForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Turn player car left.
    }

    internal void TurnRight()
    {
        rb.AddForce(playerTurnForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Turn player car right.
    }

    internal void Accelerate()
    {
        rb.AddForce(0, 0, playerAccelerationForce * Time.deltaTime); // Accelerate player car.
    }
}
