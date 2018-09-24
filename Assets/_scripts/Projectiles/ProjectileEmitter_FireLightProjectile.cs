using UnityEngine;

[System.Serializable]
public class ProjectileEmitter_FireLightProjectile : System.Object {

    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 50;

    // Program to the interface to limit calls to 'GetInstance'
    private IProjectileFactory<GameObject> projectileFactory;

    // Empty constructor due to timing issue on injection of prefab
    public ProjectileEmitter_FireLightProjectile(){}

    public void fire(Vector3 position, Quaternion rotation)
    {
        // There's a strange race condition with instantiating the factory in the constructor.
        // The constructor is called before Unity injects the projectile prefab through
        // the editor. 
        if (projectileFactory == null)
        {
            projectileFactory = new LightboxFactory(projectilePrefab);
        }

        GameObject projectile = projectileFactory.GenerateInstance(position, rotation);
        projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * projectileSpeed;
        projectileFactory.DestroyInstance(projectile);
    }

    public void setPrefab(GameObject prefab)
    {
        projectilePrefab = prefab;
    }

}