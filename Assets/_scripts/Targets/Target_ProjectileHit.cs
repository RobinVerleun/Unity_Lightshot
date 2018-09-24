using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_ProjectileHit : MonoBehaviour {

    private Color targetColor;
    private void Start()
    {
        targetColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check to make sure it's the right type
        if (other.tag == "Projectile")
        {
            GameObject otherObj = other.gameObject;
            Color otherColor = otherObj.GetComponentInChildren<Light>().color;

            // Check to see if the colour matches
            if (otherColor.Equals(targetColor))
            {
                // If match, destroy objects
                GameState.score++;
                GameState.numTargets--;
                Destroy(gameObject);
                Destroy(otherObj);
            }
        }
    }
}
