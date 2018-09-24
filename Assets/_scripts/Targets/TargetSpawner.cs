using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour {

    [SerializeField] private GameObject targetPrefab;
    [SerializeField] private int maxTargets = 100;
    [SerializeField] private float spawnDelay = 5.0f;

    private TargetFactory targetFactory;
    private Vector3 spawnPosition;
    private Vector3 spawnDimensions;
    private GameObject target;
    private float timeDelay = 0.0f;

	// Use this for initialization
	void Start () {
        spawnPosition = gameObject.transform.position;
        spawnDimensions = gameObject.transform.localScale;
        targetFactory = new TargetFactory();
	}
	
	// Update is called once per frame
	void Update () {
        timeDelay += Time.deltaTime;

        if (timeDelay > spawnDelay && GameState.numTargets < maxTargets)
        {
            timeDelay = 0.0f;
            target = targetFactory.GetInstance(targetPrefab, spawnPosition, spawnDimensions, targetPrefab.transform.rotation);
            GameState.numTargets++;
            // Alternatively, you could do:
            /*
             * target = targetFactory.GetInstance(targetPrefab);
             * target.transform.position = targetFactory.CalculateInstanceLocation(spawnPosition, spawnDimensions);
             * targetFactory.ModifyInstance(target);
             * targetFactory.DestoryInstance(instance);
             */
        }
	}
}
