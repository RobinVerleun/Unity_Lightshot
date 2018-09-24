using UnityEngine;

public class GunController : MonoBehaviour {

    [SerializeField] private ProjectileEmitter_FireLightProjectile emitter;

    private GameObject projectileEmitterObject;

    private void Start()
    {
        projectileEmitterObject = GameObject.Find("ProjectileEmitter");
    }

    void Update () {
	    // Determine is the user has clicked down the left mouse
        if(Input.GetButtonDown("Fire1"))
        {
            emitter.fire(projectileEmitterObject.transform.position, gameObject.transform.rotation);
        }
	}
}
