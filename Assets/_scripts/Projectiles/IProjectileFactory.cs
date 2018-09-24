using UnityEngine;

// All projectiles will require this interface as a minimum definition.
public interface IProjectileFactory<T> {

    // Return the instance back to the caller at the specified position and rotation.
    T GenerateInstance(Vector3 position, Quaternion rotation);

    void DestroyInstance(GameObject instance);
}
