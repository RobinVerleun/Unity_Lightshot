using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITargetFactory<T> {

    // All target factories must have some way of calculating their spawns position
    Vector3 CalculateInstanceLocation(Vector3 center, Vector3 dimensions);

    // All target factories must implement some method for post-instantiation modification
    void ModifyInstance(GameObject instance);

    // Get an instance of the object from the factory without modifications. 
    T GetInstance(T prefab);

    // Get an instance of the object from the factory with passed in position and rotation
    T GetInstance(T prefab, Vector3 position, Vector3 dimensions, Quaternion rotation);

    // All target factories must implement a method to destroy their spawns
    void DestroyInstance(GameObject instance);

}
