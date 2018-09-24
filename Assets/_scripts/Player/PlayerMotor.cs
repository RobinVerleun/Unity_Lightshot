
using UnityEngine;

public class PlayerMotor {

    private IMovementController movementController;

    public void PerformMovement()
    {
        Vector3 velocity = movementController.CalculateVelocity();
        movementController.MoveRigidbody(velocity);
    }

    public void PerformRotation()
    {
        Vector3 horzRotation = movementController.CalculateHorizontalRotation();
        Vector3 vertRotation = movementController.CalculateVerticalRotation();

        movementController.RotateHorizontal(horzRotation);
        movementController.RotateVertical(vertRotation);
    }

    public void SetMovementController(IMovementController movementController)
    {
        this.movementController = movementController;
    }
   
}
