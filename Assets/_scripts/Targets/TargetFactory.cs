using UnityEngine;

public class TargetFactory : Behaviour, ITargetFactory<GameObject> {

    public Vector3 CalculateInstanceLocation(Vector3 center, Vector3 dimensions)
    {
        float randomX = Random.Range(center.x - dimensions.x / 2, center.x + dimensions.x / 2);
        float randomY = Random.Range(center.y - dimensions.y / 2, center.y + dimensions.y / 2);
        float randomZ = Random.Range(center.z - dimensions.z / 2, center.z + dimensions.z / 2);
        return new Vector3(randomX, randomY, randomZ);
    }

    public void ModifyInstance(GameObject instance)
    {
        Color color = GameState.colors[Random.Range(0, GameState.colors.Count)];
        instance.GetComponent<MeshRenderer>().material.color = color;
        instance.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color(color.r / 2, color.g / 2, color.b / 2));
    }

    public void DestroyInstance(GameObject instance)
    {
        // Not initialized
        return;
    }

    public GameObject GetInstance(GameObject prefab)
    {
        return Instantiate(prefab) as GameObject;
    }

    public GameObject GetInstance(GameObject prefab, Vector3 position, Vector3 dimensions, Quaternion rotation)
    {
        Vector3 _position = CalculateInstanceLocation(position, dimensions);
        GameObject target = Instantiate(prefab, _position, rotation) as GameObject;
        ModifyInstance(target);
        return target;
    }
}
