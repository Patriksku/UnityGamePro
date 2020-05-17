using UnityEngine;

public class PlayerMovementController
{
    private PlayerMovementModel PlayerMovementModel = new PlayerMovementModel();

    internal void Turn(string action)
    {
        if (action.Equals("left", System.StringComparison.InvariantCultureIgnoreCase))
        {
            PlayerMovementModel.TurnLeft();
        }
        else if (action.Equals("right", System.StringComparison.InvariantCultureIgnoreCase))
        {
            PlayerMovementModel.TurnRight();
        }
    }

    internal void Accelerate()
    {
        PlayerMovementModel.Accelerate();
    }
}
