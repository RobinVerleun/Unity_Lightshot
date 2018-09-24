using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementController {

    // Implemented by a class with a transform. Define movement for a single update
    Vector3 CalculateVelocity();

    // Implemented by a class with a transform. Define Horizontal camera rotation for a single update
    Vector3 CalculateHorizontalRotation();

    // Implemented by a class with a disjoined vertical transform (camera). 
    Vector3 CalculateVerticalRotation();

    // Translate the rigidbody attached to the implementing object. Takes a velocity input to allow for injection
    // of randomized values
    void MoveRigidbody(Vector3 velocity);

    // Rotate the object horizontally
    void RotateHorizontal(Vector3 _rotation);

    // Rotate the object vertically 
    void RotateVertical(Vector3 _rotation);
}
