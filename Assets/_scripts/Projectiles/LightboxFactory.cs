using UnityEngine;

/*
 * Implement the functionality defined by IProjectileFactory for instantiating,
 * returning, configuring, and clearing a Lighbox Projectile.
 * 
 * This factory will set the parameters of the projectile
 */
public class LightboxFactory : Behaviour, IProjectileFactory<GameObject> {

    public GameObject lightboxPrefab;
    private float destroyTime = 3.0f;

    public LightboxFactory(GameObject prefab)
    {
        lightboxPrefab = prefab;
    }

    private void configureInstance(GameObject lightBox)
    {
        if (!lightBox) return;

        // Remove the projectile from the parent
        lightBox.transform.parent = null;

        // Set the color
        Light light = lightBox.GetComponentInChildren<Light>();
        if(light)
        {
            light.color = GameState.bulletColor;
        }
    }

    public void DestroyInstance(GameObject lightbox)
    {
        Destroy(lightbox, destroyTime);
    }
    
    public GameObject GenerateInstance(Vector3 position, Quaternion rotation)
    {
        GameObject lightBox = (GameObject)Instantiate(lightboxPrefab, position, rotation);
        configureInstance(lightBox);
        return lightBox;
    }
}
